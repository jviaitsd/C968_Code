
namespace C968_PerformanceAssessment
{
    partial class AddProductForm
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
            this.AddProductScreenLabel = new System.Windows.Forms.Label();
            this.AddPartsLabel = new System.Windows.Forms.Label();
            this.AddRequiredLablel = new System.Windows.Forms.Label();
            this.DGV_AddProductParts = new System.Windows.Forms.DataGridView();
            this.DGV_AddProductRequired = new System.Windows.Forms.DataGridView();
            this.SearchParts = new System.Windows.Forms.Button();
            this.AddParts = new System.Windows.Forms.Button();
            this.AddProductSave = new System.Windows.Forms.Button();
            this.AddProductsCancel = new System.Windows.Forms.Button();
            this.IdLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.InventoryLabel = new System.Windows.Forms.Label();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.MinLabel = new System.Windows.Forms.Label();
            this.RequiedAddLabel = new System.Windows.Forms.Label();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.InventoryTB = new System.Windows.Forms.TextBox();
            this.MaxTB = new System.Windows.Forms.TextBox();
            this.MinTB = new System.Windows.Forms.TextBox();
            this.SearchPartsTB = new System.Windows.Forms.TextBox();
            this.AddRequiedDelete = new System.Windows.Forms.Button();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PriceTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AddProductParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AddProductRequired)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProductScreenLabel
            // 
            this.AddProductScreenLabel.AutoSize = true;
            this.AddProductScreenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddProductScreenLabel.Location = new System.Drawing.Point(12, 9);
            this.AddProductScreenLabel.Name = "AddProductScreenLabel";
            this.AddProductScreenLabel.Size = new System.Drawing.Size(97, 20);
            this.AddProductScreenLabel.TabIndex = 0;
            this.AddProductScreenLabel.Text = "Add Product";
            // 
            // AddPartsLabel
            // 
            this.AddPartsLabel.AutoSize = true;
            this.AddPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddPartsLabel.Location = new System.Drawing.Point(342, 57);
            this.AddPartsLabel.Name = "AddPartsLabel";
            this.AddPartsLabel.Size = new System.Drawing.Size(41, 17);
            this.AddPartsLabel.TabIndex = 1;
            this.AddPartsLabel.Text = "Parts";
            // 
            // AddRequiredLablel
            // 
            this.AddRequiredLablel.AutoSize = true;
            this.AddRequiredLablel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddRequiredLablel.Location = new System.Drawing.Point(342, 351);
            this.AddRequiredLablel.Name = "AddRequiredLablel";
            this.AddRequiredLablel.Size = new System.Drawing.Size(177, 17);
            this.AddRequiredLablel.TabIndex = 2;
            this.AddRequiredLablel.Text = "Parts Required for Product";
            // 
            // DGV_AddProductParts
            // 
            this.DGV_AddProductParts.AllowUserToAddRows = false;
            this.DGV_AddProductParts.AllowUserToResizeColumns = false;
            this.DGV_AddProductParts.AllowUserToResizeRows = false;
            this.DGV_AddProductParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_AddProductParts.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_AddProductParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_AddProductParts.Location = new System.Drawing.Point(345, 80);
            this.DGV_AddProductParts.MultiSelect = false;
            this.DGV_AddProductParts.Name = "DGV_AddProductParts";
            this.DGV_AddProductParts.ReadOnly = true;
            this.DGV_AddProductParts.RowHeadersVisible = false;
            this.DGV_AddProductParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_AddProductParts.Size = new System.Drawing.Size(622, 150);
            this.DGV_AddProductParts.TabIndex = 33;
            this.DGV_AddProductParts.TabStop = false;
            this.DGV_AddProductParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.AddProductPartsDataBindingComplete);
            // 
            // DGV_AddProductRequired
            // 
            this.DGV_AddProductRequired.AllowUserToAddRows = false;
            this.DGV_AddProductRequired.AllowUserToDeleteRows = false;
            this.DGV_AddProductRequired.AllowUserToResizeColumns = false;
            this.DGV_AddProductRequired.AllowUserToResizeRows = false;
            this.DGV_AddProductRequired.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_AddProductRequired.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_AddProductRequired.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_AddProductRequired.Location = new System.Drawing.Point(345, 380);
            this.DGV_AddProductRequired.MultiSelect = false;
            this.DGV_AddProductRequired.Name = "DGV_AddProductRequired";
            this.DGV_AddProductRequired.ReadOnly = true;
            this.DGV_AddProductRequired.RowHeadersVisible = false;
            this.DGV_AddProductRequired.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_AddProductRequired.Size = new System.Drawing.Size(622, 150);
            this.DGV_AddProductRequired.TabIndex = 44;
            this.DGV_AddProductRequired.TabStop = false;
            this.DGV_AddProductRequired.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.AddProductRequiredDataBindingComplete);
            // 
            // SearchParts
            // 
            this.SearchParts.Location = new System.Drawing.Point(738, 51);
            this.SearchParts.Name = "SearchParts";
            this.SearchParts.Size = new System.Drawing.Size(75, 23);
            this.SearchParts.TabIndex = 28;
            this.SearchParts.Text = "Search";
            this.SearchParts.UseVisualStyleBackColor = true;
            this.SearchParts.Click += new System.EventHandler(this.SearchParts_Click);
            // 
            // AddParts
            // 
            this.AddParts.Location = new System.Drawing.Point(897, 351);
            this.AddParts.Name = "AddParts";
            this.AddParts.Size = new System.Drawing.Size(75, 23);
            this.AddParts.TabIndex = 20;
            this.AddParts.TabStop = false;
            this.AddParts.Text = "Add Part";
            this.AddParts.UseVisualStyleBackColor = true;
            this.AddParts.Click += new System.EventHandler(this.AddParts_Click);
            // 
            // AddProductSave
            // 
            this.AddProductSave.Location = new System.Drawing.Point(738, 546);
            this.AddProductSave.Name = "AddProductSave";
            this.AddProductSave.Size = new System.Drawing.Size(75, 23);
            this.AddProductSave.TabIndex = 6;
            this.AddProductSave.Text = "Save";
            this.AddProductSave.UseVisualStyleBackColor = true;
            this.AddProductSave.Click += new System.EventHandler(this.AddProductSave_Click);
            // 
            // AddProductsCancel
            // 
            this.AddProductsCancel.Location = new System.Drawing.Point(900, 546);
            this.AddProductsCancel.Name = "AddProductsCancel";
            this.AddProductsCancel.Size = new System.Drawing.Size(75, 23);
            this.AddProductsCancel.TabIndex = 18;
            this.AddProductsCancel.TabStop = false;
            this.AddProductsCancel.Text = "Cancel";
            this.AddProductsCancel.UseVisualStyleBackColor = true;
            this.AddProductsCancel.Click += new System.EventHandler(this.AddProductCancel_Click);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(57, 183);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(18, 13);
            this.IdLabel.TabIndex = 10;
            this.IdLabel.Text = "ID";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(40, 210);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 11;
            this.NameLabel.Text = "Name";
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.AutoSize = true;
            this.InventoryLabel.Location = new System.Drawing.Point(24, 235);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.InventoryLabel.TabIndex = 12;
            this.InventoryLabel.Text = "Inventory";
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Location = new System.Drawing.Point(48, 288);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(27, 13);
            this.MaxLabel.TabIndex = 13;
            this.MaxLabel.Text = "Max";
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Location = new System.Drawing.Point(187, 288);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(24, 13);
            this.MinLabel.TabIndex = 14;
            this.MinLabel.Text = "Min";
            // 
            // RequiedAddLabel
            // 
            this.RequiedAddLabel.AutoSize = true;
            this.RequiedAddLabel.Location = new System.Drawing.Point(792, 356);
            this.RequiedAddLabel.Name = "RequiedAddLabel";
            this.RequiedAddLabel.Size = new System.Drawing.Size(94, 13);
            this.RequiedAddLabel.TabIndex = 21;
            this.RequiedAddLabel.Text = "Add Required Part";
            // 
            // IdTB
            // 
            this.IdTB.BackColor = System.Drawing.Color.LightGray;
            this.IdTB.ForeColor = System.Drawing.SystemColors.InfoText;
            this.IdTB.Location = new System.Drawing.Point(81, 180);
            this.IdTB.Name = "IdTB";
            this.IdTB.ReadOnly = true;
            this.IdTB.Size = new System.Drawing.Size(100, 20);
            this.IdTB.TabIndex = 22;
            this.IdTB.TabStop = false;
            this.IdTB.Text = "Auto Asssigned";
            this.IdTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.InventoryTB.Location = new System.Drawing.Point(81, 232);
            this.InventoryTB.Name = "InventoryTB";
            this.InventoryTB.Size = new System.Drawing.Size(100, 20);
            this.InventoryTB.TabIndex = 2;
            // 
            // MaxTB
            // 
            this.MaxTB.Location = new System.Drawing.Point(81, 284);
            this.MaxTB.Name = "MaxTB";
            this.MaxTB.Size = new System.Drawing.Size(100, 20);
            this.MaxTB.TabIndex = 4;
            // 
            // MinTB
            // 
            this.MinTB.Location = new System.Drawing.Point(217, 285);
            this.MinTB.Name = "MinTB";
            this.MinTB.Size = new System.Drawing.Size(100, 20);
            this.MinTB.TabIndex = 5;
            // 
            // SearchPartsTB
            // 
            this.SearchPartsTB.Location = new System.Drawing.Point(819, 54);
            this.SearchPartsTB.Name = "SearchPartsTB";
            this.SearchPartsTB.Size = new System.Drawing.Size(153, 20);
            this.SearchPartsTB.TabIndex = 27;
            this.SearchPartsTB.TabStop = false;
            // 
            // AddRequiedDelete
            // 
            this.AddRequiedDelete.Location = new System.Drawing.Point(819, 546);
            this.AddRequiedDelete.Name = "AddRequiedDelete";
            this.AddRequiedDelete.Size = new System.Drawing.Size(75, 23);
            this.AddRequiedDelete.TabIndex = 28;
            this.AddRequiedDelete.TabStop = false;
            this.AddRequiedDelete.Text = "Delete";
            this.AddRequiedDelete.UseVisualStyleBackColor = true;
            this.AddRequiedDelete.Click += new System.EventHandler(this.AddRequiredDelete_Click);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(40, 261);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(31, 13);
            this.PriceLabel.TabIndex = 29;
            this.PriceLabel.Text = "Price";
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(81, 258);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(100, 20);
            this.PriceTB.TabIndex = 3;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 581);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.AddRequiedDelete);
            this.Controls.Add(this.SearchPartsTB);
            this.Controls.Add(this.MinTB);
            this.Controls.Add(this.MaxTB);
            this.Controls.Add(this.InventoryTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.IdTB);
            this.Controls.Add(this.RequiedAddLabel);
            this.Controls.Add(this.MinLabel);
            this.Controls.Add(this.MaxLabel);
            this.Controls.Add(this.InventoryLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.AddProductsCancel);
            this.Controls.Add(this.AddProductSave);
            this.Controls.Add(this.AddParts);
            this.Controls.Add(this.SearchParts);
            this.Controls.Add(this.DGV_AddProductRequired);
            this.Controls.Add(this.DGV_AddProductParts);
            this.Controls.Add(this.AddRequiredLablel);
            this.Controls.Add(this.AddPartsLabel);
            this.Controls.Add(this.AddProductScreenLabel);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "AddProductForm";
            this.Text = "Add Products Screen";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AddProductParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AddProductRequired)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddProductScreenLabel;
        private System.Windows.Forms.Label AddPartsLabel;
        private System.Windows.Forms.Label AddRequiredLablel;
        private System.Windows.Forms.DataGridView DGV_AddProductParts;
        private System.Windows.Forms.DataGridView DGV_AddProductRequired;
        private System.Windows.Forms.Button SearchParts;
        private System.Windows.Forms.Button AddParts;
        private System.Windows.Forms.Button AddProductSave;
        private System.Windows.Forms.Button AddProductsCancel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label InventoryLabel;
        private System.Windows.Forms.Label MaxLabel;
        private System.Windows.Forms.Label MinLabel;
        private System.Windows.Forms.Label RequiedAddLabel;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox InventoryTB;
        private System.Windows.Forms.TextBox MaxTB;
        private System.Windows.Forms.TextBox MinTB;
        private System.Windows.Forms.TextBox SearchPartsTB;
        private System.Windows.Forms.Button AddRequiedDelete;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox PriceTB;
    }
}