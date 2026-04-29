using System;
using System.Linq;
using System.Windows.Forms;

namespace Jewlery_Shop_Management
{
    public partial class Signup : Form
    {
        JewellryShopEntities1 db = new JewellryShopEntities1();
        public Signup()
        {
            InitializeComponent();
            LoadCountries();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }
        void LoadCountries()
        {
            cmbCountry.Items.Add("Pakistan");
            cmbCountry.Items.Add("USA");
            cmbCountry.Items.Add("UK");

            cmbCity.Items.Add("Rawalpindi");
            cmbCity.Items.Add("Lahore");
            cmbCity.Items.Add("Karachi");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // ================= GET VALUES =================
            string FullName = txtName.Text.Trim();
            string username = txtUserName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPass.Text.Trim();
            string contact = txtContact.Text.Trim();

            string country = cmbCountry.Text;
            string city = cmbCity.Text;

            string maritalStatus = rdoSingle.Checked ? "single" :
                                   rdoMarried.Checked ? "married" : "";

            string gender = rdoMale.Checked ? "male" :
                            rdoFemale.Checked ? "female" : "";

            // ================= VALIDATION =================
            if (string.IsNullOrWhiteSpace(FullName) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Fill all required fields!");
                return;
            }

            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please select Gender!");
                return;
            }

            if (string.IsNullOrEmpty(maritalStatus))
            {
                MessageBox.Show("Please select Marital Status!");
                return;
            }

            // ================= DUPLICATE CHECK =================
            var existUser = db.users.FirstOrDefault(x => x.username == username);
            if (existUser != null)
            {
                MessageBox.Show("Username already exists!");
                return;
            }

            if (!string.IsNullOrWhiteSpace(email))
            {
                var existEmail = db.users.FirstOrDefault(x => x.email == email);
                if (existEmail != null)
                {
                    MessageBox.Show("Email already exists!");
                    return;
                }
            }

            // ================= ROLE =================
            string role = "employee";

            if (chkIsAdmin.Checked)
            {
                if (txtAdminKey.Text == "1234")
                    role = "admin";
                else
                {
                    MessageBox.Show("Invalid Admin Key → Registered as Employee");
                    role = "employee";
                }
            }

            // ================= CREATE USER =================
            user u = new user
            {
                fullname = FullName,
                username = username,
                email = string.IsNullOrWhiteSpace(email) ? null : email,
                password = password,
                contactno = contact,
                country = country,
                city = city,
                gender = gender,                 // must be "male" or "female"
                maritalstatus = maritalStatus,   // must be "single" or "married"
                role = role,                     // must be "admin" or "employee"
                createdat = DateTime.Now
            };

            // ================= SAVE =================
            try
            {
                db.users.Add(u);
                db.SaveChanges();

                MessageBox.Show("Signup Successful as " + role);

                // redirect
                this.Hide();
                new LoginForm().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
        }
    }
}
