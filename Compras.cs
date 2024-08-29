using System;

namespace PedidoDeCompras
{
    internal class Compras
    {
        public string produtos;
        public double preco;
        public double quantidade;

        public double CalcularDesconto()
        {
            double desconto = 0.00;

            if (quantidade <= 10)
            {
                desconto = ProdutoSemDesconto();
            }
            else if (quantidade > 11 && quantidade < 20)
            {
                desconto = CalculaPrimeiroDesconto();
            }
            else if (quantidade > 21 && quantidade <= 50)
            {
                desconto = CalculaSegundoDesconto();
            }
            else if (quantidade > 50)
            {
                desconto = CalculaTerceiroDesconto();
            }
            return desconto;
        }

        public double ProdutoSemDesconto()
        {
            return 0.0;
        }

        public double CalculaPrimeiroDesconto()
        {
            return preco * 0.10;
        }

        public double CalculaSegundoDesconto()
        {
            return preco * 0.20;
        }

        public double CalculaTerceiroDesconto()
        {
            return preco * 0.25;
        }
    }
}
