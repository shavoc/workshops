using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FileInclusion
{
    public partial class Reader : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string fileName = Request.Form["fileInput"];
                ReadFile(fileName);
                
            }
        }
        public void ReadFile(string fileName)
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
                string resolvedPath = Path.GetFullPath(filePath);
                Response.AppendHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(resolvedPath));
                Response.TransmitFile(resolvedPath);
                Response.End();
            }
            catch (Exception ex)
            {
                
            }
        }

        //public void ReadFilePatched(string fileName)
        //{
        //    try
        //    {
        //        string basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files");
        //        string filePath = Path.Combine(basePath, fileName);
        //        string resolvedPath = Path.GetFullPath(filePath);
        //        if (!resolvedPath.StartsWith(basePath, StringComparison.OrdinalIgnoreCase))
        //        {
        //            Response.Write("Invalid file path.");
        //            return;
        //        }

        //        if (File.Exists(resolvedPath))
        //        {
        //            Response.AppendHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(resolvedPath));
        //            Response.TransmitFile(resolvedPath);
        //            Response.End();
        //        }
        //        else
        //        {
        //            Response.Write("File does not exist.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Write("Error: " + ex.Message);
        //    }
        //}

    }
}
