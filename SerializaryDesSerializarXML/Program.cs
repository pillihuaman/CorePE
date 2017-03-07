using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessEntity;
using System.IO;
using System.Web;
using System.Net;

namespace SerializaryDesSerializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            //PostTOApi();
            //SerizalizarDesSerializaXML();
            Console.ReadLine();

        }

        public static  void SerizalizarDesSerializaXML()
        {

            BeCliente Cliente = new BeCliente();
            string Path = "C:\\Users\\user\\Documents\\PE_Core_NewVersion\\PE_Core_V1\\SerializaryDesSerializarXML\\TestXMLFile\\TestXml.xml";
            Cliente.Alias = "zarmir";
            Cliente.EmailAlternativo = "Pillihuamanhz@gmail.com";
            Cliente.FechaHabilitarMonedero = DateTime.Now;
            Cliente.FechaInfoCompleta = DateTime.Now;
            Cliente.FechaInhabilitarMonedero = DateTime.Now;
            Cliente.HabilitarMonedero = true;
            Cliente.IdCliente = 1222;
            Cliente.IdUsuario = 1222;
            Cliente.Observaciones = "Generacion de XML FIle";
            Cliente.TieneInfoCompleta = true;

            System.Xml.Serialization.XmlSerializer XML = new System.Xml.Serialization.XmlSerializer(Cliente.GetType());
            //XML.Serialize(Console.Out, Cliente);
            StreamWriter WriteXML = new StreamWriter(Path);
            XML.Serialize(WriteXML, Cliente);
            Console.WriteLine();
            Console.ReadLine();


        
        }
        public static string PostTOApi()
        {
            HttpWebRequest Request = (HttpWebRequest)WebRequest.Create("http://localhost:50545/api/values");
            string PostData = "Data... leng";
            Request.Method = "POST";
            Request.ContentType = "application/json";
            Request.UserAgent = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 7.1; Trident/5.0)";
            Request.Accept = "/";
            Request.UseDefaultCredentials = true;
            //Request.ContentLength = Byte
            Request.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            byte[] bytes = Encoding.UTF8.GetBytes(PostData);
            Request.ContentLength = bytes.Length;
            Stream StreamWri = Request.GetRequestStream();
            StreamWri.Write(bytes, 0, bytes.Length);
            StreamWri.Close();
            WebResponse res = Request.GetResponse();
            if (res == null) return null;
            StreamReader read = new StreamReader(res.GetResponseStream());

            //HttpWebResponse Response = Request.GetResponse() as HttpWebResponse;
            string Response = read.ReadToEnd().Trim();


            return Response;

        
        
        }
    }
}
