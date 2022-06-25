using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Model;
using PizzariaCSharp.Repository;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Controller
{
    public class BebidaController : ICrudController<Bebida>
    {
        private ICrudRepository<Bebida> _repositoryBebida;

        public BebidaController(ICrudRepository<Bebida> repositoryBebida)
        {
            _repositoryBebida = repositoryBebida;
        }

        public Bebida Adicionar(Bebida bebida)
        {
            return _repositoryBebida.Adicionar(bebida);
        }

        public Bebida Atualizar(int id, Bebida bebida)
        {
            bebida.Id = id;
            return _repositoryBebida.Atualizar(bebida);
        }

        public Bebida ObterPorId(int id)
        {
            return _repositoryBebida.ObterPorId(id);
        }

        public List<Bebida> ObterTodas()
        {
            return _repositoryBebida.ObterTodas();
        }

        public void Remover(int id)
        {
            _repositoryBebida.Remover(id);
        }
    }
}