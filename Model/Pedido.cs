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
        
    }
}