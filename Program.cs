using System;

namespace Lab10
{
    class Bus
    {
        public string fio;
        public int numberOfBus;
        public int numberOfRoute;
        public string brand;
        public int yearOfExploitation;
        public int mileage;

    

        public Bus(string fio, int numberOfBus, int numberOfRoute, string brand, int yearOfExploitation)
        {
            this.fio = fio;
            this.numberOfBus = numberOfBus;
            this.numberOfRoute = numberOfRoute;
            this.brand = brand;
            this.yearOfExploitation = yearOfExploitation;
            mileage = 201;
        }

        public Bus(int numberOfBus, int numberOfRoute, string brand, int yearOfExploitation, int mileage)
        {
            fio = "Иванов Иван Иванович";
            this.numberOfBus = numberOfBus;
            this.numberOfRoute = numberOfRoute;
            this.brand = brand;
            this.yearOfExploitation = yearOfExploitation;
            this.mileage=mileage;

        }

        public Bus( int numberOfRoute, string brand, int yearOfExploitation, int mileage)
        {
            fio = "Иванов Иван Иванович";
            numberOfBus = 4;
            this.numberOfRoute = numberOfRoute;
            this.brand = brand;
            this.yearOfExploitation = yearOfExploitation;
            this.mileage = mileage;
        }

        public Bus(string brand, int yearOfExploitation, int mileage, string fio = "Иванов Иван Иванович", int numberOfBus = 5,int numberOfRoute= 17 )
        {
            this.fio = fio;
            this.numberOfBus = numberOfBus;
            this.numberOfRoute = numberOfRoute;
            this.brand = brand;
            this.yearOfExploitation = yearOfExploitation;
            this.mileage = mileage;
        }

        public Bus( int yearOfExploitation, int mileage, string fio = "Иванов Иван Иванович", int numberOfBus = 6, int numberOfRoute = 17, string brand="opel")
        {
            this.fio = fio;
            this.numberOfBus = numberOfBus;
            this.numberOfRoute = numberOfRoute;
            this.brand = brand;
            this.yearOfExploitation = yearOfExploitation;
            this.mileage = mileage;

        }
        public Bus( int mileage, string fio = "Иванов Иван Иванович", int numberOfBus = 7, int numberOfRoute = 18, string brand = "kia", int yearOfExploitation = 1995)
        {
            this.fio = fio;
            this.numberOfBus = numberOfBus;
            this.numberOfRoute = numberOfRoute;
            this.brand = brand;
            this.yearOfExploitation = yearOfExploitation;
            this.mileage = mileage;

        }


        public string Fio
        {
            get
            {
                return fio;

            }
            set
            {
                fio = value;
            }
        }

        public int NumberOfBus
        {
            get
            {
                return numberOfBus;

            }
            set
            {
                numberOfBus = value;
            }
        }

        public int NumberOfRoute
        {
            get
            {
                return numberOfRoute;

            }
            set
            {
                numberOfRoute = value;
            }
        }

        public string Brand
        {
            get
            {
                return brand;

            }
            set
            {
                brand = value;
            }
        }

        public int YearOfExploitation
        {
            get
            {
                return yearOfExploitation;

            }
            set
            {
                yearOfExploitation = value;
            }
        }

        public int Mileage
        {
            get
            {
                return mileage;

            }
            private set
            {
                mileage = value;
            }
        }
        public override string ToString()
        {
            return brand.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bus obj1 = new Bus();
            Bus obj2 = new Bus("Иванов Иван Иванович", 1, 15, "bmw", 1991);
            Bus obj3 = new Bus(3, 16, "toyota", 1992, 201);
            Bus obj4 = new Bus(16, "lexus", 1993, 201);
            Bus obj5 = new Bus("ferrari", 1993, 202);
            Bus obj6 = new Bus(1994, 203);
            Bus obj7 = new Bus(204);
            Bus obj8 = new Bus();
            Bus obj9 = new Bus();
            Bus obj10 = new Bus();
            List<Bus> list = new List<Bus>();
            list.Add(obj1);
            list.Add(obj2);
            list.Add(obj3);
            list.Add(obj4);
            list.Add(obj5);
            list.Add(obj6);
            list.Add(obj7);
            list.Add(obj8);
            list.Add(obj9);
            list.Add(obj10);
            int min = 1000;
            foreach (var obj in list)
            {
                if (obj.mileage < min)
                    min = obj.mileage;
            }
            Console.Write("Укажите номер маршрута:");
            int userRoute = Convert.ToInt32(Console.ReadLine());
            var selecteList1 = from p in list where p.NumberOfRoute == userRoute select p;
            Console.Write("Cписок автобусов для заданного номера маршрута:");
            foreach (var l in selecteList1)
            {
                Console.Write($"{l}, ");
            }
            Console.WriteLine();
            Console.WriteLine();


            Console.Write("Укажите год эксплуатации:");
            int userYear = Convert.ToInt32(Console.ReadLine());
            var selecteList2 = from p in list where p.YearOfExploitation < userYear select p;
            Console.Write("Список автобусов, которые эксплуатируются больше \r\nзаданного срока:");
            foreach (var l in selecteList2)
            {
                Console.Write($"{l}, ");
            }
            Console.WriteLine();
            Console.WriteLine();


            var selecteList3 = from p in list where p.mileage == min select p;
            Console.Write("Минимальный по пробегу автобус:");
            foreach (var l in selecteList3)
            {
                Console.Write($"{l}, ");
            }
            Console.WriteLine();
            Console.WriteLine();

            var selecteList4 = (from p in list orderby p.mileage select p).ElementAt(8);
            var selecteList5 = (from p in list orderby p.mileage select p).ElementAt(9);
            Console.Write($"последние два автобуса максимальные по пробегу:{selecteList4},{selecteList5}");
            Console.WriteLine();
            Console.WriteLine();

            var selecteList6 = from p in list orderby p.mileage select p;
            Console.Write("упорядоченный список автобусов по номеру:");
            foreach (var l in selecteList6)
            {
                Console.Write($"{l}, ");
            }


            Console.WriteLine();
            Console.WriteLine();
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            Console.Write("Введите n:");
            int userLength = Convert.ToInt32(Console.ReadLine());
            var selectedMonth1 = from p in months where p.Length == userLength select p;
            Console.Write("Названия месяцев с длиной n:");
            foreach (string month in selectedMonth1)
            {
                Console.Write($"{month},");
            }
            var selectedMonth2 = from p in months where (p == "January" || p == "February" || p == "December" || p == "June" || p == "July" || p == "August") select p;
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Летние и зимние месяца:");
            foreach (string month in selectedMonth2)
            {
                Console.Write($"{month},");
            }
            Console.WriteLine();
            Console.WriteLine();
            var selectedMonth3 = from p in months orderby p select p;
            Console.Write("Вывод месяцев в алфавитном порядке:");
            foreach (string month in selectedMonth3)
            {
                Console.Write($"{month},");
            }
            Console.WriteLine();
            Console.WriteLine();
            var selectedMonth4 = from p in months where p.Contains('u') && p.Length >= 4 select p;
            Console.Write("месяцы содержащие букву «u» и длиной имени не менее 4-х:");
            foreach (string month in selectedMonth4)
            {
                Console.Write($"{month},");
            }
            Console.WriteLine();
            Console.WriteLine();

            Person[] people =
            {
                new Person("Tom", "Microsoft"), new Person("Sam", "Google"),
                new Person("Bob", "JetBrains"), new Person("Mike", "Microsoft"),
            };
            Company[] companies =
            {
                new Company("Microsoft", "C#"),
                new Company("Google", "Go"),
                new Company("Oracle", "Java")
            };
            var employees = from p in people where p.Name.StartsWith("T") || p.Name.StartsWith("M")orderby p.Company
                            join c in companies on p.Company equals c.Title
                            select new { Name = p.Name, Company = c.Title, Language = c.Language };

            foreach (var emp in employees)
                Console.WriteLine($"{emp.Name} - {emp.Company} ({emp.Language})");
        }
    }
    record class Company(string Title, string Language);
    record class Person(string Name, string Company);
}