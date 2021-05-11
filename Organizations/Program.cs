using System;

namespace Organizations
{
    class Program
    {
        static void Main(string[] args)
        {
            //InsuranceCompany insuranceCompany1 = new InsuranceCompany(250, 2500, "Б.Ю.Александров", 500, 700, 350000);
            //Factory factory1 = new Factory(250, 2500, "Б.Ю.Александров", 2500, 765000, 0.3456);
            //OilAndGasCompany oilAndGasCompany1 = new OilAndGasCompany(250, 2500, "Б.Ю.Александров", 800000, 347, 1500);
            //Console.WriteLine(insuranceCompany1);
            //Console.WriteLine(factory1);
            //Console.WriteLine(oilAndGasCompany1);
            Menu menu = new Menu();
            Menu.Run();
        }
    }
}
