using System;
using mshtml;
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
    public partial class loginPopUp : Form
    {
        String organization;
        String username;

        public loginPopUp(object sender, String inputOrg)
        {
            InitializeComponent();
            organization = inputOrg;
            username = null;

            // Determine login portal
            if(organization == "Queen's University")
            {
                loginBrowser.Navigate("http://my.queensu.ca");
            }
            else if(organization == "University of Western Ontario")
            {
                loginBrowser.Navigate("http://WESTERNLOGINPORTAL.ca");
            }
            else
            {
                MessageBox.Show("Illegal facility! Please select a valid facility.");
                Close();
            }
            
        }

        private void loginBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            String url = loginBrowser.Url.ToString();
            if (loginBrowser.Url.ToString() == "https://my.queensu.ca/")
            {
                Close();
                //Program.initialPortal.Close();
                Program.initialPortal.Visible = false;
                RentSpace mainApplication = new RentSpace(organization, username);
                mainApplication.Show();
                //Program.RunApp(organization, username);
                MessageBox.Show("Successful login!\nUsername: " + username);

            }
            else
            {
                //MessageBox.Show("Unsuccessful login! Please try again.");
                //loginBrowser.Navigate("http://my.queensu.ca");
            }
        }

        private void loginBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (loginBrowser.Document != null)
            {
                HtmlElement inputHtmlElement = loginBrowser.Document.GetElementById("j_username");
                IHTMLElement inputDomElement = null;
                IHTMLInputElement inputElement = null;

                inputDomElement = (IHTMLElement)inputHtmlElement.DomElement;
                inputElement = (IHTMLInputElement)inputDomElement;
                username = (String)inputElement.value;
            }
        }
    }
}
