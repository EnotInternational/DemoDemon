namespace DemoDemon.Forms
{
    partial class ProductsViewForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.currentOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 36);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(769, 344);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // currentOrderButton
            // 
            this.currentOrderButton.Location = new System.Drawing.Point(644, 400);
            this.currentOrderButton.Name = "currentOrderButton";
            this.currentOrderButton.Size = new System.Drawing.Size(135, 23);
            this.currentOrderButton.TabIndex = 4;
            this.currentOrderButton.Text = "Текущий заказ";
            this.currentOrderButton.UseVisualStyleBackColor = true;
            this.currentOrderButton.Click += new System.EventHandler(this.currentOrderButton_Click);
            // 
            // ProductsViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.currentOrderButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ProductsViewForm";
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.currentOrderButton, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button currentOrderButton;
    }
}
