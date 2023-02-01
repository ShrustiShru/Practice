using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Products.cs
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var data = PhoneRepo.AllProducts;//Passing everything to data
                foreach (var item in data)
                lstProducts.Items.Add(new ListItem //adds products to listBox created in front end
                {
                    Text=item.ProductName,
                    Value=item.ProductId.ToString()
                });
            }
        }

        protected void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = int.Parse(lstProducts.SelectedValue);//input given by a user via dropdown box
            var selected = PhoneRepo.AllProducts.FirstOrDefault((p) => p.ProductId == id); //comparing user input with the database
            txtName.Text = selected.ProductName; //after comparing passing the related id details to the id created in the front end and displaying the name ande price
            txtPrice.Text = selected.ProductPrice.ToString();
            Image.ImageUrl = selected.Image;
        }

    }
}