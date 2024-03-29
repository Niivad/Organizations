﻿namespace Organizations
{
    /// <summary>
    /// Страховая компания
    /// </summary>
    public class InsuranceCompany : Organization
    {
        #region Конструктор
        /// <summary>
        /// Страховая компания
        /// </summary>
        /// <param name="numberOfEmployees">Кол-во сотрудников</param>
        /// <param name="income">Прибыль (млн.р)</param>
        /// <param name="leader">Глава страховой компании</param>
        /// <param name="amountOfInsurancePaymentsPerYear">Сумма страховых выплат (млн.р)</param>
        /// <param name="cashReceiptsPerYear">Сумма денежных поступлений (млн.р)</param>
        /// <param name="numberOfInsuredPersons">Застрахованных лиц</param>
        public InsuranceCompany(int numberOfEmployees, double income, string leader,
            double amountOfInsurancePaymentsPerYear, double cashReceiptsPerYear, int numberOfInsuredPersons) :
            base(numberOfEmployees, income, leader)
        {
            AmountOfInsurancePaymentsPerYear = amountOfInsurancePaymentsPerYear;
            CashReceiptsPerYear = cashReceiptsPerYear;
            NumberOfInsuredPersons = numberOfInsuredPersons;
        }
        #endregion

        #region Свойства

        /// <summary>
        /// Сумма страховых выплат в год (в млн.р.)
        /// </summary>
        /// <returns>Млн. рублей</returns>
        public double AmountOfInsurancePaymentsPerYear { get; set; }

        /// <summary>
        /// Сумма денежных поступлений в год (в млн.р.)
        /// </summary>
        /// <returns>Млн. рублей</returns>
        public double CashReceiptsPerYear { get; set; }

        /// <summary>
        /// Число застрахованных лиц
        /// </summary>
        public int NumberOfInsuredPersons { get; set; }

        #endregion

        #region Методы
        /// <summary>
        /// Эффективность страхования
        /// <list type="bullet">
        /// <item><b>Положительное</b> - Получает доход</item>
        /// <item><b>Отрицательное</b> - Терпит убытки</item>
        /// </list>
        /// </summary>
        /// <returns>Проценты</returns>
        public double GetInsuranceEffectiveness()
        {
            if (AmountOfInsurancePaymentsPerYear < CashReceiptsPerYear)
            {
                return (AmountOfInsurancePaymentsPerYear / CashReceiptsPerYear) * 100;
            }
            else
            {
                return -(CashReceiptsPerYear / AmountOfInsurancePaymentsPerYear) * 100;
            }
        }

        /// <summary>
        /// Средняя сумма страховых выплат на человека в год
        /// </summary>
        /// <returns>Рубли</returns>
        public double GetAverageInsurancePaymentsPerPersonPerYear() => (AmountOfInsurancePaymentsPerYear / NumberOfInsuredPersons) * 1000000;

        /// <summary>
        /// Ежемесячный страховой взнос
        /// </summary>
        /// <returns></returns>
        public double GetInsurancePremium() => (CashReceiptsPerYear / NumberOfInsuredPersons) * 1000000 / 12;
        #endregion
    }
}
