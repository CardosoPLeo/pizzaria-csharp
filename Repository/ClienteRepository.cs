using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
    public class ClienteRepository : ICrudRepository<Cliente>
    {
        private List<Cliente> _clientes;
        
        private int _ultimoId = 0;
        
        public ClienteRepository()
        {
            _clientes = new List<Cliente>();
        }

        public Cliente Adicionar(Cliente cliente)
        {
            _ultimoId ++;
            cliente.Id = _ultimoId;
            _clientes.Add(cliente);
            return cliente;
        }

        public Cliente Atualizar(Cliente cliente)
        {
            var clienteExiste = _clientes.Where(b => b.Id == cliente.Id).FirstOrDefault();

            if (clienteExiste == null)
            {
                throw new Exception("Não possível atualizar uma cliente inexistente");
            }
            _clientes.Remove(clienteExiste);
            _clientes.Add(cliente);

            return cliente;
        }

        public Cliente ObterPorId(int id)
        {
            return _clientes.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Cliente> ObterTodas()
        {
            return _clientes;
        }

        public void Remover(int id)
        {
            var cliente = ObterPorId(id);

            if (cliente == null)
            {
                throw new Exception("Não foi encontrado uma cliente para remover");
            }

            _clientes.Remove(cliente);
        }
    }
}