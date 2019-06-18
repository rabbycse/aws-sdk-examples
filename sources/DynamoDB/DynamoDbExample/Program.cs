using System;

namespace DynamoDbExample
{
    class Program
    {
        public static void Main(string[] args)
        {
            string key = "**************";
            string secret = "*******************************";

            ContactsRepository repo = new ContactsRepository(key, secret);
            var contact = new Contact();
            contact.MobileNumber = "084294738947289";
            contact.OtherDetails = new System.Collections.Specialized.NameValueCollection();
            contact.OtherDetails.Add("Name", "Rabbi");
            contact.OtherDetails.Add("BirthDate", "2/2/2001");

            repo.Add(contact);
        }
    }
}
