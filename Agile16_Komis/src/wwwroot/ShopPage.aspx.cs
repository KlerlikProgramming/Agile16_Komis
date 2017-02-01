using System;
using System.Collections.Generic;
using Agile16_Komis.App_Code;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Agile16_Komis.src.wwwroot
{
    public partial class ShopPage : System.Web.UI.Page
    {
        List<Car> list;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                SetInitialRow();
            }
        }

        private void SetInitialRow()
        {
            list = ListCar.GetAllOffer();

            DataTable dt = new DataTable();
            DataRow dr = null;

            for(int i = 0; i<ListCar.columnHeader.Count();i++)
            {
                dt.Columns.Add(new DataColumn(ListCar.columnHeader[i], typeof(string)));
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
    }
}