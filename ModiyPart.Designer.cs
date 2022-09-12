
namespace C968_PerformanceAssessment
{
    partial class ModifyPart
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
            this.ModifyPartsLabel = new System.Windows.Forms.Label();
            this.ModifyPartSave = new System.Windows.Forms.Button();
            this.ModifyPartsFormCancel = new System.Windows.Forms.Button();
            this.InhouseRB = new System.Windows.Forms.RadioButton();
            this.OutsourcedRB = new System.Windows.Forms.RadioButton();
            this.IdLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.InventoryLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.MaxLAbel = new System.Windows.Forms.Label();
            this.MinLabel = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.InventoryTB = new System.Windows.Forms.TextBox();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.MaxTB = new System.Windows.Forms.TextBox();
            this.MinTB = new System.Windows.Forms.TextBox();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.IOLabel = new System.Windows.Forms.Label();
            this.IOTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ModifyPartsLabel
            // 
            this.ModifyPartsLabel.AutoSize = true;
            this.ModifyPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ModifyPartsLabel.Location = new System.Drawing.Point(12, 9);
            this.ModifyPartsLabel.Name = "ModifyPartsLabel";
            this.ModifyPartsLabel.Size = new System.Drawing.Size(96, 20);
            this.ModifyPartsLabel.TabIndex = 0;
            this.ModifyPartsLabel.Text = "Modify Parts";
            // 
            // ModifyPartSave
            // 
            this.ModifyPartSave.Location = new System.Drawing.Point(256, 266);
            this.ModifyPartSave.Name = "ModifyPartSave";
            this.ModifyPartSave.Size = new System.Drawing.Size(75, 23);
            this.ModifyPartSave.TabIndex = 8;
            this.ModifyPartSave.Text = "Save";
            this.ModifyPartSave.UseVisualStyleBackColor = true;
            this.ModifyPartSave.Click += new System.EventHandler(this.ModifyPartSave_Click);
            // 
            // ModifyPartsFormCancel
            // 
            this.ModifyPartsFormCancel.Location = new System.Drawing.Point(337, 266);
            this.ModifyPartsFormCancel.Name = "ModifyPartsFormCancel";
            this.ModifyPartsFormCancel.Size = new System.Drawing.Size(75, 23);
            this.ModifyPartsFormCancel.TabIndex = 9;
            this.ModifyPartsFormCancel.TabStop = false;
            this.ModifyPartsFormCancel.Text = "Cancel";
            this.ModifyPartsFormCancel.UseVisualStyleBackColor = true;
            this.ModifyPartsFormCancel.Click += new System.EventHandler(this.ModifyPartCancel_Click);
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
            this.InhouseRB.CheckedChanged += new System.EventHandler(this.InHouseRB_CheckedChanged);
            // 
            // OutsourcedRB
            // 
            this.OutsourcedRB.AutoSize = true;
            this.OutsourcedRB.Location = new System.Drawing.Point(286, 24);
            this.OutsourcedRB.Name = "OutsourcedRB";
            this.OutsourcedRB.Size = new System.Drawing.Size(80, 17);
            this.OutsourcedRB.TabIndex = 1;
            this.OutsourcedRB.Text = "Outsourced";
            this.OutsourcedRB.UseVisualStyleBackColor = true;
            this.OutsourcedRB.CheckedChanged += new System.EventHandler(this.OutsourceRB_CheckedChanged);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(73, 60);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(18, 13);
            this.IdLabel.TabIndex = 12;
            this.IdLabel.Text = "ID";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(56, 90);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 13;
            this.NameLabel.Text = "Name";
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.AutoSize = true;
            this.InventoryLabel.Location = new System.Drawing.Point(40, 120);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.InventoryLabel.TabIndex = 14;
            this.InventoryLabel.Text = "Inventory";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(60, 150);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(31, 13);
            this.PriceLabel.TabIndex = 15;
            this.PriceLabel.Text = "Price";
            // 
            // MaxLAbel
            // 
            this.MaxLAbel.AutoSize = true;
            this.MaxLAbel.Location = new System.Drawing.Point(64, 180);
            this.MaxLAbel.Name = "MaxLAbel";
            this.MaxLAbel.Size = new System.Drawing.Size(27, 13);
            this.MaxLAbel.TabIndex = 16;
            this.MaxLAbel.Text = "Max";
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Location = new System.Drawing.Point(210, 180);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(24, 13);
            this.MinLabel.TabIndex = 17;
            this.MinLabel.Text = "Min";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(97, 87);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(100, 20);
            this.NameTB.TabIndex = 3;
            // 
            // InventoryTB
            // 
            this.InventoryTB.Location = new System.Drawing.Point(97, 117);
            this.InventoryTB.Name = "InventoryTB";
            this.InventoryTB.Size = new System.Drawing.Size(100, 20);
            this.InventoryTB.TabIndex = 4;
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(97, 147);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(100, 20);
            this.PriceTB.TabIndex = 5;
            // 
            // MaxTB
            // 
            this.MaxTB.Location = new System.Drawing.Point(97, 177);
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
            this.IdTB.Location = new System.Drawing.Point(97, 57);
            this.IdTB.Name = "IdTB";
            this.IdTB.ReadOnly = true;
            this.IdTB.Size = new System.Drawing.Size(100, 20);
            this.IdTB.TabIndex = 10;
            this.IdTB.TabStop = false;
            // 
            // IOLabel
            // 
            this.IOLabel.AutoSize = true;
            this.IOLabel.Location = new System.Drawing.Point(13, 210);
            this.IOLabel.Name = "IOLabel";
            this.IOLabel.Size = new System.Drawing.Size(44, 13);
            this.IOLabel.TabIndex = 24;
            this.IOLabel.Text = "MD/CN";
            // 
            // IOTB
            // 
            this.IOTB.Location = new System.Drawing.Point(97, 207);
            this.IOTB.Name = "IOTB";
            this.IOTB.Size = new System.Drawing.Size(100, 20);
            this.IOTB.TabIndex = 2;
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 301);
            this.Controls.Add(this.IOTB);
            this.Controls.Add(this.IOLabel);
            this.Controls.Add(this.IdTB);
            this.Controls.Add(this.MinTB);
            this.Controls.Add(this.MaxTB);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.InventoryTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.MinLabel);
            this.Controls.Add(this.MaxLAbel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.InventoryLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.OutsourcedRB);
            this.Controls.Add(this.InhouseRB);
            this.Controls.Add(this.ModifyPartsFormCancel);
            this.Controls.Add(this.ModifyPartSave);
            this.Controls.Add(this.ModifyPartsLabel);
            this.Name = "ModifyPart";
            this.Text = "Modify Parts Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ModifyPartsLabel;
        private System.Windows.Forms.Button ModifyPartSave;
        private System.Windows.Forms.Button ModifyPartsFormCancel;
        private System.Windows.Forms.RadioButton InhouseRB;
        private System.Windows.Forms.RadioButton OutsourcedRB;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label InventoryLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label MaxLAbel;
        private System.Windows.Forms.Label MinLabel;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox InventoryTB;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.TextBox MaxTB;
        private System.Windows.Forms.TextBox MinTB;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.Label IOLabel;
        private System.Windows.Forms.TextBox IOTB;
    }
}