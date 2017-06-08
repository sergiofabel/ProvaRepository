using ProvaRegimental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProvaRegimental
{
    public partial class Contact : Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            ListarCep();
        }

        private void ListarCep()
        {
            GridView1.DataSource = new CepDAO().Listar();
            GridView1.DataBind();
        }

        
    }
}