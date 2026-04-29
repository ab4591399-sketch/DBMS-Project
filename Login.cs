using Jewelry_Shop_Management;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Jewlery_Shop_Management
{
    public partial class LoginForm : Form
    {
        JewellryShopEntities1 db = new JewellryShopEntities1();

        public LoginForm()
        {
            InitializeComponent();
        }

        // ================= LOGIN =================
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string role = rdoAdmin.Checked ? "Admin" : "Employee";

            var user = db.users.FirstOrDefault(x =>
                x.username == txtUserName.Text &&
                x.password == txtPassword.Text);

            if (user != null)
            {
                if (user.role.Trim().ToLower() == role.Trim().ToLower())
                {
                    MessageBox.Show("Login Successful");

                    if (role == "Employee")
                    {
                        CUSTOMER_MANAGEMENT f = new CUSTOMER_MANAGEMENT(user.userid);
                        f.Show();
                        this.Hide();
                    }
                    else if (role == "Admin")
                    {
                        JewelleryManagement f = new JewelleryManagement(user.userid);
                        f.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Role mismatch! You selected wrong role.");
                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");

                Signup s = new Signup();
                s.Show();
                this.Hide();
            }
        }

        // ================= FORGOT PASSWORD (SIMPLE) =================
        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            var user = db.users.FirstOrDefault(x => x.username == txtUserName.Text);

            if (user == null)
            {
                MessageBox.Show("Enter correct username first");
                return;
            }

            // STEP 1: GENERATE OTP
            Random r = new Random();
            string otp = r.Next(1000, 9999).ToString();

            user.otp = otp;
            db.SaveChanges();

            // SHOW OTP (BASIC - NO EMAIL)
            MessageBox.Show("Your OTP is: " + otp);

            // STEP 2: ENTER OTP
            string inputOtp = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter OTP:",
                "OTP Verification",
                ""
            );

            if (user != null)
            {
                if (user.otp != null && inputOtp == user.otp)
                {
                    string newPass = Microsoft.VisualBasic.Interaction.InputBox(
                        "Enter New Password:",
                        "Reset Password",
                        ""
                    );

                    user.password = newPass;
                    user.otp = null;

                    db.SaveChanges();

                    MessageBox.Show("Password Reset Successful");
                }
                else
                {
                    MessageBox.Show("Invalid OTP");
                }
            }
            else
            {
                MessageBox.Show("User not found");
            }
        }
    }
}