using System;

namespace Lab4_3
{
    //create a customer class w/private fields: p for private...
    class Customer
    {
        private string pCompany;
        private string pContactName;//name of person at company
        private string pContactEmail;//email of contact @ company
        private string pPhone;//main comp ph#

        //create a getter and setter for each field:
        public string GetCompany()
        {
            return pCompany;
        }

        public void SetCompany(string _Company)
        {
            pCompany = _Company;
        }

        public string GetContactName()
        {
            return pContactName;
        }

        public void SetContactName(string _ContactName)
        {
            pContactName = _ContactName;
        }

        public string GetContactEmail()
        {
            return pContactEmail;
        }

        public void SetContactEmail(string _ContactEmail)
        {
            pContactEmail = _ContactEmail;
        }

        public string GetPhone()
        {
            return pPhone;
        }

        public void SetPhone(string _Phone)
        {
            pPhone = _Phone;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
