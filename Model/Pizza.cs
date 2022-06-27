using PizzariaCSharp.Enum;

namespace PizzariaCSharp.Model
{
    public class Pizza
    {
        public int Id { get; set; }
        public ETipoPizza TipoPizza { get; set; }
        public ETipoBorda TipoBorda { get; set; }      
        public List<Sabor> Sabores { get; set; }      
        public double Valor { get; set; } = 0.00;

        public Pizza()
        {
        }
        public Pizza(ETipoPizza tipoPizza, ETipoBorda tipoBorda, List<Sabor> sabores, double valor)
        {
            TipoPizza = tipoPizza;
            TipoBorda = tipoBorda;
            Sabores = sabores;
            Valor = valor;
        }
    }
}