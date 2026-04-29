using Jewelry_Shop_Management;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Jewlery_Shop_Management
{
    public partial class Inventory_Screen : Form
    {
        int currentUserID;
        JewellryShopEntities1 db = new JewellryShopEntities1();

        int selectedItemId = 0;

        public Inventory_Screen()
        {
            InitializeComponent();
        }
        public Inventory_Screen(int userId)
        {
            InitializeComponent();
            currentUserID = userId;
        }
        private void Inventory_Screen_Load(object sender, EventArgs e)
        {
            cmbFilter.Items.Add("All");
            cmbFilter.Items.Add("Low Stock");
            cmbFilter.Items.Add("Available");

            cmbFilter.SelectedIndex = 0;

            LoadInventory();
        }

        // ================= LOAD INVENTORY =================
        private void LoadInventory()
        {
            var data = db.jewelleries.AsQueryable();

            // SEARCH
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                data = data.Where(x => x.itemname.Contains(txtSearch.Text));
            }

            // FILTER
            if (cmbFilter.Text == "Low Stock")
            {
                data = data.Where(x => x.stockquantity < 5);
            }
            else if (cmbFilter.Text == "Available")
            {
                data = data.Where(x => x.stockquantity > 0);
            }

            dgvInventory.DataSource = data.Select(x => new
            {
                x.itemid,
                x.itemname,
                x.category,
                x.price,
                x.stockquantity
            }).ToList();
        }

        // ================= SEARCH =================
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadInventory();
        }

        // ================= FILTER =================
        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadInventory();
        }

        // ================= GRID SELECT =================
        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // 🔥 FIX CRASH
            {
                selectedItemId = Convert.ToInt32(
                    dgvInventory.Rows[e.RowIndex].Cells[0].Value
                );
            }
        }

        // ================= UPDATE STOCK =================
        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            if (selectedItemId == 0)
            {
                MessageBox.Show("Please select an item first");
                return;
            }

            var item = db.jewelleries.FirstOrDefault(x => x.itemid == selectedItemId);

            if (item != null)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter new stock quantity:",
                    "Update Stock",
                    item.stockquantity.ToString()
                );

                int newStock;

                if (int.TryParse(input, out newStock))
                {
                    item.stockquantity = newStock;
                    db.SaveChanges();

                    MessageBox.Show("Stock Updated Successfully");

                    LoadInventory();
                }
                else
                {
                    MessageBox.Show("Invalid stock value");
                }
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentUserID == 0)
            {
                MessageBox.Show("User session not found. Please login again.");
                return;
            }

            Sales_Report s  = new Sales_Report(currentUserID);
            s.Show();
            this.Hide();
        }
    }
}
