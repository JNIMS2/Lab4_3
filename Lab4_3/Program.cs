using System;
using System.Collections.Generic;
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
            //testing it out
            //Customer bert = new Customer("Bert's Burgers", "Bert Smith", "BTSmith@Bertsburgers.com", "248-351-4752");
            //Console.WriteLine(bert);
            //bert.SetCompany("Burt's Best Burgers");
            //bert.SetContactEmail("Number1Burgers@Bertsbestburgers.com");
            //bert.SetContactName("Bert the Burger Beast");
            //bert.SetPhone("1-800-BURGER1");
            //Console.WriteLine();
            //Console.WriteLine(bert);
            //Console.WriteLine($"{bert.GetCompany()} {bert.GetContactEmail()}  {bert.GetContactName()} {bert.GetPhone()}");

            //Customer Phil = new Customer("Phil's Pizza", "Phil CheeseSteak", "Orders@PhilsPizza.com", "313-451-4200");
            //Console.WriteLine(Phil);

            //make a List of customer instances and save it in a variable name of your choice. 
            //make all the customers first:

            Customer Frank = new Customer("Frank Lloyd Wright Jr.'s Carpet Emporium", "Frank Wright Jr", "FLW@FLWCarpet.com", "313-1CARPET");
            Customer John = new Customer("John Legend's Fancy Silky Smooth Shirts", "John Legend", "JLegend@silksmooth.com", "313-SMOOTH1");
            Customer Jack = new Customer("The School of Rockin' Rock", "Jack Black III", "JB1@SOR.com","313-ONE-ROCK");
            Customer Amy = new Customer("Not your mamma's shoes...", "Amy Schumer", "NYMS@shoebeast.com","313-NSFW-SHU" );

            //make the list:
            List<Customer> customers = new List<Customer>();

            //add stuff to it:

            customers.Add(Frank);
            customers.Add(John);
            customers.Add(Jack);
            customers.Add(Amy);

            //test it out:
            //foreach (Customer tcustomer in customers)
            //{
            //    Console.WriteLine(tcustomer);
            //}



        }
    }
}
