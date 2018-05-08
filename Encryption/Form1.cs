using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption
{
    public partial class Form1 : Form
    {
        private Controller controller;
       

        public Form1()
        {
            controller = new Controller();
            InitializeComponent();
            tbResult.ReadOnly = true;
            cbHide.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if(tbKey.Text == null || tbKey.Text == "" || tbPlainText.Text==null|| tbPlainText.Text=="")
            {
                MessageBox.Show("폼을 모두 입력해주세요.");
                return;
            }
            tbResult.Text = controller.Encryption(tbKey.Text, tbPlainText.Text);
        }

        private void tbKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (tbKey.Text == null || tbKey.Text == "" || tbPlainText.Text == null || tbPlainText.Text == "")
            {
                MessageBox.Show("폼을 모두 입력해주세요.");
                return;
            }
            tbResult.Text = controller.Decryption(tbKey.Text, tbPlainText.Text, cbIsShowingX.Checked);
            
        }

        private void tbPlainText_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbResult_MouseClick(object sender, MouseEventArgs e)
        {
  


        }

        private void tbResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbResult_Click(object sender, EventArgs e)
        {
            var w = new Form() { Size = new Size(0, 0) };
            Task.Delay(TimeSpan.FromSeconds(2))
                .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());

            if (!(tbResult.Text == null || tbResult.Text == ""))
            {
                Clipboard.SetText(tbResult.Text);
                MessageBox.Show(w, "클립보드에 복사되었습니다.", "2초 뒤에 사라집니다.");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tbKey.UseSystemPasswordChar = cbHide.Checked;
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            tbResult.Text = controller.Decryption(tbKey.Text, tbPlainText.Text, cbIsShowingX.Checked);
        }
    }
}
