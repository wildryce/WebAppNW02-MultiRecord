using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using DBSystem.BLL;
using DBSystem.ENTITIES;

namespace WebApp.ExercisePages
{
    public partial class MultiRecordQueryWithCustomGridView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MessageLabel.Text = "";
            if (!Page.IsPostBack)
            {
                BindCategoryList();
            }
        }

        protected void BindCategoryList()
        {
            try
            {
                Controller02 sysmgr = new Controller02();
                List<Entity02> info = null;
                info = sysmgr.List();
                info.Sort((x, y) => x.CategoryName.CompareTo(y.CategoryName));
                CategoryList.DataSource = info;
                CategoryList.DataTextField = nameof(Entity02.CategoryName);
                CategoryList.DataValueField = nameof(Entity02.CategoryID);
                CategoryList.DataBind();
                CategoryList.Items.Insert(0, "select...");

            }
            catch (Exception ex)
            {
                MessageLabel.Text = ex.Message;
            }
        }

        protected void Fetch_Click(object sender, EventArgs e)
        {
            if (CategoryList.SelectedIndex == 0)
            {
                MessageLabel.Text = "Select a category to view its products";
            }
            else
            {
                try
                {
                    Controller03 sysmgr = new Controller03();
                    List<Entity03> info = null;
                    info = sysmgr.FindByEntity02ID(int.Parse(CategoryList.SelectedValue));
                    info.Sort((x, y) => x.ProductName.CompareTo(y.ProductName));
                    ProductList.DataSource = info;
                    ProductList.DataBind();
                }
                catch (Exception ex)
                {
                    MessageLabel.Text = ex.Message;
                }
            }
        }

        protected void ProductList_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            ProductList.PageIndex = e.NewPageIndex;
            Fetch_Click(sender, new EventArgs());
        }

        protected void ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow agvrow = ProductList.Rows[ProductList.SelectedIndex];
            string productid = (agvrow.FindControl("ProductID") as Label).Text;
            Response.Redirect("ReceivingPage.aspx?pid=" + productid);
        }
    }
}