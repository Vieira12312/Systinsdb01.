using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{

    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public DateTime Data_Nasc { get; set; }
        public DateTime Data_cad { get; set; }
        public bool Ativo;
        public List<Endereco>? Endereco { get; set; }
        public Cliente()
        {
            Endereco = new List<Endereco>();
        }
        public Cliente(int id, string? nome, string? cpf, string? telefone, string? email, DateTime data_Nasc, DateTime data_cad, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_Nasc = data_Nasc;
            Data_cad = data_cad;
            Ativo = ativo;
        }

        public Cliente(string? nome, string? cpf, string? telefone, string? email, DateTime data_Nasc)
        {

            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_Nasc = data_Nasc;

        }
        public Cliente(int id, string? nome, string? telefone, DateTime data_Nasc)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Data_Nasc = data_Nasc;
        }

        public Cliente(int id, string? nome, string? cpf, string? telefone, string? email, DateTime data_Nasc, DateTime data_cad, bool ativo, List<Endereco>? endereco)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_Nasc = data_Nasc;
            Data_cad = data_cad;
            Ativo = ativo;
            Endereco = endereco;
        }



        // Inserir Cliente

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spdatanasc", Data_Nasc);
            var dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Id = dr.GetInt32(0);
            }

            cmd.Connection.Close();

        }

        // ObterporId

        public static Cliente ObterporId(int id)
        {
            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from clientes where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cliente = new(
                   dr.GetInt32(0),
                   dr.GetString(1),
                   dr.GetString(2),
                   dr.GetString(3),
                   dr.GetString(4),
                   dr.GetDateTime(5),
                   dr.GetDateTime(6),
                   dr.GetBoolean(7)
                   );

            }

            return cliente;

        }

        // Classe busca pelo nome do Cliente

        public static List<Cliente> ObterLista()
        {
            List<Cliente> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from clientes order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(
                   dr.GetInt32(0),
                   dr.GetString(1),
                   dr.GetString(2),
                   dr.GetString(3),
                   dr.GetString(4),
                   dr.GetDateTime(5),
                   dr.GetDateTime(6),
                   dr.GetBoolean(7)
                   ));

            }

            return lista;

        }

        // Atualizar ou alterar

        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spdatanasc", Data_Nasc);
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }
    }
}
