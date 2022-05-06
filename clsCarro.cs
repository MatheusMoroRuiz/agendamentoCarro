using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Agendamento
{
    class clsCarro
    {
        private String marca, modelo, placa;
        private int km, codigocarro, codigoCliente;

        public String Marca
        {
            get { return marca;  }
            set { marca = value;  }
        }
        public String Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public String Placa
        {
            get { return placa; }
            set { placa = value; }
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
        public int CodigoCliente
        {
            get { return codigoCliente; }
            set { codigoCliente = value; }
        }
        public string Cadastrar()
        {
            string mensagem;
            clsConexao con = new clsConexao();
            con.marca = marca;
            con.modelo = modelo;
            con.placa = placa;
            con.km = km;
            con.codigoCliente = codigoCliente;
            mensagem = con.InsereCarro();




            return mensagem;
        }
        public String cpf;
        public DataTable Consulta()
        {
            DataTable dtTable = new DataTable();
            string sql = "Select codigo_carro, marca, modelo, placa, km from carro where placa = '" + placa + "'";
            clsConexao conexao = new clsConexao();
            dtTable = conexao.RetornaDados(sql);

            return dtTable;
        }
        public string EditarCarro()
        {
            string mensagem;
            clsConexao con = new clsConexao();
            con.marca = marca;
            con.modelo = modelo;
            con.placa = placa;
            con.km = km;
            con.codigocarro = codigocarro;
            mensagem = con.EditarCarro();

            return mensagem;

        }
    }
}
