using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
    public class BebidaRepository:ICrudRepository<Bebida>
    {
        private List<Bebida> _bebidas;
        
        private int _ultimoId = 0;
        
        public BebidaRepository()
        {
            _bebidas = new List<Bebida>();
        }

        public Bebida Adicionar(Bebida bebida)
        {
            _ultimoId ++;
            bebida.Id = _ultimoId;
            _bebidas.Add(bebida);
            return bebida;
        }
        public List<Bebida> ObterTodas()
        {
            return _bebidas;
        }

        public Bebida ObterPorId(int id)
        {
           return _bebidas.Where(b => b.Id == id).FirstOrDefault();    
        }

        public Bebida Atualizar(Bebida bebida)
        {
            // var bebibaExiste = _bebidas.Where(b => b.Id == bebida.Id).Any();
            var bebibaExiste = _bebidas.Where(b => b.Id == bebida.Id).FirstOrDefault();

            if (bebibaExiste == null)
            {
                throw new Exception("Não possível atualizar uma bebida inexistente");
            }
            _bebidas.Remove(bebibaExiste);
            _bebidas.Add(bebida);

            return bebida;
        }

        public void Remover(int id)
        {
            var bebida = ObterPorId(id);

            if (bebida == null)
            {
                throw new Exception("Não foi encontrado uma bebida para remover");
            }

            _bebidas.Remove(bebida);
        }

    }
}