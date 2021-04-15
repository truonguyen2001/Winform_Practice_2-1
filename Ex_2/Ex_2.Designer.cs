namespace bai2
{
    partial class Ex_2
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
            this.txtkhungnhap = new System.Windows.Forms.TextBox();
            this.btnnhap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbketqua = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnle = new System.Windows.Forms.Button();
            this.btnchan = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btntang2 = new System.Windows.Forms.Button();
            this.btnxoachon = new System.Windows.Forms.Button();
            this.btnxoadaucuoi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtkhungnhap
            // 
            this.txtkhungnhap.Location = new System.Drawing.Point(33, 40);
            this.txtkhungnhap.Name = "txtkhungnhap";
            this.txtkhungnhap.Size = new System.Drawing.Size(135, 22);
            this.txtkhungnhap.TabIndex = 1;
            this.txtkhungnhap.Text = "1";
            // 
            // btnnhap
            // 
            this.btnnhap.Location = new System.Drawing.Point(33, 68);
            this.btnnhap.Name = "btnnhap";
            this.btnnhap.Size = new System.Drawing.Size(135, 35);
            this.btnnhap.TabIndex = 2;
            this.btnnhap.Text = "Nhập";
            this.btnnhap.UseVisualStyleBackColor = true;
            this.btnnhap.Click += new System.EventHandler(this.btnnhap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 3;
            // 
            // lbketqua
            // 
            this.lbketqua.FormattingEnabled = true;
            this.lbketqua.ItemHeight = 16;
            this.lbketqua.Location = new System.Drawing.Point(38, 112);
            this.lbketqua.Name = "lbketqua";
            this.lbketqua.Size = new System.Drawing.Size(130, 180);
            this.lbketqua.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnle);
            this.groupBox1.Controls.Add(this.btnchan);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.btntang2);
            this.groupBox1.Controls.Add(this.btnxoachon);
            this.groupBox1.Controls.Add(this.btnxoadaucuoi);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(462, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 366);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xử lý lisbox";
            // 
            // btnle
            // 
            this.btnle.Location = new System.Drawing.Point(17, 321);
            this.btnle.Name = "btnle";
            this.btnle.Size = new System.Drawing.Size(216, 27);
            this.btnle.TabIndex = 6;
            this.btnle.Text = "Chọn số lẻ";
            this.btnle.UseVisualStyleBackColor = true;
            this.btnle.Click += new System.EventHandler(this.btnle_Click);
            // 
            // btnchan
            // 
            this.btnchan.Location = new System.Drawing.Point(17, 277);
            this.btnchan.Name = "btnchan";
            this.btnchan.Size = new System.Drawing.Size(217, 25);
            this.btnchan.TabIndex = 5;
            this.btnchan.Text = "Chọn số chẵn";
            this.btnchan.UseVisualStyleBackColor = true;
            this.btnchan.Click += new System.EventHandler(this.btnchan_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(17, 230);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(218, 28);
            this.button6.TabIndex = 4;
            this.button6.Text = "Thay bằng bình phương";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btntang2
            // 
            this.btntang2.Location = new System.Drawing.Point(16, 180);
            this.btntang2.Name = "btntang2";
            this.btntang2.Size = new System.Drawing.Size(220, 33);
            this.btntang2.TabIndex = 3;
            this.btntang2.Text = "tăng mỗi phần tử lên 2";
            this.btntang2.UseVisualStyleBackColor = true;
            this.btntang2.Click += new System.EventHandler(this.btntang2_Click);
            // 
            // btnxoachon
            // 
            this.btnxoachon.Location = new System.Drawing.Point(17, 133);
            this.btnxoachon.Name = "btnxoachon";
            this.btnxoachon.Size = new System.Drawing.Size(220, 26);
            this.btnxoachon.TabIndex = 2;
            this.btnxoachon.Text = "xóa phần tử đang chọn";
            this.btnxoachon.UseVisualStyleBackColor = true;
            this.btnxoachon.Click += new System.EventHandler(this.btnxoachon_Click);
            // 
            // btnxoadaucuoi
            // 
            this.btnxoadaucuoi.Location = new System.Drawing.Point(17, 82);
            this.btnxoadaucuoi.Name = "btnxoadaucuoi";
            this.btnxoadaucuoi.Size = new System.Drawing.Size(221, 36);
            this.btnxoadaucuoi.TabIndex = 1;
            this.btnxoadaucuoi.Text = "Xóa các phần tử đầu và cuối";
            this.btnxoadaucuoi.UseVisualStyleBackColor = true;
            this.btnxoadaucuoi.Click += new System.EventHandler(this.btnxoadaucuoi_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 32);
            this.button2.TabIndex = 0;
            this.button2.Text = "Tổng các phần tử trong list";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(291, 411);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(163, 27);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Kết thúc";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtkhungnhap);
            this.groupBox2.Controls.Add(this.btnnhap);
            this.groupBox2.Controls.Add(this.lbketqua);
            this.groupBox2.Location = new System.Drawing.Point(66, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 306);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "lisbox";
            // 
            // Ex_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "Ex_2";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtkhungnhap;
        private System.Windows.Forms.Button btnnhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbketqua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnle;
        private System.Windows.Forms.Button btnchan;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btntang2;
        private System.Windows.Forms.Button btnxoachon;
        private System.Windows.Forms.Button btnxoadaucuoi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

