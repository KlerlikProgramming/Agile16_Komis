using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agile16_Komis.App_Code
{
    public static class Search
    {
        public enum TypeOfSearch {Model, Mark, YearProduction, EngineType, TransmissionModel, TransmissionGears, Chassis, Color }
        public static List<Car> GetSearchResult(string s)
        {
            IEnumerable<Car> result = from Car car in ListCar.listCar
                                      where car.Model.IndexOf(s) != -1
                                      where car.Mark.IndexOf(s) != -1
                                      orderby car.Mark, car.Model
                                      select car;
            return result.ToList();
        }

        public static List<Car> AdvancedSearch(List<Car> carList, TypeOfSearch typeOfSearch, string text)
        {
            IEnumerable<Car> result = from Car car in carList
                                      select car;

            switch (typeOfSearch)
            {
                case (TypeOfSearch.Model):
                    {
                        result = result.Where(x => x.Model == text);
                        break;
                    }
                case (TypeOfSearch.Mark):
                    {
                        result = result.Where(x => x.Mark == text);
                        break;
                    }
                case (TypeOfSearch.Chassis):
                    {
                        result = result.Where(x => x.Chassis == text);
                        break;
                    }
                case (TypeOfSearch.Color):
                    {
                        result = result.Where(x => x.Color == text);
                        break;
                    }
                case (TypeOfSearch.EngineType):
                    {
                        result = result.Where(x => x.EngineType == text);
                        break;
                    }
                case (TypeOfSearch.TransmissionGears):
                    {
                        result = result.Where(x => x.TransmissionGears.ToString() == text);
                        break;
                    }
                case (TypeOfSearch.TransmissionModel):
                    {
                        result = result.Where(x => x.TransmissionModel == text);
                        break;
                    }
                case (TypeOfSearch.YearProduction):
                    {
                        result = result.Where(x => x.YearProduction.ToString() == text);
                        break;
                    }
                default:
                    break;
            }
            return result.ToList();
        }
        
    }
}