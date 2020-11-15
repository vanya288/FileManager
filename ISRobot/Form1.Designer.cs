namespace ISRobot
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
            this.components = new System.ComponentModel.Container();
            this.ID = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ManufacturerCountTxt = new System.Windows.Forms.TextBox();
            this.featuresList = new System.Windows.Forms.CheckedListBox();
            this.runTestBtn = new System.Windows.Forms.Button();
            this.LaptopIdLbl = new System.Windows.Forms.Label();
            this.ManufacturerCountLbl = new System.Windows.Forms.Label();
            this.ManufacturerLbl = new System.Windows.Forms.Label();
            this.Manufacturer = new System.Windows.Forms.TextBox();
            this.ScreenSizeLbl = new System.Windows.Forms.Label();
            this.ScreenSize = new System.Windows.Forms.TextBox();
            this.ResolutionLbl = new System.Windows.Forms.Label();
            this.Resolution = new System.Windows.Forms.TextBox();
            this.ScreenTypeLbl = new System.Windows.Forms.Label();
            this.ScreenType = new System.Windows.Forms.TextBox();
            this.TouchscreenLbl = new System.Windows.Forms.Label();
            this.Touchscreen = new System.Windows.Forms.TextBox();
            this.ProcessorLbl = new System.Windows.Forms.Label();
            this.Processor = new System.Windows.Forms.TextBox();
            this.CoreCountLbl = new System.Windows.Forms.Label();
            this.CoreCount = new System.Windows.Forms.TextBox();
            this.ODDLbl = new System.Windows.Forms.Label();
            this.OpticalDiscType = new System.Windows.Forms.TextBox();
            this.OSLbl = new System.Windows.Forms.Label();
            this.OperatingSystem = new System.Windows.Forms.TextBox();
            this.GPUCapacityLbl = new System.Windows.Forms.Label();
            this.GraphicsCardCapacity = new System.Windows.Forms.TextBox();
            this.GPULbl = new System.Windows.Forms.Label();
            this.GraphicCard = new System.Windows.Forms.TextBox();
            this.DiskTypeLbl = new System.Windows.Forms.Label();
            this.DiskType = new System.Windows.Forms.TextBox();
            this.CapacityLbl = new System.Windows.Forms.Label();
            this.Capacity = new System.Windows.Forms.TextBox();
            this.RAMLbl = new System.Windows.Forms.Label();
            this.RAM = new System.Windows.Forms.TextBox();
            this.ClockSignalLbl = new System.Windows.Forms.Label();
            this.ClockSignal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(100, 35);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(254, 30);
            this.ID.TabIndex = 0;
            this.ID.Text = "3";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ManufacturerCountTxt
            // 
            this.ManufacturerCountTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerCountTxt.Location = new System.Drawing.Point(100, 367);
            this.ManufacturerCountTxt.Name = "ManufacturerCountTxt";
            this.ManufacturerCountTxt.Size = new System.Drawing.Size(254, 30);
            this.ManufacturerCountTxt.TabIndex = 2;
            // 
            // featuresList
            // 
            this.featuresList.CheckOnClick = true;
            this.featuresList.FormattingEnabled = true;
            this.featuresList.Location = new System.Drawing.Point(100, 417);
            this.featuresList.Name = "featuresList";
            this.featuresList.Size = new System.Drawing.Size(254, 157);
            this.featuresList.TabIndex = 17;
            // 
            // runTestBtn
            // 
            this.runTestBtn.Location = new System.Drawing.Point(30, 605);
            this.runTestBtn.Name = "runTestBtn";
            this.runTestBtn.Size = new System.Drawing.Size(694, 37);
            this.runTestBtn.TabIndex = 18;
            this.runTestBtn.Text = "Run test";
            this.runTestBtn.UseVisualStyleBackColor = true;
            this.runTestBtn.Click += new System.EventHandler(this.runTestBtn_Click);
            // 
            // LaptopIdLbl
            // 
            this.LaptopIdLbl.AutoSize = true;
            this.LaptopIdLbl.Location = new System.Drawing.Point(27, 38);
            this.LaptopIdLbl.Name = "LaptopIdLbl";
            this.LaptopIdLbl.Size = new System.Drawing.Size(69, 17);
            this.LaptopIdLbl.TabIndex = 19;
            this.LaptopIdLbl.Text = "Laptop ID";
            // 
            // ManufacturerCountLbl
            // 
            this.ManufacturerCountLbl.AutoSize = true;
            this.ManufacturerCountLbl.Location = new System.Drawing.Point(6, 370);
            this.ManufacturerCountLbl.Name = "ManufacturerCountLbl";
            this.ManufacturerCountLbl.Size = new System.Drawing.Size(92, 17);
            this.ManufacturerCountLbl.TabIndex = 20;
            this.ManufacturerCountLbl.Text = "Manufacturer";
            // 
            // ManufacturerLbl
            // 
            this.ManufacturerLbl.AutoSize = true;
            this.ManufacturerLbl.Location = new System.Drawing.Point(6, 74);
            this.ManufacturerLbl.Name = "ManufacturerLbl";
            this.ManufacturerLbl.Size = new System.Drawing.Size(92, 17);
            this.ManufacturerLbl.TabIndex = 22;
            this.ManufacturerLbl.Text = "Manufacturer";
            // 
            // Manufacturer
            // 
            this.Manufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manufacturer.Location = new System.Drawing.Point(100, 71);
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.Size = new System.Drawing.Size(254, 30);
            this.Manufacturer.TabIndex = 21;
            this.Manufacturer.Text = "Robot";
            // 
            // ScreenSizeLbl
            // 
            this.ScreenSizeLbl.AutoSize = true;
            this.ScreenSizeLbl.Location = new System.Drawing.Point(15, 110);
            this.ScreenSizeLbl.Name = "ScreenSizeLbl";
            this.ScreenSizeLbl.Size = new System.Drawing.Size(82, 17);
            this.ScreenSizeLbl.TabIndex = 24;
            this.ScreenSizeLbl.Text = "Screen size";
            // 
            // ScreenSize
            // 
            this.ScreenSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenSize.Location = new System.Drawing.Point(100, 107);
            this.ScreenSize.Name = "ScreenSize";
            this.ScreenSize.Size = new System.Drawing.Size(254, 30);
            this.ScreenSize.TabIndex = 23;
            this.ScreenSize.Text = "Robot 1920x1080";
            // 
            // ResolutionLbl
            // 
            this.ResolutionLbl.AutoSize = true;
            this.ResolutionLbl.Location = new System.Drawing.Point(23, 146);
            this.ResolutionLbl.Name = "ResolutionLbl";
            this.ResolutionLbl.Size = new System.Drawing.Size(75, 17);
            this.ResolutionLbl.TabIndex = 26;
            this.ResolutionLbl.Text = "Resolution";
            // 
            // Resolution
            // 
            this.Resolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resolution.Location = new System.Drawing.Point(100, 143);
            this.Resolution.Name = "Resolution";
            this.Resolution.Size = new System.Drawing.Size(254, 30);
            this.Resolution.TabIndex = 25;
            // 
            // ScreenTypeLbl
            // 
            this.ScreenTypeLbl.AutoSize = true;
            this.ScreenTypeLbl.Location = new System.Drawing.Point(13, 182);
            this.ScreenTypeLbl.Name = "ScreenTypeLbl";
            this.ScreenTypeLbl.Size = new System.Drawing.Size(84, 17);
            this.ScreenTypeLbl.TabIndex = 28;
            this.ScreenTypeLbl.Text = "Screen type";
            // 
            // ScreenType
            // 
            this.ScreenType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenType.Location = new System.Drawing.Point(100, 179);
            this.ScreenType.Name = "ScreenType";
            this.ScreenType.Size = new System.Drawing.Size(254, 30);
            this.ScreenType.TabIndex = 27;
            // 
            // TouchscreenLbl
            // 
            this.TouchscreenLbl.AutoSize = true;
            this.TouchscreenLbl.Location = new System.Drawing.Point(6, 218);
            this.TouchscreenLbl.Name = "TouchscreenLbl";
            this.TouchscreenLbl.Size = new System.Drawing.Size(91, 17);
            this.TouchscreenLbl.TabIndex = 30;
            this.TouchscreenLbl.Text = "Touchscreen";
            // 
            // Touchscreen
            // 
            this.Touchscreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Touchscreen.Location = new System.Drawing.Point(100, 215);
            this.Touchscreen.Name = "Touchscreen";
            this.Touchscreen.Size = new System.Drawing.Size(254, 30);
            this.Touchscreen.TabIndex = 29;
            // 
            // ProcessorLbl
            // 
            this.ProcessorLbl.AutoSize = true;
            this.ProcessorLbl.Location = new System.Drawing.Point(27, 254);
            this.ProcessorLbl.Name = "ProcessorLbl";
            this.ProcessorLbl.Size = new System.Drawing.Size(72, 17);
            this.ProcessorLbl.TabIndex = 32;
            this.ProcessorLbl.Text = "Processor";
            // 
            // Processor
            // 
            this.Processor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Processor.Location = new System.Drawing.Point(100, 251);
            this.Processor.Name = "Processor";
            this.Processor.Size = new System.Drawing.Size(254, 30);
            this.Processor.TabIndex = 31;
            this.Processor.Text = "Robot processor";
            // 
            // CoreCountLbl
            // 
            this.CoreCountLbl.AutoSize = true;
            this.CoreCountLbl.Location = new System.Drawing.Point(22, 290);
            this.CoreCountLbl.Name = "CoreCountLbl";
            this.CoreCountLbl.Size = new System.Drawing.Size(77, 17);
            this.CoreCountLbl.TabIndex = 34;
            this.CoreCountLbl.Text = "Core count";
            // 
            // CoreCount
            // 
            this.CoreCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoreCount.Location = new System.Drawing.Point(100, 287);
            this.CoreCount.Name = "CoreCount";
            this.CoreCount.Size = new System.Drawing.Size(254, 30);
            this.CoreCount.TabIndex = 33;
            // 
            // ODDLbl
            // 
            this.ODDLbl.AutoSize = true;
            this.ODDLbl.Location = new System.Drawing.Point(428, 290);
            this.ODDLbl.Name = "ODDLbl";
            this.ODDLbl.Size = new System.Drawing.Size(39, 17);
            this.ODDLbl.TabIndex = 50;
            this.ODDLbl.Text = "ODD";
            // 
            // OpticalDiscType
            // 
            this.OpticalDiscType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpticalDiscType.Location = new System.Drawing.Point(470, 287);
            this.OpticalDiscType.Name = "OpticalDiscType";
            this.OpticalDiscType.Size = new System.Drawing.Size(254, 30);
            this.OpticalDiscType.TabIndex = 49;
            // 
            // OSLbl
            // 
            this.OSLbl.AutoSize = true;
            this.OSLbl.Location = new System.Drawing.Point(438, 254);
            this.OSLbl.Name = "OSLbl";
            this.OSLbl.Size = new System.Drawing.Size(28, 17);
            this.OSLbl.TabIndex = 48;
            this.OSLbl.Text = "OS";
            // 
            // OperatingSystem
            // 
            this.OperatingSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperatingSystem.Location = new System.Drawing.Point(470, 251);
            this.OperatingSystem.Name = "OperatingSystem";
            this.OperatingSystem.Size = new System.Drawing.Size(254, 30);
            this.OperatingSystem.TabIndex = 47;
            this.OperatingSystem.Text = "Robot OS";
            // 
            // GPUCapacityLbl
            // 
            this.GPUCapacityLbl.AutoSize = true;
            this.GPUCapacityLbl.Location = new System.Drawing.Point(372, 218);
            this.GPUCapacityLbl.Name = "GPUCapacityLbl";
            this.GPUCapacityLbl.Size = new System.Drawing.Size(94, 17);
            this.GPUCapacityLbl.TabIndex = 46;
            this.GPUCapacityLbl.Text = "GPU capacity";
            // 
            // GraphicsCardCapacity
            // 
            this.GraphicsCardCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GraphicsCardCapacity.Location = new System.Drawing.Point(470, 215);
            this.GraphicsCardCapacity.Name = "GraphicsCardCapacity";
            this.GraphicsCardCapacity.Size = new System.Drawing.Size(254, 30);
            this.GraphicsCardCapacity.TabIndex = 45;
            // 
            // GPULbl
            // 
            this.GPULbl.AutoSize = true;
            this.GPULbl.Location = new System.Drawing.Point(428, 182);
            this.GPULbl.Name = "GPULbl";
            this.GPULbl.Size = new System.Drawing.Size(38, 17);
            this.GPULbl.TabIndex = 44;
            this.GPULbl.Text = "GPU";
            // 
            // GraphicCard
            // 
            this.GraphicCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GraphicCard.Location = new System.Drawing.Point(470, 179);
            this.GraphicCard.Name = "GraphicCard";
            this.GraphicCard.Size = new System.Drawing.Size(254, 30);
            this.GraphicCard.TabIndex = 43;
            this.GraphicCard.Text = "Robot GPU";
            // 
            // DiskTypeLbl
            // 
            this.DiskTypeLbl.AutoSize = true;
            this.DiskTypeLbl.Location = new System.Drawing.Point(400, 146);
            this.DiskTypeLbl.Name = "DiskTypeLbl";
            this.DiskTypeLbl.Size = new System.Drawing.Size(66, 17);
            this.DiskTypeLbl.TabIndex = 42;
            this.DiskTypeLbl.Text = "Disc type";
            // 
            // DiskType
            // 
            this.DiskType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiskType.Location = new System.Drawing.Point(470, 143);
            this.DiskType.Name = "DiskType";
            this.DiskType.Size = new System.Drawing.Size(254, 30);
            this.DiskType.TabIndex = 41;
            // 
            // CapacityLbl
            // 
            this.CapacityLbl.AutoSize = true;
            this.CapacityLbl.Location = new System.Drawing.Point(405, 110);
            this.CapacityLbl.Name = "CapacityLbl";
            this.CapacityLbl.Size = new System.Drawing.Size(62, 17);
            this.CapacityLbl.TabIndex = 40;
            this.CapacityLbl.Text = "Capacity";
            // 
            // Capacity
            // 
            this.Capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Capacity.Location = new System.Drawing.Point(470, 107);
            this.Capacity.Name = "Capacity";
            this.Capacity.Size = new System.Drawing.Size(254, 30);
            this.Capacity.TabIndex = 39;
            // 
            // RAMLbl
            // 
            this.RAMLbl.AutoSize = true;
            this.RAMLbl.Location = new System.Drawing.Point(428, 74);
            this.RAMLbl.Name = "RAMLbl";
            this.RAMLbl.Size = new System.Drawing.Size(38, 17);
            this.RAMLbl.TabIndex = 38;
            this.RAMLbl.Text = "RAM";
            // 
            // RAM
            // 
            this.RAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RAM.Location = new System.Drawing.Point(470, 71);
            this.RAM.Name = "RAM";
            this.RAM.Size = new System.Drawing.Size(254, 30);
            this.RAM.TabIndex = 37;
            // 
            // ClockSignalLbl
            // 
            this.ClockSignalLbl.AutoSize = true;
            this.ClockSignalLbl.Location = new System.Drawing.Point(386, 38);
            this.ClockSignalLbl.Name = "ClockSignalLbl";
            this.ClockSignalLbl.Size = new System.Drawing.Size(83, 17);
            this.ClockSignalLbl.TabIndex = 36;
            this.ClockSignalLbl.Text = "Clock signal";
            // 
            // ClockSignal
            // 
            this.ClockSignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockSignal.Location = new System.Drawing.Point(470, 35);
            this.ClockSignal.Name = "ClockSignal";
            this.ClockSignal.Size = new System.Drawing.Size(254, 30);
            this.ClockSignal.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 687);
            this.Controls.Add(this.ODDLbl);
            this.Controls.Add(this.OpticalDiscType);
            this.Controls.Add(this.OSLbl);
            this.Controls.Add(this.OperatingSystem);
            this.Controls.Add(this.GPUCapacityLbl);
            this.Controls.Add(this.GraphicsCardCapacity);
            this.Controls.Add(this.GPULbl);
            this.Controls.Add(this.GraphicCard);
            this.Controls.Add(this.DiskTypeLbl);
            this.Controls.Add(this.DiskType);
            this.Controls.Add(this.CapacityLbl);
            this.Controls.Add(this.Capacity);
            this.Controls.Add(this.RAMLbl);
            this.Controls.Add(this.RAM);
            this.Controls.Add(this.ClockSignalLbl);
            this.Controls.Add(this.ClockSignal);
            this.Controls.Add(this.CoreCountLbl);
            this.Controls.Add(this.CoreCount);
            this.Controls.Add(this.ProcessorLbl);
            this.Controls.Add(this.Processor);
            this.Controls.Add(this.TouchscreenLbl);
            this.Controls.Add(this.Touchscreen);
            this.Controls.Add(this.ScreenTypeLbl);
            this.Controls.Add(this.ScreenType);
            this.Controls.Add(this.ResolutionLbl);
            this.Controls.Add(this.Resolution);
            this.Controls.Add(this.ScreenSizeLbl);
            this.Controls.Add(this.ScreenSize);
            this.Controls.Add(this.ManufacturerLbl);
            this.Controls.Add(this.Manufacturer);
            this.Controls.Add(this.ManufacturerCountLbl);
            this.Controls.Add(this.LaptopIdLbl);
            this.Controls.Add(this.runTestBtn);
            this.Controls.Add(this.featuresList);
            this.Controls.Add(this.ManufacturerCountTxt);
            this.Controls.Add(this.ID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox ManufacturerCountTxt;
        private System.Windows.Forms.CheckedListBox featuresList;
        private System.Windows.Forms.Button runTestBtn;
        private System.Windows.Forms.Label LaptopIdLbl;
        private System.Windows.Forms.Label ManufacturerCountLbl;
        private System.Windows.Forms.Label ManufacturerLbl;
        private System.Windows.Forms.TextBox Manufacturer;
        private System.Windows.Forms.Label ScreenSizeLbl;
        private System.Windows.Forms.TextBox ScreenSize;
        private System.Windows.Forms.Label ResolutionLbl;
        private System.Windows.Forms.TextBox Resolution;
        private System.Windows.Forms.Label ScreenTypeLbl;
        private System.Windows.Forms.TextBox ScreenType;
        private System.Windows.Forms.Label TouchscreenLbl;
        private System.Windows.Forms.TextBox Touchscreen;
        private System.Windows.Forms.Label ProcessorLbl;
        private System.Windows.Forms.TextBox Processor;
        private System.Windows.Forms.Label CoreCountLbl;
        private System.Windows.Forms.TextBox CoreCount;
        private System.Windows.Forms.Label ODDLbl;
        private System.Windows.Forms.TextBox OpticalDiscType;
        private System.Windows.Forms.Label OSLbl;
        private System.Windows.Forms.TextBox OperatingSystem;
        private System.Windows.Forms.Label GPUCapacityLbl;
        private System.Windows.Forms.TextBox GraphicsCardCapacity;
        private System.Windows.Forms.Label GPULbl;
        private System.Windows.Forms.TextBox GraphicCard;
        private System.Windows.Forms.Label DiskTypeLbl;
        private System.Windows.Forms.TextBox DiskType;
        private System.Windows.Forms.Label CapacityLbl;
        private System.Windows.Forms.TextBox Capacity;
        private System.Windows.Forms.Label RAMLbl;
        private System.Windows.Forms.TextBox RAM;
        private System.Windows.Forms.Label ClockSignalLbl;
        private System.Windows.Forms.TextBox ClockSignal;
    }
}

