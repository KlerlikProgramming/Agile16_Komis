using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agile16_Komis.App_Code
{
    public static class ListCar
    {
        public static List<Car> listCar = new List<Car>();

        public static IEnumerable<Car> GetSearchResult(string s)
        {
            IEnumerable<Car> result = from Car car in listCar
                                      where car.Model.IndexOf(s) != -1
                                      where car.Mark.IndexOf(s) != -1
                                      orderby car.Mark, car.Model
                                      select car;
            return result;
        }
    }
}