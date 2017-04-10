using System;
using System.Collections.Generic;

namespace ProvaRegimental.Models
{
    /// <summary>
    /// Metodos para interação com banco
    /// </summary>
    public class CepDAO : DAO
    {
        /// <summary>
        /// Metodo para inserir CEP na Tabela
        /// </summary>
        /// <returns></returns>
        public string inserirCEP(Cep cep)
        {
            string resp;
            string sql = string.Empty;
            try
            {
                sql = "INSERT INTO CEP(Cod_cep,Desc_cep,Lat_cep,Long_cep) VALUES (@Cod_cep,@Desc_cep,@Lat_cep,@Long_cep)";
                cmd = Conexao.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@Cod_cep", cep.Cod_cep);
                cmd.Parameters.AddWithValue("@Desc_cep", cep.Desc_cep);
                cmd.Parameters.AddWithValue("@Lat_cep", cep.Lat_cep);
                cmd.Parameters.AddWithValue("@Long_cep", cep.Long_cep);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    resp = "OK";
                }
                else
                {
                    resp = "Falha ao inserir o CEP: " + sql;
                }
            }
            catch (Exception ex)
            {
                resp = "ERRO: " + ex.ToString() + "SQL: " + sql;
            }
            finally
            {
                Fechar();
            }
            return resp;
        }

        /// <summary>
        /// Metodo para Alterar CEP na Tabela
        /// </summary>
        /// <param name="CEP"></param>
        /// <returns></returns>
        public string AlteraCEP(Cep cep)
        {
            string resp;
            string sql = string.Empty;
            try
            {
                sql = "UPDATE CEP SET Desc_cep=@Desc_cep, Lat_cep=@Lat_cep, Long_cep=@Long_cep WHERE Cod_cep=@Cod_cep";
                cmd = Conexao.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@Cod_cep", cep.Cod_cep);
                cmd.Parameters.AddWithValue("@Desc_cep", cep.Desc_cep);
                cmd.Parameters.AddWithValue("@Lat_cep", cep.Lat_cep);
                cmd.Parameters.AddWithValue("@Long_cep", cep.Long_cep);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    resp = "OK";
                }
                else
                {
                    resp = "Falha ao Alterar dados: " + sql;
                }
            }
            catch (Exception ex)
            {
                resp = "ERRO: " + ex.ToString() + "SQL: " + sql;
            }
            finally
            {
                Fechar();
            }
            return resp;
        }

        /// <summary>
        /// Metodo que Deleta CEP na Tabela
        /// </summary>
        /// <param name="CEP"></param>
        /// <returns></returns>
        public string DeletaCEP(Cep cep)
        {
            string resp = "";
            string sql = "";
            try
            {

                cmd = Conexao.CreateCommand();
                cmd.CommandText = sql = "DELETE FROM CEP WHERE Cod_cep=@Cod_cep";
                cmd.Parameters.AddWithValue("@Cod_cep", cep.Cod_cep);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    resp = "OK";
                }
                else
                {
                    resp = "Falha ao Excluir dados: " + sql;
                }
            }
            catch (Exception ex)
            {
                resp = "ERRO: " + ex.ToString() + "SQL: " + sql;
            }
            finally
            {
                Fechar();
            }

            return resp;
        }

        public Cep pesqusaCEP(int id)
        {
            Cep c = null;
            string sql;
            try
            {
                sql = "SELECT * FROM CEP WHERE Cod_cep = @Cod_cep";
                cmd = Conexao.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@Cod_cep", id);

                using (var dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        if (dr.Read())
                        {
                            c = new Cep();
                            c.Cod_cep = Convert.ToInt32(dr["Cod_cep"]);
                            c.Desc_cep = dr["Desc_cep"].ToString();
                            c.Lat_cep = Convert.ToInt32(dr["Lat_cep"]);
                            c.Long_cep = Convert.ToInt32(dr["Long_cep"]);
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                Fechar();
            }
            return c;
        }

        public List<Cep> Listar()
        {
            List<Cep> cep = new List<Cep>();


            try
            {
                cmd = Conexao.CreateCommand();
                cmd.CommandText = "SELECT * FROM CEP";

                using (var dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            cep.Add(new Cep
                            {
                                Cod_cep = Convert.ToInt32(dr["Cod_cep"]),
                                Desc_cep = dr["Desc_cep"].ToString(),
                                Lat_cep = Convert.ToInt32(dr["Lat_cep"]),
                                Long_cep = Convert.ToInt32(dr["Long_cep"])
                            });
                        }
                    }
                }
            }
            finally
            {
                Fechar();
            }
            return cep;
        }
    }
}