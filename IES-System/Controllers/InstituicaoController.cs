using System;
using System.Collections.Generic;
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

        //GET: Create
        public ActionResult Create()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View(instituicoes);
        }
    }
}