using HW;
using NPOI.SS.Formula.Functions;

static void Main(string[] args)
{
    string fname = null;
    string sname = null;
    while (fname == null)
    {
        Console.WriteLine("Введите Имя:");
        fname = Console.ReadLine();
    }

    while (sname == null)
    {
        Console.WriteLine("Введите Фамилию:");
        sname = Console.ReadLine();
    }

    Random rnd = new Random();
    long num = (long)(rnd.NextDouble()*4999999999999 - 40000000000000)* long.MaxValue;
    Console.WriteLine("Введите начальную сумму(пример: 50000):");
    int sBall = Convert.ToInt32( Console.ReadLine());

    Console.WriteLine("Выеберети тип счета (0 - крдитный, 1 - дебетовый, 2 - накопительный):");
    int tAcc = Convert.ToInt32( Console.ReadLine());
    

    Account newAcc = new Account(fname, sname, num, sBall, tAcc);

    string check;
    Console.Write("Посмотреть список всех клиентов банка?(Да.Нет): ");
    check = Console.ReadLine();
    if (check == "Да")
    {
        ListAcc<T> call = new ListAcc<T>();
        call.Write();
    }
        
}