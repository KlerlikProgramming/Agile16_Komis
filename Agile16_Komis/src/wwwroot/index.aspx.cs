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
        const int numberOfCar = 6;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                list = ListCar.GetLatestOffer(numberOfCar);
                SetInitialRow();
            }
        }
        

        protected void SetInitialRow()
        {
            

            DataTable dt = new DataTable();
            DataRow dr = null;
            for (int i = 0; i < ListCar.columnHeader.Count(); i++)
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

        public void AddOfferButtonAction (object sender, EventArgs e) {
            Server.Transfer("AddOffer.aspx");
        }

        protected void carsDataGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridView gv = sender as GridView;
            Server.Transfer("offer.aspx?id=0"/*+list.ElementAt(gv.SelectedIndex).ID.ToString()*/);
        }
    }
}