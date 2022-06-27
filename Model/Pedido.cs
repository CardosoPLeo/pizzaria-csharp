namespace PizzariaCSharp.Model
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataHoraPedido { get; private set; }
        public Cliente Cliente { get; private set; }
        public List<Pizza> Pizzas { get; private set; }
        public List<Bebida> Bebidas { get; private set; }
        //public double ValorTotal { get; private set; }
        
        public Pedido(Cliente cliente)
        {
            Cliente = cliente;
            Pizzas = new List<Pizza>();
            Bebidas = new List<Bebida>();
        }

        //Builder
        public Pedido AdcionarPizza(Pizza pizza)
        {
            Pizzas.Add(pizza);
            return this;
        }

        public Pedido AdcionarBebida(Bebida bebida)
        {
            Bebidas.Add(bebida);
            return this;
        }

        public double ObterValorTotal()
        {
            return 10.00;
        }

        public Pedido FinalizarPedido()
        {
            DataHoraPedido = DateTime.Now;
            return this;
        }

    }
}