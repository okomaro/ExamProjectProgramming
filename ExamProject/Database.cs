using System;
namespace ExamProject
{
    public class Database
    {
        //general info about every person:
        //Id, Firstname, Lastname, DOB, JoinedOn
        public abstract class Person
        {
            public int Id { get; set; }
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public DateTime DOB { get; set; }
            public DateTime JoinedOn { get; set; }
        }


        //Inherited classes

        // Lawer: child class 
        // additional info about lawers: Seniority and Expertise

        public class Lawer : Person
        {
            public ESeniority Seniority { get; set; }
            public ECaseType Expertise { get; set; }

        }



        // Administration: child class 
        // additional info: role in the company

        public class Administration : Person
        {
            public ERole Role { get; set; }
        }

        // Receptionist: child class 
        public class Reception : Person
        {

        }



        // Client: child class
        //specific info about a client:
        //CaseType, Street, Zip, City

        public class Client : Person
        {
            public string Street { get; set; }
            public string City { get; set; }
            public int Zip { get; set; }
            public ECaseType CaseType { get; set; }

        }



        // Appointment: inheritance from Client 
        //general info about an appointment:
        //Id, ClientId, LawyerId, Datetime, MeetingRoom

        public class Appointment : Client
        {
            public int IdApp { get; set; }
            public DateTime AppointmentDate { get; set; }
            public ERooms MeetingRoom { get; set; }
            public int LawyerId { get; set; }

        }



        // Case: inheritance from Lawer 
        //general info about an case:
        //Id, IdCustomer, Casetype(Corporate, Family or Criminal), Startdate, TotalCharges, LawyerId (id from parent)

        public class Case : Lawer
        {
            public int IdCase { get; set; }
            public ECaseType CaseType { get; set; }
            public DateTime StartDate { get; set; }
            public int IdCustomer { get; set; }
            public int TotalCharges { get; set; }

        }

    }
}
