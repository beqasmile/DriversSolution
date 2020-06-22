﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriversManagerProject.CarFolder
{
    sealed class SportCar : Car
    {

        public SportCar(int id, string brand, string color, int speed) : base(id, brand, color, speed)
        {
        }
        public override string GetDrivers()
        {
            return base.GetDrivers();
        }
        public override string GetVehicleType()
        {
            return base.GetVehicleType() + "Sport Car";
        }
        public override string ToString()
        {
            if (this.SecondDriver is Driver)
            {
                return base.ToString() + "\nDriver: " + this.SecondDriver.ToString();
            }
            else return base.ToString();
        }
    }
}