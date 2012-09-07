
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Xml;
using System.Xml.XPath;

namespace Puce.Amazon
{
    class UPCItemLookup
    {
        private const string MY_AWS_ACCESS_KEY_ID = "YOUR_AWS_ACCESS_KEY_ID";
        private const string MY_AWS_SECRET_KEY = "YOUR_AWS_SECRET_KEY";
        private const string DESTINATION = "ecs.amazonaws.com";

        private const string NAMESPACE = "http://webservices.amazon.com/AWSECommerceService/2009-03-31";
        private const string ITEM_ID = "0545010225";


        public UPCItemLookup(string p_sUPC)
        {
            string requestUrl;
            SignedRequestHelper oHelper = new SignedRequestHelper(MY_AWS_ACCESS_KEY_ID, MY_AWS_SECRET_KEY, DESTINATION);
            IDictionary<string, string> r1 = new Dictionary<string, String>();
            r1["Service"] = "AWSECommerceService";
            r1["Version"] = "2009-03-31";
            r1["Operation"] = "ItemLookup";
            r1["ItemId"] = p_sUPC;
            r1["ResponseGroup"] = "Small";

            requestUrl = oHelper.Sign(r1);
            string title = FetchTitle(requestUrl);
        }

        private static string FetchTitle(string url)
        {
            try
            {
                WebRequest request = HttpWebRequest.Create(url);
                WebResponse response = request.GetResponse();
                XmlDocument doc = new XmlDocument();
                doc.Load(response.GetResponseStream());

                XmlNodeList errorMessageNodes = doc.GetElementsByTagName("Message", NAMESPACE);
                if (errorMessageNodes != null && errorMessageNodes.Count > 0)
                {
                    String message = errorMessageNodes.Item(0).InnerText;
                    return "Error: " + message + " (but signature worked)";
                }

                XmlNode titleNode = doc.GetElementsByTagName("Title", NAMESPACE).Item(0);
                string title = titleNode.InnerText;
                return title;
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Caught Exception: " + e.Message);
                System.Console.WriteLine("Stack Trace: " + e.StackTrace);
            }

            return null;
        }
    }
}
