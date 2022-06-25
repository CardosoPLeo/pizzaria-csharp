using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
    public class SaborRepository:ICrudRepository<Sabor>
    {
        private List<Sabor> _sabores;
        
        private int _ultimoId = 0;
        
        public SaborRepository()
        {
            _sabores = new List<Sabor>();
        }

        public Sabor Adcionar(Sabor sabor)
        {
            _ultimoId ++;
            sabor.Id = _ultimoId;
            _sabores.Add(sabor);
            return sabor;
        }
        public List<Sabor> ObterTodas()
        {
            return _sabores;
        }

        public Sabor ObterPorId(int id)
        {
           return _sabores.Where(b => b.Id == id).FirstOrDefault();    
        }

        public Sabor Atualizar(Sabor sabor)
        {
            // var bebibaExiste = _sabores.Where(b => b.Id == sabor.Id).Any();
            var bebibaExiste = _sabores.Where(b => b.Id == sabor.Id).FirstOrDefault();

            if (bebibaExiste == null)
            {
                throw new Exception("Não possível atualizar uma sabor inexistente");
            }
            _sabores.Remove(bebibaExiste);
            _sabores.Add(sabor);

            return sabor;
        }

        public void Remover(int id)
        {
            var sabor = ObterPorId(id);

            if (sabor == null)
            {
                throw new Exception("Não foi encontrado uma sabor para remover");
            }

            _sabores.Remove(sabor);
        }

    }
}