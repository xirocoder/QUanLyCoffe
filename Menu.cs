using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuanLyQuanCafe
{
    public struct MyMenu
    {
        public string tenMon;
        public string type;
        public string gia;
    }
    public class CMenu
    {
        public static void addMenu()
        {
            string[] line = File.ReadAllLines("menu.txt");
            for(int i=0; i< line.Length; i++)
            {
                MyMenu cmenu = new MyMenu();
                  string[] mon = line[i].Split(':');
                  cmenu.tenMon = mon[0];
                  cmenu.type = mon[1];
                  cmenu.gia = mon[2];
                //cmenu.tenMon = "nước lọc";
                //cmenu.type = "COFFE";
                //cmenu.gia = "10";
                menus.Add(cmenu);
            }
        }
        public static List<MyMenu> menus = new List<MyMenu>();
    }
}
