using System;
using System.Collections.Generic;
using System.Text;
using static ExamProject.Database;

namespace ExamProject
{
    public class Processor
    {

        //creating list db to store all info about human resources and clients, as well as their appointments in one list

        List<Lawer> lawers = new List<Lawer>() {
        new Lawer{Id = 1, Firstname = "Ivan", Lastname = "Ivanoff", Seniority = ESeniority.Senior, Expertise = ECaseType.CriminalCase, DOB = DateTime.ParseExact("09-09-1978","dd-MM-yyyy", null), JoinedOn = DateTime.ParseExact("03-12-1978","dd-MM-yyyy", null)

        },
        new Lawer{Id = 2, Firstname = "Olga", Lastname = "Komarova", Seniority = ESeniority.Senior, Expertise = ECaseType.CriminalCase, 
        }
        };

        List<Administration> admins = new List<Administration>() {
        new Administration{ Id = 3, Firstname = "Mette", Lastname = "Jensen"},
        new Administration{ Id = 4, Firstname = "Jack", Lastname = "Hansen"},
        };


        List<Client> cients = new List<Client>() {
        new Client{ Id = 3, Firstname = "Jan", Lastname = "Holm", City = "Copenhagen", CaseType = ECaseType.FamilyCase, Street = "Svanemoelevej", Zip = 2100}

        };

        List<Appointment> appointments = new List<Appointment>();




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



        // method to validate the user login
        private bool AuthenticateUser()
        {
            //prompting for the entries
            Console.WriteLine($"You are entering LegalX system!\nPlease provide your username:");
            string usernameInput = Console.ReadLine();

            Console.WriteLine("Please provide your password:");
            string passwordInput = Console.ReadLine();

            if (usernameInput == "a" && passwordInput == "a")
            { return true; }
            else { return false; }
        }

        //initial menu
        private void DisplayMainMenu()
        {
            Console.WriteLine("Who are you:");
            Console.WriteLine("1. Lawer");
            Console.WriteLine("2. Administration");
            Console.WriteLine("3. Receptionist");
        }

        //menu options depending on access role
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

        //methods

        //public List<Database> AddNewAppointment()
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Database> AddNewCase()
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Database> AddNewClient()
        //{
        //    throw new NotImplementedException();
        //}


        //public List<Database> ListAppointments()
        //{
        //    StringBuilder result = new StringBuilder(); //using system.text

        //    result.AppendLine("Here is the result list for All Appointments");

        //    foreach (Database s in appointments)
        //    {
        //        result.AppendLine(s);
        //    }
        //}

        //public List<Database> ListClients(List<Database> db)
        //{
        //    throw new NotImplementedException();
        //}

    } //end of class Processor

}

