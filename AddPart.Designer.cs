
namespace C968_PerformanceAssessment
{
    partial class AddPart
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
            this.AddPartScrennLabel = new System.Windows.Forms.Label();
            this.InhouseRB = new System.Windows.Forms.RadioButton();
            this.OutsourceRB = new System.Windows.Forms.RadioButton();
            this.AddPartSave = new System.Windows.Forms.Button();
            this.AddPartCancel = new System.Windows.Forms.Button();
            this.IdLabel = new System.Windows.Forms.Label();
            this.InventoryLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.MInLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.NameTB = new System.Windows.Forms.TextBox();
            this.InventoryTB = new System.Windows.Forms.TextBox();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.MaxTB = new System.Windows.Forms.TextBox();
            this.MinTB = new System.Windows.Forms.TextBox();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.AddPArtsFormLabelOutsource = new System.Windows.Forms.Label();
            this.IOLabel = new System.Windows.Forms.Label();
            this.IOTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddPartScrennLabel
            // 
            this.AddPartScrennLabel.AutoSize = true;
            this.AddPartScrennLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddPartScrennLabel.Location = new System.Drawing.Point(12, 9);
            this.AddPartScrennLabel.Name = "AddPartScrennLabel";
            this.AddPartScrennLabel.Size = new System.Drawing.Size(71, 20);
            this.AddPartScrennLabel.TabIndex = 0;
            this.AddPartScrennLabel.Text = "Add Part";
            // 
            // InhouseRB
            // 
            this.InhouseRB.AutoSize = true;
            this.InhouseRB.Location = new System.Drawing.Point(166, 24);
            this.InhouseRB.Name = "InhouseRB";
            this.InhouseRB.Size = new System.Drawing.Size(68, 17);
            this.InhouseRB.TabIndex = 1;
            this.InhouseRB.TabStop = true;
            this.InhouseRB.Text = "In House";
            this.InhouseRB.UseVisualStyleBackColor = true;
            this.InhouseRB.CheckedChanged += new System.EventHandler(this.InhouseRB_CheckedChanged);
            // 
            // OutsourceRB
            // 
            this.OutsourceRB.AutoSize = true;
            this.OutsourceRB.Location = new System.Drawing.Point(286, 24);
            this.OutsourceRB.Name = "OutsourceRB";
            this.OutsourceRB.Size = new System.Drawing.Size(74, 17);
            this.OutsourceRB.TabIndex = 1;
            this.OutsourceRB.Text = "Outsource";
            this.OutsourceRB.UseVisualStyleBackColor = true;
            this.OutsourceRB.CheckedChanged += new System.EventHandler(this.OutsourceRB_CheckedChanged);
            // 
            // AddPartSave
            // 
            this.AddPartSave.Location = new System.Drawing.Point(256, 266);
            this.AddPartSave.Name = "AddPartSave";
            this.AddPartSave.Size = new System.Drawing.Size(75, 23);
            this.AddPartSave.TabIndex = 8;
            this.AddPartSave.Text = "Save";
            this.AddPartSave.UseVisualStyleBackColor = true;
            this.AddPartSave.Click += new System.EventHandler(this.AddPartSave_Click);
            // 
            // AddPartCancel
            // 
            this.AddPartCancel.Location = new System.Drawing.Point(337, 266);
            this.AddPartCancel.Name = "AddPartCancel";
            this.AddPartCancel.Size = new System.Drawing.Size(75, 23);
            this.AddPartCancel.TabIndex = 9;
            this.AddPartCancel.TabStop = false;
            this.AddPartCancel.Text = "Cancel";
            this.AddPartCancel.UseVisualStyleBackColor = true;
            this.AddPartCancel.Click += new System.EventHandler(this.AddPartCancel_Click);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(70, 60);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(18, 13);
            this.IdLabel.TabIndex = 5;
            this.IdLabel.Text = "ID";
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.AutoSize = true;
            this.InventoryLabel.Location = new System.Drawing.Point(37, 120);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.InventoryLabel.TabIndex = 6;
            this.InventoryLabel.Text = "Inventory";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(57, 150);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(31, 13);
            this.PriceLabel.TabIndex = 7;
            this.PriceLabel.Text = "Price";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(53, 90);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "Name";
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Location = new System.Drawing.Point(61, 180);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(27, 13);
            this.MaxLabel.TabIndex = 9;
            this.MaxLabel.Text = "Max";
            // 
            // MInLabel
            // 
            this.MInLabel.AutoSize = true;
            this.MInLabel.Location = new System.Drawing.Point(210, 180);
            this.MInLabel.Name = "MInLabel";
            this.MInLabel.Size = new System.Drawing.Size(24, 13);
            this.MInLabel.TabIndex = 10;
            this.MInLabel.Text = "Min";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(94, 87);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(100, 20);
            this.NameTB.TabIndex = 3;
            // 
            // InventoryTB
            // 
            this.InventoryTB.Location = new System.Drawing.Point(94, 117);
            this.InventoryTB.Name = "InventoryTB";
            this.InventoryTB.Size = new System.Drawing.Size(100, 20);
            this.InventoryTB.TabIndex = 4;
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(94, 147);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(100, 20);
            this.PriceTB.TabIndex = 5;
            // 
            // MaxTB
            // 
            this.MaxTB.Location = new System.Drawing.Point(94, 177);
            this.MaxTB.Name = "MaxTB";
            this.MaxTB.Size = new System.Drawing.Size(100, 20);
            this.MaxTB.TabIndex = 6;
            // 
            // MinTB
            // 
            this.MinTB.Location = new System.Drawing.Point(240, 177);
            this.MinTB.Name = "MinTB";
            this.MinTB.Size = new System.Drawing.Size(100, 20);
            this.MinTB.TabIndex = 7;
            // 
            // IdTB
            // 
            this.IdTB.BackColor = System.Drawing.Color.LightGray;
            this.IdTB.ForeColor = System.Drawing.SystemColors.InfoText;
            this.IdTB.Location = new System.Drawing.Point(94, 57);
            this.IdTB.Name = "IdTB";
            this.IdTB.ReadOnly = true;
            this.IdTB.Size = new System.Drawing.Size(100, 20);
            this.IdTB.TabIndex = 10;
            this.IdTB.TabStop = false;
            this.IdTB.Text = "Auto Assignrd";
            this.IdTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddPArtsFormLabelOutsource
            // 
            this.AddPArtsFormLabelOutsource.AutoSize = true;
            this.AddPArtsFormLabelOutsource.Location = new System.Drawing.Point(6, 234);
            this.AddPArtsFormLabelOutsource.Name = "AddPArtsFormLabelOutsource";
            this.AddPArtsFormLabelOutsource.Size = new System.Drawing.Size(0, 13);
            this.AddPArtsFormLabelOutsource.TabIndex = 18;
            // 
            // IOLabel
            // 
            this.IOLabel.AutoSize = true;
            this.IOLabel.Location = new System.Drawing.Point(13, 206);
            this.IOLabel.Name = "IOLabel";
            this.IOLabel.Size = new System.Drawing.Size(44, 13);
            this.IOLabel.TabIndex = 19;
            this.IOLabel.Text = "MD/CN";
            // 
            // IOTB
            // 
            this.IOTB.Location = new System.Drawing.Point(94, 203);
            this.IOTB.Name = "IOTB";
            this.IOTB.Size = new System.Drawing.Size(100, 20);
            this.IOTB.TabIndex = 2;
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 301);
            this.Controls.Add(this.IOTB);
            this.Controls.Add(this.IOLabel);
            this.Controls.Add(this.AddPArtsFormLabelOutsource);
            this.Controls.Add(this.IdTB);
            this.Controls.Add(this.MinTB);
            this.Controls.Add(this.MaxTB);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.InventoryTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.MInLabel);
            this.Controls.Add(this.MaxLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.InventoryLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.AddPartCancel);
            this.Controls.Add(this.AddPartSave);
            this.Controls.Add(this.OutsourceRB);
            this.Controls.Add(this.InhouseRB);
            this.Controls.Add(this.AddPartScrennLabel);
            this.Name = "AddPart";
            this.Text = "Add Parts Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddPartScrennLabel;
        private System.Windows.Forms.RadioButton InhouseRB;
        private System.Windows.Forms.RadioButton OutsourceRB;
        private System.Windows.Forms.Button AddPartSave;
        private System.Windows.Forms.Button AddPartCancel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label InventoryLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label MaxLabel;
        private System.Windows.Forms.Label MInLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox InventoryTB;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.TextBox MaxTB;
        private System.Windows.Forms.TextBox MinTB;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.Label AddPArtsFormLabelOutsource;
        private System.Windows.Forms.Label IOLabel;
        private System.Windows.Forms.TextBox IOTB;
    }
}