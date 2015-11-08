using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceProject
{
    public class DataAccess
    {
        public DataAccess()
        {

        }

        public string HelloWorldDataAccess()
        {
            return "Hello World Data Access";
        }

        /*public string getCustomerForUnit(string unitID)
        {
            try
            {
                using (var db = new CustomerEntities())
                {
                    var cust = db.Main_Bridge_Customer_UnitSet.Where(o => o.Main_Dim_UnitSet.UnitID.Equals(unitID)).First();

                    return cust.Main_Dim_CustomerSet.Customer_name;
                }
                
            }
            catch (Exception ex)
            {
                return "Failed to retrieve Customer ID";
            }

            
        }*/

        public bool checkLogin(string username, string password)
        {
            try
            {
                using (var db = new CustomerEntities()) 
                {
                    if (db.Main_UsersSet.Any(o => o.Username.Equals(username) && o.Password.Equals(password)))
                    {
                        return true;
                    }
                    else
                    {
                        //User credentials doesn't match
                        return false;
                    }
                }

            }
            catch (Exception ex)
            {
                return false;
            }
            
        }

        public string getCustomerForUser(string username)
        {
            try
            {
                using (var db = new CustomerEntities())
                {
                    var userSet = db.Main_UsersSet.Where(o => o.Username.Equals(username)).First();

                    return userSet.Customer;
                }
            }
            catch (Exception ex)
            {
                return "Couldn't get Customer name";
            }

        }

        public bool UserExist(string username)
        {
            try
            {
                using (var db = new CustomerEntities())
                {
                    if (db.Main_UsersSet.Any(o => o.Username.Equals(username)))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Adduser(string username, string password, string customer)
        {
            try 
            {
                using (var db = new CustomerEntities())
                {
                    var newUser = db.Main_UsersSet.Create();
                    newUser.Username = username;
                    newUser.Password = password;
                    newUser.Customer = customer;

                    db.Main_UsersSet.Add(newUser);
                    db.SaveChanges();

                    return true;
                }
            }
            
            catch (Exception ex)
            {
                return false;
            }
            
        }

        public bool UnitExist(string ID)
        {
            try
            {
                using (var db = new CustomerEntities())
                {
                    if (db.Main_Bridge_Customer_UnitSet.Any(o => o.Main_Dim_UnitSet.UnitID.Equals(ID)))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }

        }

        public bool UnitExist(string ID, string customer)
        {

            //string customer = "RegionH";

            switch (customer)
            {
                case "RegionH":
                    try
                    {
                        using (var db = new RegionHEntities())
                        {
                            if (db.Bridge_UnitSet.Any(o => o.Dim_UnitSet.Unitname.Equals(ID)))
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    catch
                    {
                        return false;
                    }

                case "Lundbeck":
                    try
                    {
                        using (var db = new LundbeckEntities())
                        {
                            if (db.Bridge_Unit_LSet.Any(o => o.Dim_Unit_LSet.Unitname.Equals(ID)))
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    catch
                    {
                        return false;
                    }

                default:

                    return false;
            }
            

        }

        public bool AddEventForType(string type, string action, string description, string customer)
        {
            switch (customer)
            {
                case "RegionH":
                    try
                    {
                        using (var db = new RegionHEntities())
                        {
                            var newBridgeUnitEvent = db.Bridge_EventSet.Create();
                            var unitType = db.Dim_Unit_TypeSet.Where(o => o.Type.Equals(type)).First();
                            var newEvent = db.Dim_EventSet.Create();
                            newEvent.Event = action;
                            newEvent.EventDescription = description;

                            newBridgeUnitEvent.Dim_EventSet = newEvent;
                            newBridgeUnitEvent.Dim_Unit_TypeSet = unitType;

                            db.Bridge_EventSet.Add(newBridgeUnitEvent);
                            db.SaveChanges();
                        }
                        return true;
                    }
                    catch
                    {

                        return false;
                    }

                default:
                    return false;
            }

        }

        public bool ActionExistForType(string type, string action, string customer)
        {
            switch (customer)
            {
                case "RegionH":
                    try
                    {
                        using (var db = new RegionHEntities())
                        {
                            if (db.Bridge_EventSet.Any(o => o.Dim_Unit_TypeSet.Type.Equals(type) && o.Dim_EventSet.Event.Equals(action)))
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }

                    }
                    catch
                    {
                        return false;
                    }

                default:
                    return false;
            }
        }

        public bool TypeExist(string type, string customer)
        {
            //CHANGE!!
            switch (customer) 
            {
                case "RegionH":
                    //
                    try
                    {
                        using (var db = new RegionHEntities())
                        {
                            if (db.Dim_Unit_TypeSet.Any(o => o.Type.Equals(type)))
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }

                    }
                    catch
                    {
                        return false;
                    }
                                 
                case "Lundbeck":

                    try
                    {
                        using (var db = new LundbeckEntities())
                        {
                            if (db.Bridge_Event_LSet.Any(o => o.Dim_Unit_Type_LSet.Type.Equals(type)))
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }

                    }
                    catch
                    {
                        return false;
                    }

                default:
                    return false;

            }
                
        }

        public bool AddType(string type, string customer)
        {
            switch (customer)
            {
                case "RegionH":
                    try
                    {
                        using (var db = new RegionHEntities())
                        {
                            var newType = db.Dim_Unit_TypeSet.Create();
                            newType.Type = type;

                            db.Dim_Unit_TypeSet.Add(newType);
                            db.SaveChanges();
                        }
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                    

                default:

                    return false;
            }


            
        }

        public bool AddRoom(string Room, string customer)
        {
            switch (customer)
            {
                case "RegionH":
                    try
                    {
                        using (var db = new RegionHEntities())
                        {
                            var newRoom = db.Dim_LocationSet.Create();
                            newRoom.Room = Room;

                            db.Dim_LocationSet.Add(newRoom);
                            db.SaveChanges();
                        }
                        return true;
                    }
                    catch
                    {
                        return false;
                    }


                default:

                    return false;
            }



        }

        public bool AddCustomer(string customer)
        {
            try
            {
                using (var db = new CustomerEntities())
                {
                    var newCustomer = db.Main_Dim_CustomerSet.Create();
                    newCustomer.Customer_name = customer;

                    db.Main_Dim_CustomerSet.Add(newCustomer);
                    db.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool customerExist(string customer)
        {
            try
            {
                using (var db = new CustomerEntities())
                {
                    if (db.Main_Dim_CustomerSet.Any(o => o.Customer_name.Equals(customer)))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }

        }

        public bool RoomExist(string Room, string customer)
        {
            switch (customer)
            {
                case "RegionH":
                    try
                    {
                        using (var db = new RegionHEntities())
                        {
                            if (db.Dim_LocationSet.Any(o => o.Room.Equals(Room)))
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    catch
                    {
                        return false;
                    }

                case "Lundbeck":
                    try
                    {
                        //Skift til "true" når det er implementeret".
                        return false;
                    }
                    catch
                    {
                        return false;
                    }

                default:
                    return false;
            }
            
            

        }

        public string getCustomerForUnit(string UnitID)
        {
            try
            {
                using (var db = new CustomerEntities())
                {
                    if (db.Main_Bridge_Customer_UnitSet.Any(o => o.Main_Dim_UnitSet.UnitID.Equals(UnitID)))
                    {
                        var unit = db.Main_Bridge_Customer_UnitSet.Where(x => x.Main_Dim_UnitSet.UnitID.Equals(UnitID)).First();
                        return unit.Main_Dim_CustomerSet.Customer_name;
                    }
                    else
                    {
                        return "Unit not found at customer";
                    }
                }
            }
            catch
            {
                return "Couldn't connect to CustomerEntities";
            }
            
            
            //return "gg";
        }

        

        

        public bool EventExistForUnit(string ID, string action)
        {
            //Check if event exist for unit
            using (var db = new RegionHEntities())
            {
                var bridge_unit = db.Bridge_UnitSet.Where(x => x.Dim_UnitSet.Unitname.Equals(ID)).First();

                //Check if event exist for specified unit
                if (db.Bridge_EventSet.Any(o => o.Dim_Unit_TypeId == bridge_unit.Dim_Unit_TypeId && o.Dim_EventSet.Event.Equals(action)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool AddLog(string ID, DateTime timestamp, string action)
        {
            try
            {
                using (var db = new RegionHEntities())
                {
                    var newlog = db.Fact_Unit_LogSet.Create();
                    var bridge_unit = db.Bridge_UnitSet.Where(x => x.Dim_UnitSet.Unitname.Equals(ID)).First();
                    var bridge_event = db.Bridge_EventSet.Where(x => x.Dim_EventSet.Event.Equals(action)).First();

                    newlog.Bridge_UnitSet = bridge_unit;
                    newlog.Bridge_EventSet = bridge_event;
                    newlog.Timestamp = timestamp;

                    db.Fact_Unit_LogSet.Add(newlog);
                    db.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            

        }

        public bool AddLogToMainTable(string ID, DateTime timestamp, string action)
        {
            try
            {
                using (var db = new CustomerEntities())
                {
                    var newlog = db.Main_Fact_LogsSet.Create();

                    newlog.UnitName = ID;
                    newlog.Timestamp = timestamp;
                    newlog.EventName = action;

                    db.Main_Fact_LogsSet.Add(newlog);
                    db.SaveChanges();

                    return true;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool AddUnitToCustomerTable(string UnitID, string customer)
        {
            try
            {
                using (var dbCustomer = new CustomerEntities())
                {
                    var newBridgeUnit = dbCustomer.Main_Bridge_Customer_UnitSet.Create();
                    var newUnit = dbCustomer.Main_Dim_UnitSet.Create();
                    var cust = dbCustomer.Main_Dim_CustomerSet.Where(o => o.Customer_name.Equals(customer)).First();

                    newUnit.UnitID = UnitID;

                    newBridgeUnit.Main_Dim_UnitSet = newUnit;
                    newBridgeUnit.Main_Dim_CustomerSet = cust;

                    dbCustomer.Main_Bridge_Customer_UnitSet.Add(newBridgeUnit);
                    dbCustomer.SaveChanges();
                }


                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            
            /*switch (customer)
            {
                case "RegionH":
                    try
                    {
                        using (var dbCustomer = new CustomerEntities())
                        {
                            var newBridgeUnit = dbCustomer.Main_Bridge_Customer_UnitSet.Create();
                            var newUnit = dbCustomer.Main_Dim_UnitSet.Create();
                            var cust = dbCustomer.Main_Dim_CustomerSet.Where(o => o.Customer_name.Equals(customer)).First();

                            newUnit.UnitID = UnitID;

                            newBridgeUnit.Main_Dim_UnitSet = newUnit;
                            newBridgeUnit.Main_Dim_CustomerSet = cust;

                            dbCustomer.Main_Bridge_Customer_UnitSet.Add(newBridgeUnit);
                            dbCustomer.SaveChanges();
                        }

                        
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }

                case "Lundbeck":
                    try
                    {
                        using (var db = new LundbeckEntities())
                        {
                            //CHANGE!!
                        }
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }


                default:
                    return false;
            }*/
        }

        public bool AddUnit(string UnitID, string Room, string type, string customer)
        {
            switch (customer)
            {
                case "RegionH":
                    try
                    {
                        using (var db = new RegionHEntities())
                        {

                            var newUnit = db.Bridge_UnitSet.Create();
                            var unit1 = db.Dim_UnitSet.Create();
                            var type1 = db.Dim_Unit_TypeSet.Where(o => o.Type.Equals(type)).First();
                            var location1 = db.Dim_LocationSet.Where(o => o.Room.Equals(Room)).First();

                            unit1.Unitname = UnitID;

                            newUnit.Dim_LocationSet = location1;
                            newUnit.Dim_UnitSet = unit1;
                            newUnit.Dim_Unit_TypeSet = type1;

                            db.Bridge_UnitSet.Add(newUnit);
                            db.SaveChanges();
                        }
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }

                case "Lundbeck":
                    try
                    {
                        using (var db = new LundbeckEntities())
                        {
                            //CHANGE!!
                        }
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }


                default:
                    return false;
            }

        }

        public bool AddSoapDataSet(string UnitID)
        {
            try
            {
                using (var db = new RegionHEntities())
                {
                    //Add DataSet
                    var SoapData = db.Fact_Unit_DataSet.Create();
                    var soapUnit = db.Bridge_UnitSet.Where(x => x.Dim_UnitSet.Unitname.Equals(UnitID)).First();

                    SoapData.Bridge_UnitSet = soapUnit;
                    SoapData.Awake = 0;
                    SoapData.Flush = 0;
                    SoapData.Soap = 0;
                    SoapData.SoapLevel = 75;

                    db.Fact_Unit_DataSet.Add(SoapData);
                    db.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool AwakeAction(string ID)
        {
            try
            {
                using (var db = new RegionHEntities())
                {
                    var bridge_unit = db.Fact_Unit_DataSet.Where(x => x.Bridge_UnitSet.Dim_UnitSet.Unitname.Equals(ID)).First();
                    bridge_unit.Awake++;
                    db.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            
            
        }

        public bool FlushAction(string ID)
        {

            try
            {
                using (var db = new RegionHEntities())
                {
                    var bridge_unit = db.Fact_Unit_DataSet.Where(x => x.Bridge_UnitSet.Dim_UnitSet.Unitname.Equals(ID)).First();
                    bridge_unit.Flush++;
                    db.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool SoapAction(string ID)
        {

            try
            {
                using (var db = new RegionHEntities())
                {
                    var bridge_unit = db.Fact_Unit_DataSet.Where(x => x.Bridge_UnitSet.Dim_UnitSet.Unitname.Equals(ID)).First();
                    bridge_unit.Soap++;
                    bridge_unit.SoapLevel = bridge_unit.SoapLevel - 2;
                    db.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}