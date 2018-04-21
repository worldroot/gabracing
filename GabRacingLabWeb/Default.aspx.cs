using GabRacingLabWeb.AzureData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GabRacingLabWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblLocationName.Text = Settings.LocationName;

            var lapDataTable = new LapDataTable();

            var track0Laps = lapDataTable.GetTopLapTimes(0, 20);
            lsvTrack0.DataSource = track0Laps;
            lsvTrack0.DataBind();

            var track1Laps = lapDataTable.GetTopLapTimes(1, 20);
            lsvTrack1.DataSource = track1Laps;
            lsvTrack1.DataBind();

            var track2Laps = lapDataTable.GetTopLapTimes(2, 20);
            lsvTrack2.DataSource = track2Laps;
            lsvTrack2.DataBind();

        }


    }
}