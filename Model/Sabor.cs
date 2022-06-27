namespace PizzariaCSharp.Model
{
    public class Sabor
    {
        public int Id { get; set; }
        public string Descricao { get; set; } =  null;
        public string Observacao { get; set; } = null;

        public Sabor()
        {
            
        }       
       
        public Sabor(string descricao, string observacao)
        {
            Descricao = descricao;
            Observacao = observacao;
        }

    }
}