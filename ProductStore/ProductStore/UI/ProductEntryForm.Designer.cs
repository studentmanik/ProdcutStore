namespace ProductStore
{
    partial class ProductEntryForm
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
            this.productCodeTextBox = new System.Windows.Forms.TextBox();
            this.productDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.productQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.productSaveButton = new System.Windows.Forms.Button();
            this.productShowListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // productCodeTextBox
            // 
            this.productCodeTextBox.Location = new System.Drawing.Point(255, 14);
            this.productCodeTextBox.Name = "productCodeTextBox";
            this.productCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.productCodeTextBox.TabIndex = 0;
            // 
            // productDescriptionTextBox
            // 
            this.productDescriptionTextBox.Location = new System.Drawing.Point(255, 53);
            this.productDescriptionTextBox.Name = "productDescriptionTextBox";
            this.productDescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.productDescriptionTextBox.TabIndex = 0;
            // 
            // productQuantityTextBox
            // 
            this.productQuantityTextBox.Location = new System.Drawing.Point(255, 92);
            this.productQuantityTextBox.Name = "productQuantityTextBox";
            this.productQuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.productQuantityTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Product Quantity";
            // 
            // productSaveButton
            // 
            this.productSaveButton.Location = new System.Drawing.Point(280, 118);
            this.productSaveButton.Name = "productSaveButton";
            this.productSaveButton.Size = new System.Drawing.Size(75, 23);
            this.productSaveButton.TabIndex = 2;
            this.productSaveButton.Text = "Save";
            this.productSaveButton.UseVisualStyleBackColor = true;
            this.productSaveButton.Click += new System.EventHandler(this.productSaveButton_Click);
            // 
            // productShowListView
            // 
            this.productShowListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.productShowListView.Location = new System.Drawing.Point(28, 162);
            this.productShowListView.Name = "productShowListView";
            this.productShowListView.Size = new System.Drawing.Size(466, 195);
            this.productShowListView.TabIndex = 3;
            this.productShowListView.UseCompatibleStateImageBehavior = false;
            this.productShowListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product Code";
            this.columnHeader2.Width = 89;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Product Description";
            this.columnHeader3.Width = 124;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quantity";
            // 
            // ProductEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 415);
            this.Controls.Add(this.productShowListView);
            this.Controls.Add(this.productSaveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productQuantityTextBox);
            this.Controls.Add(this.productDescriptionTextBox);
            this.Controls.Add(this.productCodeTextBox);
            this.Name = "ProductEntryForm";
            this.Text = "Product Entry Form";
            this.Load += new System.EventHandler(this.ProductEntryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productCodeTextBox;
        private System.Windows.Forms.TextBox productDescriptionTextBox;
        private System.Windows.Forms.TextBox productQuantityTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button productSaveButton;
        private System.Windows.Forms.ListView productShowListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

