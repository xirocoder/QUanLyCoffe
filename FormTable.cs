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
    public partial class FormTable : Form
    {
        public FormTable()
        {
            InitializeComponent();
        }
        private void btn_click(object sender ,EventArgs e)
        {
            
            MessageBox.Show("sss");
        }
        private void FormTable_Load(object sender, EventArgs e)
        {
            // int dem = 0;fff
            //for(int i=0; i<10; i++)
            //{
            //     Button btn = new Button();
            //     btn.Name = "btn "+dem;
            ///     btn.Text = "asdsad";
            //     btn.Height = 20;
            //     btn.Click += btn_click;
            //     dem++;
            //    listBox1.Items.Add(btn);
            //     listBox1.Items.Add("12345");
            //  }
            firstLabel.Hide();
            firstTextSl.Hide();
            lbGiaBan.Hide();
            titleTable.Text = "KC TABLE  " + cofferManager.idTable;
            labels.Clear();
            labelTiens.Clear();
            textBoxes.Clear();
            labelNV.Text = InfoFormTable.infoForm;


            if(CMenu.menus.Count == 0)
            {
                CMenu.addMenu();
            }
            MessageBox.Show("loaded");
        }
        private void drawButton()
        {
            for (int i = 0; i < 3; i++)
            {
                Button btn = new Button()
                {
                    Text = "cofe",
                    Height = 52,
                    Width = 148,
                    Image = Image.FromFile("C:\\Users\\Admin\\Pictures\\du_an_app_coffe\\nut_type2.png"),
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.Black
                };
                showButton.Controls.Add(btn);
            }
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void clear()
        {
           labelMon.Controls.Clear();
        }
        private void drawmon()
        {
            for (int i = 0; i < CMenu.menus.Count; i++)
            {
                //MessageBox.Show("for "+btnCoffe.Text);
                if (CMenu.menus[i].type == publicType)
                {
                    //MessageBox.Show(btnCoffe.Text);
                    if (textTimKiem.Text != "") { }
                    Button btn = new Button()
                    {
                        Text = CMenu.menus[i].tenMon,
                        Font = button1.Font,
                        Height = 33,
                        Width = 101,
                        FlatStyle = FlatStyle.Popup,
                        AutoSize = true
                    };
                    btn.Click += btn_Click;
                    labelMon.Controls.Add(btn);
                }
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            
            Button btn = sender as Button;
            // tạo nhãn ghi tên món
            Label label = new Label()
            {
                AutoSize = false,
                Text = btn.Text,
                Image = firstLabel.Image,
                Height = firstLabel.Height,
                Width = firstLabel.Width,
                Font = firstLabel.Font
            }; 
            // tạo nhãn ghi tổng số tiền
            Label labelTien = new Label()
            {
                AutoSize = false,
                Text = "0",
                Image = firstLabel.Image,
                Height = firstLabel.Height,
                Width = firstLabel.Width,
                Font = firstLabel.Font
            };
            // tạo text nhập số lượng
            TextBox textBox = new TextBox()
            {
                Multiline = true,
                Height = firstTextSl.Height,
                Width = firstTextSl.Width,
                Font = firstTextSl.Font
            };
            textBox.TextChanged += textBox_TextChanged;
            // thay đổi thuộc tính của text bõ bên dưới:
            if(textBoxes.Count >= 1)
            {
                if(textBoxes[textBoxes.Count - 1].Text == "")
                {
                    MessageBox.Show("vui lòng nhập số lượng");
                    return;
                }
                else
                {
                    textBoxes[textBoxes.Count - 1].ReadOnly = true;
                }
            }
            labels.Add(label);
            labelTiens.Add(labelTien);
            textBoxes.Add(textBox);
            showTenMon.Controls.Clear();
            showInfo(showTenMon,showTien);
        }
        public static void showInfo(FlowLayoutPanel showTenMon, FlowLayoutPanel showTien)
        {
            for (int i = labels.Count; i > 0; i--)
            {
                showTenMon.Controls.Add(labels[i - 1]); // bug in this line
                showTenMon.Controls.Add(textBoxes[i - 1]);
                showTien.Controls.Add(labelTiens[i - 1]);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            clear();
            publicType = btnCoffe.Text;
            drawmon();
        }
        private string xuLiGia(int gia)
        {
            return String.Format("{0:#,##0.##}", gia);
        }
        private void thanhTien()
        {
            int tong = 0;
            for(int i=0; i< labelTiens.Count; i++)
            {
                tong += int.Parse(labelTiens[i].Text);
            }
            labelThanhTien.Text = xuLiGia(tong);
        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            string gia = String.Empty;
            TextBox textBoxes = sender as TextBox;
            for(int i=0; i<CMenu.menus.Count; i++)
            {
                 //kiểm tra phần tử cuối cùng
                if (CMenu.menus[i].tenMon == labels[labels.Count - 1].Text)
                {
                    gia = CMenu.menus[i].gia;
                }
            }
            // xu li gia tien:
            int gia2 = 0;
            if(textBoxes.Text != "")
            {
                try
                {
                    gia2 = int.Parse(gia) * int.Parse(textBoxes.Text);
                }
                catch (Exception) { }
            }
            tongTien = tongTien + gia2;
            labelTiens[labelTiens.Count-1].Text = xuLiGia(gia2);
            labelThanhTien.Text = xuLiGia(tongTien);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            clear();
            publicType = button1.Text;
            drawmon();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
            publicType = button3.Text;
            drawmon();
        }

        private void FormTable_FormClosed(object sender, FormClosedEventArgs e)
        {
            InfoFormTable.aTable = false; // không còn bàn nào đang mở nữa
        }

        private void textTimKiem_TextChanged(object sender, EventArgs e)
        {
            labelMon.Controls.Clear();
            for(int i = 0; i < CMenu.menus.Count; i++)
            {
                if (CMenu.menus[i].type == publicType && CMenu.menus[i].tenMon.Contains(textTimKiem.Text))
                {
                    Button btn = new Button()
                    {
                        Text = CMenu.menus[i].tenMon,
                        Font = button1.Font,
                        Height = 33,
                        Width = 101,
                        FlatStyle = FlatStyle.Popup
                    };
                    btn.Click += btn_Click;
                    labelMon.Controls.Add(btn);
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBoxes[textBoxes.Count - 1].ReadOnly = true;  // chuyển hóa nút cuối ko cho sửa
            FormHoaDon formHoaDon = new FormHoaDon();
            formHoaDon.getTenMon = labels;
            formHoaDon.getSoLuong = textBoxes;
            formHoaDon.getTien = labelTiens;
            formHoaDon.tongTien = labelThanhTien.Text;
            this.Hide();
            formHoaDon.ShowDialog();
            this.Show();
            showInfo(showTenMon, showTien);
        }

        public static List<Label> labels = new List<Label>();
        public static List<Label> labelTiens = new List<Label>();
        public static List<TextBox> textBoxes = new List<TextBox>();
        public static int tongTien = 0;
        public static string publicType;
    }
}
