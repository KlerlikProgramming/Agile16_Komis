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
        }

        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string mark;
        public string Mark
        {
            get { return mark; }
            set { mark = value; }
        }
        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        private int yearProduction;
        public int YearProduction
        {
            get { return yearProduction; }
            set { yearProduction = value; }
        }
        private string engineType;
        public string EngineType
        {
            get { return engineType; }
            set { engineType = value; }
        }
        private string transmissionModel;
        public string TransmissionModel
        {
            get { return transmissionModel; }
            set { transmissionModel = value; }
        }
        private int tranmissionGears;
        public int TransmissionGears
        {
            get { return tranmissionGears; }
            set { tranmissionGears = value; }
        }
        private string fuelType;
        public string FuelType
        {
            get { return fuelType; }
            set { fuelType = value; }
        }
        private string chassis;
        public string Chassis
        {
            get { return chassis; }
            set { chassis = value; }
        }
        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public Car This
        {
            get { return this; }
        }

        public override string ToString()
        {
            string data = Mark + " " + Model + " " + YearProduction.ToString() + " " + EngineType + " " + TransmissionModel + " " + TransmissionGears.ToString() + " " + FuelType + " " + Chassis + " " + Color;
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