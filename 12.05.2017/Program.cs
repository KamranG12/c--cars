using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _12._05._2017;

namespace _12._05._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars car_option=new Cars();
            car_option.FuelUsage=10;
            car_option.possibleDistance();
            Console.Write("Neche km gedeceyinizi daxil edin:");
            double km=Convert.ToDouble(Console.ReadLine());
            if(car_option.checkDistance(km))
            {
              Console.WriteLine("Bu yolu getmesi uchun benzin yeterlidir");
                car_option.ascGlobalDistance(km);
                car_option.ascLocalDistance(km);
            }else
            {
              Console.WriteLine("Benzin yeterli deyil");
            }
            Console.Write("Neche litr bezin dolduracaginizi daxil edin:");
            double litr=Convert.ToDouble(Console.ReadLine());
            if(car_option.checkFuelAviable(litr))
            {
              Console.WriteLine("benzin yanacaq chenine elave olundu");
                car_option.addFuel(litr);
            }else
            {
              Console.WriteLine("Yanacaq cheninin tutumunu ashirsiniz");
            }
            Console.ReadKey();
            /*Console.WriteLine("1. Masini sur (paramter olaraq km olacaq sistem yoxlamasi gerekirki bak-da olan benzin-le bu qeder gede biler mi?)");
            Console.WriteLine("2. Benzin doldur (parametr olaraq litr alacaq. Yoxlayacaqki elave olunan litr bak-in kapasitesini asirmi? )");
            Console.WriteLine("3. Local Distance. Masinin local olaraq ne qeder yol getdiyini deyecek ve sifirlana bilecek");
            Console.WriteLine("4. Global Distance. Masinin global olaraq ne qeder getdiyini deyecek ve sifirlana bilinmeyecek");
            Console.WriteLine("0. Exit");*/
        }
    }
}
