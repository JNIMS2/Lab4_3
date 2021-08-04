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

        //create only 1 constructor that tkaes all 4 fields. no default
        public Customer( string _Company, string _ContactName, string _ContactEmail, string _Phone)
        {
            SetCompany(_Company);
            SetContactName(_ContactName);
            SetContactEmail(_ContactEmail);
            SetPhone(_Phone);
        }


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


        //add a ToString that prints out all the info about the customer:
        public override string ToString()
        {
            return $"Company: {pCompany} \nContact Name: {pContactName} \nContact Email: {pContactEmail} \nPhone: {pPhone}";
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
