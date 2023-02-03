using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13_СамРабота._Наследование
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Информация о здании:");
            Building building = new Building(" Серова", " 111", " 222", " 333");
            Console.WriteLine(building.Print());
            MultiBuilding multiBuilding = new MultiBuilding("             ТрЫндЭц ((( как это ТяжкО", "      Понять", "     Алгоритм ", "     Работы", "Программы ((( ");
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}
