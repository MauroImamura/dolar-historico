using dolar_historico.Models;
using dolar_historico.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;

namespace dolar_historico.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICotacaoRepository _cotacao;

        public HomeController(ILogger<HomeController> logger, ICotacaoRepository cotacao)
        {
            _logger = logger;
            _cotacao = cotacao;
        }

        public IActionResult Index()
        {
            var dataInicial = DateTime.Today.AddDays(-1);
            var dados = _cotacao.GetCotacoes(DateOnly.FromDateTime(dataInicial));
            return View(dados);
        }

        [HttpPost]
        public string UpdateValues(string? dataEscolhida)
        {
            if(dataEscolhida == null)
            {
                return new Cotacao(DateOnly.FromDateTime(DateTime.Today.AddDays(-1))).ToString();
            }
            var data = DateOnly.Parse(dataEscolhida);
            var dados = _cotacao.GetCotacoes(data);
            return dados.ToString();
        }
    }
}