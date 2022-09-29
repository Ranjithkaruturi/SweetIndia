namespace SweetIndia
{
    partial class MainItems
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
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.cmbItemName = new System.Windows.Forms.ComboBox();
            this.btnREAD = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.btnUPDATE = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Location = new System.Drawing.Point(0, 9);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(90, 25);
            this.lblItemCode.TabIndex = 0;
            this.lblItemCode.Text = "ItemCode";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(0, 59);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(95, 25);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "ItemName";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(101, 6);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(207, 31);
            this.txtItemCode.TabIndex = 3;
            // 
            // cmbItemName
            // 
            this.cmbItemName.FormattingEnabled = true;
            this.cmbItemName.Location = new System.Drawing.Point(101, 51);
            this.cmbItemName.Name = "cmbItemName";
            this.cmbItemName.Size = new System.Drawing.Size(207, 33);
            this.cmbItemName.TabIndex = 4;
            // 
            // btnREAD
            // 
            this.btnREAD.Location = new System.Drawing.Point(242, 116);
            this.btnREAD.Name = "btnREAD";
            this.btnREAD.Size = new System.Drawing.Size(66, 34);
            this.btnREAD.TabIndex = 5;
            this.btnREAD.Text = "READ";
            this.btnREAD.UseVisualStyleBackColor = true;
            // 
            // btnDELETE
            // 
            this.btnDELETE.Location = new System.Drawing.Point(158, 116);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(78, 34);
            this.btnDELETE.TabIndex = 6;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.UseVisualStyleBackColor = true;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.Location = new System.Drawing.Point(67, 116);
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Size = new System.Drawing.Size(85, 34);
            this.btnUPDATE.TabIndex = 7;
            this.btnUPDATE.Text = "UPDATE";
            this.btnUPDATE.UseVisualStyleBackColor = true;
            this.btnUPDATE.Click += new System.EventHandler(this.btnUPDATE_Click);
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(0, 116);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(61, 34);
            this.btnADD.TabIndex = 8;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // MainItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 150);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.btnUPDATE);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.btnREAD);
            this.Controls.Add(this.cmbItemName);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblItemCode);
            this.Name = "MainItems";
            this.Text = "MainItems";
            this.Load += new System.EventHandler(this.MainItems_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblItemCode;
        private Label lblItemName;
        private TextBox txtItemCode;
        private ComboBox cmbItemName;
        private Button btnREAD;
        private Button btnDELETE;
        private Button btnUPDATE;
        private Button btnADD;
    }
}