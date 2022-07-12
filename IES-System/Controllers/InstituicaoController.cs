using System;
using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
=======
using System.Threading.Tasks;
>>>>>>> parent of e96acab (feat: Implementation of data entry fields in the controller)
using IES_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace IES_System.Controllers
{
    public class InstituicaoController : Controller
    {

        private static IList<Instituicao> instituicoes = new List<Instituicao>() {
            new Instituicao()
            {
                InstituicaoID = 1,
                Nome = "UniSanta",
                Endereco = "São Paulo"
            },
            new Instituicao()
            {
                InstituicaoID = 2,
                Nome = "UniParaná",
                Endereco = "Paraná"
            },
            new Instituicao()
            {
                InstituicaoID = 3,
                Nome = "UniSãoPaulo",
                Endereco = "São Paulo"
            },
            new Instituicao()
            {
                InstituicaoID = 4,
                Nome = "UniSulgrandense",
                Endereco = "Rio Grande do Sul"
            },
            new Instituicao()
            {
                InstituicaoID = 5,
                Nome = "UniCarioca",
                Endereco = "Rio de Janeiro"
            },
        };

<<<<<<< HEAD
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Instituicao instituicao)
        {
            instituicoes.Add(instituicao);
            instituicao.InstituicaoID = instituicoes.Select(i => i.InstituicaoID).Max() + 1;
            return RedirectToAction("Index");
        }        

=======
>>>>>>> parent of e96acab (feat: Implementation of data entry fields in the controller)
        public IActionResult Index()
        {
            return View(instituicoes);
        }
    }
}