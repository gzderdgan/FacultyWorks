using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace ProjectStockSystem
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonLogin_Click(object sender, EventArgs e)
        {
            DB_Entities db = new DB_Entities();
            
            var myAdmin = db.LoginAdmins
        .FirstOrDefault(u => u.userId == username_input.Value
                     && u.userPass == password_input.Value);

            var myStudent = db.LoginStudents
       .FirstOrDefault(u => u.userId == username_input.Value
                     && u.userPass == password_input.Value);

            var myLecturer = db.LoginLecturers
       .FirstOrDefault(u => u.userId == username_input.Value
                     && u.userPass == password_input.Value);

            var myStocker = db.LoginStockers
       .FirstOrDefault(u => u.userId == username_input.Value
                     && u.userPass == password_input.Value);
            if (myAdmin != null)    //User was found
            {
                Session["UserName"] = username_input.Value;
                Response.Redirect("~/IndexAdmin.aspx");
            }
            if (myStudent != null)    //User was found
            {
                Session["UserName"] = username_input.Value;
                Response.Redirect("~/IndexStudent.aspx");
            }
            if (myLecturer != null)    //User was found
            {
                Session["UserName"] = username_input.Value;
                Response.Redirect("~/IndexLecturer.aspx");
            }
            if (myStocker != null) //User was found
            {
                Session["UserName"] = username_input.Value;
                Response.Redirect("~/IndexStocker.aspx");
            }
            else
            {
                ModelState.AddModelError("", "Invalid login credentials.");
            }
        }
    }
}