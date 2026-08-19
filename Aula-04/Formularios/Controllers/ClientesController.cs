using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Formularios.Models;

namespace MVC_AULA;

using Microsoft.AspNetCore.Mvc;



public class ClientesController : Controller
{
    public IActionResult Cadastrar()
    {
        return View();
    }
}

