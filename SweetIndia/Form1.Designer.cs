namespace SweetIndia
{
    partial class FrmSweetIndia
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMainItems = new System.Windows.Forms.Button();
            this.btnDisplayItems = new System.Windows.Forms.Button();
            this.btnRetailItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMainItems
            // 
            this.btnMainItems.Location = new System.Drawing.Point(198, 80);
            this.btnMainItems.Name = "btnMainItems";
            this.btnMainItems.Size = new System.Drawing.Size(139, 31);
            this.btnMainItems.TabIndex = 0;
            this.btnMainItems.Text = "MainItems";
            this.btnMainItems.UseVisualStyleBackColor = true;
            // 
            // btnDisplayItems
            // 
            this.btnDisplayItems.Location = new System.Drawing.Point(198, 153);
            this.btnDisplayItems.Name = "btnDisplayItems";
            this.btnDisplayItems.Size = new System.Drawing.Size(139, 34);
            this.btnDisplayItems.TabIndex = 1;
            this.btnDisplayItems.Text = "DisplayItems";
            this.btnDisplayItems.UseVisualStyleBackColor = true;
            // 
            // btnRetailItems
            // 
            this.btnRetailItems.Location = new System.Drawing.Point(198, 221);
            this.btnRetailItems.Name = "btnRetailItems";
            this.btnRetailItems.Size = new System.Drawing.Size(139, 37);
            this.btnRetailItems.TabIndex = 2;
            this.btnRetailItems.Text = "RetailItems";
            this.btnRetailItems.UseVisualStyleBackColor = true;
            // 
            // FrmSweetIndia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 397);
            this.Controls.Add(this.btnRetailItems);
            this.Controls.Add(this.btnDisplayItems);
            this.Controls.Add(this.btnMainItems);
            this.Name = "FrmSweetIndia";
            this.Text = "SweetIndia";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnMainItems;
        private Button btnDisplayItems;
        private Button btnRetailItems;
    }
}