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
            for (int i = 0; i < carsDataGridView.Columns.Count; i++)
            {
                dt.Columns.Add(new DataColumn(carsDataGridView.Columns[i].ToString(), typeof(string)));
            }
            for (int i = 0; i < 5; i++)
            {
                dr = dt.NewRow();
                dr[1] = "coś";
                dr[i] = "nie";
                dt.Rows.Add(dr);
            }
            ViewState["CurrentTable"] = dt;

            carsDataGridView.DataSource = dt;
            carsDataGridView.DataBind();
        }
        
    }
}