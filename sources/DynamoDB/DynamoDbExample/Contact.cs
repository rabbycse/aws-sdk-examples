using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace DynamoDbExample
{
    public class Contact
    {
        public string MobileNumber { get; set; }
        public NameValueCollection OtherDetails { get; set; }
    }
}
