namespace PizzariaCSharp.Model
{
    public class Cliente
    {
        public int  Id { get; set; }        
        public string Nome { get; set; } = null;
        public string Telefone { get; set; } = null;
        public List<Endereco> Enderecos { get; set; }
                
    }
}