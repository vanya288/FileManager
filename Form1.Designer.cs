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
            this.loadFromDBBtn = new System.Windows.Forms.Button();
            this.saveToDBBtn = new System.Windows.Forms.Button();
            this.infoText = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.mfrTxt = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.countMfrBtn = new System.Windows.Forms.Button();
            this.mfrAnswerTxt = new System.Windows.Forms.TextBox();
            this.resAnswerTxt = new System.Windows.Forms.TextBox();
            this.countResBtn = new System.Windows.Forms.Button();
            this.resComboBox = new System.Windows.Forms.ComboBox();
            this.featuresList = new System.Windows.Forms.CheckedListBox();
            this.exportFeaturesBtn = new System.Windows.Forms.Button();
            this.exportFeaturesFromGridBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView
            // 
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
            this.gridView.Location = new System.Drawing.Point(12, 162);
            this.gridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersWidth = 51;
            this.gridView.RowTemplate.Height = 24;
            this.gridView.Size = new System.Drawing.Size(1911, 441);
            this.gridView.TabIndex = 0;
            // 
            // loadFromTXTBtn
            // 
            this.loadFromTXTBtn.Location = new System.Drawing.Point(12, 30);
            this.loadFromTXTBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadFromTXTBtn.Name = "loadFromTXTBtn";
            this.loadFromTXTBtn.Size = new System.Drawing.Size(144, 41);
            this.loadFromTXTBtn.TabIndex = 1;
            this.loadFromTXTBtn.Text = "Load from text file";
            this.loadFromTXTBtn.UseVisualStyleBackColor = true;
            this.loadFromTXTBtn.Click += new System.EventHandler(this.loadFromTXTBtn_Click);
            // 
            // exportToTXTBtn
            // 
            this.exportToTXTBtn.Location = new System.Drawing.Point(171, 30);
            this.exportToTXTBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportToTXTBtn.Name = "exportToTXTBtn";
            this.exportToTXTBtn.Size = new System.Drawing.Size(134, 41);
            this.exportToTXTBtn.TabIndex = 2;
            this.exportToTXTBtn.Text = "Save to text file";
            this.exportToTXTBtn.UseVisualStyleBackColor = true;
            this.exportToTXTBtn.Click += new System.EventHandler(this.exportToTXTBtn_Click);
            // 
            // loadFromXMLBtn
            // 
            this.loadFromXMLBtn.Location = new System.Drawing.Point(12, 77);
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
            this.exportToXMLBtn.Location = new System.Drawing.Point(171, 77);
            this.exportToXMLBtn.Name = "exportToXMLBtn";
            this.exportToXMLBtn.Size = new System.Drawing.Size(134, 41);
            this.exportToXMLBtn.TabIndex = 4;
            this.exportToXMLBtn.Text = "Save to XML file";
            this.exportToXMLBtn.UseVisualStyleBackColor = true;
            this.exportToXMLBtn.Click += new System.EventHandler(this.exportToXMLBtn_Click);
            // 
            // loadFromDBBtn
            // 
            this.loadFromDBBtn.Location = new System.Drawing.Point(321, 30);
            this.loadFromDBBtn.Name = "loadFromDBBtn";
            this.loadFromDBBtn.Size = new System.Drawing.Size(110, 41);
            this.loadFromDBBtn.TabIndex = 5;
            this.loadFromDBBtn.Text = "Load from DB";
            this.loadFromDBBtn.UseVisualStyleBackColor = true;
            this.loadFromDBBtn.Click += new System.EventHandler(this.loadFromDBBtn_Click);
            // 
            // saveToDBBtn
            // 
            this.saveToDBBtn.Location = new System.Drawing.Point(321, 77);
            this.saveToDBBtn.Name = "saveToDBBtn";
            this.saveToDBBtn.Size = new System.Drawing.Size(110, 41);
            this.saveToDBBtn.TabIndex = 6;
            this.saveToDBBtn.Text = "Save to DB";
            this.saveToDBBtn.UseVisualStyleBackColor = true;
            this.saveToDBBtn.Click += new System.EventHandler(this.saveToDBBtn_Click);
            // 
            // infoText
            // 
            this.infoText.AutoSize = true;
            this.infoText.Location = new System.Drawing.Point(13, 86);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(0, 17);
            this.infoText.TabIndex = 7;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(13, 131);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(103, 17);
            this.infoLabel.TabIndex = 8;
            this.infoLabel.Text = "Records status";
            // 
            // mfrTxt
            // 
            this.mfrTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mfrTxt.Location = new System.Drawing.Point(447, 86);
            this.mfrTxt.Name = "mfrTxt";
            this.mfrTxt.Size = new System.Drawing.Size(161, 30);
            this.mfrTxt.TabIndex = 10;
            this.mfrTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.countMfrBtn_KeyDown);
            // 
            // countMfrBtn
            // 
            this.countMfrBtn.Location = new System.Drawing.Point(447, 30);
            this.countMfrBtn.Name = "countMfrBtn";
            this.countMfrBtn.Size = new System.Drawing.Size(242, 41);
            this.countMfrBtn.TabIndex = 9;
            this.countMfrBtn.Text = "Count manufacturer";
            this.countMfrBtn.UseVisualStyleBackColor = true;
            this.countMfrBtn.Click += new System.EventHandler(this.countMfrBtn_Click);
            // 
            // mfrAnswerTxt
            // 
            this.mfrAnswerTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mfrAnswerTxt.Location = new System.Drawing.Point(614, 86);
            this.mfrAnswerTxt.Name = "mfrAnswerTxt";
            this.mfrAnswerTxt.ReadOnly = true;
            this.mfrAnswerTxt.Size = new System.Drawing.Size(75, 30);
            this.mfrAnswerTxt.TabIndex = 11;
            // 
            // resAnswerTxt
            // 
            this.resAnswerTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resAnswerTxt.Location = new System.Drawing.Point(872, 86);
            this.resAnswerTxt.Name = "resAnswerTxt";
            this.resAnswerTxt.ReadOnly = true;
            this.resAnswerTxt.Size = new System.Drawing.Size(75, 30);
            this.resAnswerTxt.TabIndex = 14;
            // 
            // countResBtn
            // 
            this.countResBtn.Location = new System.Drawing.Point(705, 30);
            this.countResBtn.Name = "countResBtn";
            this.countResBtn.Size = new System.Drawing.Size(242, 41);
            this.countResBtn.TabIndex = 12;
            this.countResBtn.Text = "Count resolution";
            this.countResBtn.UseVisualStyleBackColor = true;
            this.countResBtn.Click += new System.EventHandler(this.countResBtn_Click);
            // 
            // resComboBox
            // 
            this.resComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resComboBox.FormattingEnabled = true;
            this.resComboBox.Location = new System.Drawing.Point(705, 86);
            this.resComboBox.Name = "resComboBox";
            this.resComboBox.Size = new System.Drawing.Size(152, 30);
            this.resComboBox.TabIndex = 15;
            this.resComboBox.DropDownClosed += new System.EventHandler(this.resComboBox_DropDownClosed);
            this.resComboBox.SelectedValueChanged += new System.EventHandler(this.resComboBox_SelectedValueChanged);
            // 
            // featuresList
            // 
            this.featuresList.CheckOnClick = true;
            this.featuresList.FormattingEnabled = true;
            this.featuresList.Location = new System.Drawing.Point(964, 30);
            this.featuresList.Name = "featuresList";
            this.featuresList.Size = new System.Drawing.Size(173, 123);
            this.featuresList.TabIndex = 16;
            this.featuresList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.colsList_ItemCheck);
            // 
            // exportFeaturesBtn
            // 
            this.exportFeaturesBtn.Enabled = false;
            this.exportFeaturesBtn.Location = new System.Drawing.Point(1144, 30);
            this.exportFeaturesBtn.Name = "exportFeaturesBtn";
            this.exportFeaturesBtn.Size = new System.Drawing.Size(168, 41);
            this.exportFeaturesBtn.TabIndex = 17;
            this.exportFeaturesBtn.Text = "Export from DB to XML";
            this.exportFeaturesBtn.UseVisualStyleBackColor = true;
            this.exportFeaturesBtn.Click += new System.EventHandler(this.exportFeaturesBtn_Click);
            // 
            // exportFeaturesFromGridBtn
            // 
            this.exportFeaturesFromGridBtn.Enabled = false;
            this.exportFeaturesFromGridBtn.Location = new System.Drawing.Point(1144, 77);
            this.exportFeaturesFromGridBtn.Name = "exportFeaturesFromGridBtn";
            this.exportFeaturesFromGridBtn.Size = new System.Drawing.Size(168, 41);
            this.exportFeaturesFromGridBtn.TabIndex = 18;
            this.exportFeaturesFromGridBtn.Text = "Export from grid to XML";
            this.exportFeaturesFromGridBtn.UseVisualStyleBackColor = true;
            this.exportFeaturesFromGridBtn.Click += new System.EventHandler(this.exportSelectedFeaturesBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1424, 644);
            this.Controls.Add(this.exportFeaturesFromGridBtn);
            this.Controls.Add(this.exportFeaturesBtn);
            this.Controls.Add(this.featuresList);
            this.Controls.Add(this.resComboBox);
            this.Controls.Add(this.resAnswerTxt);
            this.Controls.Add(this.countResBtn);
            this.Controls.Add(this.mfrAnswerTxt);
            this.Controls.Add(this.mfrTxt);
            this.Controls.Add(this.countMfrBtn);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.saveToDBBtn);
            this.Controls.Add(this.loadFromDBBtn);
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
            this.PerformLayout();

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
        private System.Windows.Forms.Button loadFromDBBtn;
        private System.Windows.Forms.Button saveToDBBtn;
        private System.Windows.Forms.Label infoText;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TextBox mfrTxt;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button countMfrBtn;
        private System.Windows.Forms.TextBox mfrAnswerTxt;
        private System.Windows.Forms.TextBox resAnswerTxt;
        private System.Windows.Forms.Button countResBtn;
        private System.Windows.Forms.ComboBox resComboBox;
        private System.Windows.Forms.CheckedListBox featuresList;
        private System.Windows.Forms.Button exportFeaturesBtn;
        private System.Windows.Forms.Button exportFeaturesFromGridBtn;
    }
}

