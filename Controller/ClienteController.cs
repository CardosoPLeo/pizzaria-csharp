using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Controller
{
    public class ClienteController : ICrudController<Cliente>
    {
         private ICrudRepository<Cliente> _repositoryCliente;

        public ClienteController(ICrudRepository<Cliente> repositoryCliente)
        {
            _repositoryCliente = repositoryCliente;
        }

        public Cliente Adicionar(Cliente cliente)
        {
            return _repositoryCliente.Adicionar(cliente);
        }

        public Cliente Atualizar(int id, Cliente cliente)
        {
            cliente.Id = id;
            return _repositoryCliente.Atualizar(cliente);
        }

        public Cliente ObterPorId(int id)
        {
            return _repositoryCliente.ObterPorId(id);
        }

        public List<Cliente> ObterTodas()
        {
            return _repositoryCliente.ObterTodas();
        }

        public void Remover(int id)
        {
            _repositoryCliente.Remover(id);
        }
    }
}