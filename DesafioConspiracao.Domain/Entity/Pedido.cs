using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioConspiracao.Domain.Entity
{
    public class Pedido
    {
        public string? NomeFornecedor { get; set; }
        public float DescontoGeral { get; set; }
        public IEnumerable<Item> itens { get; set; } = new List<Item>();
    }
}
