using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thompson
{
    public partial class loginPortal : Form
    {
        private String organization;

        public loginPortal()
        {
            InitializeComponent();
            // Initialize organization
            organization = null;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Initialize login screen
            if(organization == "Queen's University")
            {
                // Initialize login pop-up
                loginPopUp login = new loginPopUp(sender, organization);
                login.Show();
                // Activate hidden login view while pop-up is exposed
                // TBD
            }
            else if(organization == "University of Western Ontario")
            {
                MessageBox.Show("UWO login selected!\n\nThis is an example of how the RentSpace framework can be expanded to different organizations.");
            }
        }

        // Update organization value from combo box
        private void organizationCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            organization = (string) comboBox.SelectedItem;
            
            // Debug combo box values 
            //MessageBox.Show("New facility!\n" + organization);

        }
    }
}
