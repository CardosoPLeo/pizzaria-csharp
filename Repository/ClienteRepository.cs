using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
    public class ClienteRepository : ICrudRepository<Cliente>
    {
        public Cliente Adcionar(Cliente modelo)
        {
            throw new NotImplementedException();
        }

        public Cliente Atualizar(Cliente modelo)
        {
            throw new NotImplementedException();
        }

        public Cliente ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ObterTodas()
        {
            throw new NotImplementedException();
        }

        public void Remover(int id)
        {
            throw new NotImplementedException();
        }
    }
}