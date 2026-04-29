using Jewelry_Shop_Management;
using Microsoft.VisualBasic;
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
    public partial class CUSTOMER_MANAGEMENT : Form
    {
        int currentUserID;
        int editCustomerId = 0;
        bool isEditMode = false;
        JewellryShopEntities1 db = new JewellryShopEntities1();
        public CUSTOMER_MANAGEMENT()
        {
            InitializeComponent();
        }
        public CUSTOMER_MANAGEMENT(int userId)
        {
            InitializeComponent();
            currentUserID = userId;   // store login user id
        }
        private void btnAddCustomerDetails_Click(object sender, EventArgs e)
        {
            customer c = new customer
            {
                customername = txtName.Text,
                phone = txtContact.Text,
                address = txtAddress.Text,
                createdat = DateTime.Now
            };

            db.customers.Add(c);
            db.SaveChanges();

            MessageBox.Show("Customer Added Successfully");
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = db.customers
                .Select(x => new
                {
                    x.customerid,
                    x.customername,
                    x.phone,
                    x.address
                })
                .ToList();
        
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (isEditMode == false)
                {
                    string input = Interaction.InputBox("Enter Customer ID:", "Edit Customer", "");

                    if (string.IsNullOrEmpty(input))
                    {
                        MessageBox.Show("No ID entered!");
                        return;
                    }

                    int id;
                    if (!int.TryParse(input, out id))
                    {
                        MessageBox.Show("Invalid ID!");
                        return;
                    }

                    var c = db.customers.FirstOrDefault(x => x.customerid == id);

                    if (c != null)
                    {
                        // 🔥 store ID globally
                        editCustomerId = c.customerid;

                        txtName.Text = c.customername;
                        txtContact.Text = c.phone;
                        txtAddress.Text = c.address;

                        isEditMode = true;
                        btnEditCustomer.Text = "Update";

                        MessageBox.Show("Edit data and click Update");
                    }
                    else
                    {
                        MessageBox.Show("Customer not found!");
                    }
                }
                else
                {
                    var c = db.customers.FirstOrDefault(x => x.customerid == editCustomerId);

                    if (c != null)
                    {
                        c.customername = txtName.Text;
                        c.phone = txtContact.Text;
                        c.address = txtAddress.Text;

                        db.SaveChanges();

                        MessageBox.Show("Customer Updated Successfully");

                        // reset
                        isEditMode = false;
                        btnEditCustomer.Text = "Edit";
                        editCustomerId = 0;

                        txtName.Clear();
                        txtContact.Clear();
                        txtAddress.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDltCustomer_Click(object sender, EventArgs e)
        {

            string input = Interaction.InputBox("Enter Customer ID to Edit:", "Edit Customer", "");

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("No ID entered!");
                return;
            }

            int id;
            if (!int.TryParse(input, out id))
            {
                MessageBox.Show("Invalid ID!");
                return;
            }


            var c = db.customers.FirstOrDefault(x => x.customerid == id);

            if (c != null)
            {
                db.customers.Remove(c);
                db.SaveChanges();

                MessageBox.Show("Customer Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Customer not found");
            }
        
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentUserID == 0)
            {
                MessageBox.Show("User session not found. Please login again.");
                return;
            }

            Sales___Billing billingForm = new Sales___Billing(currentUserID);
            billingForm.Show();
            this.Hide();
        }
    }
}
