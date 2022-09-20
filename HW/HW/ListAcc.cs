using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW
{

    class ListAcc<T>
    {
        public string name;
        public string surname;
        public long numAcc;
        public int ballance;
        public string type;
        public static int Count { get; }

        public ListAcc(string name, string surname, long numAcc, int ballance, string type)
        {
            this.name = name;
            this.surname = surname;
            this.numAcc = numAcc;
            this.ballance = ballance;
            this.type = type;
        }

        public ListAcc() { }

        internal static void Add(ListAcc<T>)
        {

        }

        public string Write()
        {

            Console.WriteLine($"Колличество человек в списке: {(object)ListAcc<T>.Count}");
            Console.WriteLine("Введите номер человека:");
            int name = Convert.ToInt32(Console.ReadLine());
            long acc = this.numAcc;
            int ball = this.ballance;

            Type typeacc = typeof(TypeAcc);



            string R = Console.WriteLine(value: $"Имя: {this.name[name]};\nФамилия: {this.surname[name]};\nНомер счета: {acc};\nБаланс: {this.ballance};\nТип счета: {this.type[name]}");
            return R;
        }
    }
}
