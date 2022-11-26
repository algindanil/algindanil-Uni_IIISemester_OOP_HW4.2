namespace HW4._2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 
        
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemsDataSheet = new System.Windows.Forms.DataGridView();
            this.ItemsAddRowButton = new System.Windows.Forms.Button();
            this.ItemsDeleteRowButton = new System.Windows.Forms.Button();
            this.GroceriesDataSheet = new System.Windows.Forms.DataGridView();
            this.BooksDataSheet = new System.Windows.Forms.DataGridView();
            this.GroceriesAddRowButton = new System.Windows.Forms.Button();
            this.GroceriesDeleteRowButton = new System.Windows.Forms.Button();
            this.BooksAddRowButton = new System.Windows.Forms.Button();
            this.BooksDeleteRowButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataSheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroceriesDataSheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataSheet)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemsDataSheet
            // 
            this.ItemsDataSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsDataSheet.Location = new System.Drawing.Point(12, 12);
            this.ItemsDataSheet.Name = "ItemsDataSheet";
            this.ItemsDataSheet.RowHeadersWidth = 51;
            this.ItemsDataSheet.RowTemplate.Height = 29;
            this.ItemsDataSheet.Size = new System.Drawing.Size(540, 139);
            this.ItemsDataSheet.TabIndex = 0;
            // 
            // ItemsAddRowButton
            // 
            this.ItemsAddRowButton.Location = new System.Drawing.Point(576, 56);
            this.ItemsAddRowButton.Name = "ItemsAddRowButton";
            this.ItemsAddRowButton.Size = new System.Drawing.Size(94, 29);
            this.ItemsAddRowButton.TabIndex = 1;
            this.ItemsAddRowButton.Text = "Add Item";
            this.ItemsAddRowButton.UseVisualStyleBackColor = true;
            this.ItemsAddRowButton.Click += new System.EventHandler(this.addRowButton_Click);
            // 
            // ItemsDeleteRowButton
            // 
            this.ItemsDeleteRowButton.Location = new System.Drawing.Point(576, 102);
            this.ItemsDeleteRowButton.Name = "ItemsDeleteRowButton";
            this.ItemsDeleteRowButton.Size = new System.Drawing.Size(94, 29);
            this.ItemsDeleteRowButton.TabIndex = 2;
            this.ItemsDeleteRowButton.Text = "Delete Item";
            this.ItemsDeleteRowButton.UseVisualStyleBackColor = true;
            this.ItemsDeleteRowButton.Click += new System.EventHandler(this.ItemsDeleteRowButton_Click);
            // 
            // GroceriesDataSheet
            // 
            this.GroceriesDataSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroceriesDataSheet.Location = new System.Drawing.Point(12, 168);
            this.GroceriesDataSheet.Name = "GroceriesDataSheet";
            this.GroceriesDataSheet.RowHeadersWidth = 51;
            this.GroceriesDataSheet.RowTemplate.Height = 29;
            this.GroceriesDataSheet.Size = new System.Drawing.Size(540, 139);
            this.GroceriesDataSheet.TabIndex = 3;
            // 
            // BooksDataSheet
            // 
            this.BooksDataSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksDataSheet.Location = new System.Drawing.Point(12, 325);
            this.BooksDataSheet.Name = "BooksDataSheet";
            this.BooksDataSheet.RowHeadersWidth = 51;
            this.BooksDataSheet.RowTemplate.Height = 29;
            this.BooksDataSheet.Size = new System.Drawing.Size(540, 140);
            this.BooksDataSheet.TabIndex = 4;
            //this.BooksDataSheet.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.BooksDataSheet_CellStateChanged);
            // 
            // GroceriesAddRowButton
            // 
            this.GroceriesAddRowButton.Location = new System.Drawing.Point(576, 190);
            this.GroceriesAddRowButton.Name = "GroceriesAddRowButton";
            this.GroceriesAddRowButton.Size = new System.Drawing.Size(171, 29);
            this.GroceriesAddRowButton.TabIndex = 5;
            this.GroceriesAddRowButton.Text = "Add Grocery Item";
            this.GroceriesAddRowButton.UseVisualStyleBackColor = true;
            this.GroceriesAddRowButton.Click += new System.EventHandler(this.GroceriesAddRowButton_Click);
            // 
            // GroceriesDeleteRowButton
            // 
            this.GroceriesDeleteRowButton.Location = new System.Drawing.Point(576, 239);
            this.GroceriesDeleteRowButton.Name = "GroceriesDeleteRowButton";
            this.GroceriesDeleteRowButton.Size = new System.Drawing.Size(94, 29);
            this.GroceriesDeleteRowButton.TabIndex = 6;
            this.GroceriesDeleteRowButton.Text = "Delete";
            this.GroceriesDeleteRowButton.UseVisualStyleBackColor = true;
            this.GroceriesDeleteRowButton.Click += new System.EventHandler(this.GroceriesDeleteRowButton_Click);
            // 
            // BooksAddRowButton
            // 
            this.BooksAddRowButton.Location = new System.Drawing.Point(576, 344);
            this.BooksAddRowButton.Name = "BooksAddRowButton";
            this.BooksAddRowButton.Size = new System.Drawing.Size(94, 29);
            this.BooksAddRowButton.TabIndex = 7;
            this.BooksAddRowButton.Text = "Add Book";
            this.BooksAddRowButton.UseVisualStyleBackColor = true;
            this.BooksAddRowButton.Click += new System.EventHandler(this.BooksAddRowButton_Click);
            // 
            // BooksDeleteRowButton
            // 
            this.BooksDeleteRowButton.Location = new System.Drawing.Point(576, 389);
            this.BooksDeleteRowButton.Name = "BooksDeleteRowButton";
            this.BooksDeleteRowButton.Size = new System.Drawing.Size(94, 29);
            this.BooksDeleteRowButton.TabIndex = 8;
            this.BooksDeleteRowButton.Text = "Delete";
            this.BooksDeleteRowButton.UseVisualStyleBackColor = true;
            this.BooksDeleteRowButton.Click += new System.EventHandler(this.BooksDeleteRowButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 542);
            this.Controls.Add(this.BooksDeleteRowButton);
            this.Controls.Add(this.BooksAddRowButton);
            this.Controls.Add(this.GroceriesDeleteRowButton);
            this.Controls.Add(this.GroceriesAddRowButton);
            this.Controls.Add(this.BooksDataSheet);
            this.Controls.Add(this.GroceriesDataSheet);
            this.Controls.Add(this.ItemsDeleteRowButton);
            this.Controls.Add(this.ItemsAddRowButton);
            this.Controls.Add(this.ItemsDataSheet);
            this.Name = "MainForm";
            this.Text = "Homework 4.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataSheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroceriesDataSheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataSheet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView ItemsDataSheet;
        private Button ItemsAddRowButton;
        private Button ItemsDeleteRowButton;
        private DataGridView GroceriesDataSheet;
        private DataGridView BooksDataSheet;
        private Button GroceriesAddRowButton;
        private Button GroceriesDeleteRowButton;
        private Button BooksAddRowButton;
        private Button BooksDeleteRowButton;
    }
}