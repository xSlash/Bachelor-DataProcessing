using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using MainWebsite.Models;

namespace MainWebsite.Account
{
    public partial class Login : Page
    {
        private string user;
        private string password;
        private string customer;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                user = Session["Username"].ToString();
                customer = Session["Customer"].ToString();

                usernameLabel.Visible = false;
                usernameTextBox.Visible = false;

                passwordLabel.Visible = false;
                passwordTextBox.Visible = false;

                loginButton.Visible = false;
                checkLoginInfo.Visible = false;

                LoggedinLabel.Visible = true;
                logoutButton.Visible = true;

                LoggedinLabel.Text = "Logged in as: " + user + " / " + customer;
            }
        }

        protected void LogIn(object sender, EventArgs e)
        {
            WebServiceReference.InterfaceSoapClient client = new WebServiceReference.InterfaceSoapClient();
            LoggedinLabel.Text = client.Login(usernameTextBox.Text, passwordTextBox.Text);
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            WebServiceReference.InterfaceSoapClient client = new WebServiceReference.InterfaceSoapClient();
            //LoggedinLabel.Text = client.Login(usernameTextBox.Text, passwordTextBox.Text);

            user = usernameTextBox.Text;
            password = passwordTextBox.Text;
            //Label1.Text = user;
            customer = client.Login(user, password);
            //customer = "RegionH";
            Session["Username"] = usernameTextBox.Text;
            Session["Customer"] = customer;

            LoggedinLabel.Text = "Logged in as: " + user + " / " + customer;

            Response.Redirect("/Default.aspx");
        }

        protected void checkLoginInfo_Click(object sender, EventArgs e)
        {

        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {

        }
    }
}