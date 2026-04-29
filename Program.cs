using Jewelry_Shop_Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jewlery_Shop_Management
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
            Application.Run(new Signup());
            Application.Run(new LoginForm());
            Application.Run(new JewelleryManagement());
            Application.Run(new CUSTOMER_MANAGEMENT());
            Application.Run(new Inventory_Screen());
            Application.Run(new Sales___Billing());
            Application.Run(new Sales_Report());
        }
    }
}
