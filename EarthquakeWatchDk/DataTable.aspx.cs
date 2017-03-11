using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EarthquakeWatchDk
{
    public partial class DataTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

            Data.GeusDataHelper helper = new Data.GeusDataHelper();
            var geusData = helper.LoadJson();

            LiteralDataTable.Text = geusData.First().Year.ToString();

        }
    }
}