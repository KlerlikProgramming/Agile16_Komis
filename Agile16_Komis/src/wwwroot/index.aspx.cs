using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agile16_Komis.src.wwwroot
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                SetInitialRow();
            }
        }

        protected void SetInitialRow()
        {
            DataTable dt = new DataTable();
            DataRow dr = null;
            foreach (string s in carsDataGridView.Columns.ToString())
                dt.Columns.Add(new DataColumn((s), typeof(string)));
            dr = dt.NewRow();
            dr[0] = "coś";
            dt.Rows.Add(dr);

            carsDataGridView.DataSource = dt;
            carsDataGridView.DataBind();
        }
        
    }
}