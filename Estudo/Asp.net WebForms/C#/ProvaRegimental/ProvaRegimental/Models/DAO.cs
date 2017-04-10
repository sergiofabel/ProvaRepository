using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProvaRegimental.Models
{
    public abstract class DAO
    {
        SqlConnection conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        protected SqlCommand cmd;

        protected SqlConnection Conexao
        {
            get
            {
                Abrir();
                return conexao;
            }
        }

        protected void Abrir()
        {
            if (conexao.State != ConnectionState.Open)
            {
                conexao.Open();
            }
        }

        protected void Fechar()
        {
            if (conexao.State != ConnectionState.Closed)
            {
                conexao.Close();
            }
        }
    }
}