using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    public class Endereco
    {


        public int Id { get; set; }
        public int Cliente_Id { get; set; }
        public string? Cep { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Uf { get; set; }
        public string? Tipo_endereco { get; set; }

        Endereco()
        {


        }

        //Métodos construtores
        public Endereco(int id, string? cep, string? logradouro, string? numero, string? complemento, string? bairro, string? cidade, string? uf, string? tipo_endereco)
        {
            Id = id;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Tipo_endereco = tipo_endereco;
        }
        public Endereco(string? cep, string? logradouro, string? numero, string? complemento,
            string? bairro, string? cidade, string? uf, string? tipo_endereco)
        {


            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Tipo_endereco = tipo_endereco;
        }
        //Métodos Construtores


        public Endereco(int id, int cliente_Id, string? cep, string? logradouro, string? numero, string? complemento, string? bairro, string? cidade, string? uf, string? tipo_endereco)
        {
            Id = id;
            Cliente_Id = cliente_Id;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Tipo_endereco = tipo_endereco;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_enderecos_insert";
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue("sptipo", Tipo_endereco);
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Id = dr.GetInt32(0);

            }
            cmd.Connection.Close();

        }
        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_altera";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue("sptipo_endereco", Tipo_endereco);


            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }
        // efetuar login
        public void Excluir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "sp_endereco_delete";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static List<Endereco> ObterListaDoCliente(int cliente_Id)
        {
            List<Endereco> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from clientes where id= {cliente_Id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(
               dr.GetInt32(0),
               dr.GetInt32(1),
              dr.GetString(2),
                   dr.GetString(3),
                   dr.GetString(4),
                    dr.GetString(5),
                     dr.GetString(5),
                      dr.GetString(6),
                       dr.GetString(7),
                        dr.GetString(8)
                        )

                    );


            }
            return lista;
        }

    }
}

