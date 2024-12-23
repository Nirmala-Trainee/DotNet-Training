using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1_ASP_
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                imgProduct.Visible = false;
                lblPrice.Visible = false;
            }
        
         }

        protected void ddlProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedProduct = int.Parse(ddlProducts.SelectedValue);

            imgProduct.Visible = false;
            lblPrice.Visible = false;

            switch (selectedProduct)
            {
                case 1:
                    imgProduct.ImageUrl = "Images/pr-1.jpg"; // Make sure you have the image in the folder
                    lblPrice.Text = "Price: $200";
                    break;
                case 2:
                    imgProduct.ImageUrl = "Images/pr-2.jpg";
                    lblPrice.Text = "Price: $500";
                    break;
                case 3:
                    imgProduct.ImageUrl = "Images/pr-3.jpg";
                    lblPrice.Text = "Price: $250";
                    break;
                case 4:
                    imgProduct.ImageUrl = "Images/pr-4.jpg";
                    lblPrice.Text = "Price: $50";
                    break;
                default:
                    imgProduct.Visible = false;
                    lblPrice.Visible = false;
                    break;
            }

            if (selectedProduct != 0)
            {
                imgProduct.Visible = true;
                lblPrice.Visible = false;
            }
        }
        protected void btnGetPrice_Click(object sender, EventArgs e)
        {
            lblPrice.Visible = true;
        }

    }
    }