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
            App_Code.Car car = App_Code.ListCar.GetCarById(carID);

            model.Text = car.Model;
            brand.Text = car.Brand;
            yearProduction.Text = car.YearProduction.ToString();
            engineType.Text = car.EngineType;
            engineFuel.Text = car.EngineFuel.ToString();
            transmissionModel.Text = car.TransmissionModel;
            transmissionGears.Text = car.TransmissionGears.ToString();
            chassis.Text = car.Chassis;
            color.Text = car.Color;
            price.Text = car.Price.ToString();
        }
    }
}