using Jewlery_Shop_Management;
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Jewelry_Shop_Management
{
    public partial class Sales___Billing : Form
    {
        JewellryShopEntities1 db = new JewellryShopEntities1();
        int currentUserID;
        DataTable bill = new DataTable();
        decimal grandTotal = 0;

        public Sales___Billing()
        {
            InitializeComponent();
        }
        public Sales___Billing(int userId)
        {
            InitializeComponent();
            currentUserID = userId;   // store login user id
        }
        private void Sales___Billing_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadItems();
            CreateBillTable();
        }

        // =========================
        // LOAD CUSTOMERS
        // =========================
        private void LoadCustomers()
        {
            cmbCustomer.DataSource = db.customers.ToList();
            cmbCustomer.DisplayMember = "customername";
            cmbCustomer.ValueMember = "customerid";
        }

        // =========================
        // LOAD ITEMS
        // =========================
        private void LoadItems()
        {
            cmbItem.DataSource = db.jewelleries.ToList();
            cmbItem.DisplayMember = "itemname";
            cmbItem.ValueMember = "itemid";
        }

        // =========================
        // BILL TABLE
        // =========================
        private void CreateBillTable()
        {
            bill.Columns.Add("ItemID");
            bill.Columns.Add("Item Name");
            bill.Columns.Add("Price");
            bill.Columns.Add("Quantity");
            bill.Columns.Add("Total");

            dgvBill.DataSource = bill;
        }

        // =========================
        // ADD TO BILL
        // =========================
        private void btnAddToBill_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "")
            {
                MessageBox.Show("Enter Quantity");
                return;
            }

            int itemId = Convert.ToInt32(cmbItem.SelectedValue);
            int qty = Convert.ToInt32(txtQuantity.Text);

            var item = db.jewelleries.FirstOrDefault(x => x.itemid == itemId);

            if (item == null)
            {
                MessageBox.Show("Item Not Found");
                return;
            }

            if (qty > item.stockquantity)
            {
                MessageBox.Show("Not Enough Stock");
                return;
            }

            decimal price = Convert.ToDecimal(item.price);
            decimal total = price * qty;

            bill.Rows.Add(item.itemid, item.itemname, price, qty, total);

            grandTotal += total;
            txtBill.Text = grandTotal.ToString();

            txtQuantity.Clear();
        }

        // =========================
        // GENERATE INVOICE
        // =========================
        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            if (bill.Rows.Count == 0)
            {
                MessageBox.Show("Add Items First");
                return;
            }

            // ✅ SAFE CUSTOMER ID FETCH
            if (cmbCustomer.SelectedValue == null)
            {
                MessageBox.Show("Please select a customer");
                return;
            }

            if (cmbCustomer.SelectedValue == null || cmbCustomer.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                MessageBox.Show("Invalid customer selected");
                return;
            }

            int customerId;
            if (!int.TryParse(cmbCustomer.SelectedValue.ToString(), out customerId))
            {
                MessageBox.Show("Customer ID is invalid");
                return;
            }

            // ⚠️ Name should also come from selected row (not Text)
            string customerName = cmbCustomer.Text;

            try
            {
                // =========================
                // SAVE SALE
                // =========================
                sale s = new sale()
                {
                    customerid = customerId,
                    saledate = DateTime.Now,
                    totalamount = grandTotal,
                    userid = currentUserID 
                };

                db.sales.Add(s);
                db.SaveChanges();

                int saleId = s.saleid;

                // =========================
                // SAVE SALE DETAILS
                // =========================
                foreach (DataRow row in bill.Rows)
                {
                    saledetail sd = new saledetail()
                    {
                        saleid = saleId,
                        itemid = Convert.ToInt32(row["ItemID"]),
                        quantity = Convert.ToInt32(row["Quantity"]),
                        price = Convert.ToDecimal(row["Price"])
                    };

                    db.saledetails.Add(sd);
                }

                db.SaveChanges();

                // =========================
                // INVOICE GENERATION
                // =========================
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("==================================");
                sb.AppendLine("     TWIN SISTERS JEWELRY");
                sb.AppendLine("==================================");
                sb.AppendLine("Invoice No : " + saleId);
                sb.AppendLine("Date       : " + DateTime.Now.ToString("dd-MM-yyyy HH:mm"));
                sb.AppendLine("Customer   : " + customerName);
                sb.AppendLine("----------------------------------");

                sb.AppendLine("Item\tQty\tPrice\tTotal");

                foreach (DataRow row in bill.Rows)
                {
                    string itemName = row.Table.Columns.Contains("Item Name")
                        ? row["Item Name"].ToString()
                        : "Unknown Item";

                    int qty = Convert.ToInt32(row["Quantity"]);
                    decimal price = Convert.ToDecimal(row["Price"]);
                    decimal total = Convert.ToDecimal(row["Total"]);

                    sb.AppendLine($"{itemName}\t{qty}\t{price}\t{total}");
                }

                sb.AppendLine("----------------------------------");
                sb.AppendLine("Grand Total : " + grandTotal);
                sb.AppendLine("==================================");
                sb.AppendLine("   Thank You For Shopping");
                sb.AppendLine("==================================");

                richBoxInvoice.Text = sb.ToString();

                MessageBox.Show("Invoice Generated Successfully");

                // =========================
                // RESET
                // =========================
                bill.Rows.Clear();
                grandTotal = 0;
                txtBill.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}