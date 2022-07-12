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

        //Métodos Create
        public ActionResult Create()
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
        
        //Métodos Update
        public ActionResult Edit(long id)
        {
            return View(instituicoes.Where(m => m.InstituicaoID == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Instituicao instituicao)
        {
            instituicoes.Remove(instituicoes.Where(c => c.InstituicaoID == instituicao.InstituicaoID).First());
            instituicoes.Add(instituicao);
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            return View(instituicoes.OrderBy(i => i.Nome));
        }
    }
}