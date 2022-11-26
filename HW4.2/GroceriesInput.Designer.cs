namespace HW4._2
{
    partial class GroceriesInput
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
            this.textLabel = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(141, 153);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(87, 20);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "Enter Name";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(121, 176);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(125, 27);
            this.inputBox.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(134, 209);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(94, 29);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit!";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // GroceriesInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.textLabel);
            this.Name = "GroceriesInput";
            this.Text = "GroceriesInput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label textLabel;
        private TextBox inputBox;
        private Button submitButton;
    }
}