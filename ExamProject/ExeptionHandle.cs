using System;
namespace ExamProject
{


    class ExeptionHandleInt : Exception
    {
       

        public ExeptionHandleInt(int input)
            : base(String.Format("Invalid Input: {0}", input))
        {

        }

    }
}
