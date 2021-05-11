using System;

namespace Organizations
{
    /// <summary>
    /// Вспомогательный статичный класс, который запрашивает информацию об организациях у пользователя
    /// </summary>
    public static class Informations
    {

        /// <summary>
        /// Базовая информация об организации
        /// </summary>
        /// <remarks>Содержит свойства базового класса Organization</remarks>
        public struct OrganizationInfo
        {
            /// <summary>
            /// Кол-во сотрудников
            /// </summary>
            public int NumberOfEmployees;
            /// <summary>
            /// Прибыль
            /// </summary>
            public double Income;
            /// <summary>
            /// Лидер
            /// </summary>
            public string Leader;
            /// <summary>
            /// Запросить от пользователя ввод базовых данных об организации
            /// </summary>
            /// <returns>Базовая информация об организации</returns>
            public void Read()
            {
                Console.CursorVisible = true;
                do
                {
                    Console.Clear();
                    Console.Write("Сотрудников: ");
                }
                while (!int.TryParse(Console.ReadLine(), out NumberOfEmployees) || NumberOfEmployees <= 0);

                do
                {
                    Console.Clear();
                    Console.Write("Прибыль (млн.р.): ");
                }
                while (!double.TryParse(Console.ReadLine(), out Income));

                do
                {
                    Console.Clear();
                    Console.Write("ФИО директора завода: ");
                    Leader = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(Leader));
            }
        }

        /// <summary>
        /// Информация о заводе
        /// </summary>
        public struct FactoryInfo
        {
            /// <summary>
            /// Тонн продукта в год
            /// </summary>
            public double TonsOfProductPerYear;
            /// <summary>
            /// Ед. продукта в год
            /// </summary>
            public int ProductUnitsPerYear;
            /// <summary>
            /// Степень загрязнения окруж.среды
            /// </summary>
            public double PercentageOfPollution;
            /// <summary>
            /// Запросить от пользователя ввод базовых данных об организации
            /// </summary>
            /// <returns>Базовая информация об организации</returns>
            public void Read()
            {
                Console.CursorVisible = true;
                do
                {
                    Console.Clear();
                    Console.Write("Производит продукта в год (тонн): ");
                }
                while (!double.TryParse(Console.ReadLine(), out TonsOfProductPerYear) || TonsOfProductPerYear < 0);

                do
                {
                    Console.Clear();
                    Console.Write("Производит продукта в год (ед.): ");
                }
                while (!int.TryParse(Console.ReadLine(), out ProductUnitsPerYear) || ProductUnitsPerYear < 0);

                do
                {
                    Console.Clear();
                    Console.Write("Процент загрязнения окружающей среды (0,00-100,00%): ");
                }
                while (!double.TryParse(Console.ReadLine(), out PercentageOfPollution));
            }
        }

        /// <summary>
        /// Информация о нефтегазовой компании
        /// </summary>
        public struct OilAndGasCompanyInfo
        {
            /// <summary>
            /// Производит куб.м. газа в минуту
            /// </summary>
            public double CubicMetersOfGasPerMinute;
            /// <summary>
            /// Кол-во скважин
            /// </summary>
            public int NumberOfWells;
            /// <summary>
            /// Стоимость оборудования (в млн.)
            /// </summary>
            public double CostOfEquipment;
            /// <summary>
            /// Запросить от пользователя ввод данных о нефтегазовой компании
            /// </summary>
            /// <returns>Информация о нефтегазовой компании</returns>
            public void Read()
            {
                Console.CursorVisible = true;
                do
                {
                    Console.Clear();
                    Console.Write("Производит куб.м. газа в минуту: ");
                }
                while (!double.TryParse(Console.ReadLine(), out CubicMetersOfGasPerMinute) || CubicMetersOfGasPerMinute <= 0);

                do
                {
                    Console.Clear();
                    Console.Write("Кол-во скважин: ");
                }
                while (!int.TryParse(Console.ReadLine(), out NumberOfWells) || NumberOfWells <= 0);

                do
                {
                    Console.Clear();
                    Console.Write("Стоимость оборудования (в млн.)");
                }
                while (!double.TryParse(Console.ReadLine(), out CostOfEquipment) || CostOfEquipment <= 0);
            }
        }

        /// <summary>
        /// Информация о страховой компании
        /// </summary>
        public struct InsuranceCompanyInfo
        {
            /// <summary>
            /// Сумма страховых выплат (млн.р)
            /// </summary>
            public double AmountOfInsurancePaymentsPerYear;
            /// <summary>
            /// Сумма денежных поступлений (млн.р)
            /// </summary>
            public double CashReceiptsPerYear;
            /// <summary>
            /// Застрахованных лиц
            /// </summary>
            public int NumberOfInsuredPersons;
            /// <summary>
            /// Запросить от пользователя ввод данных
            /// </summary>
            /// <returns>Информация о страховой компании</returns>
            public void Read()
            {
                Console.CursorVisible = true;
                do
                {
                    Console.Clear();
                    Console.Write("Сумма страховых выплат (млн.р): ");
                }
                while (!double.TryParse(Console.ReadLine(), out AmountOfInsurancePaymentsPerYear) || AmountOfInsurancePaymentsPerYear <= 0);


                do
                {
                    Console.Clear();
                    Console.Write("Сумма денежных поступлений (млн.р)");
                }
                while (!double.TryParse(Console.ReadLine(), out CashReceiptsPerYear) || CashReceiptsPerYear <= 0);


                do
                {
                    Console.Clear();
                    Console.Write("Застрахованных лиц: ");
                }
                while (!int.TryParse(Console.ReadLine(), out NumberOfInsuredPersons) || NumberOfInsuredPersons <= 0);
            }
        }
    }
}
