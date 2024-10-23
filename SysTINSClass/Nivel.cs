using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    public class Nivel
    {
        public int Id {  get; set; }
        public string? Nome { get; set; }    
        public string? Sigla { get; set; } 

        public Nivel() { }// isso é um método construtor quando usamos a expressão new em qualquer lugar estamos chamando o metodo construtor

        public Nivel(string? name, string? sigla)
        {
            Nome = name;
            Sigla = sigla;
        }
        public Nivel(int id, string? name, string? sigla)
        {
            Id = id;
            Nome = name;
            Sigla = sigla;
        }
        public void Inserir() { 
        var cmd =Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert niveis (nome, sigla) values ('{Nome}','{Sigla}')";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static Nivel ObterPorId(int id)
        {
            Nivel nivel = new ();
            var cmd =Banco.Abrir(); 
            cmd.CommandType= System.Data.CommandType.Text;
            cmd.CommandText = $"select * from niveis where id ={id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //nivel.Id = dr.GetInt32(0);
                //nivel.Name = dr.GetString(1);
                //nivel.Sigla = dr.GetString(2);

                nivel = new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));
            }
            cmd.Connection.Close ();
            return nivel;
        }
        public static List<Nivel> ObterLista()
        { List<Nivel> lista = new();
            var cmd =Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from niveis order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Nivel(dr.GetInt32(0), dr.GetString(1), dr.GetString(2)));
            }
            cmd.Connection.Close();
            return lista; }
        public bool Atualizar()
        {
            
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"update niveis set nome = '{Nome}', silga = '{Sigla}' where id = {Id}";
            return cmd.ExecuteNonQuery()>0?true:false;


            
        }
        public void Excluir(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"delet from niveis where id ={id}";
            cmd.ExecuteNonQuery();
        }

            }
}
