
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

    }
}
