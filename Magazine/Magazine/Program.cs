using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
        }
    }

    class Magazine
    {

        public string Publisher;

        public string ISSN_Num;

        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public int Price
        {
            get
            {
                return Price;
            }
            set
            {
                Price = value;
            }
        }
    }

    class Newsstand
    {
        private Magazine[] mass;

        Newsstand (int size)
        {
            mass = new Magazine [size];
        }
        
        private void AddMagazine()
        {
            int size = mass.Length;
            for (int i = 0; i < size; i++)
            {
                
                Magazine magazine = new Magazine();
                Console.Write("Название: ");
                magazine.Name = Console.ReadLine();

                Console.Write("Издатель: ");
                magazine.Publisher = Console.ReadLine();

                Console.Write("Цена: ");
                magazine.Price = Convert.ToInt32(Console.ReadLine());

                Console.Write("Номер ISSN: ");
                magazine.ISSN_Num = Console.ReadLine();

            }

        }
    }
}
