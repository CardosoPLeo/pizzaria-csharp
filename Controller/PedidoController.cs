using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Controller
{
    public class PedidoController : ICrudController<Pedido>
    {
         private ICrudRepository<Pedido> _repositoryPedido;

        public PedidoController(ICrudRepository<Pedido> repositoryPedido)
        {
            _repositoryPedido = repositoryPedido;
        }

        public Pedido Adicionar(Pedido pedido)
        {
            return _repositoryPedido.Adicionar(pedido);
        }

        public Pedido Atualizar(int id, Pedido pedido)
        {
            pedido.Id = id;
            return _repositoryPedido.Atualizar(pedido);
        }

        public Pedido ObterPorId(int id)
        {
            return _repositoryPedido.ObterPorId(id);
        }

        public List<Pedido> ObterTodas()
        {
            return _repositoryPedido.ObterTodas();
        }

        public void Remover(int id)
        {
            _repositoryPedido.Remover(id);
        }
    }
}