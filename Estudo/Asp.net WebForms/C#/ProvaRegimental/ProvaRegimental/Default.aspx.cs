using ProvaRegimental.Models;
using System;
using System.Web.UI;

namespace ProvaRegimental
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pMensagem.Visible = false;
            pMensagem.Attributes["class"] = "col-sm-12";
            ListarCep();
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Cep cep = new Cep(Convert.ToInt32(txtCod.Text), txtDesc.Text, Convert.ToDecimal(txtLat.Text), Convert.ToDecimal(txtLong.Text));
                string retorno = new CepDAO().inserirCEP(cep);

                if (retorno == "OK")
                {
                    Mensagem(Color.Green, "O CEP foi inserido com Sucesso");
                    ListarCep();
                }
                else
                {
                    Mensagem(Color.Red, retorno);
                }
            }
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Cep cep = new Cep(Convert.ToInt32(txtCod.Text), txtDesc.Text, Convert.ToDecimal(txtLat.Text), Convert.ToDecimal(txtLong.Text));
                string retorno = new CepDAO().AlteraCEP(cep);

                if (retorno == "OK")
                {
                    Mensagem(Color.Green, "O CEP foi alterado com Sucesso");
                    ListarCep();
                }
                else
                {
                    Mensagem(Color.Red, retorno);
                }
            }
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtCod.Text))
            {
                Mensagem(Color.Red, "Preencha o Codigo");
                txtCod.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtDesc.Text))
            {
                Mensagem(Color.Red, "Preencha a descrição");
                txtDesc.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtLat.Text))
            {
                Mensagem(Color.Red, "Preencha a Latitude");
                txtLat.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtLong.Text))
            {
                Mensagem(Color.Red, "Preencha a Longitude");
                txtLong.Focus();
                return false;
            }

            return true;
        }

        protected void btnEcluir_Click(object sender, EventArgs e)
        {
            string Cod = txtCod.Text;

            if (string.IsNullOrWhiteSpace(Cod))
            {
                Mensagem(Color.Red, "Preencha o Codigo");
                txtCod.Focus();
            }
            else
            {
                Cep cep = new Cep();
                cep.Cod_cep = Convert.ToInt32(Cod);
                string retorno = new CepDAO().DeletaCEP(cep);

                if (retorno == "OK")
                {
                    Mensagem(Color.Green, "O CEP foi Excluido com Sucesso");
                    ListarCep();
                }
                else
                {
                    Mensagem(Color.Red, retorno);
                }
            }
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCod.Text))
            {
                Mensagem(Color.Red, "Preencha o Codigo");
                txtCod.Focus();
            }
            else
            {
                Cep cep = new CepDAO().pesqusaCEP(Convert.ToInt32(txtCod.Text));

                if (cep != null)
                {
                    txtCod.Text = (Convert.ToInt32(cep.Cod_cep)).ToString();
                    txtDesc.Text = cep.Desc_cep;
                    txtLat.Text = (Convert.ToInt32(cep.Lat_cep)).ToString();
                    txtLong.Text = (Convert.ToInt32(cep.Long_cep)).ToString();
                }
                else
                {
                    Mensagem(Color.Red, "CEP não encontrado");
                }
            }
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCod.Text = null;
            txtDesc.Text = null;
            txtLat.Text = null;
            txtLong.Text = null;
        }

        private void ListarCep()
        {
            GridView1.DataSource = new CepDAO().Listar();
            GridView1.DataBind();
        }

        private void Mensagem(Color color, string mensagem)
        {
            pMensagem.Visible = true;
            string css = "col-sm-12";

            switch (color)
            {
                case Color.Red:
                    css += " bg-danger";
                    break;

                case Color.Green:
                    css += " bg-success";
                    break;
            }

            pMensagem.Attributes["class"] = css;
            lblMensagem.Text = mensagem;
        }

        private enum Color
        {
            Red,
            Green
        }
    }
}