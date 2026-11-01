namespace DemoDemon.Forms
{
    partial class ManagerForm
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
            this.productsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productsButton
            // 
            this.productsButton.Location = new System.Drawing.Point(12, 36);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(127, 23);
            this.productsButton.TabIndex = 3;
            this.productsButton.Text = "Продукты";
            this.productsButton.UseVisualStyleBackColor = true;
            this.productsButton.Click += new System.EventHandler(this.productsButton_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.productsButton);
            this.Name = "ManagerForm";
            this.Controls.SetChildIndex(this.productsButton, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button productsButton;
    }
}
