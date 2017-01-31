using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agile16_Komis.src
{
    public partial class AddOffer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ApplyButton_Click(object sender, EventArgs e)
        {
            App_Code.Car car = new App_Code.Car() { Model = modelTextBox.Text, Brand = brandTextBox.Text, YearProduction = Convert.ToInt32(yearProductionTextBox.Text), EngineType = engineTypeTextBox.Text, EngineFuel = Convert.ToInt32(engineFuelTextBox.Text), TransmissionModel = transmissionModelTextBox.Text, TransmissionGears = Convert.ToInt32(transmissionGearsTextBox.Text), Chassis = chassisTextBox.Text, Color = colorTextBox.Text, Price = Convert.ToInt32(priceTextBox.Text) };
            App_Code.ListCar.AddCar(car);
            Server.Transfer("index.aspx");
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Server.Transfer("index.aspx");
        }
    }
}