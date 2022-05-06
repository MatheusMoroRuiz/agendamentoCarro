using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Agendamento
{
    class clsAgenda
    {
        private int codigoagendamento, codigocarro, km;
        private String data, hora;

        public string placa;

    public int Codigoagendamento
    {
            get { return codigoagendamento ; }
            set { codigoagendamento = value; }
    }
        public int Km
        {
            get { return km; }
            set { km = value; }
        }
        public int Codigocarro
    {
        get { return codigocarro; }
        set { codigocarro = value; }
    }
    public String Data
    {
        get { return data; }
        set { data = value; }
    }
    public String Hora
    {
        get { return hora; }
        set { hora = value; }
    }
        public void Adicionar()
        {
            String insertsql;
        }
        public void Alterar()
        {
            String updatesql;
            updatesql = "";
        }
        /* public DataTable consulta()
         {
             String selectsql;
             DataTable dadosagenda;
             selectsql = "";

             return dadosagenda;
         } */
        public string Cadastrar()
        {
            string mensagem;
            clsConexao con = new clsConexao();
            con.datahora = data + " " + hora;
            con.Km = km;
            con.codigocarro = codigocarro;
            mensagem = con.InsereAgenda();

            return mensagem;
        }
        public DataTable Consulta()
        {
            DataTable dtTable = new DataTable();
            string sql = "Select codigo_carro from carro where placa = '" + placa + "'";
            clsConexao conexao = new clsConexao();
            dtTable = conexao.RetornaDados(sql);

            return dtTable;
        }
        public DataTable ConsultaTodos()
        {
            DataTable dtTable = new DataTable();
            string sql = "Select codigo_carro, datahora, km from agenda";
            clsConexao conexao = new clsConexao();
            dtTable = conexao.RetornaDados(sql);

            return dtTable;
        }
    }
}

