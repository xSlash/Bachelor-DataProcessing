using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Soap:
using System.Xml;
using System.Net;
using System.Diagnostics;


namespace AdapterProjekt
{
    class Adapter
    {
        static void Main(string[] args)
        {
            //Test
            /*WebServiceReference.InterfaceSoapClient client = new WebServiceReference.InterfaceSoapClient();

            Console.WriteLine("Adding logs to system .. Wait ..");

            Console.WriteLine(client.AddLog("263296032096230", DateTime.Now, "A"));
            Console.WriteLine(client.AddLog("263296032096230", DateTime.Now, "F"));
            Console.WriteLine(client.AddLog("263296032096230", DateTime.Now, "S"));
            Console.WriteLine(client.AddLog("263296032096230", DateTime.Now, "S"));
            Console.WriteLine(client.HelloWorld());
            Console.WriteLine(client.HelloMike());

            Console.ReadKey();*/
            
            
            //Comsume WebService
            DirectoryInfo dinfo = new DirectoryInfo(@"C:\Users\mtkx\Desktop\Bachelor\AdapterTextFiles");
            FileInfo[] Files = dinfo.GetFiles("*.txt");

            foreach (FileInfo file in Files)
            {
                //listbox1.Items.Add(file.Name);
                WebServiceReference.InterfaceSoapClient client = new WebServiceReference.InterfaceSoapClient();

                Console.WriteLine(file.FullName);
                Console.WriteLine();
                //Console.ReadKey();

                string[] fileContent = File.ReadAllLines(file.FullName);

                Console.WriteLine("Adding logs to system .. Wait ..");

                foreach (string line in fileContent)
                {
                    
                    Console.WriteLine(line);
                    string[] splitLine = line.Split(';');

                    DateTime date = Convert.ToDateTime(DateTime.Today.ToString("d") + " " + splitLine[4]);

                    //Console.WriteLine(splitLine[0] + " " + date + " " + splitLine[5]);

                    //Send logs
                    Console.WriteLine("Log: " + client.AddLog(splitLine[0], date, splitLine[5]));

                }

                Console.WriteLine();
                Console.ReadKey();
            }



            //SOAP solution

            HttpWebRequest request = CreateWebRequest();
            XmlDocument soapEnvelopeXml = new XmlDocument();
            soapEnvelopeXml.LoadXml(@"<?xml version=""1.0"" encoding=""utf-8""?>
            <soap:Envelope xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
            <soap:Body>
                <HelloWorld xmlns=""http://tempuri.org/"">
                </HelloWorld>
            </soap:Body>
            </soap:Envelope>");

            using (Stream stream = request.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }

            using (WebResponse response = request.GetResponse())
            {
                using (StreamReader rd = new StreamReader(response.GetResponseStream()))
                {
                    string soapResult = rd.ReadToEnd();
                    Console.WriteLine(soapResult);
                    Console.ReadKey();
                }
            }




        }

        //Also for SOAP
        //Create request
        public static HttpWebRequest CreateWebRequest()
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(@"http://grandt.us:90/WebService/Interface.asmx");
            webRequest.Headers.Add(@"SOAP:Action");
            webRequest.ContentType = "text/xml;charset=\"utf-8\"";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            return webRequest;
        }

        
    }
}
