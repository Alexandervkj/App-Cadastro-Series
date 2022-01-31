namespace appcadastrodeseries.Interface
{
    public interface IRepositorio<T>
    {
        List<I> Lista();
        I RetornoPorId(int id);
        void Insere(T entidade);
        void Excliu(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
        
    }
}