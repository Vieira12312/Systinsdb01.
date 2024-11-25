using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SysTINSClass
{
    public class ItemPedido
    {
       

        public int Id { get; set; }
        public int PedidoId{ get; set; }
        public Produto? Produto { get; }
        public Produto? produto { get; set; }
        public double ValorUnit { get; set; }
        public double Quantidade { get; set; }
        public double Desconto { get; set; }
        public ItemPedido()
        {
            Produto = new();
        }
        public ItemPedido( int pedidoId, Produto? produto, double quantidade, double desconto)
        {
            PedidoId = pedidoId;
            Produto = produto;
            Quantidade = quantidade;
            Desconto = desconto;
        }
        public ItemPedido(int iD, int pedidoId, Produto? produto, double valorUnit, double quantidade, double desconto)
        {
            Id = iD;
            PedidoId = pedidoId;
            Produto = produto;
            ValorUnit = valorUnit;
            Quantidade = quantidade;
            Desconto = desconto;
        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_inserir";
            cmd.Parameters.AddWithValue("sppedido",PedidoId);
            cmd.Parameters.AddWithValue("spproduto",Produto.Id);
            cmd.Parameters.AddWithValue("spquantidade",Quantidade);
            cmd.Parameters.AddWithValue("spdesconto",Desconto);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static List<ItemPedido> ObterItensPorPedidoId(int id)
        {
            List<ItemPedido> items = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from itempedido where pedido_id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                items.Add(new(
                    dr.GetInt32(0),
                    dr.GetInt32(1),
                    Produto.ObterPorId(dr.GetInt32(2)),
                    dr.GetDouble(3),
                    dr.GetDouble(4),
                    dr.GetDouble(5)
                    ));
            }
            return items;
        }
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_inserir";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spquantidade", Quantidade);
            cmd.Parameters.AddWithValue("spdesconto", Desconto);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();        
        }
        public void Remover()
        {

            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_inserir";
            cmd.Parameters.AddWithValue("sppedido", PedidoId);
        }
    }
}
