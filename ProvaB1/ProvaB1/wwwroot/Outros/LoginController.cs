using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace SisAlmoxarifado.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public JsonResult Logar([FromBody]Dictionary<string, string> dados)
        {
            Models.Funcionario f = new Models.Funcionario();
            bool ok = f.ValidarSenha(dados["cpf"], dados["senha"]);

            //obj anônimo
            var retornoServ = new
            {
                operacao = ok
            };

            return Json(retornoServ);
        }


    }
}