using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aula1AspNetMVC.Models;

namespace Aula1AspNetMVC.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            var cliente = new Cliente()
            {
                Id = 1,
                Nome = "ASP",
                SobreNome = "NET",
                DataCadastro = DateTime.Now
            };

            //ViewBag.Cliente = cliente;

            //ViewData["Cliente"] = cliente;

            ViewBag.Cliente = "Texto";

            return View("Index", cliente);
        }

        public ActionResult Lista()
        {
            var listaClientes = new List<Cliente>()
            {
                new Cliente() { Id = 1, Nome = "Thiago", SobreNome = "Alves", DataCadastro = DateTime.Now},
                new Cliente() { Id = 2, Nome = "Tiago", SobreNome = "Farias", DataCadastro = DateTime.Now}
            };
            return View(listaClientes);
        }

        public ActionResult Pesquisa(int? idCliente, string nome)
        {
            var listaClientes = new List<Cliente>()
            {
                new Cliente() { Id = 1, Nome = "Thiago", SobreNome = "Alves", DataCadastro = DateTime.Now},
                new Cliente() { Id = 2, Nome = "Tiago", SobreNome = "Farias", DataCadastro = DateTime.Now},
                new Cliente() { Id = 3, Nome = "James", SobreNome = "Phewrys", DataCadastro = DateTime.Now},
                new Cliente() { Id = 4, Nome = "Thiago", SobreNome = "Phewrys", DataCadastro = DateTime.Now}
            };

            var cliente = listaClientes.Where(c => c.Nome == nome).ToList();

            if (!cliente.Any())
            {
                TempData["erro"] = "Nenhum cliente selecionado.";
                return RedirectToAction("ErroPesquisa");
            }

            return View("Lista", cliente);
        }

        public ActionResult ErroPesquisa()
        {
            return View("error");
        }
    }
}