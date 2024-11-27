using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    //classe banco é a nossa classe de conxão
    public static class Banco // nos colocamos como static por que não precisaremos criar uma instancia de Banco para conectar às nossas bases de dados
    {
        public static MySqlCommand Abrir()// o método(Abrir) para abrir conexão// dentro dessa classe tem uma coleção de metodos no banco de dados
        {
            string strcon = @"server=10.91.45.47;database=systinsdb01;user=aluno;password=senac;";
            MySqlConnection cn = new(strcon);
            MySqlCommand cmd = new();
            try
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch (MySqlException ex)
            {

                Console.WriteLine(ex.Message);
                throw;
            }
            return cmd;
        }
    }
}
