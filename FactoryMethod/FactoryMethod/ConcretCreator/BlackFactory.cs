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
    public class BlackFactory : CartaoFactory
    {
        private int _limiteCartao;
        private int _anuidade;

        public BlackFactory(int limiteCartao, int anuidade) 
        {
            this._limiteCartao = limiteCartao;
            this._anuidade = anuidade;
        }

        public override CartaoCredito BuscarCartaoCredito()
        {
            return new CartaoBlack(_limiteCartao, _anuidade);
        }
    }
}
