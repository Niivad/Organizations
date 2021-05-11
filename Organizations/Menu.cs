using System;
using System.Collections.Generic;
using static Organizations.Informations;

namespace Organizations
{

    /// <summary>
    /// Меню программы
    /// </summary>
    class Menu
    {
        #region Поля
        /// <summary>
        /// Список организаций
        /// </summary>
        static List<Organization> organizations = new List<Organization>();
        #endregion


        /// <summary>
        /// Инициализация списка организация начальными данными
        /// </summary>
        public Menu()
        {
            organizations.Add(new OilAndGasCompany(250, 2500, "Б.Ю.Александров", 800000, 347, 1500));
            organizations.Add(new InsuranceCompany(250, 2500, "Б.Ю.Александров", 500, 700, 350000));
            organizations.Add(new Factory(250, 2500, "Б.Ю.Александров", 2500, 765000, 0.34));
        }

        /// <summary>
        /// Запуск меню
        /// </summary>
        public static void Run()
        {
            while (true)
            {
                Console.CursorVisible = false;
                Console.Clear();//Очистка экрана консоли
                Console.WriteLine("1. Организации");
                Console.WriteLine("2. Добавить организацию");
                Console.WriteLine("3. Поиск организации");
                Console.WriteLine("0. Выход из программы");
                char key = Console.ReadKey(true).KeyChar;//Ожидания ввода символа с клавиатуры без отображения нажатого символа
                switch (key)
                {
                    case '1': PrintOrganizations(); break;
                    case '2': AddOrganizations(); break;
                    case '3': SearchOrganizations(); break;
                    case '0': Environment.Exit(0); break;
                    default: break;
                }
            }
        }
        
        
        
        /// <summary>
        /// Вывод организации
        /// </summary>
        public static void PrintOrganizations()
        {
            Console.Clear();
            foreach (var organization in organizations)
            {
                Console.WriteLine(organization);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("-----------------------------------------");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.ReadKey(true);
        }
        




        /// <summary>
        /// Добавление новой организации
        /// </summary>
        public static void AddOrganizations()
        {

            char choice;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Завод");
                Console.WriteLine("2. Страховая компания");
                Console.WriteLine("3. Нефтегазовая компания");
                Console.WriteLine("0. Назад");
                choice = Console.ReadKey(true).KeyChar;
            }
            while (choice != '1' && choice != '2' && choice != '3' && choice != '0');

            switch (choice)
            {
                case '1'://Завод
                    {
                        #region Ввод информации о заводе
                        OrganizationInfo oi = new OrganizationInfo();
                        FactoryInfo fi = new FactoryInfo();
                        oi.Read();
                        fi.Read();


                        organizations.Add(new Factory(
                            oi.NumberOfEmployees, oi.Income, oi.Leader, 
                            fi.TonsOfProductPerYear, fi.ProductUnitsPerYear, fi.PercentageOfPollution
                            )); 
                        break;
                        #endregion
                    }
                case '2'://Страховая компания
                    {
                        #region Ввод информации о страховой компании
                        OrganizationInfo oi = new OrganizationInfo();
                        InsuranceCompanyInfo ii = new InsuranceCompanyInfo();
                        oi.Read();
                        ii.Read();


                        organizations.Add(new InsuranceCompany(
                            oi.NumberOfEmployees, oi.Income, oi.Leader, 
                            ii.AmountOfInsurancePaymentsPerYear, ii.CashReceiptsPerYear, ii.NumberOfInsuredPersons
                            ));
                        break;
                        #endregion
                    }
                case '3'://Нефтегазовая компания
                    {
                        #region Ввод информации о нефтегазовой компании
                        OrganizationInfo oi = new OrganizationInfo();
                        OilAndGasCompanyInfo ogi = new OilAndGasCompanyInfo();
                        oi.Read();
                        ogi.Read();


                        organizations.Add(new OilAndGasCompany(
                            oi.NumberOfEmployees, oi.Income, oi.Leader,
                            ogi.CubicMetersOfGasPerMinute, ogi.NumberOfWells, ogi.CostOfEquipment
                            ));
                        break;
                        #endregion
                    }
                case '0'://Назад
                    {
                        Run();
                        break;
                    }
                default: throw new Exception("Ошибка");
            }
        }



        /// <summary>
        /// Поиск организации по заданной строке
        /// </summary>
        public static void SearchOrganizations()
        {
            Console.Clear();
            Console.Write("Введите строку для поиска: ");
            string searchText = Console.ReadLine();
            Console.WriteLine("========================================");

            foreach (var organization in organizations)
            {
                if (organization.IsContains(searchText))
                {
                    Console.WriteLine(organization);
                    Console.WriteLine("========================================");
                }
            }
            Console.ReadKey(true);
        }
    }
}
