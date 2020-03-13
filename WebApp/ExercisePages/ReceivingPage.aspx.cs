﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.ExercisePages
{
    public partial class ReceivingPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string pid = Request.QueryString["pid"];
                if (string.IsNullOrEmpty(pid))
                {
                    Response.Redirect("SqlQueryNiceGridYesNav.aspx");
                }
                else
                {
                    MessageLabel.Text = "you passed the following data: >" + pid + "<";
                }
            }

        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("SqlQueryNiceGridYesNav.aspx");
        }
    }
}