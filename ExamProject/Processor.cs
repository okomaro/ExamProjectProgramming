using System;
using System.Collections.Generic;
using System.Text;


namespace ExamProject
{
    public class Processor
    {

        //lists to store all info about human resources and clients, as well as their appointments in one list

        //id system
        //1-30 Lawyers
        //30-35 administration and reception

        //***************************
        //     DATA ON RESOURSES
        //***************************

        List<Lawyer> lawyers = new List<Lawyer>() {
        new Lawyer{EmpId = 1, Firstname = "Ivan", Lastname = "Ivanov", Seniority = ESeniority.Senior, Expertise = ECaseType.Criminal, DOB = DateTime.ParseExact("09-09-1978","dd-MM-yyyy", null), JoinedOn = DateTime.ParseExact("03-12-1978","dd-MM-yyyy", null)

        },
         new Lawyer{EmpId = 2, Firstname = "Ignacio", Lastname = "Holm", Seniority= ESeniority.Junior, Expertise = ECaseType.Family, DOB = DateTime.ParseExact("03-06-1988","dd-MM-yyyy", null), JoinedOn = DateTime.ParseExact("03-12-2020","dd-MM-yyyy", null)

        },
        new Lawyer{EmpId = 3, Firstname = "Olga", Lastname = "Komarova", Seniority = ESeniority.Senior, Expertise = ECaseType.Criminal
        }
        };

        List<Administration> admins = new List<Administration>() {
        new Administration{ EmpId = 3, Firstname = "Mette", Lastname = "Jensen", DOB = DateTime.ParseExact("08-03-1999","dd-MM-yyyy", null)},
        new Administration{ EmpId = 4, Firstname = "Jack", Lastname = "Hansen"},
        };

        List<Reception> receptionists = new List<Reception>() {
        new Reception{ EmpId = 3, Firstname = "Mette", Lastname = "Jensen", DOB = DateTime.ParseExact("08-03-1999","dd-MM-yyyy", null)},
        new Reception{ EmpId = 4, Firstname = "Jack", Lastname = "Hansen"},
        };


        List<Client> clients = new List<Client>() {
        new Client{ ClientId = 3, Firstname = "Jan", Lastname = "Holm", City = "Copenhagen", CaseType = ECaseType.Family, Street = "Svanemoelevej", Zip = 2100, DOB = DateTime.ParseExact("03-06-1988","dd-MM-yyyy", null) }

        };

        List<Case> cases = new List<Case>() {
        new Case { IdCase = 1, CaseType = ECaseType.Corporate, LawyerId = 1, ClientId = 3, StartDate = DateTime.ParseExact("18-12-2020","dd-MM-yyyy", null), TotalCharges = 20000  }

        };


        //***************************
        //    DATA LISTS FOR OPERATIONS
        //***************************

        List<Appointment> appointments = new List<Appointment>();
   


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
            Console.WriteLine($"Welcome to LegalX system!\nPlease provide your username:");
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
            Console.WriteLine("1. Lawyer");
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
                        Console.WriteLine("Choose action (Lawyer)\n1. List all cases\n2. Add a new Case\n3. List all Appointements");
                        int LawyerChoice  = int.Parse(Console.ReadLine()); //needs error handliing in case of string entry
                        if (LawyerChoice == 1) { ListAllCases(); }
                        else if (LawyerChoice == 2) { AddNewCase(); }
                        else if (LawyerChoice == 3) { ListAllApppointments(); }
                        else { break; }
                        break;

                    case 2:
                        Console.WriteLine("Choose action (admin)\n1. List all cases\n2. List all Appointements");
                        int adminChoice = int.Parse(Console.ReadLine()); //needs error handliing in case of string entry
                        if (adminChoice == 1) { ListAllCases(); }
                        else if (adminChoice == 2) { ListAllApppointments(); }
                        else { break; }
                        break;

                    case 3:
                        Console.WriteLine("Choose action (Receptionist)\n1. Register a new client\n2. Add a new Appointemnt\n3. List all Appointments\n4. List all Clients");
                        int receptionChoice = int.Parse(Console.ReadLine()); //needs error handliing in case of string entry
                        if (receptionChoice == 1) { AddNewClient(); }
                        else if (receptionChoice == 2) { AddNewAppointment(); }
                        else if (receptionChoice == 3) { ListAllApppointments(); }
                        else if (receptionChoice == 4) { ListAllClients(); }
                        else { break; }
                        break;

                    default:
                        Console.WriteLine("Invalid command. Make the right choice!");
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

        public void ListLawyers()
        {
            foreach (Lawyer c in lawyers)
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
            Console.WriteLine("Creating new case");
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
           
            Console.WriteLine("Creating new appointment");

            Console.WriteLine("Existing Client? (Y or N)");

            string answer = Console.ReadLine().ToLower();

            if (answer == "y")
            {
                Appointment appointment = new Appointment();

                Console.WriteLine("Enter Client's ID:");
                int clientId = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Lawyers Last name:");
                string lawyerAssigned = Console.ReadLine().ToLower();

                //here one can also check lawyer for expertise

                Client i = clients.Find(x=>x.ClientId == clientId);
                appointment.ClientId = i.ClientId;

                Lawyer s = lawyers.Find(x => x.Lastname.ToLower() == lawyerAssigned);

                appointment.LawyerId = s.EmpId;

         

                Console.WriteLine("Appointment ID:");
                appointment.AppId = int.Parse(Console.ReadLine());

                Console.WriteLine("Appointment's date (dd-MM-yyyy):");
                appointment.AppointmentDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);


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

                Console.WriteLine("New appointment is created:");
                Console.WriteLine($"Client: {i.Firstname} {i.Lastname} living in {i.City} (case: {i.CaseType} law)");
                Console.WriteLine($"Lawyer assigned: {s.Firstname} {s.Lastname} specialised in {s.Expertise} law and with seniority {s.Seniority}");
                Console.WriteLine($"Date: {appointment.AppointmentDate.ToShortDateString()}");

            }

            else {AddNewClient();}

        }



    } //end of class Processor

}

