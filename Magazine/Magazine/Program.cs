using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Magazine
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите количество записей: ");

                int size = Convert.ToInt32(Console.ReadLine());

                if (size < 1)
                {
                    Console.WriteLine("Необходима хотя бы 1 запись!");                   
                }

                Newsstand ns = new Newsstand(size);

                Console.WriteLine($"Введите {size} записи");
                ns.AddMagazine();
                ns.ArrMagazine();

                Console.WriteLine("Отсортированные записи: ");
                ns.Sort();
                ns.ArrMagazine();

                Console.WriteLine("Массив сохранен ");
                ns.Save();

                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Ошибка");
                Console.ReadKey();
            }

        }
    }
    public class Magazine
    {
        private string name;

        private int price;

        private string publisher;

        private string iSSN_Num;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public string Publisher
        {
            get
            {
                return publisher;
            }
            set
            {
                publisher = value;
            }
        }
        public string ISSN_Num
        {
            get
            {
                return iSSN_Num;
            }
            set
            {
                iSSN_Num = value;
            }
        }
    }
    class Newsstand
    {
        private Magazine[] mass;
        public Newsstand(int size)
        {
            mass = new Magazine[size];
        } 

        public void AddMagazine()
        {
            int size = mass.Length;
            for (int i = 0; i < size; i++)
            {

                Magazine magazine = new Magazine();
                Console.Write("Название: ");
                magazine.Name = Console.ReadLine();

                Console.Write("Цена: ");
                magazine.Price = Convert.ToInt32(Console.ReadLine());

                Console.Write("Издатель: ");
                magazine.Publisher = Console.ReadLine();

                Console.Write("Номер ISSN: ");
                magazine.ISSN_Num = Console.ReadLine();

                mass[i] = magazine;


            }
        }

        public void ArrMagazine()
        {

            foreach (Magazine magazine in mass)
                Console.WriteLine($"Название: {magazine.Name} Цена: {magazine.Price} Издатель: {magazine.Publisher} Номер ISSN: {magazine.ISSN_Num}");
            
        }
        public void Save()
        {
            string path = $"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\\Result.txt";
            using (StreamWriter writer = new StreamWriter(File.Open(path, FileMode.Create)))
            {
                foreach (Magazine magazine in mass)
                    writer.WriteLine($"Название: {magazine.Name} Цена: {magazine.Price} Издатель: {magazine.Publisher} Номер ISSN: {magazine.ISSN_Num}");
            }
        }

        public void Sort()
        {
            Array.Sort(mass, (x, y) => (x.Price + " " + x.Name).CompareTo(y.Price + " " + y.Name));
        }
    }  
}
