using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SerieFibonacci
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            int primero = 0, segundo = 1, num = 0;

            if (txtNumero.Text == "")
            {
                Response.Write("<script>alert('Debe ingresar una cifra numérica')</script>");
            }
            else
            {
                lbFibonacci.Text = primero + "," + segundo;

                for (int i = 0; i < Convert.ToInt32(txtNumero.Text); i++)
                {
                    num = primero + segundo;
                    if (num <= Convert.ToInt32(txtNumero.Text))
                    {
                        lbFibonacci.Text = lbFibonacci.Text + "," + num;
                        primero = segundo;
                        segundo = num;
                    }
                }
            }
        }
    }
}