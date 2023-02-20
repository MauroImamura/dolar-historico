namespace dolar_historico.Models.Repositories
{
    public interface ICotacaoRepository
    {
        Cotacao GetCotacoes(DateOnly data);
    }
}
