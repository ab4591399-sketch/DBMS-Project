using Jewlery_Shop_Management;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Objects;
namespace Jewelry_Shop_Management
{
    public partial class Sales_Report : Form
    {
        int currentUserID;
        JewellryShopEntities1 db = new JewellryShopEntities1();

        public Sales_Report()
        {
            InitializeComponent();
        }
        public Sales_Report(int userId)
        {
            InitializeComponent();
            currentUserID = userId;
        }

        private void Sales_Report_Load(object sender, EventArgs e)
        {
            cmbFilter.Items.Add("Today");
            cmbFilter.Items.Add("Monthly");
            cmbFilter.Items.Add("All");
            cmbFilter.SelectedIndex = 0;
        }

        // ===================================
        // VIEW SALES REPORT
        // ===================================
        private void btnViewSalesReport_Click(object sender, EventArgs e)
        {
            // Strip the time from the picker value for comparison
            DateTime selectedDate = dtpReportDate.Value.Date;

            if (cmbFilter.Text == "Today")
            {
                var data = db.sales
                    // Use EntityFunctions.TruncateTime to compare only the Date part in SQL
                    .Where(x => EntityFunctions.TruncateTime(x.saledate) == selectedDate)
                    .Select(x => new
                    {
                        Date = x.saledate,
                        InvoiceTotal = x.totalamount,
                        Profit = x.totalamount * 0.20m,
                        PaymentMethod = "Cash",
                        Amount = x.totalamount
                    }).ToList();

                dgvSales.DataSource = data;
            }
            else if (cmbFilter.Text == "Monthly")
            {
                var data = db.sales
                    // Use EntityFunctions for Month and Year parts
                    .Where(x => EntityFunctions.DiffMonths(x.saledate, selectedDate) == 0 &&
                                EntityFunctions.DiffYears(x.saledate, selectedDate) == 0)
                    .Select(x => new
                    {
                        Date = x.saledate,
                        InvoiceTotal = x.totalamount,
                        Profit = x.totalamount * 0.20m,
                        PaymentMethod = "Cash",
                        Amount = x.totalamount
                    }).ToList();

                dgvSales.DataSource = data;
            }
            else
            {
                // "All" filter remains the same as it doesn't use date filtering
                var data = db.sales
                    .Select(x => new
                    {
                        Date = x.saledate,
                        InvoiceTotal = x.totalamount,
                        Profit = x.totalamount * 0.20m,
                        PaymentMethod = "Cash",
                        Amount = x.totalamount
                    }).ToList();

                dgvSales.DataSource = data;
            }
        }

        // ===================================
        // CUSTOMER PURCHASE HISTORY
        // ===================================
        private void btnCustomerPurchaseHistory_Click(object sender, EventArgs e)
        {
            var data = db.sales
                .Join(db.customers,
                      s => s.customerid,
                      c => c.customerid,
                      (s, c) => new { s, c })
                .Select(x => new
                {
                    CustomerID = x.c.customerid,
                    PurchaseItem = x.s.saleid,
                    Date = x.s.saledate,
                    Amount = x.s.totalamount,
                    ContactNo = x.c.phone
                }).ToList();

            dgvCustomerHistroy.DataSource = data;
        }

        // ===================================
        // VIEW STOCK UPDATES
        // ===================================
        private void btnViewStockUpdates_Click(object sender, EventArgs e)
        {
            var data = db.jewelleries
                .Select(x => new
                {
                    TotalStock = x.stockquantity,
                    Sold = db.saledetails
                           .Where(y => y.itemid == x.itemid)
                           .Sum(y => (int?)y.quantity) ?? 0,

                    Remaining = x.stockquantity,

                    OldStock = x.stockquantity +
                               (db.saledetails
                               .Where(y => y.itemid == x.itemid)
                               .Sum(y => (int?)y.quantity) ?? 0),

                    Items = x.itemname,

                    Status = x.stockquantity <= 5 ? "Low Stock" : "Available"
                }).ToList();

            dgvStock.DataSource = data;
        }
    }
}