using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    class Account : ListAcc<T>
    {
        public double NumAcc { get; set; }
        public int Ballance { get; set; }
        enum TypeAcc
        {
            Кредитный = 0,
            Дебетовый = 1,
            Накопительный = 2
        };

        public Account (string name, string surname, long numAcc, int Ballance, int type)
        {
        
            ListAcc<T> p = new ListAcc<T>(name, surname, numAcc, Ballance, type);
            ListAcc<T>.Add(p);
        }
    }
}
