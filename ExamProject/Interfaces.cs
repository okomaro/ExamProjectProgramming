using System;
using System.Collections.Generic;

namespace ExamProject
{
    public interface IMethods

    //by creating interface we are thinking of what exactly we need to return and what will have as an input


    {
        List<Database> AddNewClient();

        List<Database> AddNewAppointment();

        List<Database> AddNewCase();

        List<Database> ListClients(List<Database> db);

        List<Database> ListAppointments(List<Database> db);

    }
}
