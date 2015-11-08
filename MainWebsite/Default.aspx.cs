using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MainWebsite
{
    public partial class _Default : Page
    {
        //WebServiceReference.InterfaceSoapClient client;
        //int i = 0;
        private string user;
        private string password;
        private string customer;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            //client = WebServiceReference.InterfaceSoapClient();
            //user = usernameTextBox.Text;
            //customer = ;
            if (Session["Username"] != null)
            {
                user = Session["Username"].ToString();
                customer = Session["Customer"].ToString();

                //usernameLabel.Visible = false;
                //usernameTextBox.Visible = false;

                //passwordLabel.Visible = false;
                //passwordTextBox.Visible = false;

                LoggedinLabel.Visible = true;


                LoggedinLabel.Text = "Logged in as: " + user + " / " + customer;
            }
        }

        private static void callTestMethod(int i)
        {
            WebServiceReference.InterfaceSoapClient client = new WebServiceReference.InterfaceSoapClient();
            //client.TestMethod(1);
            client.AddLog("T10000Unit", DateTime.Now, "T10000");

        }


        protected async void Button1_Click(object sender, EventArgs e)
        {
            WebServiceReference.InterfaceSoapClient client = new WebServiceReference.InterfaceSoapClient();

            

            /*TimeSpan dt1 = DateTime.Now.TimeOfDay;
            Label1.Text = client.TestMethod(1);
            TimeSpan dt2 = DateTime.Now.TimeOfDay;
            TimeSpan dt3 = dt2 - dt1;
            Label1.Text = dt3.ToString();*/

            int i = 10000;
            int[] arrayint = new int[i];

            for (int j = 0; j < i; j++) 
            {
                arrayint[j] = j;
            }

            for (int k = 0; k < 10; k++)
            {
                TimeSpan dt1 = DateTime.Now.TimeOfDay;
                await Task.Run(() => Parallel.ForEach(arrayint, ii =>
                {
                    callTestMethod(ii);
                }));

                TimeSpan dt2 = DateTime.Now.TimeOfDay;

                TimeSpan dt3 = dt2 - dt1;
                Label1.Text += "Attempt " + (k + 1) + " - " + dt3.TotalSeconds.ToString() + " | ";
            }

            //Label1.Text += client.AddLog("11111111", DateTime.Now, "On");
            /*Label1.Text += client.AddLog("11111111", DateTime.Now.AddMinutes(3), "Off");
            Label1.Text += client.AddLog("11111111", DateTime.Now.AddMinutes(11), "On");
            Label1.Text += client.AddLog("11111111", DateTime.Now.AddMinutes(15), "Off");
            Label1.Text += client.AddLog("11111111", DateTime.Now.AddMinutes(20), "On");*/

            

            //Label1.Text = client.AddType("Sometype", "RegionH");

            /*Label1.Text = client.AddCustomer("RegionH") + " ";
            Label1.Text += client.AddUnit("11111111", "X.15", "Light", "RegionH") + " ";
            Label1.Text += client.AddEventForType("Light", "On", "Light is ON", "RegionH") + " ";
            Label1.Text += client.AddEventForType("Light", "Off", "Light is OFF", "RegionH") + " ";
            Label1.Text += client.AddLog("11111111", DateTime.Now, "On");
            Label1.Text += client.AddLog("11111111", DateTime.Now.AddMinutes(3), "Off");
            Label1.Text += client.AddLog("11111111", DateTime.Now.AddMinutes(11), "On");
            Label1.Text += client.AddLog("11111111", DateTime.Now.AddMinutes(15), "Off");
            Label1.Text += client.AddLog("11111111", DateTime.Now.AddMinutes(20), "On");*/

            //Label1.Text = client.AddType("Soapdispenser", "RegionH");
            
            //Label1.Text = client.Testmethod("52151", DateTime.Now, "F");

            //Label1.Text = client.AddActionForType("Soapdispenser", "S", "Soap dispense command", "RegionH");

            //Label1.Text = client.AddEventForType("light", "On", "Determines if the unit is ON", "RegionH");

            //Label1.Text = client.AddLog("LightReal", DateTime.Now, "On");
            

            //Label1.Text = client.AddUnit("LightReal", "X5.1", "light", "RegionH");
            //Label1.Text = client.AddActionForType("Sometype", "TE", "Test event", "RegionH");

            //Send log
            //Label1.Text = client.AddLog("11111111", DateTime.Now, "F");
        }

        //async metode, for at kunne køre 'await Task.Run'
        protected async void Button2_Click(object sender, EventArgs e)
        {

            WebServiceReference.InterfaceSoapClient client = new WebServiceReference.InterfaceSoapClient();

            

            //Label1.Text = client.AddUser("martin", "pw", "RegionH");
            //Label1.Text = client.AddLog("TU845", DateTime.Now, "TTGT");
            //Label1.Text = client.AddCustomer("RegionH");
            //Label1.Text = client.AddUnit("RH123", "Storage", "Soapdispenser", "RegionH");
            //Label1.Text = client.AddEventForType("Soapdispenser", "S", "Dispense soap", "RegionH");
            //Label1.Text = client.AddLog("RH123", DateTime.Now, "M");
            //Label1.Text = client.AddEventForType("Soapdispenser", "Q", "Test action", "RegionH");
            
            /*int i = 1;
            int[] arrayint = new int[i];

            for (int j = 0; j < i; j++)
            {
                arrayint[j] = j;
            }


            for (int k = 0; k < 10; k++)
            {
                TimeSpan dt1 = DateTime.Now.TimeOfDay;
                await Task.Run(() => Parallel.ForEach(arrayint, ii =>
                {
                    callTestMethod(ii);
                }));

                TimeSpan dt2 = DateTime.Now.TimeOfDay;

                TimeSpan dt3 = dt2 - dt1;
                Label1.Text += "Attempt " + (k+1) + " - " + dt3.TotalSeconds.ToString() + " | ";
            }*/

            
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            //user = usernameTextBox.Text;
            //Label1.Text = user;

            //customer = "RegionH";
            //Session["Username"] = user;
            //Session["Customer"] = customer;

            //LoggedinLabel.Text = "Logged in as: " + user + " / " + customer;
        }

        protected void checkLoginInfo_Click(object sender, EventArgs e)
        {
            Label1.Text = user + " & " + customer;
        }
    }
}