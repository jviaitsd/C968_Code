
namespace C968_PerformanceAssessment
{
    partial class MainScreenForm
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
            this.DGV_Products = new System.Windows.Forms.DataGridView();
            this.SearchProducts = new System.Windows.Forms.Button();
            this.AddProducts = new System.Windows.Forms.Button();
            this.ModifyProducts = new System.Windows.Forms.Button();
            this.DeleteProducts = new System.Windows.Forms.Button();
            this.ExitMainScreen = new System.Windows.Forms.Button();
            this.SearchParts = new System.Windows.Forms.Button();
            this.AddParts = new System.Windows.Forms.Button();
            this.ModifyParts = new System.Windows.Forms.Button();
            this.DeleteParts = new System.Windows.Forms.Button();
            this.MainScreenLabel = new System.Windows.Forms.Label();
            this.PartsLabel = new System.Windows.Forms.Label();
            this.ProductsLabel = new System.Windows.Forms.Label();
            this.DGV_Parts = new System.Windows.Forms.DataGridView();
            this.SearchPartsTB = new System.Windows.Forms.TextBox();
            this.SearchProductsTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Parts)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Products
            // 
            this.DGV_Products.AllowUserToAddRows = false;
            this.DGV_Products.AllowUserToDeleteRows = false;
            this.DGV_Products.AllowUserToResizeColumns = false;
            this.DGV_Products.AllowUserToResizeRows = false;
            this.DGV_Products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Products.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Products.Location = new System.Drawing.Point(700, 85);
            this.DGV_Products.MultiSelect = false;
            this.DGV_Products.Name = "DGV_Products";
            this.DGV_Products.ReadOnly = true;
            this.DGV_Products.RowHeadersVisible = false;
            this.DGV_Products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Products.Size = new System.Drawing.Size(604, 408);
            this.DGV_Products.TabIndex = 1;
            this.DGV_Products.TabStop = false;
            this.DGV_Products.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ProductsDataBindingComplete);
            // 
            // SearchProducts
            // 
            this.SearchProducts.Location = new System.Drawing.Point(1066, 50);
            this.SearchProducts.Name = "SearchProducts";
            this.SearchProducts.Size = new System.Drawing.Size(75, 23);
            this.SearchProducts.TabIndex = 16;
            this.SearchProducts.Text = "Search";
            this.SearchProducts.UseVisualStyleBackColor = true;
            this.SearchProducts.Click += new System.EventHandler(this.SearchProducts_Click);
            // 
            // AddProducts
            // 
            this.AddProducts.Location = new System.Drawing.Point(1066, 499);
            this.AddProducts.Name = "AddProducts";
            this.AddProducts.Size = new System.Drawing.Size(75, 23);
            this.AddProducts.TabIndex = 3;
            this.AddProducts.Text = "Add";
            this.AddProducts.UseVisualStyleBackColor = true;
            this.AddProducts.Click += new System.EventHandler(this.AddProducts_Click);
            // 
            // ModifyProducts
            // 
            this.ModifyProducts.Location = new System.Drawing.Point(1147, 499);
            this.ModifyProducts.Name = "ModifyProducts";
            this.ModifyProducts.Size = new System.Drawing.Size(75, 23);
            this.ModifyProducts.TabIndex = 4;
            this.ModifyProducts.Text = "Modify";
            this.ModifyProducts.UseVisualStyleBackColor = true;
            this.ModifyProducts.Click += new System.EventHandler(this.ModifyProducts_Click);
            // 
            // DeleteProducts
            // 
            this.DeleteProducts.Location = new System.Drawing.Point(1226, 499);
            this.DeleteProducts.Name = "DeleteProducts";
            this.DeleteProducts.Size = new System.Drawing.Size(75, 23);
            this.DeleteProducts.TabIndex = 5;
            this.DeleteProducts.Text = "Delete";
            this.DeleteProducts.UseVisualStyleBackColor = true;
            this.DeleteProducts.Click += new System.EventHandler(this.DeleteProducts_Click);
            // 
            // ExitMainScreen
            // 
            this.ExitMainScreen.BackColor = System.Drawing.SystemColors.Control;
            this.ExitMainScreen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExitMainScreen.Location = new System.Drawing.Point(16, 584);
            this.ExitMainScreen.Name = "ExitMainScreen";
            this.ExitMainScreen.Size = new System.Drawing.Size(75, 23);
            this.ExitMainScreen.TabIndex = 6;
            this.ExitMainScreen.Text = "Exit";
            this.ExitMainScreen.UseVisualStyleBackColor = false;
            this.ExitMainScreen.Click += new System.EventHandler(this.ExitMainScreen_Click);
            // 
            // SearchParts
            // 
            this.SearchParts.Location = new System.Drawing.Point(383, 51);
            this.SearchParts.Name = "SearchParts";
            this.SearchParts.Size = new System.Drawing.Size(75, 23);
            this.SearchParts.TabIndex = 9;
            this.SearchParts.Text = "Search";
            this.SearchParts.UseVisualStyleBackColor = true;
            this.SearchParts.Click += new System.EventHandler(this.SearchParts_Click);
            // 
            // AddParts
            // 
            this.AddParts.Location = new System.Drawing.Point(383, 499);
            this.AddParts.Name = "AddParts";
            this.AddParts.Size = new System.Drawing.Size(75, 23);
            this.AddParts.TabIndex = 88;
            this.AddParts.Text = "Add";
            this.AddParts.UseVisualStyleBackColor = true;
            this.AddParts.Click += new System.EventHandler(this.AddParts_Click);
            // 
            // ModifyParts
            // 
            this.ModifyParts.Location = new System.Drawing.Point(464, 499);
            this.ModifyParts.Name = "ModifyParts";
            this.ModifyParts.Size = new System.Drawing.Size(75, 23);
            this.ModifyParts.TabIndex = 99;
            this.ModifyParts.Text = "Modify";
            this.ModifyParts.UseVisualStyleBackColor = true;
            this.ModifyParts.Click += new System.EventHandler(this.ModifyParts_Click);
            // 
            // DeleteParts
            // 
            this.DeleteParts.Location = new System.Drawing.Point(545, 499);
            this.DeleteParts.Name = "DeleteParts";
            this.DeleteParts.Size = new System.Drawing.Size(75, 23);
            this.DeleteParts.TabIndex = 10;
            this.DeleteParts.Text = "Delete";
            this.DeleteParts.UseVisualStyleBackColor = true;
            this.DeleteParts.Click += new System.EventHandler(this.DeleteParts_Click);
            // 
            // MainScreenLabel
            // 
            this.MainScreenLabel.AutoSize = true;
            this.MainScreenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MainScreenLabel.Location = new System.Drawing.Point(12, 9);
            this.MainScreenLabel.Name = "MainScreenLabel";
            this.MainScreenLabel.Size = new System.Drawing.Size(229, 20);
            this.MainScreenLabel.TabIndex = 11;
            this.MainScreenLabel.Text = "Inventory Management System";
            // 
            // PartsLabel
            // 
            this.PartsLabel.AutoSize = true;
            this.PartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PartsLabel.Location = new System.Drawing.Point(13, 52);
            this.PartsLabel.Name = "PartsLabel";
            this.PartsLabel.Size = new System.Drawing.Size(41, 17);
            this.PartsLabel.TabIndex = 12;
            this.PartsLabel.Text = "Parts";
            // 
            // ProductsLabel
            // 
            this.ProductsLabel.AutoSize = true;
            this.ProductsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ProductsLabel.Location = new System.Drawing.Point(697, 56);
            this.ProductsLabel.Name = "ProductsLabel";
            this.ProductsLabel.Size = new System.Drawing.Size(64, 17);
            this.ProductsLabel.TabIndex = 13;
            this.ProductsLabel.Text = "Products";
            // 
            // DGV_Parts
            // 
            this.DGV_Parts.AllowUserToAddRows = false;
            this.DGV_Parts.AllowUserToDeleteRows = false;
            this.DGV_Parts.AllowUserToResizeColumns = false;
            this.DGV_Parts.AllowUserToResizeRows = false;
            this.DGV_Parts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Parts.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV_Parts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Parts.Location = new System.Drawing.Point(16, 79);
            this.DGV_Parts.MultiSelect = false;
            this.DGV_Parts.Name = "DGV_Parts";
            this.DGV_Parts.ReadOnly = true;
            this.DGV_Parts.RowHeadersVisible = false;
            this.DGV_Parts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Parts.Size = new System.Drawing.Size(604, 408);
            this.DGV_Parts.TabIndex = 0;
            this.DGV_Parts.TabStop = false;
            this.DGV_Parts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.PartsDataBindingComplete);
            // 
            // SearchPartsTB
            // 
            this.SearchPartsTB.Location = new System.Drawing.Point(464, 53);
            this.SearchPartsTB.Name = "SearchPartsTB";
            this.SearchPartsTB.Size = new System.Drawing.Size(156, 20);
            this.SearchPartsTB.TabIndex = 8;
            this.SearchPartsTB.TabStop = false;
            // 
            // SearchProductsTB
            // 
            this.SearchProductsTB.Location = new System.Drawing.Point(1147, 52);
            this.SearchProductsTB.Name = "SearchProductsTB";
            this.SearchProductsTB.Size = new System.Drawing.Size(154, 20);
            this.SearchProductsTB.TabIndex = 15;
            this.SearchProductsTB.TabStop = false;
            // 
            // MainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 619);
            this.Controls.Add(this.SearchProductsTB);
            this.Controls.Add(this.SearchPartsTB);
            this.Controls.Add(this.ProductsLabel);
            this.Controls.Add(this.PartsLabel);
            this.Controls.Add(this.MainScreenLabel);
            this.Controls.Add(this.DeleteParts);
            this.Controls.Add(this.ModifyParts);
            this.Controls.Add(this.AddParts);
            this.Controls.Add(this.SearchParts);
            this.Controls.Add(this.ExitMainScreen);
            this.Controls.Add(this.DeleteProducts);
            this.Controls.Add(this.ModifyProducts);
            this.Controls.Add(this.AddProducts);
            this.Controls.Add(this.SearchProducts);
            this.Controls.Add(this.DGV_Products);
            this.Controls.Add(this.DGV_Parts);
            this.Name = "MainScreenForm";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Parts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_Products;
        private System.Windows.Forms.Button SearchProducts;
        private System.Windows.Forms.Button AddProducts;
        private System.Windows.Forms.Button ModifyProducts;
        private System.Windows.Forms.Button DeleteProducts;
        private System.Windows.Forms.Button ExitMainScreen;
        private System.Windows.Forms.Button SearchParts;
        private System.Windows.Forms.Button AddParts;
        private System.Windows.Forms.Button ModifyParts;
        private System.Windows.Forms.Button DeleteParts;
        private System.Windows.Forms.Label MainScreenLabel;
        private System.Windows.Forms.Label PartsLabel;
        private System.Windows.Forms.Label ProductsLabel;
        private System.Windows.Forms.DataGridView DGV_Parts;
        private System.Windows.Forms.TextBox SearchPartsTB;
        private System.Windows.Forms.TextBox SearchProductsTB;
    }
}

