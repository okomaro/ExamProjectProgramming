using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace ExamProject
{
    public class Processor
    {

        //Lists of objects to store all info about human resources and clients, as well as their appointments in the code

        //***************************
        //        DATA LISTS
        //***************************

        List<Lawyer> lawyers = new List<Lawyer>()
        {
            new Lawyer{EmpId = 1, Firstname = "Ivan", Lastname = "Ivanov", Seniority = ESeniority.Senior, Expertise = ECaseType.Family, DOB = DateTime.ParseExact("09-09-1978","dd-MM-yyyy", null), JoinedOn = DateTime.ParseExact("03-12-1978","dd-MM-yyyy", null), Role = ERole.Lawyer
            },
            new Lawyer{EmpId = 2, Firstname = "Ignacio", Lastname = "Holm", Seniority= ESeniority.Junior, Expertise = ECaseType.Family, DOB = DateTime.ParseExact("03-06-1988","dd-MM-yyyy", null), JoinedOn = DateTime.ParseExact("03-12-2020","dd-MM-yyyy", null), Role = ERole.Lawyer
            },
            new Lawyer{EmpId = 3, Firstname = "Olga", Lastname = "Komarova", Seniority = ESeniority.Junior, Expertise = ECaseType.Criminal, DOB = DateTime.ParseExact("08-08-1988","dd-MM-yyyy", null), JoinedOn = DateTime.ParseExact("03-12-2020","dd-MM-yyyy", null), Role = ERole.Lawyer
            },
            new Lawyer{EmpId = 4, Firstname = "Amanda", Lastname = "Perez", Seniority = ESeniority.Senior, Expertise = ECaseType.Criminal, DOB = DateTime.ParseExact("01-04-1994","dd-MM-yyyy", null), JoinedOn = DateTime.ParseExact("03-12-2019","dd-MM-yyyy", null), Role = ERole.Lawyer
            },
            new Lawyer{EmpId = 5, Firstname = "Peter", Lastname = "Gonzalez", Seniority = ESeniority.Senior, Expertise = ECaseType.Family, DOB = DateTime.ParseExact("03-06-1994","dd-MM-yyyy", null), JoinedOn = DateTime.ParseExact("03-12-2010","dd-MM-yyyy", null), Role = ERole.Lawyer
            },
            new Lawyer{EmpId = 6, Firstname = "Nikolaj", Lastname = "Johanson", Seniority = ESeniority.Senior, Expertise = ECaseType.Family, DOB = DateTime.ParseExact("03-06-1979","dd-MM-yyyy", null), JoinedOn = DateTime.ParseExact("03-12-2005","dd-MM-yyyy", null), Role = ERole.Lawyer
            },
            new Lawyer{EmpId = 7, Firstname = "Nacho", Lastname = "Garcia", Seniority = ESeniority.Junior, Expertise = ECaseType.Criminal, DOB = DateTime.ParseExact("03-06-1984","dd-MM-yyyy", null), JoinedOn = DateTime.ParseExact("03-12-2020","dd-MM-yyyy", null), Role = ERole.Lawyer
            },
            new Lawyer{EmpId = 8, Firstname = "Maria", Lastname = "Lastra", Seniority = ESeniority.Junior, Expertise = ECaseType.Family, DOB = DateTime.ParseExact("03-06-1985","dd-MM-yyyy", null), JoinedOn = DateTime.ParseExact("03-12-2020","dd-MM-yyyy", null), Role = ERole.Lawyer
            },
            new Lawyer{EmpId = 9, Firstname = "Ana", Lastname = "Mountbatten", Seniority = ESeniority.Junior, Expertise = ECaseType.Criminal, DOB = DateTime.ParseExact("03-06-1991","dd-MM-yyyy", null), JoinedOn = DateTime.ParseExact("03-12-2019","dd-MM-yyyy", null), Role = ERole.Lawyer
            },
            new Lawyer{EmpId = 10, Firstname = "Julia", Lastname = "Irujo", Seniority = ESeniority.Junior, Expertise = ECaseType.Family, DOB = DateTime.ParseExact("03-06-1992","dd-MM-yyyy", null), JoinedOn = DateTime.ParseExact("03-12-2017","dd-MM-yyyy", null), Role = ERole.Lawyer
            },
            new Lawyer{EmpId = 11, Firstname = "Emma", Lastname = "Vergara", Seniority = ESeniority.Junior, Expertise = ECaseType.Criminal, DOB = DateTime.ParseExact("03-06-1974","dd-MM-yyyy", null), JoinedOn = DateTime.ParseExact("03-12-2019","dd-MM-yyyy", null), Role = ERole.Lawyer
            },
            new Lawyer{EmpId = 12, Firstname = "John", Lastname = "", Seniority = ESeniority.Junior, Expertise = ECaseType.Family, DOB = DateTime.ParseExact("03-06-1963","dd-MM-yyyy", null), JoinedOn = DateTime.ParseExact("03-12-2004","dd-MM-yyyy", null), Role = ERole.Lawyer
            },
            new Lawyer{EmpId = 13, Firstname = "Juan", Lastname = "Fernandez", Seniority = ESeniority.Junior, Expertise = ECaseType.Family, DOB = DateTime.ParseExact("03-06-1994","dd-MM-yyyy", null), JoinedOn = DateTime.ParseExact("03-12-2013","dd-MM-yyyy", null), Role = ERole.Lawyer
            },
            new Lawyer{EmpId = 14, Firstname = "Javier", Lastname = "Gonzalez", Seniority = ESeniority.Junior, Expertise = ECaseType.Corporate, DOB = DateTime.ParseExact("03-06-1973","dd-MM-yyyy", null), JoinedOn = DateTime.ParseExact("03-12-2012","dd-MM-yyyy", null), Role = ERole.Lawyer
            },
            new Lawyer{EmpId = 15, Firstname = "Francis", Lastname = "Diaz", Seniority = ESeniority.Senior, Expertise = ECaseType.Corporate, DOB = DateTime.ParseExact("03-06-1979","dd-MM-yyyy", null), JoinedOn = DateTime.ParseExact("03-12-2007","dd-MM-yyyy", null), Role = ERole.Lawyer
            },
            new Lawyer{EmpId = 16, Firstname = "Maria", Lastname = "Luque", Seniority = ESeniority.Junior, Expertise = ECaseType.Criminal, DOB = DateTime.ParseExact("03-06-1962","dd-MM-yyyy", null), JoinedOn = DateTime.ParseExact("03-12-2005","dd-MM-yyyy", null), Role = ERole.Lawyer
            },
            new Lawyer{EmpId = 17, Firstname = "Manuel", Lastname = "Campeon", Seniority = ESeniority.Junior, Expertise = ECaseType.Corporate, DOB = DateTime.ParseExact("03-06-1985","dd-MM-yyyy", null), JoinedOn = DateTime.ParseExact("03-12-2005","dd-MM-yyyy", null), Role = ERole.Lawyer
            },
            new Lawyer{EmpId = 18, Firstname = "Anna", Lastname = "Gonzalez", Seniority = ESeniority.Junior, Expertise = ECaseType.Family, DOB = DateTime.ParseExact("03-06-1984","dd-MM-yyyy", null), JoinedOn = DateTime.ParseExact("03-12-2004","dd-MM-yyyy", null), Role = ERole.Lawyer
            },
            new Lawyer{EmpId = 19, Firstname = "Daniella", Lastname = "Morrison", Seniority = ESeniority.Junior, Expertise = ECaseType.Criminal, DOB = DateTime.ParseExact("03-06-1974","dd-MM-yyyy", null), JoinedOn = DateTime.ParseExact("03-12-2003","dd-MM-yyyy", null), Role = ERole.Lawyer
            },
            new Lawyer{EmpId = 20, Firstname = "Emmanuel", Lastname = "Lemus", Seniority = ESeniority.Junior, Expertise = ECaseType.Corporate, DOB = DateTime.ParseExact("03-06-1964","dd-MM-yyyy", null), JoinedOn = DateTime.ParseExact("03-12-2003","dd-MM-yyyy", null), Role = ERole.Lawyer
            },
            new Lawyer{EmpId = 21, Firstname = "Maria", Lastname = "Cerero", Seniority = ESeniority.Junior, Expertise = ECaseType.Family, DOB = DateTime.ParseExact("03-06-1986","dd-MM-yyyy", null), JoinedOn = DateTime.ParseExact("03-12-2000","dd-MM-yyyy", null), Role = ERole.Lawyer
            },
            new Lawyer{EmpId = 22, Firstname = "Julia", Lastname = "Capitan", Seniority = ESeniority.Junior, Expertise = ECaseType.Criminal, DOB = DateTime.ParseExact("03-06-1989","dd-MM-yyyy", null), JoinedOn = DateTime.ParseExact("03-12-2012","dd-MM-yyyy", null), Role = ERole.Lawyer
            },
              new Lawyer{EmpId = 23, Firstname = "Manuela", Lastname = "Concepcion", Seniority = ESeniority.Junior, Expertise = ECaseType.Corporate, DOB = DateTime.ParseExact("03-06-1990","dd-MM-yyyy", null), JoinedOn = DateTime.ParseExact("03-12-2018","dd-MM-yyyy", null), Role = ERole.Lawyer
            },
            new Lawyer{EmpId = 24, Firstname = "Fatima", Lastname = "Ros", Seniority = ESeniority.Senior, Expertise = ECaseType.Family, DOB = DateTime.ParseExact("03-06-1994","dd-MM-yyyy", null), JoinedOn = DateTime.ParseExact("03-12-2019","dd-MM-yyyy", null), Role = ERole.Lawyer
            },
            new Lawyer{EmpId = 25, Firstname = "Clementine", Lastname = "Aramburu", Seniority = ESeniority.Junior, Expertise = ECaseType.Criminal, DOB = DateTime.ParseExact("03-06-1977","dd-MM-yyyy", null), JoinedOn = DateTime.ParseExact("03-12-2007","dd-MM-yyyy", null), Role = ERole.Lawyer
            },
            new Lawyer{EmpId = 26, Firstname = "Susana", Lastname = "Nenuco", Seniority = ESeniority.Junior, Expertise = ECaseType.Criminal, DOB = DateTime.ParseExact("03-06-1988","dd-MM-yyyy", null), JoinedOn = DateTime.ParseExact("03-12-2008","dd-MM-yyyy", null), Role = ERole.Lawyer
            },

        };

        List<Administration> admins = new List<Administration>()
        {
            new Administration{EmpId = 27, Firstname = "Mette", Lastname = "Jensen", DOB = DateTime.ParseExact("08-03-1999","dd-MM-yyyy", null), AdminRole = EAdminRole.Support, Role = ERole.Administration},

            new Administration{EmpId = 28, Firstname = "Jack", Lastname = "Hansen", AdminRole = EAdminRole.Finances, Role = ERole.Administration},

            new Administration{EmpId = 29, Firstname = "Blanca", Lastname = "Bonito",  DOB = DateTime.ParseExact("03-06-1996","dd-MM-yyyy", null), JoinedOn = DateTime.ParseExact("03-12-2003","dd-MM-yyyy", null), Role = ERole.Administration, AdminRole = EAdminRole.IT
        },

        };

        List<Reception> receptionists = new List<Reception>()
        {
             new Reception{ EmpId = 30, Firstname = "Mette", Lastname = "Jensen", DOB = DateTime.ParseExact("08-03-1999","dd-MM-yyyy", null), Role = ERole.Reception, JoinedOn = DateTime.ParseExact("03-12-2003","dd-MM-yyyy", null) },
        };

        List<Client> clients = new List<Client>() {
              new Client{ ClientId = 1, Firstname = "Jan", Lastname = "Holm", City = "Copenhagen", CaseType = ECaseType.Family, Street = "Svanemoelevej", Zip = 2100, DOB = DateTime.ParseExact("03-06-1988","dd-MM-yyyy", null) },
              new Client{ ClientId = 2, Firstname = "Anna", Lastname = "Ryzh", City = "Copenhagen", CaseType = ECaseType.Criminal, Street = "Rebekkavej", Zip = 2100, DOB = DateTime.ParseExact("03-10-1966","dd-MM-yyyy", null),
              }

        };

        List<Clientcase> cases = new List<Clientcase>() {
                new Clientcase { IdCase = 1, CaseType = ECaseType.Corporate, LawyerId = 1, ClientId = 3, StartDate = DateTime.ParseExact("18-12-2020","dd-MM-yyyy", null), TotalCharges = 20000  }
        };

        List<Appointment> appointments = new List<Appointment>() {
                new Appointment {AppId = 1, ClientId = 3, AppointmentDate = DateTime.ParseExact("24-12-2020","dd-MM-yyyy", null), AppointmentTime = DateTime.ParseExact("11:00","HH:mm", null), LawyerId = 2, MeetingRoom = ERooms.Cave}
        };



        //***************************
        //    MENU AND LOGIN
        //***************************

        // the first method activated from Program.cs

        public void EntrySystem()
        {
            while (true)
            {
                DisplayMainMenu();
                int choiceRole;

                //validation of the input of chioceRole as integer
                bool valid; //which is false by default
                do { valid = int.TryParse(Console.ReadLine(), out choiceRole); }
                while (!valid);

                if (AuthenticateUser())  //same as ==true
                {
                    ShowMenuOption(choiceRole);
                }

                else
                {
                    Console.WriteLine("Incorrect User or Password... Try again!");

                }
            }
        }


        // method to validate user login

        private bool AuthenticateUser()
        {
            //prompting for the entries
            Console.WriteLine("Please provide your username:");
            string usernameInput = Console.ReadLine();

            //validation 
            while (string.IsNullOrEmpty(usernameInput))
            {
                Console.WriteLine("Username can't be empty! Please provide your username:");
                usernameInput = Console.ReadLine();
            }

            Console.WriteLine("Please provide your password:");
            string passwordInput = Console.ReadLine();

            while (string.IsNullOrEmpty(passwordInput))
            {
                Console.WriteLine("Password can't be empty! Please provide your password:");
                passwordInput = Console.ReadLine();
            }


            if (usernameInput == "a" && passwordInput == "a")
            { return true; }
            else { return false; }
        }


        // initial menu text

        private void DisplayMainMenu()
        {
            Console.WriteLine("What is your role in the company:");
            Console.WriteLine("1. Lawyer");
            Console.WriteLine("2. Administrator");
            Console.WriteLine("3. Receptionist");

        }


        //************************
        //      MAIN NAVIGATION
        // menu options depending on role
        //************************

        // user menu (built via if-esle statement, repeated inside the loop while depending on the initial choice of choiceRole)

        private void ShowMenuOption(int choiceRole)
        {

            while (true)
            {
                if (choiceRole == 1)
                {
                    Console.WriteLine("Choose action (lawyer)\n1. List all Cases\n2. Add a new Case\n3. List all Appointements");

                    int choiceMenu;

                    //validation of input as integer

                    bool valid; //false by default
                    do { valid = int.TryParse(Console.ReadLine(), out choiceMenu); }

                    while (!valid);

                    switch (choiceMenu)
                    {
                        case 1:
                            ListAllCases();
                            break;

                        case 2:
                            AddNewCase();
                            break;

                        case 3:
                            ListAllApppointments();
                            break;

                        default:
                            Console.WriteLine("Choose an action from the menu");
                            break;
                    }

                }

                else if (choiceRole == 2)
                {
                    Console.WriteLine("Choose action (admin)\n1. List all cases\n2. List all Appointements");

                    int choiceMenu;

                    //validation of input as integer

                    bool valid; //false by default
                    do { valid = int.TryParse(Console.ReadLine(), out choiceMenu); }
                    while (!valid);


                    switch (choiceMenu)
                    {
                        case 1:
                            ListAllCases();
                            break;

                        case 2:
                            ListAllApppointments();
                            break;


                        default:
                            Console.WriteLine("Choose an action from the menu");
                            break;
                    }
                }

                else if (choiceRole == 3)
                {
                    Console.WriteLine("Choose action (Receptionist)\n1. Register a new client\n2. Add a new Appointemnt\n3. List all Appointments\n4. List all Clients");

                    int choiceMenu;

                    //validation of input as integer

                    bool valid; //false by default
                    do { valid = int.TryParse(Console.ReadLine(), out choiceMenu); }
                    while (!valid);

                    switch (choiceMenu)
                    {
                        case 1:
                            AddNewClient();
                            break;
                        case 2:
                            AddNewAppointment();
                            break;
                        case 3:
                            ListAllApppointments();
                            break;
                        case 4:
                            ListAllClients();
                            break;

                        default:
                            Console.WriteLine("Choose an action from the menu");
                            break;
                    }
                }

                else
                {
                    Console.WriteLine("Can not find this role. Make your choice again!");
                }
            }
        }


        //**********************
        //       METHODS
        //**********************

        private void AddNewClient()
        {
            Client client = new Client();
            Console.WriteLine("Creating a New Client");
            Console.WriteLine("***********");
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

            // collecting answer from user and validation of input as integer
            int caseType;
            bool valid; //false by default
            do { valid = int.TryParse(Console.ReadLine(), out caseType); }
            while (!valid);

            if (caseType == 1)
                client.CaseType = ECaseType.Corporate;
            else if (caseType == 2)
                client.CaseType = ECaseType.Family;
            else if (caseType == 3)
                client.CaseType = ECaseType.Criminal;
            else
                client.CaseType = ECaseType.Unknown;

            clients.Add(client); //adding created object to the list of objects
            Console.WriteLine("New Client's record is created:");
            Console.WriteLine(client.ShowInfo());
        }

        private void ListAllClients()
        {
            foreach (Client c in clients)
            {
                Console.WriteLine(c.ShowInfo());
            }

        }

        private void ListAllApppointments()
        {
            if (appointments.Any()) //using system.LINQ library which has a method of checking, if objects exist in the list and returns true or false
            {
                foreach (Appointment c in appointments)
                {
                    Console.WriteLine(c.ShowInfo());
                }
            }
            else { Console.WriteLine("No appointments planned\n********************"); }
        }

        private void AddNewCase()
        {

            Console.WriteLine("Creating a new Case");

            Console.WriteLine("Enter Lawyer ID:");

            // collecting answer from user and validation of input as integer
            int idInput;
            bool valid; //false by default
            do { valid = int.TryParse(Console.ReadLine(), out idInput); }
            while (!valid);

            //creating object lawyer with the requested id via search method
            Lawyer lawyer = FindLawyer(idInput);

            if (lawyer != null)
            {
                Clientcase clientcase = new Clientcase();

                clientcase.LawyerId = lawyer.EmpId;

                lawyer.GreetEmployee();

                Console.WriteLine("Enter Client's ID:");

                int clientId;
                bool valid1; //false by default
                do { valid1 = int.TryParse(Console.ReadLine(), out clientId); }
                while (!valid1);

                Client client = FindClient(clientId);

                clientcase.ClientId = client.ClientId;

                Console.WriteLine("***********************");
                Console.WriteLine($"Info about the Client:\n{client.ShowShortInfo()}");

                if (client.CaseType != lawyer.Expertise)
                {
                    Console.WriteLine($"Hello, {lawyer.Firstname} are you sure you have enough expertise for this? Better ask your collegue");
                }

                else
                {
                    Console.WriteLine("Assigning Id Case:");
                    clientcase.IdCase = int.Parse(Console.ReadLine());
                    clientcase.CaseType = client.CaseType;

                    clientcase.StartDate = DateTime.Now; //assigning start date of the case to the current date

                    Console.WriteLine("Enter the total charge of Client:");
                    clientcase.TotalCharges = int.Parse(Console.ReadLine());

                    cases.Add(clientcase);

                    Console.WriteLine("New Case created:");
                    Console.WriteLine($"{clientcase.ShowInfo()}\nClient:\n{client.ShowShortInfo()}");
                }
            }

            else
            {
                Console.WriteLine("The ID does not exist");
                Console.WriteLine("Please start creating the Case from beginning");
                AddNewCase();
            }

        }

        private void ListAllCases()
        {
            if (cases.Any()) //using system.LINQ library which has a method of checking if objects exist in the list through operator Any, returns bool
            {
                foreach (Clientcase c in cases)
                {
                    Console.WriteLine(c.ShowInfo());
                }
            }
            else { Console.WriteLine("No cases are found in the system\n********************"); }

        }

        private void AddNewAppointment()
        {
            Console.WriteLine("Creating a new Appointment");

            Console.WriteLine("Existing Client? (Y or N)");

            string answer = Console.ReadLine().ToLower();

            if (answer == "y")
            {
                Appointment appointment = new Appointment();

                Console.WriteLine("Enter Client's ID:");
                int clientId = int.Parse(Console.ReadLine());
                Client i = FindClient(clientId);
                appointment.ClientId = i.ClientId;
                Console.WriteLine("***********************");
                Console.WriteLine($"Info about the Client:\n{i.ShowShortInfo()}");

                Console.WriteLine("***********************");
                Console.WriteLine("List of lawyers with the matching expertise:");

                //searching for the matching experitise 
                var foundLawyerslist = lawyers.FindAll(x => x.Expertise == i.CaseType);

                foreach (Lawyer lawyer in foundLawyerslist)
                {
                    Console.WriteLine(lawyer.ShowInfo());
                }

                Console.WriteLine("Assign the lawyer by typing Laywer's last name:");
                string lawyerAssigned = Console.ReadLine().ToLower();


                Lawyer l = lawyers.Find(x => x.Lastname.ToLower() == lawyerAssigned);
                appointment.LawyerId = l.EmpId;


                Console.WriteLine("Appointment ID:");
                appointment.AppId = int.Parse(Console.ReadLine());

                Console.WriteLine("Appointment's date (dd-MM-yyyy):");
                appointment.AppointmentDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
                Console.WriteLine("Appointment's time (HH:mm):");
                appointment.AppointmentDate = DateTime.ParseExact(Console.ReadLine(), "HH:mm", null);


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
                Console.WriteLine($"Client: {i.Firstname} {i.Lastname} from {i.City} (case: {i.CaseType} law)");
                Console.WriteLine($"Lawyer assigned: {l.Firstname} {l.Lastname} specialised in {l.Expertise} law and with seniority as {l.Seniority}");
                Console.WriteLine($"Date of appointment: {appointment.AppointmentDate.ToShortDateString()}");
                Console.WriteLine($"Time of appointment: {appointment.AppointmentTime.ToShortTimeString()}");
                Console.WriteLine("******************************");

            }

            else { AddNewClient(); }
        }

        //helping search functions
        private Client FindClient(int clientId)
        {
            var clientObj = clients.Find(x => x.ClientId == clientId); // Lambda operator
            return clientObj;
        }

        private Lawyer FindLawyer(int empId)
        {
            var lawyerObj = lawyers.Find(x => x.EmpId == empId);
            return lawyerObj;
        }
    }

}

