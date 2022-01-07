using Microsoft.AspNetCore.Mvc;
using NEGRASM.Data;
using NEGRASM.Enum;
using NEGRASM.Enum2;
using NEGRASM.Models;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NEGRASM.Controllers
{
    
    public class ConsumidorController : Controller
    {
        [HttpGet]
        
        public IActionResult Index()
        {
            var dbcontext = new Contexto();

            ViewData["Consumidores"] = dbcontext.Consumidores.Where(p => p.Id > 0).ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Index(Consumidor consumidor)
        {
            var dbcontext = new Contexto();
            dbcontext.Add(consumidor);
            dbcontext.SaveChanges();


            return RedirectToAction("Index");

        }

        [HttpPost]
        public IActionResult Deletar(Consumidor consumidor)
        {
            var dbcontext = new Contexto();

               var consumidorDelete = dbcontext.Consumidores.Find(consumidor.Id);
               dbcontext.Remove(consumidorDelete);
               dbcontext.SaveChanges();


            return RedirectToAction("Index");

        }

        [HttpPost]
        public IActionResult Atualizar(Consumidor novosDadosConsumidor)
        {
            var dbcontext = new Contexto();

            var antigosDadosConsumidor = dbcontext.Consumidores.Find(novosDadosConsumidor.Id);

            antigosDadosConsumidor.Nome = novosDadosConsumidor.Nome;
            antigosDadosConsumidor.CPF = novosDadosConsumidor.CPF;
            antigosDadosConsumidor.Endereco = novosDadosConsumidor.Endereco;
            antigosDadosConsumidor.Complemento = novosDadosConsumidor.Complemento;
            antigosDadosConsumidor.Cidade = novosDadosConsumidor.Cidade;
            antigosDadosConsumidor.Estado = novosDadosConsumidor.Estado;
            antigosDadosConsumidor.Email = novosDadosConsumidor.Email;
            antigosDadosConsumidor.Nascimento = novosDadosConsumidor.Nascimento;
            antigosDadosConsumidor.Telefone = novosDadosConsumidor.Telefone;
            antigosDadosConsumidor.Sexo = novosDadosConsumidor.Sexo;

            dbcontext.SaveChanges();


            return RedirectToAction("Index");

        }

    }
}
