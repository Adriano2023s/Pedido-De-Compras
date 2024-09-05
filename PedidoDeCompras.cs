namespace PedidoDeCompras
{
    internal class PedidoDeCompras
    {
       public string NomeDoProduto { get; set; }
        public double Preco {  get; set; }
        public int Quantidade { get; set; }

        public PedidoDeCompras()
        {

        }

        public PedidoDeCompras(string nomedoproduto, double preco, int quantidade)
        {
            NomeDoProduto = nomedoproduto;
            Preco = preco;
            Quantidade = quantidade;
            }

        public double CalcularDesconto()
        {
            if (Quantidade <= 10)
            {
                return 0;
            }
            else if (Quantidade <= 20)
            {
                return Preco * Quantidade * 0.10;
            }
            else if (Quantidade <= 50)
            {
                return Preco * Quantidade * 0.20;
            }
            else
            {
                return Preco * Quantidade * 0.25;
            }
        }
    
        public double ValorTotal()
        {
            double valorTotal = Preco * Quantidade;
            double desconto = CalcularDesconto();
            return valorTotal - desconto;
        }
    }
}
