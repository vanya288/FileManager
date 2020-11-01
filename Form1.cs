using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Lab1
{
    public partial class Form1 : Form
    {
        string connStr = "Driver={Sql Server};Server=np:DESKTOP-JH58MI8;Database=IS;";

        ArrayList modfiiedRows   = new ArrayList();
        ArrayList newRows        = new ArrayList();
        ArrayList deletedRows    = new ArrayList();
        ArrayList duplicatedRows = new ArrayList();

        private Source currentSource;

        public string currentText
        {
            get
            {
                string ret = "";

                if (currentSource != Source.none)
                {
                    ret = $"Loaded from {currentSourceName}. New: {newRows.Count}; Modified: {modfiiedRows.Count}; Deleted: {deletedRows.Count}; Duplicates: {duplicatedRows.Count}";
                }

                return ret;
            }
        }

        public string currentSourceName
        {
            get {
                string ret = "";

                switch (currentSource)
                {
                    case Source.TXT:
                        ret = "Text file";
                        break;

                    case Source.XML:
                        ret = "XML file";
                        break;

                    case Source.DB:
                        ret = "Database";
                        break;
                }

                return ret; 
            }
        }

        enum Source
        {
            none,
            TXT,
            XML,
            DB 
        }

        public Form1()
        {
            InitializeComponent();

            openTXTFileDialog.Title = "Browse text file";
            openTXTFileDialog.FileName = "";
            openTXTFileDialog.Filter = "TXT files (*.txt)|*.txt";
            openTXTFileDialog.ShowHelp = true;

            openXMLFileDialog.Title = "Browse xml file";
            openXMLFileDialog.FileName = "";
            openXMLFileDialog.Filter = "XML files (*.xml)|*.xml";
            openXMLFileDialog.ShowHelp = true;

            saveTXTFileDialog.Title = "Browse text file";
            saveTXTFileDialog.FileName = "";
            saveTXTFileDialog.Filter = "TXT files (*.txt)|*.txt";
            saveTXTFileDialog.ShowHelp = true;

            saveXMLFileDialog.Title = "Browse xml file";
            saveXMLFileDialog.FileName = "";
            saveXMLFileDialog.Filter = "XML files (*.xml)|*.xml";
            saveXMLFileDialog.ShowHelp = true;

            gridView.UserDeletingRow  += new DataGridViewRowCancelEventHandler(gridView_UserDeletingRow);
            gridView.UserDeletedRow   += new DataGridViewRowEventHandler(gridView_UserDeletedRow);
            gridView.UserAddedRow     += new DataGridViewRowEventHandler(gridView_UserAddedRow);
            gridView.CellValueChanged += new DataGridViewCellEventHandler(gridView_CellValueChanged);
        }


        public void updateDesign()
        {
            this.updateRowsColor();

            saveToDBBtn.Enabled = currentSource == Source.DB;

            infoLabel.Text = currentText;
        }

        private void updateRowsColor()
        {
            foreach (DataGridViewRow dataRow in gridView.Rows)
            {
                if (duplicatedRows.Contains(dataRow.Index))
                {
                    dataRow.DefaultCellStyle.BackColor = Color.Red;
                }
                else if (newRows.Contains(dataRow.Index) || modfiiedRows.Contains(dataRow.Index))
                {
                    dataRow.DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    dataRow.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }
     
        private void loadFromTXTBtn_Click(object sender, EventArgs e)
        {
            this.loadFromTXT();
        }

        private void loadFromXMLBtn_Click(object sender, EventArgs e)
        {
            this.loadFromXML();
        }

        private void loadFromDBBtn_Click(object sender, EventArgs e)
        {
            this.loadFromDB();
        }

        private void exportToTXTBtn_Click(object sender, EventArgs e)
        {
            this.exportToTXT();
        }

        private void exportToXMLBtn_Click(object sender, EventArgs e)
        {
            this.exportToXML();
        }


        private void saveToDBBtn_Click(object sender, EventArgs e)
        {
            this.saveToDB();
            this.loadFromDB();
        }

        private void gridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            newRows.Add(e.Row.Index - 1);

            this.updateDesign();
        }

        private void gridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var cells = gridView.Rows[e.Row.Index].Cells;
            bool hasID = gridView.Columns.Contains("ID");

            if (!newRows.Contains(e.Row.Index))
            {
                deletedRows.Add(hasID ? cells["ID"].Value.ToString() : e.Row.Index.ToString());
            }

            newRows.Remove(e.Row.Index);
            modfiiedRows.Remove(e.Row.Index);
        }

        private void gridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            duplicatedRows = this.getDuplicatedRows();

            this.updateDesign();
        }

        private void gridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            gridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;

            if (!newRows.Contains(e.RowIndex))
            {
                modfiiedRows.Add(e.RowIndex);
            }

            duplicatedRows = this.getDuplicatedRows();

            this.updateDesign();
        }

        private void loadFromTXT()
        {
            StreamReader file;

            if (openTXTFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            file = new StreamReader(openTXTFileDialog.FileName);

            DataTable dt = new DataTable();

            int colNum = 0;
            string newline = file.ReadLine();

            if (newline == null)
            {
                file.Close();

                return;
            }

            string[] values = newline.Split(';');

            int[] columnnames = Enumerable.Range(1, values.Length - 1).ToArray();

            foreach (int c in columnnames)
            {
                dt.Columns.Add(c.ToString());
            }

            do
            {
                DataRow dr = dt.NewRow();

                values = newline.Split(';');

                for (int i = 0; i < values.Length - 1; i++)
                {
                    dr[i] = values[i];

                    if (i > colNum)
                    {
                        colNum = i;
                    }
                }

                dt.Rows.Add(dr);

            } while ((newline = file.ReadLine()) != null);

            file.Close();

            gridView.DataSource = dt;

            this.emptyRowLists();

            duplicatedRows = this.getDuplicatedRows();

            currentSource = Source.TXT;

            this.updateDesign();
        }


        private void loadFromXML()
        {
            if (openXMLFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();

            dataSet.ReadXml(openXMLFileDialog.FileName);

            for (int col = 0; col < dataSet.Tables.Count; col++)
            {
                dataTable.Merge(dataSet.Tables[col]);
            }

            gridView.DataSource = dataTable;

            this.emptyRowLists();

            duplicatedRows = this.getDuplicatedRows();

            currentSource = Source.XML;

            this.updateDesign();
        }

        private void exportToTXT()
        {
            if (saveTXTFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            StreamWriter file = new StreamWriter(saveTXTFileDialog.FileName);

            for (int rows = 0; rows < gridView.Rows.Count; rows++)
            {
                for (int col = 0; col < gridView.Rows[rows].Cells.Count; col++)
                {
                    string value = "";

                    if (gridView.Rows[rows].Cells[col].Value != null)
                    {
                        value = gridView.Rows[rows].Cells[col].Value.ToString();
                    }

                    file.Write(value + ";");
                }

                file.Write("\n");
            }

            file.Close();

            MessageBox.Show("Exported to " + saveTXTFileDialog.FileName);
        }


        private void exportToXML()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            StreamWriter file;

            if (saveXMLFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            file = new StreamWriter(saveXMLFileDialog.FileName);

            foreach (DataGridViewColumn col in gridView.Columns)
            {
                dt.Columns.Add(col.DataPropertyName, col.ValueType);
            }

            foreach (DataGridViewRow row in gridView.Rows)
            {
                DataRow row1 = dt.NewRow();

                for (int i = 0; i < gridView.ColumnCount; i++)

                    row1[i] = (row.Cells[i].Value == null ? DBNull.Value : row.Cells[i].Value);

                dt.Rows.Add(row1);
            }

            ds.Tables.Add(dt);
            ds.WriteXml(file);

            file.Close();

            MessageBox.Show("Exported to " + saveXMLFileDialog.FileName);
        }


        private void loadFromDB()
        {
            DataTable laptopTable;

            try
            {
                laptopTable = this.FillDataTable("select * from laptop");

                gridView.DataSource = laptopTable;

                gridView.Columns["ID"].ReadOnly = true;

                this.emptyRowLists();

                duplicatedRows = this.getDuplicatedRows();

                currentSource = Source.DB;

                this.updateDesign();
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        DataTable FillDataTable(string _sql)
        {
            var dataTable = new DataTable();

            using (var con = new OdbcConnection(connStr))
            {
                using (var dataAdapter = new OdbcDataAdapter(_sql, con))
                {
                    dataAdapter.Fill(dataTable);
                }
            }
            return dataTable;
        }


        private void saveToDB()
        {
            try
            {
                using (var con = new OdbcConnection(connStr))
                {
                    con.Open();

                    var    transaction = con.BeginTransaction();
                    string sql;
                    string values;

                    string columnNames = 
                        String.Join(",", gridView.Columns.Cast<DataGridViewColumn>()
                        .Where(x => x.Name != "ID")
                        .Select(x => x.Name)
                        .ToArray());

                    foreach (int rowIdx in newRows)
                    {
                        values = "";

                        foreach (DataGridViewColumn col in gridView.Columns)
                        {
                            if (col.Name != "ID")
                            {
                                values += values == String.Empty ? "" : ",";

                                values += this.getValueFromCell(gridView.Rows[rowIdx - deletedRows.Count].Cells[col.Name]);
                            }
                        }

                        sql = $"INSERT INTO laptop ({columnNames}) VALUES ({values})";

                        using (var command = new OdbcCommand(sql, con, transaction))
                        {
                            command.ExecuteNonQuery();
                        }
                    }

                    foreach (int rowIdx in modfiiedRows)
                    {
                        values = "";

                        foreach (DataGridViewColumn col in gridView.Columns)
                        {
                            if (col.Name != "ID")
                            {
                                values += values == String.Empty ? "" : ",";

                                values += col.Name + "=";

                                values += this.getValueFromCell(gridView.Rows[rowIdx].Cells[col.Name]);
                            }
                        }

                        sql = $"UPDATE laptop SET {values} WHERE ID = {gridView.Rows[rowIdx].Cells["ID"].Value}";

                        using (var command = new OdbcCommand(sql, con, transaction))
                        {
                            command.ExecuteNonQuery();
                        }
                    }

                    string idsToDelete = String.Join(",", deletedRows.Cast<String>());


                    if (idsToDelete != String.Empty)
                    {
                        sql = $"DELETE FROM laptop WHERE ID in ({idsToDelete})";

                        using (var command = new OdbcCommand(sql, con, transaction))
                        {
                            command.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();

                    this.emptyRowLists();
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void emptyRowLists()
        {
            modfiiedRows   = new ArrayList();
            newRows        = new ArrayList();
            deletedRows    = new ArrayList();
            duplicatedRows = new ArrayList();
        }

        private string getValueFromCell(DataGridViewCell _cell)
        {
            string ret;
            string cellValue = (_cell.Value ?? "").ToString();

            if (_cell.ValueType == typeof(String))
            {
                ret = $"'{cellValue.Trim()}'";
            }
            else
            {
                ret = cellValue == String.Empty ? "0" : cellValue;
            }

            return ret;
        }


        private ArrayList getDuplicatedRows()
        {
            StringBuilder output;
            Hashtable hTable = new Hashtable();
            ArrayList duplicateList = new ArrayList();

            for (int i = 0; i < gridView.Rows.Count - 1; i++)
            {
                DataGridViewRow row = gridView.Rows[i];

                output = new StringBuilder();

                foreach (DataGridViewColumn col in gridView.Columns)
                {
                    if (col.Name != "ID")
                    {
                        output.AppendFormat("{0}", Regex.Replace(row.Cells[col.Name].Value.ToString(), @"\s+", ""));
                    }
                }

                if (hTable.Contains(output.ToString()))
                {
                    duplicateList.Add(row.Index);
                    duplicateList.Add(hTable[output.ToString()]);
                }
                else
                {
                    hTable.Add(output.ToString(), row.Index);
                }
            };

            return duplicateList;
        }
    }
}
