namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.loadFromTXTBtn = new System.Windows.Forms.Button();
            this.exportToTXTBtn = new System.Windows.Forms.Button();
            this.loadFromXMLBtn = new System.Windows.Forms.Button();
            this.openXMLFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openTXTFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.exportToXMLBtn = new System.Windows.Forms.Button();
            this.saveTXTFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveXMLFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridView.Location = new System.Drawing.Point(12, 86);
            this.gridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersWidth = 51;
            this.gridView.RowTemplate.Height = 24;
            this.gridView.Size = new System.Drawing.Size(1189, 390);
            this.gridView.TabIndex = 0;
            this.gridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // loadFromTXTBtn
            // 
            this.loadFromTXTBtn.Location = new System.Drawing.Point(12, 30);
            this.loadFromTXTBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadFromTXTBtn.Name = "loadFromTXTBtn";
            this.loadFromTXTBtn.Size = new System.Drawing.Size(130, 41);
            this.loadFromTXTBtn.TabIndex = 1;
            this.loadFromTXTBtn.Text = "Load from text file";
            this.loadFromTXTBtn.UseVisualStyleBackColor = true;
            this.loadFromTXTBtn.Click += new System.EventHandler(this.loadFromTXTBtn_Click);
            // 
            // exportToTXTBtn
            // 
            this.exportToTXTBtn.Location = new System.Drawing.Point(298, 30);
            this.exportToTXTBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportToTXTBtn.Name = "exportToTXTBtn";
            this.exportToTXTBtn.Size = new System.Drawing.Size(128, 41);
            this.exportToTXTBtn.TabIndex = 2;
            this.exportToTXTBtn.Text = "Save to text file";
            this.exportToTXTBtn.UseVisualStyleBackColor = true;
            this.exportToTXTBtn.Click += new System.EventHandler(this.exportToTXTBtn_Click);
            // 
            // loadFromXMLBtn
            // 
            this.loadFromXMLBtn.Location = new System.Drawing.Point(148, 30);
            this.loadFromXMLBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadFromXMLBtn.Name = "loadFromXMLBtn";
            this.loadFromXMLBtn.Size = new System.Drawing.Size(144, 41);
            this.loadFromXMLBtn.TabIndex = 3;
            this.loadFromXMLBtn.Text = "Load from XML file";
            this.loadFromXMLBtn.UseVisualStyleBackColor = true;
            this.loadFromXMLBtn.Click += new System.EventHandler(this.loadFromXMLBtn_Click);
            // 
            // exportToXMLBtn
            // 
            this.exportToXMLBtn.Location = new System.Drawing.Point(432, 30);
            this.exportToXMLBtn.Name = "exportToXMLBtn";
            this.exportToXMLBtn.Size = new System.Drawing.Size(134, 41);
            this.exportToXMLBtn.TabIndex = 4;
            this.exportToXMLBtn.Text = "Save to XML file";
            this.exportToXMLBtn.UseVisualStyleBackColor = true;
            this.exportToXMLBtn.Click += new System.EventHandler(this.exportToXMLBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 487);
            this.Controls.Add(this.exportToXMLBtn);
            this.Controls.Add(this.loadFromXMLBtn);
            this.Controls.Add(this.exportToTXTBtn);
            this.Controls.Add(this.loadFromTXTBtn);
            this.Controls.Add(this.gridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Integracja systemów - Ivan Falchuk";
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Button loadFromTXTBtn;
        private System.Windows.Forms.Button exportToTXTBtn;
        private System.Windows.Forms.Button loadFromXMLBtn;
        private System.Windows.Forms.OpenFileDialog openXMLFileDialog;
        private System.Windows.Forms.OpenFileDialog openTXTFileDialog;
        private System.Windows.Forms.Button exportToXMLBtn;
        private System.Windows.Forms.SaveFileDialog saveTXTFileDialog;
        private System.Windows.Forms.SaveFileDialog saveXMLFileDialog;
    }
}

