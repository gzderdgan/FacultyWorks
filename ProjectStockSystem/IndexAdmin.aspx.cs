using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectStockSystem
{
    public partial class IndexAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] != null)
            {
                loginName.Text = Session["UserName"].ToString();
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
        protected void logOutButton_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Session.RemoveAll();
            Response.Redirect("Login.aspx", true);
        }

        protected void btnSistemKaydet_Click(object sender, EventArgs e)
        {
            FacultyWorksEntities db = new FacultyWorksEntities();
            //yönetici için bilgileri alır
            LoginAdmin a = new LoginAdmin();
            a.userId = Convert.ToInt32(tbSistemTcNo.Text);
            a.userName = tbSistemAdı.Text;
            a.userSurname = tbSistemSoyadı.Text;

            //depocu için bilgileri alır

            LoginStocker s = new LoginStocker();
            s.userId = Convert.ToInt32(tbSistemTcNo.Text);
            s.userName = tbSistemAdı.Text;
            s.userSurname = tbSistemSoyadı.Text;


            //kontrol ederek database e kaydetme

            if (ddlSistemRolu.SelectedValue == "Yönetici")
            {

                db.LoginAdmin.Add(a);
                db.SaveChanges();
            }
            if (ddlSistemRolu.SelectedValue == "Depo Sorumlusu")
            {
                db.LoginStocker.Add(s);
                db.SaveChanges();

            }
            gwAdmin.DataBind();
            gwStocker.DataBind();
            tbSistemTcNo.Text = "";
            tbSistemAdı.Text = "";
            tbSistemSoyadı.Text = "";
        }

    }
}