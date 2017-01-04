using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agile16_Komis
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Context.User.Identity.IsAuthenticated) admin.Text = "You're a Jedi, Frodo";
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