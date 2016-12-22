using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thompson
{
    static class Program
    {
        public static loginPortal initialPortal;
        // The main entry point for the application.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Skip login process for debugging
            initialPortal = new loginPortal();
            Application.Run(initialPortal);
            //Application.Run(new RentSpace("Queen's University", "13zy23"));
        }

        public static void RunApp(string organization, string username)
        {
            Application.Run(new RentSpace(organization, username));
        }

    }
}
