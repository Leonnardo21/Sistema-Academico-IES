using System;
using System.Collections.Generic;
using System.Linq;
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
                Nome = "Estácio",
                Endereco = "Fortaleza"
            },
            new Instituicao()
            {
                InstituicaoID = 2,
                Nome = "Unifor",
                Endereco = "Fortaleza"
            },
            new Instituicao()
            {
                InstituicaoID = 3,
                Nome = "UniFametro",
                Endereco = "Fortaleza"
            },
        };

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

        public IActionResult Index()
        {
            return View(instituicoes);
        }
    }
}