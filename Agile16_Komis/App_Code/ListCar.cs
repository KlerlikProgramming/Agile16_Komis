using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agile16_Komis.App_Code
{
    public static class ListCar
    {
        public static List<Car> listCar = new List<Car>();

        public static string[] columnHeader = { "Model", "Marka", "Rok produkcji", "Typ silnika", "Pojemność silnika", "Typ skrzyni biegów", "Ilość biegów", "Podwozie", "Kolor", "Cena" };


        public static int idCar = 0;

        public static bool AddCar(Car car)
        {
            listCar.Add(car);
            return true;
        }

        public static bool AddCar(int id, Car car)
        {
            listCar.RemoveAt(listCar.FindIndex(x => x.ID == id));
            car.SetId(id);
            AddCar(car);
            return true;
        }

        public static List<Car> GetLatestOffer(int numberOfCar)
        {
            if (numberOfCar > listCar.Count)
                numberOfCar = listCar.Count;

            IEnumerable<Car> temp = listCar.OrderByDescending(x => x.DateAdded).Take(numberOfCar);

            return temp.ToList();
        }

        public static List<Car> GetAllOffer()
        {
            return listCar;
        }

        public static void ClearList()
        {
            listCar.Clear();
        }

        public static Car GetCarById(int id)
        {
            return listCar.Find(x => x.ID == id);
        }
    }
}