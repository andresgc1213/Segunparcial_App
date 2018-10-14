using System;
using System.Collections.Generic;
using System.Text;
using Segunparcial_App.Views;

namespace Segunparcial_App.Class
{
    public class clasConditions
    {
        int Salary, Date;
        string FirstN, LastN;

        View1 vP1 = new View1();

        public clasConditions(int Salar, int Year, string Name, string LName)
        {
            Salary = Salar;
            Date = Year;
            FirstN = Name;
            LastN = LName;
        }

        public int ValidateYear()
        {

            if (Date.ToString().Length == 4)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int ValidateSalary()
        {
            if (Salary > 737000 && Salary < 900001)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


    }
}