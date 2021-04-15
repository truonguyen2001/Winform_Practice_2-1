
namespace Ex_1
{
    partial class Ex_1
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
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbxInput = new System.Windows.Forms.ComboBox();
            this.btnSumAll = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCountEven = new System.Windows.Forms.Button();
            this.btnCountPrime = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbInput.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.txtInput);
            this.grbInput.Controls.Add(this.btnUpdate);
            this.grbInput.Controls.Add(this.cbxInput);
            this.grbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInput.Location = new System.Drawing.Point(46, 43);
            this.grbInput.Name = "grbInput";
            this.grbInput.Size = new System.Drawing.Size(336, 174);
            this.grbInput.TabIndex = 0;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "Nhập số";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(22, 37);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(155, 27);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(183, 37);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 29);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "&Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbxInput
            // 
            this.cbxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxInput.FormattingEnabled = true;
            this.cbxInput.Location = new System.Drawing.Point(22, 101);
            this.cbxInput.Name = "cbxInput";
            this.cbxInput.Size = new System.Drawing.Size(253, 28);
            this.cbxInput.TabIndex = 2;
            this.cbxInput.SelectedIndexChanged += new System.EventHandler(this.cbxInput_SelectedIndexChanged);
            // 
            // btnSumAll
            // 
            this.btnSumAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSumAll.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSumAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSumAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumAll.Location = new System.Drawing.Point(478, 234);
            this.btnSumAll.Name = "btnSumAll";
            this.btnSumAll.Size = new System.Drawing.Size(283, 40);
            this.btnSumAll.TabIndex = 2;
            this.btnSumAll.Text = "&Tổng các ước số";
            this.btnSumAll.UseVisualStyleBackColor = false;
            this.btnSumAll.Click += new System.EventHandler(this.btnSumAll_Click);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(22, 25);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(283, 115);
            this.txtResult.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Location = new System.Drawing.Point(441, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 161);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách ước số";
            // 
            // btnCountEven
            // 
            this.btnCountEven.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCountEven.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCountEven.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCountEven.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCountEven.Location = new System.Drawing.Point(478, 280);
            this.btnCountEven.Name = "btnCountEven";
            this.btnCountEven.Size = new System.Drawing.Size(283, 40);
            this.btnCountEven.TabIndex = 3;
            this.btnCountEven.Text = "Số lượng ước số chẵn";
            this.btnCountEven.UseVisualStyleBackColor = false;
            this.btnCountEven.Click += new System.EventHandler(this.btnCountEven_Click);
            // 
            // btnCountPrime
            // 
            this.btnCountPrime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCountPrime.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCountPrime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCountPrime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCountPrime.Location = new System.Drawing.Point(478, 326);
            this.btnCountPrime.Name = "btnCountPrime";
            this.btnCountPrime.Size = new System.Drawing.Size(283, 40);
            this.btnCountPrime.TabIndex = 4;
            this.btnCountPrime.Text = "Số lượng ước số nguyên tố";
            this.btnCountPrime.UseVisualStyleBackColor = false;
            this.btnCountPrime.Click += new System.EventHandler(this.btnCountPrime_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(305, 326);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 29);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Th&oát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Ex_1
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(815, 389);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCountPrime);
            this.Controls.Add(this.btnCountEven);
            this.Controls.Add(this.btnSumAll);
            this.Controls.Add(this.grbInput);
            this.Name = "Ex_1";
            this.Text = "Ex_1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ex_1_FormClosing);
            this.grbInput.ResumeLayout(false);
            this.grbInput.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbxInput;
        private System.Windows.Forms.Button btnSumAll;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCountPrime;
        private System.Windows.Forms.Button btnCountEven;
        private System.Windows.Forms.Button btnExit;
    }
}

