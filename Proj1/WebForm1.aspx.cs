using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proj1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btCalcular_Click(object sender, EventArgs e)
        {
            try
            {
               
                int i = Convert.ToInt32(txtNum.Text);
                txtRes.Text = Convert.ToString(Fatorial.calculaFatorial(i));
                
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Entre com um dado numerico. Erro:" + ex.Message;
            }

        }
    }
}