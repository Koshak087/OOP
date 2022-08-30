using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW
{
    class ListAcc<T>
    {
        private string name;
        private string surname;
        private long numAcc;
        private int ballance;
        private int type;
        public static int Count { get; }

        public ListAcc(string name, string surname, long numAcc, int ballance, int type)
        {
            this.name = name;
            this.surname = surname;
            this.numAcc = numAcc;
            this.ballance = ballance;
            this.type = type;
        }

        internal static void Add(ListAcc<T> p)
        {
         
            throw new NotImplementedException();
            
        }

        public string Write()
        {
            
            Console.WriteLine($"Колличество человек в списке: {(object)ListAcc<T>.Count}");
            Console.WriteLine("Введите номер человека:");
            var name = Convert.ToInt32(Console.ReadLine());
            long acc = name;
            string R = Console.WriteLine(value: $"Имя: {this.name[name]};\nФамилия: {this.surname[name]};\nНомер счета: {this.numAcc[acc]};\nБаланс: {this.ballance[name]};\nТип счета: {this.type[name]}");
            return R;
        }
    }
}
