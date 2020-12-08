using System;
using System.Collections.Generic;
using System.Text;


namespace ExamProject
{
    public class Processor
    {

        //lists to store all info about human resources and clients, as well as their appointments in one list

        //id system
        //1-30 lawers
        //30-35 administration and reception

        //***************************
        //     DATA ON RESOURSES
        //***************************

        List<Lawer> lawers = new List<Lawer>() {
        new Lawer{Id = 1, Firstname = "Ivan", Lastname = "Ivanoff", Seniority = ESeniority.Senior, Expertise = ECaseType.Criminal, DOB = DateTime.ParseExact("09-09-1978","dd-MM-yyyy", null), JoinedOn = DateTime.ParseExact("03-12-1978","dd-MM-yyyy", null)

        },
         new Lawer{Id = 2, Firstname = "Ignacio", Lastname = "rfr", Seniority= ESeniority.Junior, Expertise = ECaseType.Family, DOB = DateTime.ParseExact("03-06-1988","dd-MM-yyyy", null), JoinedOn = DateTime.ParseExact("03-12-2020","dd-MM-yyyy", null)

        },
        new Lawer{Id = 3, Firstname = "Olga", Lastname = "Komarova", Seniority = ESeniority.Senior, Expertise = ECaseType.Criminal,
        }
        };

        List<Administration> admins = new List<Administration>() {
        new Administration{ Id = 3, Firstname = "Mette", Lastname = "Jensen", DOB = DateTime.ParseExact("08-03-1999","dd-MM-yyyy", null)},
        new Administration{ Id = 4, Firstname = "Jack", Lastname = "Hansen"},
        };

        List<Reception> receptionists = new List<Reception>() {
        new Reception{ Id = 3, Firstname = "Mette", Lastname = "Jensen", DOB = DateTime.ParseExact("08-03-1999","dd-MM-yyyy", null)},
        new Reception{ Id = 4, Firstname = "Jack", Lastname = "Hansen"},
        };


        List<Client> clients = new List<Client>() {
        new Client{ ClientId = 3, Firstname = "Jan", Lastname = "Holm", City = "Copenhagen", CaseType = ECaseType.Family, Street = "Svanemoelevej", Zip = 2100, DOB = DateTime.ParseExact("03-06-1988","dd-MM-yyyy", null) }

        };


        //***************************
        //    DATA ON OPERATIONS
        //***************************

        List<Appointment> appointments = new List<Appointment>();
        List<Case> cases = new List<Case>();


        //***************************
        //    ROLES AND LOGIN
        //***************************

        // the first method activated from Program.cs
        public void EntrySystem()
        {
            DisplayMainMenu();
            int choice = int.Parse(Console.ReadLine()); //needs error handliing in case of string entry

            if (AuthenticateUser())  //same as ==true
            {
                ShowMenuOption(choice);
            }
            else
            {
                Console.WriteLine("Incorrect user or password. \nTry again!");
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
            Console.WriteLine("Your role in the LegalX company:");
            Console.WriteLine("1. Lawer");
            Console.WriteLine("2. Administrator");
            Console.WriteLine("3. Receptionist");
        }


        //************************
        //      MAIN NAVIGATION
        // menu options depending on role
        //************************

        private void ShowMenuOption(int choice)
        {
            while (true)
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Choose action (lawer)\n1. List all cases\n2. Add a new Case\n3. List all Appointements");
                        int lawerChoice  = int.Parse(Console.ReadLine()); //needs error handliing in case of string entry
                        if (lawerChoice == 1) { ListAllCases(); }
                        else if (lawerChoice == 2) { AddNewCase(); }
                        else if (lawerChoice == 3) { ListAllApppointments(); }
                        else { break; }
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("Choose action (admin)\n1. List all cases\n2. List all Appointements");
                        int adminChoice = int.Parse(Console.ReadLine()); //needs error handliing in case of string entry
                        if (adminChoice == 1) { ListAllCases(); }
                        else if (adminChoice == 2) { ListAllApppointments(); }
                        else { break; }
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Choose action (Receptionist)\n1. Register a new client\n2. Add a new Appointemnt\n3. List all Appointments\n4. List all Clients");
                        int receptionChoice = int.Parse(Console.ReadLine()); //needs error handliing in case of string entry
                        if (receptionChoice == 1) { AddNewClient(); }
                        else if (receptionChoice == 2) { AddNewAppointment(); }
                        else if (receptionChoice == 3) { ListAllApppointments(); }
                        else if (receptionChoice == 4) { ListAllClients(); }
                        else { break; }
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Invalid command");
                        return;
                }
            }

        }

      

        //**********************
        //       METHODS
        //**********************

        public void AddNewClient()
        {
            Client client = new Client();
            Console.WriteLine("Creating new client");
            Console.WriteLine("Client ID:");
            client.ClientId = int.Parse(Console.ReadLine());
            Console.WriteLine("First name:");
            client.Firstname = Console.ReadLine();
            Console.WriteLine("Last name:");
            client.Lastname = Console.ReadLine();
            Console.WriteLine("Date of birth (in format dd-MM-yyyy):");

            client.DOB = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
            Console.WriteLine("City:");
            client.City = Console.ReadLine();
            Console.WriteLine("Street:");
            client.Street = Console.ReadLine();
            Console.WriteLine("ZIP:");
            client.Zip = int.Parse(Console.ReadLine());
            Console.WriteLine("Type of case:");
            Console.WriteLine("1. Corporate law\n2.Family law\n3.Criminal law");
            int caseType = int.Parse(Console.ReadLine());
            if (caseType == 1)
                client.CaseType = ECaseType.Corporate;
            else if (caseType == 2)
                client.CaseType = ECaseType.Family;
            else if (caseType == 3)
                client.CaseType = ECaseType.Criminal;
            else
                client.CaseType = ECaseType.Unknown;
            clients.Add(client);
            Console.WriteLine("New client's record is created");
            Console.WriteLine(client.ShowInfo());
        }

        public void ListAllClients()
        {
            foreach (Client c in clients)
            {
                Console.WriteLine(c.ShowInfo());
            }

        }

        public void ListLawers()
        {
            foreach (Lawer c in lawers)
            {
                Console.WriteLine(c.ShowInfo());
            }

        }

        private void ListAllApppointments()
        {
            foreach (Appointment c in appointments)
            {
                Console.WriteLine(c.ShowInfo());
            }
        }

        private void AddNewCase()
        {
          
            Console.WriteLine("Tested: case created");
        }

        private void ListAllCases()
        {

            foreach (Case c in cases)
            {
                Console.WriteLine(c.ShowInfo());
            }
        }

        private void AddNewAppointment()
        {
            Appointment appointment  = new Appointment();

            Console.WriteLine("Creating new appointment");

            Console.WriteLine("Existing Client? (Y or N)");
            string answer = Console.ReadLine().ToLower();
            if (answer == "y")
            {
                Console.WriteLine("Enter Client's ID:");
                appointment.ClientId = int.Parse(Console.ReadLine());
                Console.WriteLine("Appointment ID:");
                appointment.AppId = int.Parse(Console.ReadLine());
                Console.WriteLine("Appointment's date:");
                appointment.AppointmentDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
                Console.WriteLine("Enter Lawers's ID:");
                appointment.LawyerId = int.Parse(Console.ReadLine());
                Console.WriteLine("Choose room:");
                Console.WriteLine("1. Aquarium\n2. Cave\n3. Cube");
                int roomChoice = int.Parse(Console.ReadLine());
                if (roomChoice == 1)
                    appointment.MeetingRoom = ERooms.Aquarium;
                else if (roomChoice == 2)
                    appointment.MeetingRoom = ERooms.Cave;
                else if (roomChoice == 3)
                    appointment.MeetingRoom = ERooms.Cube;
                else
                    appointment.MeetingRoom = ERooms.Unknown;

                appointments.Add(appointment);
                Console.WriteLine("New appointment is created");

                Console.WriteLine(appointment.ShowInfo());

            }

            else { AddNewClient(); }
       

        }


        //public List<Database> AddNewAppointment()
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Database> AddNewCase()
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




    } //end of class Processor

}

