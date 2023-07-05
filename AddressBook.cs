using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ__Using_Address_Book
{
    internal class AddressBook
    {
        static void AddContact()
        {
            Console.WriteLine("Enter Contact Details:");
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Address: ");
            string address = Console.ReadLine();
            Console.Write("City: ");
            string city = Console.ReadLine();
            Console.Write("State: ");
            string state = Console.ReadLine();
            Console.Write("ZIP: ");
            string zip = Console.ReadLine();
            Console.Write("Phone Number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();

            Contact contact = new Contact()
            {
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                City = city,
                State = state,
                ZIP = zip,
                PhoneNumber = phoneNumber,
                Email = email
            };

            addressBook.Add(contact);

            Console.WriteLine("Contact added successfully.");
        }

        static void EditContact()
        {
            Console.Write("Enter the first name of the contact you want to edit: ");
            string firstName = Console.ReadLine();

            var contacts = addressBook.Where(c => c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase)).ToList();

            if (contacts.Count > 0)
            {
                Console.WriteLine("Select the contact you want to edit:");
                for (int i = 0; i < contacts.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {contacts[i].FirstName} {contacts[i].LastName}");
                }

                Console.Write("Enter the number of the contact: ");
                int contactIndex;
                if (int.TryParse(Console.ReadLine(), out contactIndex) && contactIndex > 0 && contactIndex <= contacts.Count)
                {
                    Contact contact = contacts[contactIndex - 1];

                    Console.WriteLine("Enter new contact details:");
                    Console.Write("First Name: ");
                    contact.FirstName = Console.ReadLine();
                    Console.Write("Last Name: ");
                    contact.LastName = Console.ReadLine();
                    Console.Write("Address: ");
                    contact.Address = Console.ReadLine();
                    Console.Write("City: ");
                    contact.City = Console.ReadLine();
                    Console.Write("State: ");
                    contact.State = Console.ReadLine();
                    Console.Write("ZIP: ");
                    contact.ZIP = Console.ReadLine();
                    Console.Write("Phone Number: ");
                    contact.PhoneNumber = Console.ReadLine();
                    Console.Write("Email: ");
                    contact.Email = Console.ReadLine();

                    Console.WriteLine("Contact updated successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid contact number.");
                }
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }

        static void DeleteContact()
        {
            Console.Write("Enter the first name of the contact you want to delete: ");
            string firstName = Console.ReadLine();

            var contacts = addressBook.Where(c => c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase)).ToList();

            if (contacts.Count > 0)
            {
                Console.WriteLine("Select the contact you want to delete:");
                for (int i = 0; i < contacts.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {contacts[i].FirstName} {contacts[i].LastName}");
                }

                Console.Write("Enter the number of the contact: ");
                int contactIndex;
                if (int.TryParse(Console.ReadLine(), out contactIndex) && contactIndex > 0 && contactIndex <= contacts.Count)
                {
                    Contact contact = contacts[contactIndex - 1];
                    addressBook.Remove(contact);
                    Console.WriteLine("Contact deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid contact number.");
                }
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }

        static void RetrieveContactsByCityState()
        {
            Console.Write("Enter the city or state: ");
            string cityState = Console.ReadLine();

            var contacts = addressBook.Where(c => c.City.Equals(cityState, StringComparison.OrdinalIgnoreCase) ||
                                                  c.State.Equals(cityState, StringComparison.OrdinalIgnoreCase)).ToList();

            if (contacts.Count > 0)
            {
                Console.WriteLine("Contacts matching the city/state:");
                foreach (var contact in contacts)
                {
                    Console.WriteLine($"{contact.FirstName} {contact.LastName}");
                }
            }
            else
            {
                Console.WriteLine("No contacts found for the specified city/state.");
            }
        }
    }

}

