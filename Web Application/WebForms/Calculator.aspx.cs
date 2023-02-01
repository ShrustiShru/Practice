using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApplication
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnResult_Click(object sender, EventArgs e)
        {
            var v1 = Convert.ToInt32(FirstNo.Text);
            var v2 = Convert.ToInt32(SecondNo.Text);
            var operation = dropList.SelectedValue;
            var result = getResult(v1, v2, operation);
            lblDisplay.Text = "The Result: " + result;
        }

        private double getResult(double v1, double v2, string operation)
        {
            switch(operation)
            {
                case "Addition":return v1 + v2;
                case "Subtraction":return v1 - v2;
                case "Multipication":return v1 * v2;
                case "Division":return v1 / v2;
                default: break;
            }
            return 0;
        }
    }
}