using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioConspiracao.Domain.Entity
{
    public class Item
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public float Desconto { get; set; }
        public string? Descricao { get; set; }
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; } = new();
    }
}
