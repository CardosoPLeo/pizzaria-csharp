using PizzariaCSharp.Model;
using PizzariaCSharp.Repository;

namespace PizzariaCSharp.Controller
{
    public class BebidaController
    {
        private BebidaRepository _repositoryBebida;

        public BebidaController(BebidaRepository repositoryBebida)
        {
            _repositoryBebida = repositoryBebida;
        }

        public List<Bebida> Obtertodos()
        {
            return _repositoryBebida.ObterTodas();
        }

        public Bebida ObterPorId(int id)
        {
            return _repositoryBebida.ObterPorId(id);
        }
        
        public Bebida Adicionar(Bebida bebida)
        {
            return _repositoryBebida.Adcionar(bebida);
        }

        public void Remover(int id)
        {
             _repositoryBebida.Remover(id);
        }

        public Bebida Atualizar(int id, Bebida bebida)
        {
            bebida.Id = id;
            return _repositoryBebida.Atualizar(bebida);
        }
    }
}