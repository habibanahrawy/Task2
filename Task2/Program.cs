using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace Task2
{
    internal class Program
    {
        private static readonly Dictionary<int, string> userData = new();
        static void Main(string[] args)
        {

            userData.Add(36588096, "habiba mohamad");
            userData.Add(577488, "aliaa ahmad");
            userData.Add(38775580, "asmaa ebrahim");
            userData.Add(8670521, "eman alaa");

            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Edit Contact");
            Console.WriteLine("3. Delete Contact");
            Console.WriteLine("4. Show All Contacts");
            Console.WriteLine("5. Exit\n\n");


            while (true)
            {
                Console.WriteLine("#####################################\n\n");
                Console.Write("Enter your option: ");
                var option = Console.ReadLine();


                switch (option)
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
                        ShowAllContact();
                        break;

                    case "5":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("InValid...");
                        break;

                }
            }
        }

        private static void ShowAllContact()
        {
            int i = 1;
            Console.WriteLine("All Contacts: ");
            foreach (var x in userData)
            {
                Console.WriteLine($"Contact {i}: {x.Value}");
                Console.WriteLine($"Phone Number: {x.Key}\n");
                i++;
            }
        }

        private static void DeleteContact()
        {
            Console.Write("Enter Phone Number: ");
            var phonenum = int.Parse(Console.ReadLine());
            if (userData.Remove(phonenum))
            {
                Console.WriteLine("Contact deleted successfully!");
            }
            else
            {
                Console.WriteLine("This Contact is not found!");
            }
        }

        private static void EditContact()
        {
            Console.Write("Enter Phone Number: ");
            var phonenum = int.Parse(Console.ReadLine());
            if (userData.ContainsKey(phonenum))
            {
                Console.Write("New First Name: ");
                string first = Console.ReadLine();
                Console.Write("New Last Name: ");
                string last = Console.ReadLine();
                userData[phonenum] = $"{first} {last}";
                Console.WriteLine("this process Successfully!");
            }
            else
            {
                Console.WriteLine("This Contact is not found!");
            }
        }

        private static void AddContact()
        {
            Console.Write("Enter Phone Number: ");
            var Phonenum = int.Parse(Console.ReadLine());
            if (userData.ContainsKey(Phonenum))
            {
                Console.WriteLine("This Contact is exits ");
            }
            else
            {
                Console.Write("Is This a user? (y/n): ");
                var Isuser = Console.ReadLine();
                Console.Write("First Name: ");
                var first = Console.ReadLine();
                Console.Write("Last Name: ");
                var last = Console.ReadLine();
                userData[Phonenum] = $"{first} {last}";
                Console.WriteLine("Contact Added Successfully!\n\n");
            }
        }
    }
}


