using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class FormLogin : Form
    {
        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 0x1;
        const int HTCAPTION = 0x2;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InfoFormTable.infoForm == "") 
            {
                return;
            }
            if (textPass.Text == "") 
            {
                labelPass.Text = "Vui lòng nhập mật khẩu của " + InfoFormTable.infoForm;
                return;
            }
            else if(textPass.Text != "123")
            {
                labelPass.Text = "Mật khẩu sai cho "+ InfoFormTable.infoForm;
                return;
            }
            if(InfoFormTable.infoForm == btnTNS.Text || InfoFormTable.infoForm == btnTNT.Text)
            {
                labelPass.Text = String.Empty;
                FormCustomer formCustomer = new FormCustomer();
                this.Hide();
                formCustomer.ShowDialog();
                this.Show();
            }
            else if(InfoFormTable.infoForm == btnQTV.Text)
            {
                labelPass.Text = String.Empty;
                QTV QTV = new QTV();
                this.Hide();
                QTV.ShowDialog();
                this.Show();
            }    
        }
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {
            // pasword char = \0 là kí tự có thể đọc dc
            if(textPass.PasswordChar != '*')
            {
                textPass.PasswordChar = '*';
            }
        }

        private void btnQTV_Click(object sender, EventArgs e)
        {
            InfoFormTable.infoForm = btnQTV.Text;
            labelPass.Text = "Vui lòng nhập mật khẩu của " + InfoFormTable.infoForm;
        }

        private void btnTNS_Click(object sender, EventArgs e)
        {
            InfoFormTable.infoForm = btnTNS.Text;
            labelPass.Text = "Vui lòng nhập mật khẩu của " + InfoFormTable.infoForm;
        }

        private void btnTNT_Click(object sender, EventArgs e)
        {
            InfoFormTable.infoForm = btnTNT.Text;
            labelPass.Text = "Vui lòng nhập mật khẩu của " + InfoFormTable.infoForm;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            labelPass.Text = "Bạn chưa chọn tài khoản";
        }
    }
}
