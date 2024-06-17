namespace CSharp_laixuatnganhang
{
    partial class txtketqua
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
            this.lblnhapsotien = new System.Windows.Forms.Label();
            this.txtsotien = new System.Windows.Forms.TextBox();
            this.lblnhaplaima = new System.Windows.Forms.Label();
            this.lblnhapsonam = new System.Windows.Forms.Label();
            this.lblketqua = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btntinh = new System.Windows.Forms.Button();
            this.txtlaisuat = new System.Windows.Forms.ComboBox();
            this.txtsonam = new System.Windows.Forms.ComboBox();
            this.lsbketqua = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblnhapsotien
            // 
            this.lblnhapsotien.AutoSize = true;
            this.lblnhapsotien.Location = new System.Drawing.Point(69, 75);
            this.lblnhapsotien.Name = "lblnhapsotien";
            this.lblnhapsotien.Size = new System.Drawing.Size(68, 13);
            this.lblnhapsotien.TabIndex = 0;
            this.lblnhapsotien.Text = "nhập số tiền ";
            // 
            // txtsotien
            // 
            this.txtsotien.Location = new System.Drawing.Point(165, 68);
            this.txtsotien.Name = "txtsotien";
            this.txtsotien.Size = new System.Drawing.Size(186, 20);
            this.txtsotien.TabIndex = 1;
            // 
            // lblnhaplaima
            // 
            this.lblnhaplaima.AutoSize = true;
            this.lblnhaplaima.Location = new System.Drawing.Point(69, 116);
            this.lblnhaplaima.Name = "lblnhaplaima";
            this.lblnhaplaima.Size = new System.Drawing.Size(66, 13);
            this.lblnhaplaima.TabIndex = 2;
            this.lblnhaplaima.Text = "Nhập lại mã ";
            // 
            // lblnhapsonam
            // 
            this.lblnhapsonam.AutoSize = true;
            this.lblnhapsonam.Location = new System.Drawing.Point(69, 167);
            this.lblnhapsonam.Name = "lblnhapsonam";
            this.lblnhapsonam.Size = new System.Drawing.Size(71, 13);
            this.lblnhapsonam.TabIndex = 4;
            this.lblnhapsonam.Text = "nhập số năm ";
            // 
            // lblketqua
            // 
            this.lblketqua.AutoSize = true;
            this.lblketqua.Location = new System.Drawing.Point(69, 219);
            this.lblketqua.Name = "lblketqua";
            this.lblketqua.Size = new System.Drawing.Size(43, 13);
            this.lblketqua.TabIndex = 6;
            this.lblketqua.Text = "kết quả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(198, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(401, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "ỨNG DỤNG TÍNH LÃI XUẤT NGÂN HÀNG";
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(362, 383);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(75, 25);
            this.btntinh.TabIndex = 9;
            this.btntinh.Text = "tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // txtlaisuat
            // 
            this.txtlaisuat.FormattingEnabled = true;
            this.txtlaisuat.Location = new System.Drawing.Point(165, 116);
            this.txtlaisuat.Name = "txtlaisuat";
            this.txtlaisuat.Size = new System.Drawing.Size(186, 21);
            this.txtlaisuat.TabIndex = 10;
            // 
            // txtsonam
            // 
            this.txtsonam.FormattingEnabled = true;
            this.txtsonam.Location = new System.Drawing.Point(165, 167);
            this.txtsonam.Name = "txtsonam";
            this.txtsonam.Size = new System.Drawing.Size(186, 21);
            this.txtsonam.TabIndex = 11;
            // 
            // lsbketqua
            // 
            this.lsbketqua.FormattingEnabled = true;
            this.lsbketqua.Location = new System.Drawing.Point(165, 219);
            this.lsbketqua.Name = "lsbketqua";
            this.lsbketqua.Size = new System.Drawing.Size(186, 95);
            this.lsbketqua.TabIndex = 12;
            this.lsbketqua.SelectedIndexChanged += new System.EventHandler(this.lsbketqua_SelectedIndexChanged);
            // 
            // txtketqua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsbketqua);
            this.Controls.Add(this.txtsonam);
            this.Controls.Add(this.txtlaisuat);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblketqua);
            this.Controls.Add(this.lblnhapsonam);
            this.Controls.Add(this.lblnhaplaima);
            this.Controls.Add(this.txtsotien);
            this.Controls.Add(this.lblnhapsotien);
            this.Name = "txtketqua";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnhapsotien;
        private System.Windows.Forms.TextBox txtsotien;
        private System.Windows.Forms.Label lblnhaplaima;
        private System.Windows.Forms.Label lblnhapsonam;
        private System.Windows.Forms.Label lblketqua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.ComboBox txtlaisuat;
        private System.Windows.Forms.ComboBox txtsonam;
        private System.Windows.Forms.ListBox lsbketqua;
    }
}

