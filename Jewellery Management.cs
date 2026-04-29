using Jewelry_Shop_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jewlery_Shop_Management
{
    public partial class JewelleryManagement : Form
    {
        int currentUserID;
        public JewelleryManagement()
        {
            InitializeComponent();
        }
        public JewelleryManagement(int userId)
        {
            InitializeComponent();
            currentUserID = userId;
        }
        private void LoadJewellery()
        {
            JewellryShopEntities1 db = new JewellryShopEntities1();

            dgvViewItem.DataSource = db.jewelleries
                .Select(x => new
                {
                    x.itemid,
                    x.itemname,
                    x.category,
                    x.price,
                    x.stockquantity
                })
                .ToList();
        }

        private void JewelleryManagement_Load(object sender, EventArgs e)
        {
            LoadJewellery();
        }

        private void btnAddJewelryItem_Click(object sender, EventArgs e)
        {
            JewellryShopEntities1 db = new JewellryShopEntities1();

            jewellery j = new jewellery
            {
                itemname = txtName.Text,
                category = txtCategory.Text,
                price = Convert.ToDecimal(txtPrice.Text),
                stockquantity = Convert.ToInt32(txtStock.Text),
                createdat = DateTime.Now
            };

            db.jewelleries.Add(j);
            db.SaveChanges();

            MessageBox.Show("Item Added to Database");
        }

        private void btnDltItem_Click(object sender, EventArgs e)
        {
            JewellryShopEntities1 db = new JewellryShopEntities1();

            int id = Convert.ToInt32(txtID.Text);

            var j = db.jewelleries.FirstOrDefault(x => x.itemid == id);

            if (j != null)
            {
                db.jewelleries.Remove(j);
                db.SaveChanges();

                MessageBox.Show("Item Deleted");
                LoadJewellery();
            }
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            JewellryShopEntities1 db = new JewellryShopEntities1();

            int id = Convert.ToInt32(txtID.Text);

            var j = db.jewelleries.FirstOrDefault(x => x.itemid == id);

            if (j != null)
            {
                j.itemname = txtName.Text;
                j.category = txtCategory.Text;
                j.price = Convert.ToDecimal(txtPrice.Text);
                j.stockquantity = Convert.ToInt32(txtStock.Text);

                db.SaveChanges();

                MessageBox.Show("Item Updated");
                LoadJewellery();
            }
        }

        private void btnViewNewItem_Click(object sender, EventArgs e)
        {
            JewellryShopEntities1 db = new JewellryShopEntities1();

            dgvViewItem.DataSource = db.jewelleries
                .Select(x => new
                {
                    x.itemid,
                    x.itemname,
                    x.category,
                    x.price,
                    x.stockquantity
                })
                .ToList();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentUserID == 0)
            {
                MessageBox.Show("User session not found. Please login again.");
                return;
            }

            Inventory_Screen billingForm = new Inventory_Screen(currentUserID);
            billingForm.Show();
            this.Hide();
        }
    }
}
