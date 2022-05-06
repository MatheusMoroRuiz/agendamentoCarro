using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Agendamento
{
    class clsCliente
    {
        private String cpf, nome, email;
        private Int64 telefone, codigocliente;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        public String Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public Int64 Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public Int64 Codigocliente
        {
            get { return codigocliente; }
            set { codigocliente = value; }
        }
        public void Cadastrar()
        {
            String insertsql;
        }

        public void Alterar()
        {
            String updatesql;
            updatesql = "";
        }
        /*public DataTable consulta()
        {
            String selectsql;
            DataTable dadoscliente;
            selectsql = "";

            return dadoscliente;
        } */

        public void Remover()
        {
            String deletesql;
            deletesql = "";
        }
        public DataTable Consulta()
        {
            DataTable dtTable = new DataTable();
            string sql = "Select nome, email, telefone, codigo_cliente from cliente where cpf = '" + cpf + "'";
            clsConexao conexao = new clsConexao();
            dtTable = conexao.RetornaDados(sql);

            return dtTable;
        }
        public string Salvar()
        {
            string mensagem;
            clsConexao con = new clsConexao();
            con.nome = nome;
            con.email = email;
            con.cpf = cpf;
            con.telefone = telefone;
            mensagem = con.InsereCliente();




            return mensagem;
        }

        public string EditarCliente()
        {
            string mensagem;
            clsConexao con = new clsConexao();
            con.nome = nome;
            con.email = email;
            con.cpf = cpf;
            con.telefone = telefone;
            con.codigoCliente = codigocliente;
            mensagem = con.EditarCliente();

            return mensagem;

        }

        public string ExcluiCliente()
        {
            string mensagem;
            clsConexao con = new clsConexao();
            con.codigoCliente = codigocliente;
            mensagem = con.ExcluiCliente();

            return mensagem;
        }
    }
}
