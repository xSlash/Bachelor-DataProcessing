using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateDatabaseInfo
{
    class Generator
    {
        static void Main(string[] args)
        {
            /*first();
            second();
            third();
            forth();
            fifth();
            //sixth();

            //Create dataset for units, how much flush, awake, soaplevel etc.
            seventh();*/

            Console.WriteLine("Success!");
            Console.WriteLine("PRESS ANY KEY TO EXIT");
            Console.ReadKey();
        }

        static void first()
        {
            using (var db = new UnitModelContainer())
            {
                var bridgeUnit1 = db.Bridge_UnitSet.Create();
                var unit1 = db.Dim_UnitSet.Create();
                var type1 = db.Dim_Unit_TypeSet.Create();
                var location1 = db.Dim_LocationSet.Create();

                unit1.Unitname = "359551032793381";
                location1.Room = "X1.51";
                type1.Type = "Soapdispenser";

                bridgeUnit1.Dim_Location = location1;
                bridgeUnit1.Dim_Unit = unit1;
                bridgeUnit1.Dim_Unit_Type = type1;


                db.Bridge_UnitSet.Add(bridgeUnit1);
                //
                var bridgeUnit2 = db.Bridge_UnitSet.Create();
                var unit2 = db.Dim_UnitSet.Create();
                var type2 = db.Dim_Unit_TypeSet.Create();
                var location2 = db.Dim_LocationSet.Create();

                location2.Room = "V1.42";

                unit2.Unitname = "263296032096230";

                bridgeUnit2.Dim_Location = location2;
                bridgeUnit2.Dim_Unit = unit2;
                bridgeUnit2.Dim_Unit_Type = type1;


                db.Bridge_UnitSet.Add(bridgeUnit2);

                


                db.SaveChanges();

            }
        }

        //Checks if the soapdispenser object is already there. If it is, fetch ID, and link to it.
        static void second()
        {
            using (var db = new UnitModelContainer())
            {
                var bridgeUnit2 = db.Bridge_UnitSet.Create();
                var unit2 = db.Dim_UnitSet.Create();
                var location2 = db.Dim_LocationSet.Create();
                location2.Room = "X2.62";
                unit2.Unitname = "69023602309623963290";
                bridgeUnit2.Dim_Location = location2;
                bridgeUnit2.Dim_Unit = unit2;

                if (db.Dim_Unit_TypeSet.Any(o => o.Type.Equals("Soapdispenser")))
                {
                    var typetest = db.Dim_Unit_TypeSet.Where(x => x.Type.Equals("Soapdispenser")).First();
                    bridgeUnit2.Dim_Unit_Type = typetest;
                }
                else
                {
                    var type2 = db.Dim_Unit_TypeSet.Create();
                    type2.Type = "Soapdispenser";
                    bridgeUnit2.Dim_Unit_Type = type2;
                }

                db.Bridge_UnitSet.Add(bridgeUnit2);
                db.SaveChanges();

            }
        }

        static void third()
        {
            /*using (var db = new UnitModelContainer())
            {
                var testbridge1 = db.Bridge_UnitSet.Where(x => x.Dim_UnitId == 1).First();
                Console.WriteLine("testbridge1.Dim_UnitId: " + testbridge1.Dim_UnitId);
                Console.WriteLine("testbridge1.Dim_Unit.Id: " + testbridge1.Dim_Unit.Id);
                Console.WriteLine("testbridge1.Dim_Unit.Unitname: " + testbridge1.Dim_Unit.Unitname);
                Console.WriteLine("testbridge1.Dim_Unit: " + testbridge1.Dim_Unit);
                Console.WriteLine("testbridge1.Dim_Location.Room: " + testbridge1.Dim_Location.Room);
                Console.WriteLine("testbridge1.Dim_Unit_Type.Type: " + testbridge1.Dim_Unit_Type.Type);


                Console.WriteLine("----------------------");

                var testbridge2 = db.Bridge_UnitSet.Where(x => x.Dim_UnitId == 2).First();
                Console.WriteLine("testbridge2.Dim_UnitId: " + testbridge2.Dim_UnitId);
                Console.WriteLine("testbridge2.Dim_Unit.Id: " + testbridge2.Dim_Unit.Id);
                Console.WriteLine("testbridge2.Dim_Unit.Unitname: " + testbridge2.Dim_Unit.Unitname);
                Console.WriteLine("testbridge2.Dim_Unit: " + testbridge2.Dim_Unit);
                Console.WriteLine("testbridge2.Dim_Location.Room: " + testbridge2.Dim_Location.Room);
                Console.WriteLine("testbridge2.Dim_Unit_Type.Type: " + testbridge2.Dim_Unit_Type.Type);
                //Console.ReadKey();
            }*/
        }

        static void forth()
        {
            var editroom = new Dim_Location();
            using (var db = new UnitModelContainer())
            {
                editroom = db.Dim_LocationSet.Where(x => x.Room.Equals("X2.62")).First();
                editroom.Room = "N3.22";
                db.Entry(editroom).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }


            /*using (var db = new UnitModelContainer())
            {
                Console.WriteLine("----------------------");

                var testbridge2 = db.Bridge_UnitSet.Where(x => x.Dim_UnitId == 3).First();
                Console.WriteLine("testbridge2.Dim_UnitId: " + testbridge2.Dim_UnitId);
                Console.WriteLine("testbridge2.Dim_Unit.Id: " + testbridge2.Dim_Unit.Id);
                Console.WriteLine("testbridge2.Dim_Unit.Unitname: " + testbridge2.Dim_Unit.Unitname);
                Console.WriteLine("testbridge2.Dim_Unit: " + testbridge2.Dim_Unit);
                Console.WriteLine("testbridge2.Dim_Location.Room: " + testbridge2.Dim_Location.Room);
                Console.WriteLine("testbridge2.Dim_Unit_Type.Type: " + testbridge2.Dim_Unit_Type.Type);

                Console.WriteLine("PRESS ANY KEY TO EXIT");
                Console.ReadKey();
            }*/
            
        }

        static void fifth()
        {
            using (var db = new UnitModelContainer())
            {
                //Create events

                var bridgeEvent1 = db.Bridge_EventSet.Create();
                var bridgeEvent2 = db.Bridge_EventSet.Create();
                var bridgeEvent3 = db.Bridge_EventSet.Create();
                var eventobj1 = db.Dim_EventSet.Create();
                var eventobj2 = db.Dim_EventSet.Create();
                var eventobj3 = db.Dim_EventSet.Create();

                //NOTE! Requires "Soapdispenser" type is created
                var soaptype = db.Dim_Unit_TypeSet.Where(x => x.Type.Equals("Soapdispenser")).First();
                bridgeEvent1.Dim_Unit_Type = soaptype;
                bridgeEvent2.Dim_Unit_Type = soaptype;
                bridgeEvent3.Dim_Unit_Type = soaptype;

                //eventobj1.Event =
                eventobj1.Event = "A";
                eventobj1.EventDescription = "Awake";
                eventobj2.Event = "F";
                eventobj2.EventDescription = "Flush";
                eventobj3.Event = "S";
                eventobj3.EventDescription = "Soap";

                bridgeEvent1.Dim_Event = eventobj1;
                bridgeEvent2.Dim_Event = eventobj2;
                bridgeEvent3.Dim_Event = eventobj3;

                db.Bridge_EventSet.Add(bridgeEvent1);
                db.Bridge_EventSet.Add(bridgeEvent2);
                db.Bridge_EventSet.Add(bridgeEvent3);

                db.SaveChanges();
            }
        }

        static void sixth()
        {
            String unit = "359551032793381";
            DateTime dt = Convert.ToDateTime("08-10-2015 11:55:48");
            String unitevent = "S";

            using (var db = new UnitModelContainer())
            {
                var newlog = db.Fact_Unit_LogSet.Create();

                if (db.Bridge_UnitSet.Any(o => o.Dim_Unit.Unitname.Equals(unit)))
                {
                    var bridge_unit = db.Bridge_UnitSet.Where(x => x.Dim_Unit.Unitname.Equals(unit)).First();

                    if (db.Bridge_EventSet.Any(o => o.Dim_Unit_TypeId == bridge_unit.Dim_Unit_TypeId && o.Dim_Event.Event.Equals(unitevent)))
                    {
                        var bridge_event = db.Bridge_EventSet.Where(x => x.Dim_Event.Event.Equals(unitevent)).First();

                        newlog.Bridge_Unit = bridge_unit;
                        newlog.Bridge_Event = bridge_event;
                        newlog.Timestamp = dt;

                        db.Fact_Unit_LogSet.Add(newlog);
                        db.SaveChanges();

                        //Console.WriteLine("Log added!");
                        //Console.ReadKey();
                    }

                    else
                    {
                        Console.WriteLine("Event not found");
                        Console.ReadKey();
                    }


                }
                else
                {
                    Console.WriteLine("Unit not found");
                    Console.ReadKey();
                }
            }
        }

        static void seventh()
        {

            //String unit = "359551032793381";
            int soaplvl = 75;
            int awake = 0;
            int flush = 0;
            int soap = 0;

            addDataUnit("359551032793381", soaplvl, awake, flush, soap);
            addDataUnit("263296032096230", soaplvl, awake, flush, soap);
            addDataUnit("69023602309623963290", soaplvl, awake, flush, soap);
        }


        static void addDataUnit(String unit, int soaplvl, int awake, int flush, int soap)
        {
            using (var db = new UnitModelContainer())
            {
                var newDataUnit = db.Fact_Unit_DataSet.Create();

                if (db.Bridge_UnitSet.Any(o => o.Dim_Unit.Unitname.Equals(unit)))
                {
                    var bridge_unit = db.Bridge_UnitSet.Where(x => x.Dim_Unit.Unitname.Equals(unit)).First();

                    newDataUnit.Bridge_Unit = bridge_unit;
                    newDataUnit.SoapLevel = soaplvl;
                    newDataUnit.Awake = awake;
                    newDataUnit.Flush = flush;
                    newDataUnit.Soap = soap;

                    db.Fact_Unit_DataSet.Add(newDataUnit);
                    db.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Couldn't add unit - Not found");
                }
            }
        }

        /*static void addUnitForCustomer()
        {

        }*/
    }
}
