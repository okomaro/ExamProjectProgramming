using System;
using System.Collections.Generic;

namespace ExamProject
{
    public class Processor
    {
        //creating list db to store all info about human resources and clients, as well as their appointments in one list

        List<Database> db = new List<Database>();


        public void EntrySystem()
        {
            DisplayMainMenu();
            int choice = int.Parse(Console.ReadLine()); //needs error handliing in case of string entry
            if (AuthenticateUser() == true)
            {
                ShowMenuOption(choice);
                int selected = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"This is what is selected {selected }"); //temporary line for testing
            }
            else
            {
                Console.WriteLine("Incorrect user or password. \nTry again!");
                DisplayMainMenu();
            }
        }

        private void DisplayMainMenu()
        {
            Console.WriteLine("Who are you\nChoose type\n1. Lawer\n2. Administration\n3. Receptionist");
        }



        // method to validate the user login
        private bool AuthenticateUser()
        {
            //prompting for the entries
            Console.WriteLine($"You are entering LegalX system!\nPlease provide your username:");
            string usernameInput = Console.ReadLine();

            Console.WriteLine("Please provide your password");
            string passwordInput = Console.ReadLine();

            if (usernameInput == "a" && passwordInput == "a")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //menu option depending on access role

        private void ShowMenuOption(int choice)
        {


            switch (choice)
            {
                case 1:
                    Console.WriteLine("Choose action (lawer)\n1. List all cases\n2. Add a new Case\n3. List all Appointements");
                    break;

                case 2:
                    Console.WriteLine("Choose action (admin)\n1. List all cases\n2. List all Appointements");
                    break;

                case 3:
                    Console.WriteLine("Choose action (Receptionist)\n1. Register a new client\n2. Add a new Appointemnt\n3.List all Appointments\n4.List all Clients");

                    break;

                default:
                    Console.WriteLine("Invalid command");
                    return;
            }
        }

    } //end of class Processor

}

