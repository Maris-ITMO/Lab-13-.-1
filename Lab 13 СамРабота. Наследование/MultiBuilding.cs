using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13_СамРабота._Наследование
{
    sealed class MultiBuilding : Building
    {
        private string numberOfFloors;

        public MultiBuilding(string address, string length, string width, string height, string numberOfFloors)
            : base(address, length, width, height)
        {
            this.numberOfFloors = numberOfFloors;
        }

        public string NumberOfFloors
        {
            get
            {
                return numberOfFloors;
            }
            set
            {
                NumberOfFloors = value;
            }
        }

        public new string Print()
        {
            return $" Адрес:{Address} \n" + $" Длина здания:{Length} \n" + $" Ширина здания:{Width} \n" + $" Высота здания:{Height} \n" + $" Количество этажей: {NumberOfFloors}";
        }
    }
}

