using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Product
{
    // Classe abstrata para herança
    public abstract class CartaoCredito
    {
        public abstract string TipoCartao { get; }
        public abstract int LimiteCartao { get; set; }
        public abstract int Anuidade { get; set; }
    }
}
