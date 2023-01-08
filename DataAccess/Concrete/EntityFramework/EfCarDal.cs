using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, Context>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (Context context = new Context())
            {
                var result = from car in context.Cars
                             join brand in context.Brands on car.BrandId equals brand.BrandId
                             join color in context.Colors on car.ColorId equals color.ColorId
                             select new CarDetailDto
                             {
                                 CarId= car.CarId,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 ModelYear= car.ModelYear,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description

                             };
                return result.ToList();
            }
        }
    }
}
