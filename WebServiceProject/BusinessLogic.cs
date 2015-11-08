using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceProject
{
    public class BusinessLogic
    {
        

        public BusinessLogic()
        {
            
        }

        public string HelloWorldBusinessLogic()
        {
            DataAccess da = new DataAccess();
            return da.HelloWorldDataAccess();
        }

        public string Login(string username, string password)
        {
            DataAccess da = new DataAccess();

            if (da.checkLogin(username, password))
            {
                return da.getCustomerForUser(username);
            }
            else
            {
                return "Username & password doesn't match";
            }

        }

        public string AddUser(string username, string password, string customer)
        {
            DataAccess da = new DataAccess();

            if (!da.UserExist(username))
            {
                if (da.Adduser(username, password, customer))
                {
                    return "User added";
                }
                else
                {
                    return "Failed to add user";
                }
            }
            else
            {
                return "User already exist. Please pick another username";
            }

        }

        public string AddEventForType(string type, string action, string description, string customer)
        {
            DataAccess da = new DataAccess();
            if (da.TypeExist(type, customer))
            {
                if (da.ActionExistForType(type, action, customer))
                {
                    return "'" + action + "' event already exist for " + type;
                }
                else
                {
                    //Tilføjer event til en type
                    if (da.AddEventForType(type, action, description, customer))
                    {
                        return "'" + action + "' event added to " + type;
                    }
                    else
                    {
                        return "failed to add '" + action + "' for " + type;
                    }
                }

                    
                
            }
            else
            {
                //Lav typen af enhed hos kunden
                if (da.AddType(type, customer))
                {
                    //Tilføjer event til en type
                    if (da.AddEventForType(type, action, description, customer))
                    {
                        return "'" + action + "' event added to " + type;
                    }
                    else
                    {
                        return "failed to add '" + action + "' for " + type;
                    }
                }
                else
                {
                    return type + " type doesn't exist & failed to add it";
                }
                
            }


        }

        public bool doSpecialEvent(string unitID, string action, string customer)
        {
            DataAccess da = new DataAccess();

            switch (customer)
            {
                case "RegionH":
                    switch (action)
                    {
                        case "A":
                            return da.AwakeAction(unitID);

                        case "F":
                            return da.FlushAction(unitID);

                        case "S":
                            return da.SoapAction(unitID);

                        default:
                            //Not a special event for RegionH
                            return false;

                    }
                
                case "Lundbeck":
                    switch (action)
                    {
                        case "On":
                            return true;

                        case "Off":
                            return true;

                        default:
                            //Not a special event for Lundbeck
                            return false;
                    }

                default:
                    return false;
            }
        }

        public string AddLog(string unitID, DateTime timestamp, string action)
        {
            DataAccess da = new DataAccess();

            //Send til generelt log table
            if (da.AddLogToMainTable(unitID, timestamp, action))
            {
                //Find out which customer got the ID, then go to below IF statement

                if (da.UnitExist(unitID))
                {
                    string customer = da.getCustomerForUnit(unitID);

                    //RegionH should be replaced by customer
                    if (da.UnitExist(unitID, customer))
                    {
                        if (da.EventExistForUnit(unitID, action))
                        {
                            if (da.AddLog(unitID, timestamp, action))
                            {
                                if (doSpecialEvent(unitID, action, customer))
                                {
                                    return "Log added, special event";
                                }
                                else
                                {
                                    return "Log added, no special event";
                                }

                            }
                            else
                            {
                                return "Log added to main table - Failed to add to customer table";
                            }

                        }
                        else
                        {
                            return "Log added to main table - Action not found for unit";
                        }
                    }
                    else
                    {
                        return "Log added to main database - Unit not found in a customer table";
                    }
                }
                else
                {
                    return "Log added to main table - Unit not mapped to a customer";
                }


                
            }

            //Failed to add log to main database
            else
            {
                return "Failed to add log to main database";
            }
            

            

            
        }

        public string AddCustomer(string customer)
        {
            DataAccess da = new DataAccess();
            //Check om Customer allerede findes
            if (!da.customerExist(customer))
            {
                if (da.AddCustomer(customer))
                {
                    return "Customer added";
                }
                else
                {
                    return "Error, while adding customer";
                }
            }
            else
            {
                return "Customer already exist";
            }

        }

        public string AddType(string type, string customer)
        {
            DataAccess da = new DataAccess();
            if (!da.TypeExist(type, customer))
            {
                if (da.AddType(type, customer))
                {
                    return type + " type added";
                }
                else
                {
                    return "Error, while adding type";
                }
            }
            else
            {
                return "Type already exist";
            }

        }


        //Add it to Customer database, and the selected customers database.
        public string AddUnitForCustomer(string UnitID, string Room, string type, string customer)
        {
            DataAccess da = new DataAccess();
            if (da.AddUnitToCustomerTable(UnitID, customer))
            {

                switch (customer)
                {
                    case "RegionH":
                        if (da.AddUnit(UnitID, Room, type, customer))
                        {

                            switch (type)
                            {
                                case "Soapdispenser":
                                    if (da.AddSoapDataSet(UnitID))
                                    {
                                        return "Unit added to the system, as Soapdispenser";
                                    }
                                    else
                                    {
                                        return "Unit added, but failed to add Soap data";
                                    }
                                    

                                default:

                                    return "Unit added, but type doesn't have any special function";
                            }


                        }
                        else
                        {
                            return "Unit not added to RegionH database";
                        }

                    case "something":

                        return "something!";

                    default:

                        return "Customer not valid";
                }

            }
            else
            {
                return "Error - Couldn't add unit to Customer table";
            }
            
            
        }

        //Check for om hvor vidt kunden / unit / rum eller typen eksisterer i forvejen
        public string AddUnit(string UnitID, string Room, string type, string customer)
        {
            DataAccess da = new DataAccess();

            if (!da.UnitExist(UnitID))
            {
                if (da.customerExist(customer))
                {
                    if (!da.UnitExist(UnitID, customer))
                    {
                        if (da.TypeExist(type, customer))
                        {
                            if (da.RoomExist(Room, customer))
                            {
                                return AddUnitForCustomer(UnitID, Room, type, customer);
                            }
                            else
                            {
                                //Lav room
                                if (da.AddRoom(Room, customer))
                                {
                                    return AddUnitForCustomer(UnitID, Room, type, customer);
                                }
                                else
                                {
                                    return "Failed to add room";
                                }
                            }

                        }
                        else
                        {
                            if (da.AddType(type, customer))
                            {
                                if (da.RoomExist(Room, customer))
                                {
                                    return AddUnitForCustomer(UnitID, Room, type, customer);
                                }
                                else
                                {
                                    //Create room
                                    if (da.AddRoom(Room, customer))
                                    {
                                        return AddUnitForCustomer(UnitID, Room, type, customer);
                                    }
                                    else
                                    {
                                        return "Failed to add room";
                                    }
                                }
                            }
                            else
                            {
                                return "Failed to add type";
                            }

                        }
                    }
                    else
                    {
                        return "Unit already exist in your database";
                    }
                }
                else
                {
                    return "customer doesn't exist";
                }
   
            }
            else
            {
                return "Unit already exist in Customer Database";
            }
  
            
        }

    }
}