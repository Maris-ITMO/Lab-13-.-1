using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13_СамРабота._Наследование
{
    class Building
    {
        private string address;
        private string length;
        private string width;
        private string height;

        public Building(string address, string length, string width, string height)
        {
            this.address = address;
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }
        public string Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        public string Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public string Print()
        {
            return $" Адрес:{Address} \n" + $" Длина здания:{Length} \n" + $" Ширина здания:{Width} \n" + $" Высота здания:{Height} \n";
        }
    }
}