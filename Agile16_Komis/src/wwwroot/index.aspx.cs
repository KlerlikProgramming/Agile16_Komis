using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Agile16_Komis.App_Code;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agile16_Komis.src.wwwroot
{
    public partial class index : System.Web.UI.Page
    {
        List<Car> list;

        string[] columnHeader = { "Model", "Marka", "Rok produkcji", "Typ silnika", "Pojemność silnika", "Typ skrzyni biegów", "Ilość biegów", "Podwozie", "Kolor", "Cena" };

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                AddCarsToDataBase();
                SetInitialRow();
            }
        }

        private void AddCarsToDataBase()
        {
            for (int i = 0; i < 10; i++)
            {
                ListCar.AddCar(new Car { Model = "Stilo", Brand = "Fiat", Chassis = "Kombi", Color = "Granatowy", EngineFuel = 1600, EngineType = "Benzyna", TransmissionModel = "Manual", TransmissionGears = 6, YearProduction = 2004, Price = 5000 });
            }
        }

        protected void SetInitialRow()
        {
            const int numberOfCar = 6;
            list = ListCar.GetLatestOffer(numberOfCar);

            DataTable dt = new DataTable();
            DataRow dr = null;
            for (int i = 0; i < columnHeader.Count(); i++)
            {
                dt.Columns.Add(new DataColumn(columnHeader[i], typeof(string)));
            }
            for (int i = 0; i < list.Count; i++)
            {
                dr = dt.NewRow();
                dr[0] = list.ElementAt(i).Model;
                dr[1] = list.ElementAt(i).Brand;
                dr[2] = list.ElementAt(i).YearProduction.ToString();
                dr[3] = list.ElementAt(i).EngineType;
                dr[4] = list.ElementAt(i).EngineFuel.ToString();
                dr[5] = list.ElementAt(i).TransmissionModel;
                dr[6] = list.ElementAt(i).TransmissionGears.ToString();
                dr[7] = list.ElementAt(i).Chassis;
                dr[8] = list.ElementAt(i).Color;
                dr[9] = list.ElementAt(i).Price;
                dt.Rows.Add(dr);
            }
            carsDataGridView.Controls.Clear();
            carsDataGridView.DataSource = dt;
            carsDataGridView.DataBind();
        }

        public void AddOfferButtonAction (object sender, EventArgs e) {
            Server.Transfer("AddOffer.aspx");
        }
        
    }
}