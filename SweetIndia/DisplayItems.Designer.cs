namespace SweetIndia
{
    partial class DisplayItems
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
            this.btnDELETE = new System.Windows.Forms.Button();
            this.btnUPDATE = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.bnREAD = new System.Windows.Forms.Button();
            this.lblMainItem = new System.Windows.Forms.Label();
            this.cmbMainItem = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Location = new System.Drawing.Point(12, 9);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(90, 25);
            this.lblItemCode.TabIndex = 0;
            this.lblItemCode.Text = "ItemCode";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 89);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // btnDELETE
            // 
            this.btnDELETE.Location = new System.Drawing.Point(182, 128);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(81, 31);
            this.btnDELETE.TabIndex = 2;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.UseVisualStyleBackColor = true;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.Location = new System.Drawing.Point(87, 128);
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Size = new System.Drawing.Size(89, 31);
            this.btnUPDATE.TabIndex = 3;
            this.btnUPDATE.Text = "UPDATE";
            this.btnUPDATE.UseVisualStyleBackColor = true;
            this.btnUPDATE.Click += new System.EventHandler(this.btnUPDATE_Click);
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(12, 128);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(69, 31);
            this.btnADD.TabIndex = 4;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(107, 6);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(182, 31);
            this.txtItemCode.TabIndex = 5;
            // 
            // cmbName
            // 
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(105, 89);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(182, 33);
            this.cmbName.TabIndex = 6;
            // 
            // bnREAD
            // 
            this.bnREAD.Location = new System.Drawing.Point(269, 128);
            this.bnREAD.Name = "bnREAD";
            this.bnREAD.Size = new System.Drawing.Size(67, 31);
            this.bnREAD.TabIndex = 7;
            this.bnREAD.Text = "READ";
            this.bnREAD.UseVisualStyleBackColor = true;
            this.bnREAD.Click += new System.EventHandler(this.bnREAD_Click);
            // 
            // lblMainItem
            // 
            this.lblMainItem.AutoSize = true;
            this.lblMainItem.Location = new System.Drawing.Point(12, 51);
            this.lblMainItem.Name = "lblMainItem";
            this.lblMainItem.Size = new System.Drawing.Size(87, 25);
            this.lblMainItem.TabIndex = 8;
            this.lblMainItem.Text = "MainItem";
            // 
            // cmbMainItem
            // 
            this.cmbMainItem.FormattingEnabled = true;
            this.cmbMainItem.Location = new System.Drawing.Point(105, 48);
            this.cmbMainItem.Name = "cmbMainItem";
            this.cmbMainItem.Size = new System.Drawing.Size(182, 33);
            this.cmbMainItem.TabIndex = 9;
            // 
            // DisplayItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 168);
            this.Controls.Add(this.cmbMainItem);
            this.Controls.Add(this.lblMainItem);
            this.Controls.Add(this.bnREAD);
            this.Controls.Add(this.cmbName);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.btnUPDATE);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblItemCode);
            this.Name = "DisplayItems";
            this.Text = "DisplayItems";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblItemCode;
        private Label lblName;
        private Button btnDELETE;
        private Button btnUPDATE;
        private Button btnADD;
        private TextBox txtItemCode;
        private ComboBox cmbName;
        private Button bnREAD;
        private Label lblMainItem;
        private ComboBox cmbMainItem;
    }
}