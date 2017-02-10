﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectStockSystem
{
    public partial class IndexStudentGroup : System.Web.UI.Page
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

        protected void btnSaveContinue_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("~/IndexStudentSelectAssistantCourse.aspx", true);
        }
    }
}