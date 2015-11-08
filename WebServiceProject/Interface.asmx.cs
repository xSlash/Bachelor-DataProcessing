using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Threading;

namespace WebServiceProject
{
    /// <summary>
    /// Summary description for Interface
    /// </summary>
    //[WebService(Namespace = "http://tempuri.org/")]
    [WebService(Namespace = "http://grandt.us:90/WebService/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Interface : System.Web.Services.WebService
    {
        [WebMethod]
        public int HelloAdd(int a, int b)
        {

            return a + b;
        }

        [WebMethod]
        public string TestMethod(int i)
        {
            Thread.Sleep(10000);
            return i + " slept. ";
        }


        [WebMethod]
        public string HelloWorld()
        {
            BusinessLogic bl = new BusinessLogic();
            //bl.HelloWorldBusinessLogic();

            return bl.HelloWorldBusinessLogic();
        }

        [WebMethod]
        public string Login(string username, string password)
        {
            BusinessLogic bl = new BusinessLogic();

            return bl.Login(username, password);
        }

        [WebMethod]
        public string AddUser(string username, string password, string customer)
        {
            BusinessLogic bl = new BusinessLogic();

            return bl.AddUser(username, password, customer);
        }

        [WebMethod]
        public string AddEventForType(string type, string action, string description, string customer) 
        {
            BusinessLogic bl = new BusinessLogic();

            return bl.AddEventForType(type, action, description, customer);
        }

        [WebMethod]
        public string AddCustomer(string customer)
        {
            BusinessLogic bl = new BusinessLogic();
            return bl.AddCustomer(customer);
        }

        [WebMethod]
        public string AddLog(string ID, DateTime timestamp, string action)
        {
            BusinessLogic bl = new BusinessLogic();

            return bl.AddLog(ID, timestamp, action);
        }

        [WebMethod]
        public string AddType(string type, string customer)
        {
            BusinessLogic bl = new BusinessLogic();

            return bl.AddType(type, customer);
        }

        [WebMethod]
        public string AddUnit(string UnitID, string Room, string type, string customer)
        {
            BusinessLogic bl = new BusinessLogic();
            return bl.AddUnit(UnitID, Room, type, customer);
        }
    }
}
