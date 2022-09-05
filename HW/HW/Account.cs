using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{

    enum TypeAcc
    {
        Кредитный,
        Дебетовый,
        Накопительный
    };
    class Account
    {
        /*public double NumAcc { get; set; }
        public int Ballance { get; set; }*/

        public Account(string name, string surname, long numAcc, int Ballance, string type)
        {

            ListAcc<T> p = new ListAcc<T>(name, surname, numAcc, Ballance, type);
            ListAcc<T>.Add(p);
        }
    }
}
