using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agile16_Komis.wwwroot
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void searchButtonClick(object sender, EventArgs e)
        {
            searchInput.Text = "MAM";
        }

        protected void searchInputTextChange(object sender, EventArgs e)
        {
            searchInput.Text = "Piotrek";
        }
    }
}