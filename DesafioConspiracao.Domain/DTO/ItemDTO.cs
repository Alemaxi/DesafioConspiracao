using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioConspiracao.Domain.DTO
{
    public class ItemDTO
    {
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Desconto { get; set; }
        public decimal DescricaoItem { get; set; }
        public decimal ValorLiquido { get; set; }
    }
}
