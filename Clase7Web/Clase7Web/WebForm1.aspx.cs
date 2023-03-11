using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clase7Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
 static float total;
        protected void Boton_Calcular_Click(object sender, EventArgs e)
        {
            float N1, N2;
            N1 = float.Parse(txtn1.Text);
            N2 = float.Parse(txtn2.Text);
              
            if (RBSuma.Checked)
            {
                total = N1 + N2;

            }
            else if (RBResta.Checked)
            {
                total = N1 - N2;
            }
            else if (RBMulti.Checked)
            {
                total = N1 * N2;
            }
            else if (RBDivision.Checked)
            {
                total = N1 / N2;
            }

            txtresultado.Text = total.ToString();
        }

    }
}