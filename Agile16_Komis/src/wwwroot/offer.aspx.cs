using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agile16_Komis.src.wwwroot
{
    public partial class offer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int carID = Convert.ToInt32(Request["id"]);
            //Agile16_Komis.App_Code.Car car = Agile16_Komis.App_Code.ListCar.GetCarByID(carID);

            model.Text = Agile16_Komis.App_Code.ListCar.listCar.ElementAt(carID).Model;
            brand.Text = Agile16_Komis.App_Code.ListCar.listCar.ElementAt(carID).Brand;
            yearProduction.Text = Agile16_Komis.App_Code.ListCar.listCar.ElementAt(carID).YearProduction.ToString();
            engineType.Text = Agile16_Komis.App_Code.ListCar.listCar.ElementAt(carID).EngineType;
            engineFuel.Text = Agile16_Komis.App_Code.ListCar.listCar.ElementAt(carID).EngineFuel.ToString();
            transmissionModel.Text = Agile16_Komis.App_Code.ListCar.listCar.ElementAt(carID).TransmissionModel;
            transmissionGears.Text = Agile16_Komis.App_Code.ListCar.listCar.ElementAt(carID).TransmissionGears.ToString();
            chassis.Text = Agile16_Komis.App_Code.ListCar.listCar.ElementAt(carID).Chassis;
            color.Text = Agile16_Komis.App_Code.ListCar.listCar.ElementAt(carID).Color;
            price.Text = Convert.ToString(Agile16_Komis.App_Code.ListCar.listCar.ElementAt(carID).Price);
        }
    }
}