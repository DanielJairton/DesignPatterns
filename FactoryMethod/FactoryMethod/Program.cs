using FactoryMethod.ConcretCreator;
using FactoryMethod.Creator;
using FactoryMethod.Product;

CartaoFactory cartaoFactory = null;
Console.WriteLine("Digite o tipo de Cartão para o Cliente");

string console = Console.ReadLine();

switch(console.ToLower())
{
    case "black":
        cartaoFactory = new BlackFactory(10000, 0);
        break;

    case "titanium":
        cartaoFactory = new TitaniumFactory(50000, 700);
        break;

    case "platinum":
        cartaoFactory = new PlatinumFactory(100000, 2000);
        break;

    default: 
        break;
}

CartaoCredito cartaoCredito = cartaoFactory.BuscarCartaoCredito();
Console.Write("\nOs detalhes do seu cartão estão abaixo \n");
Console.Write("Tipo do cartão: {0}\nCrédito limite: {1}\nCobrança Anual: {2}\n",
    cartaoCredito.TipoCartao, cartaoCredito.LimiteCartao, cartaoCredito.Anuidade);
Console.ReadKey();