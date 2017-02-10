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
            FacultyWorksEntities db = new FacultyWorksEntities();
            int usernameInputValue = Convert.ToInt32(username_input.Value);
            var myAdmin = db.LoginAdmin
        .FirstOrDefault(u => u.userId == usernameInputValue
                     && u.userPass == password_input.Value);

            var myStudent = db.Ogrenci
       .FirstOrDefault(u => u.kullanıcı_id == usernameInputValue
                     && u.kullanıcı_sifre == password_input.Value);

            var myLecturer = db.LoginLecturer
       .FirstOrDefault(u => u.userId == usernameInputValue
                     && u.userPass == password_input.Value);

            var myStocker = db.LoginStocker
       .FirstOrDefault(u => u.userId == usernameInputValue
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