using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserSave
{
    public partial class UserSaveHome : Form
    {
        public UserSaveHome()
        {
            InitializeComponent();

            EnableComboBox.Items.Add("有効");
            EnableComboBox.Items.Add("無効");
            EnableComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            EnableComboBox.SelectedIndex = 0;

            StatusText.Text = "";

            SetMailAddressCheck();

            FreeRadioButton.Checked = true;
            UnlimitedLabelVisible();
        }

        private void MailAddressCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetMailAddressCheck();

        }

        public void SetMailAddressCheck()
        {
            if (MailAddressCheckBox.Checked)
            {
                MailAddressTextBox.Enabled = true;
            }
            else
            {
                MailAddressTextBox.Enabled = false;
            }
        }

        private void BussinessRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UnlimitedLabelVisible();
        }

        public void UnlimitedLabelVisible()
        {
            if (BussinessRadioButton.Checked)
            {
                UnlimitedLabel.Visible = true;
            }
            else
            {
                UnlimitedLabel.Visible = false;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("保存しますか？","確認",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                using (var sw = new System.IO.StreamWriter(
                    "save.csv", true, System.Text.Encoding.GetEncoding("shift_jis")))
                {
                    sw.Write(IdTextBox.Text + ",");
                    sw.Write(MailAddressCheckBox.Checked + ",");
                    sw.Write(MailAddressTextBox.Text + ",");
                    if(BussinessRadioButton.Checked)
                    {
                        sw.Write(1 + ",");
                    } else
                    {
                        sw.Write(0 + ",");
                    }
                    sw.Write(EnableComboBox.Text);
                    sw.WriteLine("");
                }

                StatusText.Text = "保存しました。";
            } else
            {
                StatusText.Text = "キャンセルしました。";
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
