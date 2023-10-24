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
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
        }

        //tao thuoc tinh cho form
        public static List<Label> labels = new List<Label>();
        public static List<Label> labelTiens = new List<Label>();
        public static List<TextBox> textBoxes = new List<TextBox>();
        private string tong_tien;
        public List<Label> getTenMon
        {
            get { return labels; }
            set { labels = value; }
        }
        public List<TextBox> getSoLuong
        {
            get { return textBoxes; }
            set { textBoxes = value; }
        }
        public List<Label> getTien
        {
            get { return labelTiens; }
            set { labelTiens = value; }
        }
        public string tongTien
        {
            get { return tong_tien; }
            set { tong_tien = value; }
        }
        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            labelTenMon.Hide();
            textSoLuong.Hide();
            labelThanhTien.Hide();
            drawhoaDon();
        }
        private void drawhoaDon()
        {
            for (int i = labels.Count; i > 0; i--)
            {
                showHoaDon.Controls.Add(labels[i - 1]); // bug in this line
                showHoaDon.Controls.Add(textBoxes[i - 1]);
                showHoaDon.Controls.Add(labelTiens[i - 1]);
                TongTien.Text = tong_tien;
            }
        }
    }
}
