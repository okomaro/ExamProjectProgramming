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

        
            RoleAccess(choice);
        }

        private void DisplayMainMenu()
        {
            Console.WriteLine("Who are you\nChoose type\n1. Lawer\n2. Administration\n3. Receptionist");
        }

        private void RoleAccess(int choice)
        {
            if (AuthenticateUser() == true)
            {
                switch (choice)
                {
                    case 1:

                        var lawer = new Database.Lawer();
                        Console.WriteLine("Lawer tested");
                        break;

                    case 2:

                        var admin = new Database.Administration();
                        Console.WriteLine("Admin tested");

                        break;


                    case 3:
                        var receptionist = new Database.Reception();
                        Console.WriteLine("Reception tested");

                        break;


                    default:
                        Console.WriteLine("Please make your choice!");
                        break;
                }


            }

            else
            {
                Console.WriteLine("Incorrect user or password. \nTry again!");
                AuthenticateUser();
            }
        }


        // method to validate the user
        private bool AuthenticateUser()
        {
            //prompting for the entries
            Console.WriteLine("Please provide username to access the LegalX system");
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



    } //end of class Processor

}

