namespace PizzariaCSharp.Repository.Interfaces
{
    /// <summary>
    /// Interface repositório genérico baseado na construção do modelo.
    /// </summary>
    /// <typeparam name="T">modelo, entidade a qual será persistida</typeparam>
    public interface ICrudRepository<T>
    {
        /// <summary>
        /// Método que adiciona um modelo ao banco de dados
        /// </summary>
        /// <param name="modelo"></param>
        /// <returns>Retorna um modelo após ser adicionado no bancco de dados</returns>
         T Adicionar(T modelo);

         /// <summary>
         /// Método que retorna uma lista com todos os modelos encontrado no banco de dados
         /// </summary>
         /// <returns>Retorna uma lista de um modelo</returns>
         List<T> ObterTodas();

         /// <summary>
         /// Retorna um item de um modelo pelo pelo seu id do banco de dados
         /// </summary>
         /// <param name="id">Id do modelo a ser encontrado</param>
         /// <returns>Retorna item de um modelo encontrado pelo id</returns>
         T ObterPorId(int id);

         /// <summary>
         /// Método para atualizar o modelo no banco de dados 
         /// </summary>
         /// <param name="modelo">modelo a ser atualizado</param>
         /// <returns>Retorna um modelo após a atualização</returns>
         T Atualizar(T modelo);

         /// <summary>
         /// Deleta um modelo pelo seu Id
         /// </summary>
         /// <param name="id">Id do modelo que será deletado</param>
         void Remover(int id);
    }
}