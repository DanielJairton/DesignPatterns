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
    public class TitaniumFactory : CartaoFactory
    {
        private int _limiteCartao;
        private int _anuidade;

        public TitaniumFactory(int limiteCartao, int anuidade)
        {
            this._limiteCartao = limiteCartao;
            this._anuidade = anuidade;
        }

        public override CartaoCredito BuscarCartaoCredito()
        {
            return new CartaoTitanium(_limiteCartao, _anuidade);
        }
    }
}
