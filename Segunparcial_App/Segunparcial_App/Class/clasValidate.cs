using System;
using System.Collections.Generic;
using System.Text;

namespace Segunparcial_App.Class
{
    public class clasValidate
    {
        string FirstN, LastN, Message;
        int Year, YearOld;
        double SalaryT;

        public clasValidate(string NameF, string NameL, int YearB)
        {
            FirstN = NameF;
            LastN = NameL;
            Year = YearB;
        }

        public string Mensajefinal(string inicial, int salary)
        {
            inicial = inicial.ToUpper();
            YearOld = 2018 - Year;

            if (inicial.Equals("A") || inicial.Equals("B") || inicial.Equals("C"))
            {
                SalaryT = salary * 1.5;
                Message = "Señor " + FirstN + " " + LastN + " es grato para nosotros informale que el proceso fue exitosamente realizado, teniendo" +
                    " presente que la edad que usted tiene es de " + YearOld + " años y teniendo en cuenta que el nombre que usted tiene " +
                    " comienza con la letra " + inicial + " su valor final es de " + SalaryT;

                return Message;
            }

            if (inicial.Equals("D") || inicial.Equals("E") || inicial.Equals("F"))
            {
                SalaryT = salary * 0.95;
                Message = "Señor " + FirstN + " " + LastN + " es grato para nosotros informale que el proceso fue exitosamente realizado, teniendo" +
                    " presente que la edad que usted tiene es de " + YearOld + "años y teniendo en cuenta que el nombre que usted tiene " +
                    "comienza con la letra " + inicial + " su valor final es de " + SalaryT;

                return Message;

            }

            else
            {
                Message = "Señor " + FirstN + " " + LastN + " es grato para nosotros informale que el proceso fue exitosamente realizado, teniendo" +
                    " presente que la edad que usted tiene es de " + YearOld + "años y teniendo en cuenta que el nombre que usted tiene " +
                    "comienza con la letra " + inicial + " su valor final es de " + salary;

                return Message;
            }
        }
    }
}