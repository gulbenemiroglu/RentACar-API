using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Delete(colorManager.GetById(8));
            //colorManager.Delete(colorManager.GetById(7));
            //colorManager.Delete(colorManager.GetById(6));
            //colorManager.Add(new Color { ColorName = "Beyaz" });
            //colorManager.Add(new Color { ColorName = "Siyah" });
            //colorManager.Add(new Color { ColorName = "Gri" });
            //colorManager.Add(new Color { ColorName = "Kırmızı" });

            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.ColorName);
            //}

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand { BrandName = "Porsche" });
            //brandManager.Add(new Brand { BrandName = "Volvo" });
            //brandManager.Add(new Brand { BrandName = "Renault" });
            //brandManager.Add(new Brand { BrandName = "Nissan" });

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }

            CarManager carManager = new CarManager(new EfCarDal());
            ////carManager.Add(new Car { BrandId= 1, ColorId=5, DailyPrice=1000, Description="Taygan", ModelYear=DateTime.Now});
            //carManager.Add(new Car { BrandId = 2, ColorId = 2, DailyPrice = 1000, Description = "xc90", ModelYear = DateTime.Now });
            //carManager.Add(new Car { BrandId = 3, ColorId = 4, DailyPrice = 500, Description = "Megan", ModelYear = DateTime.Now });
            //carManager.Add(new Car { BrandId = 4, ColorId = 3, DailyPrice = 250, Description = "Micra", ModelYear = DateTime.Now });

            Console.WriteLine("CAR BRAND -- DESCRIPTION -- DAILY PRICE -- MODEL YEAR -- COLOR");
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine( car.BrandName + " ----- " + car.Description + " ----- " + car.DailyPrice + " ----- " + car.ModelYear + " ----- " + car.ColorName);
            }
        }
    }
}
