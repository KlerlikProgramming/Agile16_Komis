using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agile16_Komis
{
    public partial class Site1 : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> tempString = new List<string>();
            tempString.Add("Hello");
            tempString.Add("World");

            StringBuilder sb = new StringBuilder();
            sb.Append("<script>");
            sb.Append("var autoComplete = new Array;");
            foreach (App_Code.Car car in App_Code.ListCar.listCar) {
                sb.Append("autoComplete.push('" + car.Brand + " " + car.Model + "');");
            }
            sb.Append("$( '#searchInput' ).autocomplete({source: autoComplete});");
            sb.Append("</script>");

            Page.ClientScript.RegisterStartupScript(this.GetType(), "AutoCompleteScript", sb.ToString());
        }
        protected void searchButtonClick(object sender, EventArgs e)
        {
            //searchInput.Text = "MAM";
        }

        protected void searchInputTextChange(object sender, EventArgs e)
        {
            //searchInput.Text = "Piotrek";
        }
    }
}