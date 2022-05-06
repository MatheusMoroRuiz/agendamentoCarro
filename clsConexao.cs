using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Agendamento
{
    class clsConexao
    {
        private string stringConexao;
        private string sql;

        public string nome, cpf, email;
        public Int64 telefone, codigoCliente;

        public String marca, modelo, placa;
        public int km, Km, codigocarro;

        public String datahora;

        //abre a conexão com o banco
        public SqlConnection Conectar()
        {
            string ConnectionString = "DATA SOURCE=localhost;INITIAL CATALOG=AGENDAMENTO;USER ID=sa;Password=headpvp123;";
            SqlConnection conectar = new SqlConnection(ConnectionString);
            conectar.Open();
            //conectar.Close();
            return conectar;
        }
        public DataTable RetornaDados(string sql)
        {
            DataTable dtTable = new DataTable();
            SqlConnection conectar;
            conectar = Conectar();
            SqlDataAdapter consulta = new SqlDataAdapter(sql, conectar);
            //preenche o DataTable
            consulta.Fill(dtTable);

            conectar.Close();

            return dtTable;

        }
        public string InsereCliente()
        {
            string mensagem;
            string sql = "INSERT CLIENTE(NOME, EMAIL, CPF, TELEFONE) " +
            "VALUES (@NOME, @EMAIL, @CPF, @TELEFONE)";



            try
            {

                SqlConnection conn = new SqlConnection();
                conn = Conectar();
                //Cria uma objeto do tipo comando passando como parametro a string sql e a string de conexão
                SqlCommand comando = new SqlCommand(sql, conn);
                //Adicionando o valor das textBox nos parametros do comando
                comando.Parameters.Add(new SqlParameter("@NOME", nome));
                comando.Parameters.Add(new SqlParameter("@EMAIL", email));
                comando.Parameters.Add(new SqlParameter("@CPF", cpf));
                comando.Parameters.Add(new SqlParameter("@TELEFONE", telefone));
                comando.ExecuteNonQuery();
                //fecha a conexao
                conn.Close();



                mensagem = "Salvo com sucesso";



                return mensagem;



            }
            catch (Exception ex)
            {
                mensagem = "Erro ao salvar - " + ex.Message;
                return mensagem;
            }
        }
        public string InsereCarro()
        {
            string mensagem;
            string sql = "INSERT CARRO(MARCA, MODELO, PLACA, KM, CODIGO_CLIENTE) " +
            "VALUES (@MARCA, @MODELO, @PLACA, @KM, @CODIGO_CLIENTE)";



            try
            {

                SqlConnection conn = new SqlConnection();
                conn = Conectar();
                //Cria uma objeto do tipo comando passando como parametro a string sql e a string de conexão
                SqlCommand comando = new SqlCommand(sql, conn);
                //Adicionando o valor das textBox nos parametros do comando
                comando.Parameters.Add(new SqlParameter("@MARCA", marca));
                comando.Parameters.Add(new SqlParameter("@MODELO", modelo));
                comando.Parameters.Add(new SqlParameter("@PLACA", placa));
                comando.Parameters.Add(new SqlParameter("@KM", km));
                comando.Parameters.Add(new SqlParameter("@CODIGO_CLIENTE", codigoCliente));
                comando.ExecuteNonQuery();
                //fecha a conexao
                conn.Close();



                mensagem = "Salvo com sucesso";



                return mensagem;



            }
            catch (Exception ex)
            {
                mensagem = "Erro ao salvar - " + ex.Message;
                return mensagem;
            }
        }
        public string InsereAgenda()
        {
            string mensagem;
            string sql = "INSERT AGENDA(DATAHORA, KM, CODIGO_CARRO) " +
            "VALUES (@DATAHORA, @KM, @CODIGO_CARRO)";



            try
            {

                SqlConnection conn = new SqlConnection();
                conn = Conectar();
                //Cria uma objeto do tipo comando passando como parametro a string sql e a string de conexão
                SqlCommand comando = new SqlCommand(sql, conn);
                //Adicionando o valor das textBox nos parametros do comando
                comando.Parameters.Add(new SqlParameter("@DATAHORA", datahora));
                comando.Parameters.Add(new SqlParameter("@KM", Km));
                comando.Parameters.Add(new SqlParameter("@CODIGO_CARRO", codigocarro));
                comando.ExecuteNonQuery();
                //fecha a conexao
                conn.Close();



                mensagem = "Salvo com sucesso";



                return mensagem;



            }
            catch (Exception ex)
            {
                mensagem = "Erro ao salvar - " + ex.Message;
                return mensagem;
            }
        }
        public string EditarCliente()
        {
            string mensagem;
            string sql = "UPDATE CLIENTE SET NOME = @NOME, EMAIL = @EMAIL," +
            "CPF = @CPF, TELEFONE = @TELEFONE WHERE CODIGO_CLIENTE = @CODIGO_CLIENTE ";



            try
            {

                SqlConnection conn = new SqlConnection();
                conn = Conectar();
                //Cria uma objeto do tipo comando passando como parametro a string sql e a string de conexão
                SqlCommand comando = new SqlCommand(sql, conn);
                //Adicionando o valor das textBox nos parametros do comando
                comando.Parameters.Add(new SqlParameter("@NOME", nome));
                comando.Parameters.Add(new SqlParameter("@EMAIL", email));
                comando.Parameters.Add(new SqlParameter("@CPF", cpf));
                comando.Parameters.Add(new SqlParameter("@TELEFONE", telefone));
                comando.Parameters.Add(new SqlParameter("@CODIGO_CLIENTE", codigoCliente));
                comando.ExecuteNonQuery();
                //fecha a conexao
                conn.Close();



                mensagem = "Salvo com sucesso";



                return mensagem;



            }
            catch (Exception ex)
            {
                mensagem = "Erro ao salvar - " + ex.Message;
                return mensagem;
            }
        }

        public string EditarCarro()
        {
            string mensagem;
            string sql = "UPDATE CARRO SET MARCA = @MARCA, MODELO = @MODELO," +
            "PLACA = @PLACA, KM = @KM WHERE CODIGO_CARRO = @CODIGO_CARRO ";



            try
            {

                SqlConnection conn = new SqlConnection();
                conn = Conectar();
                //Cria uma objeto do tipo comando passando como parametro a string sql e a string de conexão
                SqlCommand comando = new SqlCommand(sql, conn);
                //Adicionando o valor das textBox nos parametros do comando
                comando.Parameters.Add(new SqlParameter("@MARCA", marca));
                comando.Parameters.Add(new SqlParameter("@MODELO", modelo));
                comando.Parameters.Add(new SqlParameter("@PLACA", placa));
                comando.Parameters.Add(new SqlParameter("@KM", km));
                comando.Parameters.Add(new SqlParameter("@CODIGO_CARRO", codigocarro));
                comando.ExecuteNonQuery();
                //fecha a conexao
                conn.Close();



                mensagem = "Salvo com sucesso";



                return mensagem;



            }
            catch (Exception ex)
            {
                mensagem = "Erro ao salvar - " + ex.Message;
                return mensagem;
            }
        }
        public string ExcluiCliente()
        {
            string mensagem;
            string sql = "DELETE FROM CLIENTE WHERE CODIGO_CLIENTE = @CODIGO_CLIENTE";



            try
            {

                SqlConnection conn = new SqlConnection();
                conn = Conectar();
                //Cria uma objeto do tipo comando passando como parametro a string sql e a string de conexão
                SqlCommand comando = new SqlCommand(sql, conn);
                //Adicionando o valor das textBox nos parametros do comando
                comando.Parameters.Add(new SqlParameter("@CODIGO_CLIENTE", codigoCliente));
                comando.ExecuteNonQuery();
                //fecha a conexao
                conn.Close();



                mensagem = "Excluído com sucesso";



                return mensagem;



            }
            catch (Exception ex)
            {
                mensagem = "Erro ao salvar - " + ex.Message;
                return mensagem;
            }
        }
    }
}
