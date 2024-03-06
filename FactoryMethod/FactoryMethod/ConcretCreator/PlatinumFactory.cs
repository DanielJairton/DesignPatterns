using FactoryMethod.ConcretProduct;
using FactoryMethod.Creator;
using FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.ConcretCreator
{
    public class PlatinumFactory : CartaoFactory
    {
        private int _limiteCartao;
        private int _anuidade;

        public PlatinumFactory(int limiteCartao, int anuidade)
        {
            this._limiteCartao = limiteCartao;
            this._anuidade = anuidade;
        }

        public override CartaoCredito BuscarCartaoCredito()
        {
            return new CartaoPlatinum(_limiteCartao, _anuidade);
        }
    }
}
