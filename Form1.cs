using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Lab1
{
    public partial class Form1 : Form
    {
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

            folderBrowserDialog1.SelectedPath = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadFromTXTBtn_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader file;
            if (openTXTFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            file = new System.IO.StreamReader(openTXTFileDialog.FileName);

            string[] columnnames = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16" };

            DataTable dt = new DataTable();

            foreach (string c in columnnames)
            {
                dt.Columns.Add(c);
            }

            string newline;

            while ((newline = file.ReadLine()) != null)
            {
                DataRow dr = dt.NewRow();
                string[] values = newline.Split(';');
                for (int i = 0; i < values.Length; i++)
                {
                    dr[i] = values[i];
                }
                dt.Rows.Add(dr);
            }
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
            string fileName = "";

            openTXTFileDialog.CheckFileExists = false;

            if (openTXTFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            fileName = folderBrowserDialog1.SelectedPath;

            List<string> list = new List<string>();

            for (int rows = 0; rows < gridView.Rows.Count; rows++)
            {
                for (int col = 0; col < gridView.Rows[rows].Cells.Count; col++)
                {
                    string value = "";

                    if (gridView.Rows[rows].Cells[col].Value != null)
                    {
                        value = gridView.Rows[rows].Cells[col].Value.ToString();
                    }

                    list.Add(value);
                }
                list.Add("\n");
            }

            System.IO.StreamWriter file = new System.IO.StreamWriter(fileName);

            foreach (var item in list)
            {
                file.Write(item + (item == "\n" ? "" : ";"));
            }

            file.Close();
        }

        private void exportToXMLBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            System.IO.StreamWriter file;

            openXMLFileDialog.CheckFileExists = false;

            if (openXMLFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            file = new System.IO.StreamWriter(openXMLFileDialog.FileName);

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

            this.Close();
        }
    }
}
