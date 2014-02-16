﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboration.DoggieDayCare.WebService.Models
{
    public class MediumDog : DogBreed
    {
        public override string BreedName
        {
            get { return "Medium"; }
        }

        public override decimal GetCostOfCare(Booking booking)
        {
            var daySpanAsDecimal = Convert.ToDecimal((booking.CheckOut.ToUniversalTime() - booking.CheckIn.ToUniversalTime()).TotalDays);
            var housingCost = daySpanAsDecimal * BaseCosts.PerDayOfCare * 1.3M;

            var foodCost = BaseCosts.PerKiloGramOfFood * (booking.CheckInFoodWeight - booking.CheckOutFoodWeight);

            return housingCost + foodCost;
        }

    }
}