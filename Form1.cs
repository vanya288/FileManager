using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Lab1
{
    public partial class Form1 : Form
    {
        private readonly SynchronizationContext synchronizationContext;
        private DateTime previousTime = DateTime.Now;

        public Form1()
        {
            InitializeComponent();

            synchronizationContext = SynchronizationContext.Current;

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
        }

        public void UpdateUI(int value)
        {
            var timeNow = DateTime.Now;

            //Here we only refresh our UI each 50 ms  
            if ((DateTime.Now - previousTime).Milliseconds <= 50) return;

            previousTime = timeNow;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadFromTXTBtn_Click(object sender, EventArgs e)
        {
            StreamReader file;

            if (openTXTFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            file = new StreamReader(openTXTFileDialog.FileName);

            DataTable dt = new DataTable();

            int    colNum = 0;
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
        }

        private void loadFromXMLBtn_Click(object sender, EventArgs e)
        {
            if (openXMLFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();

            dataSet.ReadXml(openXMLFileDialog.FileName);

            for (int col = 0; col < dataSet.Tables.Count; col++)
            {
                dataTable.Merge(dataSet.Tables[col]);
            }

            gridView.DataSource = dataTable;
        }

        private void exportToTXTBtn_Click(object sender, EventArgs e)
        {
            if (saveTXTFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

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

        private void exportToXMLBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            StreamWriter file;

            if (saveXMLFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

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
    }
}
