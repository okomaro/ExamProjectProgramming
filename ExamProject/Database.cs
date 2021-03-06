﻿using System;

using System.Text;


namespace ExamProject
{
    //Base class

    //general info about every employee:

    //Id, Firstname, Lastname, DOB, JoinedOn

    public abstract class Employee
    {
        public int EmpId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DOB { get; set; }
        public DateTime JoinedOn { get; set; }
        public ERole Role { get; set; }
        public abstract string ShowInfo();

        //greeting user
        public virtual void GreetEmployee()
        { Console.WriteLine($"Hello {Firstname} {Lastname}!"); }

    }


    // Derived classes

    // Lawyer: child class 
    // additional info about lawyers: Seniority and Expertise

    public class Lawyer : Employee
    {
        public ESeniority Seniority { get; set; }
        public ECaseType Expertise { get; set; }

        public override string ShowInfo()
        {
            StringBuilder textResult = new StringBuilder();
            textResult.AppendLine($"*** Lawyer's Id: {EmpId} ***");
            textResult.AppendLine($"Name: {Firstname} {Lastname}");
            textResult.AppendLine($"Seniority: {Seniority} level");
            textResult.AppendLine($"Expertise: {Expertise} law");

            return textResult.ToString();
        }
    }


    // Administration: child class 
    // additional info: admin role in the company

    public class Administration : Employee
    {
        public EAdminRole AdminRole { get; set; }

        public override string ShowInfo()
        {
            return "Nothing here";
        }
    }


    // Receptionist: child class 
    public class Reception : Employee
    {
        public override string ShowInfo()
        {
            StringBuilder textResult = new StringBuilder();
            textResult.AppendLine($"*** Receptionist's Id: {EmpId} ***");
            textResult.AppendLine($"Name: {Firstname} {Lastname}");
            textResult.AppendLine($"Dob: {DOB.ToShortDateString()}");
            return textResult.ToString();
        }
    }



    // Client: parent class

    public class Client

    {
        public int ClientId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DOB { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }
        public ECaseType CaseType { get; set; }


        public virtual string ShowInfo()
        {
            StringBuilder textResult = new StringBuilder();
            textResult.AppendLine($"*** Client's Id: {ClientId} ***");
            textResult.AppendLine($"Name: {Firstname} {Lastname}, born { DOB.ToString("dd/MM/yyyy")}");
            textResult.AppendLine($"Adress: {Street}, {City}, {Zip}");
            textResult.AppendLine($"Case type: {CaseType} law");
            textResult.AppendLine("*** ******** ***");

            return textResult.ToString();
        }


        public virtual string ShowShortInfo()
        {
            StringBuilder textResult = new StringBuilder();
            textResult.AppendLine($"{Firstname} {Lastname} Id: {ClientId} Case type: {CaseType} law");
            return textResult.ToString();
        }
    }

    //Interface to make sure the connection between case and appointment with lawyer and client

    interface IConnection
    {
         int LawyerId { get; set; }
         int ClientId { get; set; }
    }

    // Appointment
    //general info about an appointment:
    //Id, ClientId, LawyerId, Datetime, MeetingRoom

    public class Appointment : IConnection
    {
        public int AppId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime AppointmentTime { get; set; }
        public ERooms MeetingRoom { get; set; }
        public int ClientId { get ; set ; }
        public int LawyerId { get; set; }

        public  string ShowInfo()
        {
            StringBuilder textResult = new StringBuilder();
            textResult.AppendLine($"Appointment Id: {AppId}");
            textResult.AppendLine($"Date: {AppointmentDate.ToShortDateString()}");
            textResult.AppendLine($"Time: {AppointmentTime.ToShortTimeString()}");
            textResult.AppendLine($"Room: {MeetingRoom}");
            textResult.AppendLine($"Lawyer's ID: {LawyerId}");
            textResult.AppendLine($"Client's ID: {ClientId}");
            textResult.AppendLine("*************************");

            return textResult.ToString();
        }

    }



    // Case:
    //general info about an case:
    //Id, IdCustomer, Casetype(Corporate, Family or Criminal), Startdate, TotalCharges, 

    public class Clientcase : IConnection
    {
        public int IdCase { get; set; }
        public ECaseType CaseType { get; set; }
        public DateTime StartDate { get; set; }
        
        public int TotalCharges { get; set; }

        public int LawyerId { get; set; }
        public int ClientId { get; set; }


        public string ShowInfo()
        {
            StringBuilder textResult = new StringBuilder();
            textResult.AppendLine($"*** Case Id: {IdCase} ***");
            textResult.AppendLine($"Start Date: {StartDate.ToShortDateString()}");
            textResult.AppendLine($"Total charges: {TotalCharges.ToString("C")}");
            textResult.AppendLine($"Lawyer's ID: {LawyerId}");
            textResult.AppendLine($"Client's ID: {ClientId}");
            textResult.AppendLine("*** ******** ***");

            return textResult.ToString();
        }

        public string ShowConnectedInfo()

        {
            StringBuilder textResult = new StringBuilder();

 

            return textResult.ToString();

        }

    }

}
