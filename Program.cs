using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQ__Using_Address_Book
{
    public class Program
    {
        static void Main(string[] args)
        {
             List<Contact> AddressBook = new List<Contact>();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Address Book Management");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Retrieve Contacts by City/State");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddContact();
                        break;
                    case "2":
                        EditContact();
                        break;
                    case "3":
                        DeleteContact();
                        break;
                    case "4":
                        RetrieveContactsByCityState();
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

    }  
}   
      