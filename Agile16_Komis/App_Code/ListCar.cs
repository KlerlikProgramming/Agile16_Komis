using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agile16_Komis.App_Code
{
    public static class ListCar
    {
        public static List<Car> listCar = new List<Car>();

        public static int idCar = 0;

        public static bool AddCar(Car car)
        {
            listCar.Add(car);
            return true;
        }

        public static List<Car> GetLatestOffer(int numberOfCar)
        {
            if (numberOfCar < listCar.Count)
                numberOfCar = listCar.Count;
            IEnumerable<Car> temp = from Car car in listCar
                                    orderby car.DateAdded descending
                                    select car;

            return temp.Take(numberOfCar).ToList();
        }

        public static void ClearList()
        {
            listCar.Clear();
        }

        public static Car GetCar(int id)
        {
            return listCar.Find(x => x.ID == id);
        }

    }
}