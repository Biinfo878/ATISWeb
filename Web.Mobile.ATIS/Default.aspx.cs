using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.IO;
using System.Web.UI.WebControls;

namespace Web.Mobile.ATIS
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.FileStream fs = null;
                fs = System.IO.File.Open(HttpContext.Current.Server.MapPath("~/App_Data/ATISMobile.APK"), FileMode.Open);
                byte[] btFile = new byte[fs.Length];
                fs.Read(btFile, 0, Convert.ToInt32(fs.Length));
                fs.Close();
                Response.Buffer = true;
                Response.Expires = 0;
                Response.ContentType = "application/octet-stream";
                Response.AddHeader("Content-Type", "application/octet-stream");
                //Response.AddHeader("Content-Length", btFile.Length.ToString);
                Response.AddHeader("Content-Disposition", "attachment;filename=ATISMobile.apk");
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.BinaryWrite(btFile);
                Response.End();
            }
            catch (Exception ex)
            { return; }
        }
    }
}