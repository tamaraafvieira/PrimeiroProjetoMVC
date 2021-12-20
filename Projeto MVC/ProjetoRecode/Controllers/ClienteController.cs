using ProjetoRecode.Models;
using ProjetoRecode.Data;
using ProjetoRecode.Enum;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;

namespace ProjetoRecode.Controllers
{
    public class ClienteController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var dbcontext = new ApplicationContext();

            ViewData["clientes"] = dbcontext.Clientes.Where(p => p.CodigoCliente > 0).ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Index(Cadastro cliente)
        {
            var dbcontext = new ApplicationContext();
            dbcontext.Add(cliente);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Deletar(Cadastro cliente)
        {
            var dbcontext = new ApplicationContext();

            var clienteDelete = dbcontext.Clientes.Find(cliente.CodigoCliente);
            dbcontext.Remove(clienteDelete);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Atualizar(Cadastro novosDadosCliente)
        {
            var dbcontext = new ApplicationContext();

            var antigosDadosCliente = dbcontext.Clientes.Find(novosDadosCliente.CodigoCliente);

            antigosDadosCliente.Nome = novosDadosCliente.Nome;
            antigosDadosCliente.Cpf = novosDadosCliente.Cpf;
            antigosDadosCliente.E_mail = novosDadosCliente.E_mail;
            antigosDadosCliente.Rua = novosDadosCliente.Rua;
            antigosDadosCliente.Numero = novosDadosCliente.Numero;
            antigosDadosCliente.Complemento = novosDadosCliente.Complemento;
            antigosDadosCliente.Cep = novosDadosCliente.Cep;
            antigosDadosCliente.Situacao = novosDadosCliente.Situacao;          

        dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}