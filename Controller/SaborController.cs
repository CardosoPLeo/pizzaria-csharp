using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Controller
{
    public class SaborController : ICrudController<Sabor>
    {
        private ICrudRepository<Sabor> _repositorySabor;

        public SaborController(ICrudRepository<Sabor> repositorySabor)
        {
            _repositorySabor = repositorySabor;
        }

        public Sabor Adicionar(Sabor sabor)
        {
            return _repositorySabor.Adicionar(sabor);
        }

        public Sabor Atualizar(int id, Sabor sabor)
        {
            sabor.Id = id;
            return _repositorySabor.Atualizar(sabor);
        }

        public Sabor ObterPorId(int id)
        {
            return _repositorySabor.ObterPorId(id);
        }

        public List<Sabor> ObterTodas()
        {
            return _repositorySabor.ObterTodas();
        }

        public void Remover(int id)
        {
            _repositorySabor.Remover(id);
        }
    }
}