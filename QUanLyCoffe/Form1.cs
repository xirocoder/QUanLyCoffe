using QuanLyQuanCafe.Themxoa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class QTV : Form
    {
        BindingSource foodList = new BindingSource();
        public QTV()
        {
            InitializeComponent();
            Load();
        }

        #region methods

        void Load()
        {
            LoadListFood();
            LoadCategoryIntoCombobox(cbFoodCategory);
            AddFoodBinding();
        }

        void LoadListFood()
        {
            dtgvFood.DataSource = FoodDAO.Instance.GetListFood();
        }
        void LoadCategoryIntoCombobox(ComboBox cb)
        {

            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "name";
        }
        void AddFoodBinding()
        {
            txbFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name"));
            txbFoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID"));
            nmFoodPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "Price"));
        }
        #endregion

        #region events
        #endregion
        #region events
        private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }


        private void txbFoodID_TextChanged(object sender, EventArgs e)
        {
            if (dtgvFood.SelectedCells.Count > 0)
            {
                int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

                Category cateogory = CategoryDAO.Instance.GetCategoryByID(id);

                cbFoodCategory.SelectedItem = cateogory;

                int index = -1;
                int i = 0;
                foreach (Category item in cbFoodCategory.Items)
                {
                    if (item.ID == cateogory.ID)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }

                cbFoodCategory.SelectedIndex = index;
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int categoryID = (cbFoodCategory.SelectedItem as Category).ID;
            int price = (int)nmFoodPrice.Value;

            if (FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công");
                LoadListFood();
                if (insertFood != null)
                    insertFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn");
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbFoodID.Text);

            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa món thành công");
                LoadListFood();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa thức ăn");
            }
        }
        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
        #endregion
    
}