﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DriversManagerProject
{
    public abstract class Vehicle
    {
        private int id;
        private string brand;
        private string color;
        private Driver firstDriver;
        private int seatsNum;
        private int amoutOfDrivers = 1;

        protected Vehicle(int id)
        {
            this.id = id;
        }

        protected Vehicle(int id, string brand, string color)
        {
            this.id = id;
            this.Brand = brand;
            this.color = color;
        }
        public int AmoutOfDrivers { get => amoutOfDrivers; }
        public int Id { get => id; }
        public string Color { get => color; set => color = value; }
        public string Brand { get => brand; set => brand = value; }
        public int SeatsNum { get => seatsNum; set => seatsNum = value; }
        internal Driver FirstDriver { get => firstDriver; set => firstDriver = value; }

        public virtual string GetDrivers()
        {
            return "Driver 1: " + this.firstDriver.ToString();
        }
        public virtual string GetVehicleType()
        {
            return "Vehicle Type: ";
        }
        public override string ToString()
        {
            if (firstDriver is Driver)
            {
                return
                    "============\n" +
                    this.GetVehicleType() + ": \n" +
                    "ID: " + this.id + "\n" +
                    "Brand: " + this.brand + "\n" +
                    "Color: " + this.color + "\n" +
                    "Driver: " + this.FirstDriver.ToString();
            }
            else
            {
                return
                    "============\n" +
                    this.GetVehicleType() + ": \n" +
                    "ID: " + this.id + "\n" +
                    "Brand: " + this.brand + "\n" +
                    "Color: " + this.color + "\n" +
                    "Driver: ";
            }
        }
    }
}
