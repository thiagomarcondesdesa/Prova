using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProvaB1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult Autenticar([FromBody]Dictionary<string, string> func)
        {
            Models.Funcionario f = new Models.Funcionario();
            bool flag = f.Autenticar(func["usuario"], func["senha"]);

            var retornoServ = new
            {
                operacao = flag
            };

            return Json(retornoServ);
        }
    }
}