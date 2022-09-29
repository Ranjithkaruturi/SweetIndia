namespace SweetIndia
{
    partial class RetailItem
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
            this.lblItemCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.cmbDisplayItem = new System.Windows.Forms.ComboBox();
            this.btnREAD = new System.Windows.Forms.Button();
            this.btnUPDATE = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.lblDisplayItem = new System.Windows.Forms.Label();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Location = new System.Drawing.Point(12, 11);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(90, 25);
            this.lblItemCode.TabIndex = 0;
            this.lblItemCode.Text = "ItemCode";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 111);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(131, 12);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(182, 31);
            this.txtItemCode.TabIndex = 2;
            // 
            // cmbDisplayItem
            // 
            this.cmbDisplayItem.FormattingEnabled = true;
            this.cmbDisplayItem.Location = new System.Drawing.Point(131, 57);
            this.cmbDisplayItem.Name = "cmbDisplayItem";
            this.cmbDisplayItem.Size = new System.Drawing.Size(182, 33);
            this.cmbDisplayItem.TabIndex = 3;
            // 
            // btnREAD
            // 
            this.btnREAD.Location = new System.Drawing.Point(243, 174);
            this.btnREAD.Name = "btnREAD";
            this.btnREAD.Size = new System.Drawing.Size(70, 28);
            this.btnREAD.TabIndex = 4;
            this.btnREAD.Text = "READ";
            this.btnREAD.UseVisualStyleBackColor = true;
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.Location = new System.Drawing.Point(66, 174);
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Size = new System.Drawing.Size(84, 28);
            this.btnUPDATE.TabIndex = 5;
            this.btnUPDATE.Text = "UPDATE";
            this.btnUPDATE.UseVisualStyleBackColor = true;
            this.btnUPDATE.Click += new System.EventHandler(this.btnUPDATE_Click);
            // 
            // btnDELETE
            // 
            this.btnDELETE.Location = new System.Drawing.Point(156, 174);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(81, 28);
            this.btnDELETE.TabIndex = 6;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.UseVisualStyleBackColor = true;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(1, 174);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(59, 28);
            this.btnADD.TabIndex = 7;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // lblDisplayItem
            // 
            this.lblDisplayItem.AutoSize = true;
            this.lblDisplayItem.Location = new System.Drawing.Point(12, 57);
            this.lblDisplayItem.Name = "lblDisplayItem";
            this.lblDisplayItem.Size = new System.Drawing.Size(106, 25);
            this.lblDisplayItem.TabIndex = 8;
            this.lblDisplayItem.Text = "DisplayItem";
            this.lblDisplayItem.Click += new System.EventHandler(this.lblDisplayName_Click);
            // 
            // cmbName
            // 
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(131, 111);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(182, 33);
            this.cmbName.TabIndex = 9;
            // 
            // RetailItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 214);
            this.Controls.Add(this.cmbName);
            this.Controls.Add(this.lblDisplayItem);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.btnUPDATE);
            this.Controls.Add(this.btnREAD);
            this.Controls.Add(this.cmbDisplayItem);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblItemCode);
            this.Name = "RetailItem";
            this.Text = "RetailItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblItemCode;
        private Label lblName;
        private TextBox txtItemCode;
        private ComboBox cmbDisplayItem;
        private Button btnREAD;
        private Button btnUPDATE;
        private Button btnDELETE;
        private Button btnADD;
        private Label lblDisplayItem;
        private ComboBox cmbName;
    }
}