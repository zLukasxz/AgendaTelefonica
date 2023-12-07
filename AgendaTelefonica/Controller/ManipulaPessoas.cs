using AgendaTelefonica.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonica.Controller
{
    internal class ManipulaPessoas
    {
        public void AdicionaPessoas()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_AdicionarPessoa", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@Nome", Pessoas.Nome1);
                cmd.Parameters.AddWithValue("@Fone", Pessoas.Fone1);
                cmd.Parameters.AddWithValue("@Email", Pessoas.Email1);
                cmd.Parameters.AddWithValue("@Endereco", Pessoas.Endereco1);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Pessoa Cadastrada com Sucesso.");
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void DeletarPessoas()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_DeletarPessoa", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@Id", Pessoas.Id1);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Registo Excluído com Sucesso");
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void AlterarPessoa()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_AlterarPessoa", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@Id", Pessoas.Id1);
                cmd.Parameters.AddWithValue("@Nome", Pessoas.Nome1);
                cmd.Parameters.AddWithValue("@Fone", Pessoas.Fone1);
                cmd.Parameters.AddWithValue("@Email", Pessoas.Email1);
                cmd.Parameters.AddWithValue("@Endereco", Pessoas.Endereco1);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Informações Atualizadas com Sucesso.");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Registro não alterado.");
            }
            finally { cn.Close(); }
        }
        public void ProcurarPessoaCodigo()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_ProcurarPessoaCodigo", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@Id", Pessoas.Id1);
                cn.Open();
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Pessoas.Id1 = Convert.ToInt32(dr["Id"]);
                    Pessoas.Nome1 = dr["Nome"].ToString();
                    Pessoas.Fone1 = dr["Fone"].ToString();
                    Pessoas.Email1 = dr["Email"].ToString();
                    Pessoas.Endereco1 = dr["Endereco"].ToString();
                }
                else
                {
                    Pessoas.Id1 = 0;
                    Pessoas.Nome1 = "";
                    Pessoas.Fone1 = "";
                    Pessoas.Email1 = "";
                    Pessoas.Endereco1 = "";
                    MessageBox.Show("Contato não encontrado.");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static BindingSource ProcurarPessoaNome()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_ProcurarPessoaNome", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nome", Pessoas.Nome1);
            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;
        }
    }
}
