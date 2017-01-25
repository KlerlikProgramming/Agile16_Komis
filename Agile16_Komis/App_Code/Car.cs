using System;
using System.Collections;
using System.Collections.Generic;

namespace Agile16_Komis.App_Code
{
    public class Car
    {
        List<string> photo;
        public Car()
        {
            photo = new List<string>();
            ID = ListCar.idCar++;
        }

        private int id;
        private string mark;
        private string model;
        private int yearProduction;
        private string engineType;
        private double engineFuel;
        private string transmissionModel;
        private int transmissionGears;
        private string chassis;
        private string color;
        private DateTime dateAdded;
        private int price;


        public int ID
        {
            get { return id; }
            private set { id = value; }
        }
        public string Mark
        {
            get { return mark; }
            set { mark = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int YearProduction
        {
            get { return yearProduction; }
            set { yearProduction = value; }
        }
        public string EngineType
        {
            get { return engineType; }
            set { engineType = value; }
        }
        public string TransmissionModel
        {
            get { return transmissionModel; }
            set { transmissionModel = value; }
        }
        public int TransmissionGears
        {
            get { return transmissionGears; }
            set { transmissionGears = value; }
        }
        public string Chassis
        {
            get { return chassis; }
            set { chassis = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public DateTime DateAdded
        {
            get { return dateAdded; }
            private set { dateAdded = value; }
        }

        public double EngineFuel
        {
            get
            {
                return engineFuel;
            }

            set
            {
                engineFuel = value;
            }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public override string ToString()
        {
            string data = Mark + " " + Model + " " + YearProduction.ToString() + " " + EngineType + " " + TransmissionModel + " " + TransmissionGears.ToString() + " " + Chassis + " " + Color;
            foreach(string item in photo)
            {
                data += " " + item;
            }
            return data;
        }

        public string ToStringMarkAndModel()
        {
            return Mark + " " + Model;
        }
    }
}