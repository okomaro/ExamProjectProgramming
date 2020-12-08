using System;
using System.Collections.Generic;
using System.Text;

namespace ExamProject
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

        public abstract string ShowInfo();

    }


        //Inherited classes

        // Lawer: child class 
        // additional info about lawers: Seniority and Expertise

        public class Lawer : Person
        {
            public ESeniority Seniority { get; set; }
            public ECaseType Expertise { get; set; }

        public override string ShowInfo()
        {
            StringBuilder textResult = new StringBuilder();
          textResult.AppendLine($"*** Lawer Id: {Id} ***");
            textResult.AppendLine($"Name: {Firstname} {Lastname}");
            textResult.AppendLine($"Seniority: {Seniority} level");
            textResult.AppendLine($"Expertise: {Expertise} law");

            return textResult.ToString();
        }
    }

       

        // Administration: child class 
        // additional info: role in the company

        public class Administration : Person
        {
            public ERole Role { get; set; }

        public override string ShowInfo()
        {
            throw new NotImplementedException();
        }
    }


    // Receptionist: child class 
    public class Reception : Person
    {
        public override string ShowInfo()
        {
            StringBuilder textResult = new StringBuilder();
            textResult.AppendLine($"*** Receptionist Id: {Id} ***");
            textResult.AppendLine($"Id: {Id}");
            textResult.AppendLine($"Name: {Firstname} {Lastname}");     
            textResult.AppendLine($"Dob: {DOB.ToString("dd/MM/yyyy")}");

            return textResult.ToString();
        }
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

        public override string ShowInfo()
        {
            StringBuilder textResult = new StringBuilder();
            textResult.AppendLine($"*** Client Id: {Id} ***");
            textResult.AppendLine($"Name: {Firstname} {Lastname}, born { DOB.ToString("dd/MM/yyyy")}");
            textResult.AppendLine($"Adress: {Street}, {City}, {Zip}");
            textResult.AppendLine($"Case type: {CaseType} law");
            textResult.AppendLine("*** ******** ***");

            return textResult.ToString();
        }
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
