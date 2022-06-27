using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
    public class PedidoRepository : ICrudRepository<Pedido>
    {
       private List<Pedido> _pedidos;
        
        private int _ultimoId = 0;
        
        public PedidoRepository()
        {
            _pedidos = new List<Pedido>();
        }

        public Pedido Adicionar(Pedido pedido)
        {
            _ultimoId ++;
            pedido.Id = _ultimoId;
            _pedidos.Add(pedido);
            return pedido;
        }

        public Pedido Atualizar(Pedido pedido)
        {
            var pedidoExiste = _pedidos.Where(b => b.Id == pedido.Id).FirstOrDefault();

            if (pedidoExiste == null)
            {
                throw new Exception("Não possível atualizar uma pedido inexistente");
            }
            _pedidos.Remove(pedidoExiste);
            _pedidos.Add(pedido);

            return pedido;
        }

        public Pedido ObterPorId(int id)
        {
            return _pedidos.Where(p => p.Id == id).FirstOrDefault();
        }

        public List<Pedido> ObterTodas()
        {
            return _pedidos;
        }

        public void Remover(int id)
        {
            var pedido = ObterPorId(id);

            if (pedido == null)
            {
                throw new Exception("Não foi encontrado uma pedido para remover");
            }

            _pedidos.Remove(pedido);
    }
    }
}