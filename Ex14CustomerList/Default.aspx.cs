using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ch14CustomerList
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void grdCustomer_PreRunder(object sender, EventArgs e)
        {
            if (grdCustomers.HeaderRow != null)
            {
                grdCustomers.HeaderRow.TableSection = TableRowSection.TableHeader;

            }
        }

    }
}