using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2
{
    public partial class Ex_2 : Form
    {
        public Ex_2()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("bạn có muốn thoát không","thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
                Application.Exit();

        }
        bool kiemtralb()
        {
            if (lbketqua.Items.Count > 0)
                return true;
            return false;
        }

        private void btnnhap_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtkhungnhap.Text);
                lbketqua.Items.Add(txtkhungnhap.Text.Trim());
                txtkhungnhap.ResetText();
                txtkhungnhap.Focus();

            }
            catch(Exception)
            {
                MessageBox.Show("yeu cau nhap so nguyen", "error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtkhungnhap.ResetText();
                txtkhungnhap.Focus();

            }
        }

        private void btntang2_Click(object sender, EventArgs e)
        {
            int n = lbketqua.Items.Count;
            for (int i = 0; i < n; i++)
                lbketqua.Items[i] = Convert.ToInt32(lbketqua.Items[i]) + 2;
        }

        private void btnchan_Click(object sender, EventArgs e)
        {
            int n = lbketqua.Items.Count;
            for (int i=0;i<n;i++)
                if (Convert.ToInt32(lbketqua.Items[i])%2==0)
                {
                    lbketqua.SelectedIndex = i;
                    return;

                }
        }

        private void btnle_Click(object sender, EventArgs e)
        {

            int n = lbketqua.Items.Count;
            for (int i = n-1; i >= n; i--)
                if (Convert.ToInt32(lbketqua.Items[i]) % 2 != 0)
                {
                    lbketqua.SelectedIndex = i;
                    return;

                }
        }

        private void btnxoadaucuoi_Click(object sender, EventArgs e)
        {
            if (kiemtralb())
                lbketqua.Items.RemoveAt(0);
            else
                MessageBox.Show("lis rong, khong the xoa", "error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

        }

        private void btnxoachon_Click(object sender, EventArgs e)
        {
            if (kiemtralb())
                while (lbketqua.SelectedItems.Count > 0)
                    lbketqua.Items.Remove(lbketqua.SelectedItem);
            else
                MessageBox.Show("lis rong, khong the xoa","error",MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

        }

    }
}
