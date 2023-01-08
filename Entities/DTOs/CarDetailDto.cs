using Core.Entities;
using System;

namespace Entities.DTOs
{
    public class CarDetailDto:IDto
    {
        public int CarId { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public DateTime ModelYear { get; set; }
        public double DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
