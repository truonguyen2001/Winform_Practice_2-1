using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_1
{
    public partial class Ex_1 : Form
    {
        public Ex_1()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            int Temp;
            if (txtInput.Text.Trim() != "")
            {
                if (int.TryParse(txtInput.Text, out Temp))
                {
                    btnUpdate.Enabled = true;
                }
                else
                {
                    btnUpdate.Enabled = false;
                    MessageBox.Show("Nhập vào một số!", "Thông báo");
                    txtInput.Text = "";
                }
            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!cbxInput.Items.Contains(txtInput.Text))
            {
                cbxInput.Items.Add(txtInput.Text);
            }
            txtInput.Text = "";
        }

        private void cbxInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
            int Temp = int.Parse(cbxInput.SelectedItem.ToString());
            for (int i = 1; i < Temp; i++)
            {
                if (Temp % i == 0)
                {
                    txtResult.Text += i + "\r\n";
                }
            }
        }

        private void btnSumAll_Click(object sender, EventArgs e)
        {
            int Sum = 0;
            if (txtResult.Text.Trim() != "")
            {
                string[] Arr = txtResult.Text.Trim('\n', '\r').Split('\n');
                for (int i = 0; i < Arr.Length; i++)
                {
                    Sum += int.Parse(Arr[i].Trim('\r'));
                }
            }
            MessageBox.Show($"Tổng các ước số: {Sum}", "Kết quả");
        }

        private void btnCountEven_Click(object sender, EventArgs e)
        {
            int Sum = 0, Temp;
            if (txtResult.Text.Trim() != "")
            {
                string[] Arr = txtResult.Text.Trim('\n', '\r').Split('\n');
                for (int i = 0; i < Arr.Length; i++)
                {
                    Temp = int.Parse(Arr[i].Trim('\r'));
                    if (Temp % 2 == 0)
                    {
                        Sum += Temp;
                    }
                }
            }
            MessageBox.Show($"Tổng các ước số chẵn: {Sum}", "Kết quả");
        }

        private void btnCountPrime_Click(object sender, EventArgs e)
        {
            int Sum = 0, Temp;
            if (txtResult.Text.Trim() != "")
            {
                string[] Arr = txtResult.Text.Trim('\n', '\r').Split('\n');
                for (int i = 0; i < Arr.Length; i++)
                {
                    Temp = int.Parse(Arr[i].Trim('\r'));
                    if (IsPrime(Temp))
                    {
                        Sum += Temp;
                    }
                }
            }
            MessageBox.Show($"Tổng các ước số là số nguyên tố: {Sum}", "Kết quả");
        }
        private static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            int boundary = (int)Math.Floor(Math.Sqrt(number));
            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ex_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đóng?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
