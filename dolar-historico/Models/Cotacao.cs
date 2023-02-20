using dolar_historico.Models.Enumerators;

namespace dolar_historico.Models
{
    public class Cotacao
    {

        public DateOnly Data { get; private set; }

        public ETipoResposta TipoResposta { get; private set; } = ETipoResposta.invalido;

        public string Cotacoes { get; private set; } = "";

        public Cotacao(DateOnly data)
        {
            Data = data;
        }

        public Cotacao(DateTime data)
        {
            Data = new DateOnly(data.Year, data.Month, data.Day);
        }

        public void SetTipoResposta(ETipoResposta resposta)
        {
            TipoResposta = resposta;
        }

        public void SetCotacoes(string cotacoes)
        {
            Cotacoes = cotacoes;
        }

        public override string ToString()
        {
            return this.Cotacoes;
        }
    }
}
