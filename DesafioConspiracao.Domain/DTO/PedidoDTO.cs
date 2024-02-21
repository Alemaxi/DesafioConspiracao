using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioConspiracao.Domain.DTO
{
    public class PedidoDTO
    {
        public int NumeroPedido { get; set; }
        public string NomeFornecedor { get; set; } = string.Empty;
        public decimal ValorTotal { get; set; }
        public decimal DescontoGeral { get; set; }
    }
}
