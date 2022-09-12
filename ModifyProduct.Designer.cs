
namespace C968_PerformanceAssessment
{
    partial class ModifyProduct
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
            this.ModifyProductLabel = new System.Windows.Forms.Label();
            this.ModifySearchParts = new System.Windows.Forms.Button();
            this.ModifyPartsLabel = new System.Windows.Forms.Label();
            this.DGV_ModifyProductParts = new System.Windows.Forms.DataGridView();
            this.AddRequiredParts = new System.Windows.Forms.Button();
            this.ModifyProductsFormLableProductsParts = new System.Windows.Forms.Label();
            this.DGV_ModifyProductRequired = new System.Windows.Forms.DataGridView();
            this.ModifyProductSave = new System.Windows.Forms.Button();
            this.ModifyProductCancel = new System.Windows.Forms.Button();
            this.ModifyIdLabel = new System.Windows.Forms.Label();
            this.ModifyNameLabel = new System.Windows.Forms.Label();
            this.ModifyInventoryLabel = new System.Windows.Forms.Label();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.MinLabel = new System.Windows.Forms.Label();
            this.ModifyProductsLabelAddRequireParts = new System.Windows.Forms.Label();
            this.ModifyRequiredDelete = new System.Windows.Forms.Button();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.InventoryTB = new System.Windows.Forms.TextBox();
            this.MaxTB = new System.Windows.Forms.TextBox();
            this.MinTB = new System.Windows.Forms.TextBox();
            this.ModifySearchPartsTB = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PriceTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ModifyProductParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ModifyProductRequired)).BeginInit();
            this.SuspendLayout();
            // 
            // ModifyProductLabel
            // 
            this.ModifyProductLabel.AutoSize = true;
            this.ModifyProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ModifyProductLabel.Location = new System.Drawing.Point(12, 9);
            this.ModifyProductLabel.Name = "ModifyProductLabel";
            this.ModifyProductLabel.Size = new System.Drawing.Size(114, 20);
            this.ModifyProductLabel.TabIndex = 1;
            this.ModifyProductLabel.Text = "Modify Product";
            // 
            // ModifySearchParts
            // 
            this.ModifySearchParts.Location = new System.Drawing.Point(735, 58);
            this.ModifySearchParts.Name = "ModifySearchParts";
            this.ModifySearchParts.Size = new System.Drawing.Size(75, 23);
            this.ModifySearchParts.TabIndex = 28;
            this.ModifySearchParts.Text = "Search";
            this.ModifySearchParts.UseVisualStyleBackColor = true;
            this.ModifySearchParts.Click += new System.EventHandler(this.ModifySearchParts_Click);
            // 
            // ModifyPartsLabel
            // 
            this.ModifyPartsLabel.AutoSize = true;
            this.ModifyPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ModifyPartsLabel.Location = new System.Drawing.Point(342, 63);
            this.ModifyPartsLabel.Name = "ModifyPartsLabel";
            this.ModifyPartsLabel.Size = new System.Drawing.Size(41, 17);
            this.ModifyPartsLabel.TabIndex = 7;
            this.ModifyPartsLabel.Text = "Parts";
            // 
            // DGV_ModifyProductParts
            // 
            this.DGV_ModifyProductParts.AllowUserToAddRows = false;
            this.DGV_ModifyProductParts.AllowUserToDeleteRows = false;
            this.DGV_ModifyProductParts.AllowUserToResizeColumns = false;
            this.DGV_ModifyProductParts.AllowUserToResizeRows = false;
            this.DGV_ModifyProductParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_ModifyProductParts.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_ModifyProductParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ModifyProductParts.Location = new System.Drawing.Point(350, 83);
            this.DGV_ModifyProductParts.MultiSelect = false;
            this.DGV_ModifyProductParts.Name = "DGV_ModifyProductParts";
            this.DGV_ModifyProductParts.ReadOnly = true;
            this.DGV_ModifyProductParts.RowHeadersVisible = false;
            this.DGV_ModifyProductParts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_ModifyProductParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ModifyProductParts.Size = new System.Drawing.Size(622, 150);
            this.DGV_ModifyProductParts.TabIndex = 8;
            this.DGV_ModifyProductParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ModifyProductsPartsDataBindingComplete);
            // 
            // AddRequiredParts
            // 
            this.AddRequiredParts.Location = new System.Drawing.Point(897, 351);
            this.AddRequiredParts.Name = "AddRequiredParts";
            this.AddRequiredParts.Size = new System.Drawing.Size(75, 23);
            this.AddRequiredParts.TabIndex = 9;
            this.AddRequiredParts.TabStop = false;
            this.AddRequiredParts.Text = "Add Part";
            this.AddRequiredParts.UseVisualStyleBackColor = true;
            this.AddRequiredParts.Click += new System.EventHandler(this.ModifyAddParts_Click);
            // 
            // ModifyProductsFormLableProductsParts
            // 
            this.ModifyProductsFormLableProductsParts.AutoSize = true;
            this.ModifyProductsFormLableProductsParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ModifyProductsFormLableProductsParts.Location = new System.Drawing.Point(342, 351);
            this.ModifyProductsFormLableProductsParts.Name = "ModifyProductsFormLableProductsParts";
            this.ModifyProductsFormLableProductsParts.Size = new System.Drawing.Size(175, 17);
            this.ModifyProductsFormLableProductsParts.TabIndex = 10;
            this.ModifyProductsFormLableProductsParts.Text = "Parts Required by Product";
            // 
            // DGV_ModifyProductRequired
            // 
            this.DGV_ModifyProductRequired.AllowUserToAddRows = false;
            this.DGV_ModifyProductRequired.AllowUserToDeleteRows = false;
            this.DGV_ModifyProductRequired.AllowUserToResizeColumns = false;
            this.DGV_ModifyProductRequired.AllowUserToResizeRows = false;
            this.DGV_ModifyProductRequired.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_ModifyProductRequired.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_ModifyProductRequired.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ModifyProductRequired.Location = new System.Drawing.Point(345, 380);
            this.DGV_ModifyProductRequired.MultiSelect = false;
            this.DGV_ModifyProductRequired.Name = "DGV_ModifyProductRequired";
            this.DGV_ModifyProductRequired.ReadOnly = true;
            this.DGV_ModifyProductRequired.RowHeadersVisible = false;
            this.DGV_ModifyProductRequired.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ModifyProductRequired.Size = new System.Drawing.Size(622, 150);
            this.DGV_ModifyProductRequired.TabIndex = 11;
            this.DGV_ModifyProductRequired.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ModifyProductsRequiredDataBindinComplete);
            // 
            // ModifyProductSave
            // 
            this.ModifyProductSave.Location = new System.Drawing.Point(730, 546);
            this.ModifyProductSave.Name = "ModifyProductSave";
            this.ModifyProductSave.Size = new System.Drawing.Size(75, 23);
            this.ModifyProductSave.TabIndex = 7;
            this.ModifyProductSave.Text = "Save";
            this.ModifyProductSave.UseVisualStyleBackColor = true;
            this.ModifyProductSave.Click += new System.EventHandler(this.ModifyProductSave_Click);
            // 
            // ModifyProductCancel
            // 
            this.ModifyProductCancel.Location = new System.Drawing.Point(892, 546);
            this.ModifyProductCancel.Name = "ModifyProductCancel";
            this.ModifyProductCancel.Size = new System.Drawing.Size(75, 23);
            this.ModifyProductCancel.TabIndex = 13;
            this.ModifyProductCancel.TabStop = false;
            this.ModifyProductCancel.Text = "Cancel";
            this.ModifyProductCancel.UseVisualStyleBackColor = true;
            this.ModifyProductCancel.Click += new System.EventHandler(this.ModifyProductCancel_Click);
            // 
            // ModifyIdLabel
            // 
            this.ModifyIdLabel.AutoSize = true;
            this.ModifyIdLabel.Location = new System.Drawing.Point(57, 180);
            this.ModifyIdLabel.Name = "ModifyIdLabel";
            this.ModifyIdLabel.Size = new System.Drawing.Size(18, 13);
            this.ModifyIdLabel.TabIndex = 15;
            this.ModifyIdLabel.Text = "ID";
            // 
            // ModifyNameLabel
            // 
            this.ModifyNameLabel.AutoSize = true;
            this.ModifyNameLabel.Location = new System.Drawing.Point(40, 206);
            this.ModifyNameLabel.Name = "ModifyNameLabel";
            this.ModifyNameLabel.Size = new System.Drawing.Size(35, 13);
            this.ModifyNameLabel.TabIndex = 16;
            this.ModifyNameLabel.Text = "Name";
            // 
            // ModifyInventoryLabel
            // 
            this.ModifyInventoryLabel.AutoSize = true;
            this.ModifyInventoryLabel.Location = new System.Drawing.Point(24, 232);
            this.ModifyInventoryLabel.Name = "ModifyInventoryLabel";
            this.ModifyInventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.ModifyInventoryLabel.TabIndex = 17;
            this.ModifyInventoryLabel.Text = "Inventory";
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Location = new System.Drawing.Point(48, 288);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(27, 13);
            this.MaxLabel.TabIndex = 18;
            this.MaxLabel.Text = "Max";
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Location = new System.Drawing.Point(187, 284);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(24, 13);
            this.MinLabel.TabIndex = 19;
            this.MinLabel.Text = "Min";
            // 
            // ModifyProductsLabelAddRequireParts
            // 
            this.ModifyProductsLabelAddRequireParts.AutoSize = true;
            this.ModifyProductsLabelAddRequireParts.Location = new System.Drawing.Point(789, 356);
            this.ModifyProductsLabelAddRequireParts.Name = "ModifyProductsLabelAddRequireParts";
            this.ModifyProductsLabelAddRequireParts.Size = new System.Drawing.Size(97, 13);
            this.ModifyProductsLabelAddRequireParts.TabIndex = 20;
            this.ModifyProductsLabelAddRequireParts.Text = "Add  Required Part";
            // 
            // ModifyRequiredDelete
            // 
            this.ModifyRequiredDelete.Location = new System.Drawing.Point(811, 546);
            this.ModifyRequiredDelete.Name = "ModifyRequiredDelete";
            this.ModifyRequiredDelete.Size = new System.Drawing.Size(75, 23);
            this.ModifyRequiredDelete.TabIndex = 21;
            this.ModifyRequiredDelete.TabStop = false;
            this.ModifyRequiredDelete.Text = "Delete";
            this.ModifyRequiredDelete.UseVisualStyleBackColor = true;
            this.ModifyRequiredDelete.Click += new System.EventHandler(this.ModifyRequiredDelete_Click);
            // 
            // IdTB
            // 
            this.IdTB.BackColor = System.Drawing.Color.LightGray;
            this.IdTB.Location = new System.Drawing.Point(81, 177);
            this.IdTB.Name = "IdTB";
            this.IdTB.ReadOnly = true;
            this.IdTB.Size = new System.Drawing.Size(100, 20);
            this.IdTB.TabIndex = 22;
            this.IdTB.TabStop = false;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(81, 203);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(100, 20);
            this.NameTB.TabIndex = 1;
            // 
            // InventoryTB
            // 
            this.InventoryTB.Location = new System.Drawing.Point(81, 229);
            this.InventoryTB.Name = "InventoryTB";
            this.InventoryTB.Size = new System.Drawing.Size(100, 20);
            this.InventoryTB.TabIndex = 2;
            // 
            // MaxTB
            // 
            this.MaxTB.Location = new System.Drawing.Point(81, 281);
            this.MaxTB.Name = "MaxTB";
            this.MaxTB.Size = new System.Drawing.Size(100, 20);
            this.MaxTB.TabIndex = 5;
            // 
            // MinTB
            // 
            this.MinTB.Location = new System.Drawing.Point(217, 281);
            this.MinTB.Name = "MinTB";
            this.MinTB.Size = new System.Drawing.Size(100, 20);
            this.MinTB.TabIndex = 6;
            // 
            // ModifySearchPartsTB
            // 
            this.ModifySearchPartsTB.Location = new System.Drawing.Point(816, 60);
            this.ModifySearchPartsTB.Name = "ModifySearchPartsTB";
            this.ModifySearchPartsTB.Size = new System.Drawing.Size(156, 20);
            this.ModifySearchPartsTB.TabIndex = 27;
            this.ModifySearchPartsTB.TabStop = false;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(40, 258);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(31, 13);
            this.PriceLabel.TabIndex = 28;
            this.PriceLabel.Text = "Price";
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(81, 255);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(100, 20);
            this.PriceTB.TabIndex = 3;
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 581);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ModifySearchPartsTB);
            this.Controls.Add(this.MinTB);
            this.Controls.Add(this.MaxTB);
            this.Controls.Add(this.InventoryTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.IdTB);
            this.Controls.Add(this.ModifyRequiredDelete);
            this.Controls.Add(this.ModifyProductsLabelAddRequireParts);
            this.Controls.Add(this.MinLabel);
            this.Controls.Add(this.MaxLabel);
            this.Controls.Add(this.ModifyInventoryLabel);
            this.Controls.Add(this.ModifyNameLabel);
            this.Controls.Add(this.ModifyIdLabel);
            this.Controls.Add(this.ModifyProductCancel);
            this.Controls.Add(this.ModifyProductSave);
            this.Controls.Add(this.DGV_ModifyProductRequired);
            this.Controls.Add(this.ModifyProductsFormLableProductsParts);
            this.Controls.Add(this.AddRequiredParts);
            this.Controls.Add(this.DGV_ModifyProductParts);
            this.Controls.Add(this.ModifyPartsLabel);
            this.Controls.Add(this.ModifySearchParts);
            this.Controls.Add(this.ModifyProductLabel);
            this.Name = "ModifyProduct";
            this.Text = "Modify Products Screen";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ModifyProductParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ModifyProductRequired)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ModifyProductLabel;
        private System.Windows.Forms.Button ModifySearchParts;
        private System.Windows.Forms.Label ModifyPartsLabel;
        private System.Windows.Forms.DataGridView DGV_ModifyProductParts;
        private System.Windows.Forms.Button AddRequiredParts;
        private System.Windows.Forms.Label ModifyProductsFormLableProductsParts;
        private System.Windows.Forms.DataGridView DGV_ModifyProductRequired;
        private System.Windows.Forms.Button ModifyProductSave;
        private System.Windows.Forms.Button ModifyProductCancel;
        private System.Windows.Forms.Label ModifyIdLabel;
        private System.Windows.Forms.Label ModifyNameLabel;
        private System.Windows.Forms.Label ModifyInventoryLabel;
        private System.Windows.Forms.Label MaxLabel;
        private System.Windows.Forms.Label MinLabel;
        private System.Windows.Forms.Label ModifyProductsLabelAddRequireParts;
        private System.Windows.Forms.Button ModifyRequiredDelete;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox InventoryTB;
        private System.Windows.Forms.TextBox MaxTB;
        private System.Windows.Forms.TextBox MinTB;
        private System.Windows.Forms.TextBox ModifySearchPartsTB;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox PriceTB;
    }
}