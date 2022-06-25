using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Model;

namespace PizzariaCSharp.Controller
{
    public class ClienteController : ICrudController<Cliente>
    {
        public Cliente Adcionar(Cliente modelo)
        {
            throw new NotImplementedException();
        }

        public Cliente Atualizar(int id, Cliente modelo)
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