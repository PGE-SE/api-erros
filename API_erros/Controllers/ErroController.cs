using Microsoft.AspNetCore.Mvc;
using System;

namespace API_erros.Controllers
{
    public class ErroController : Controller
    {
        public int ErroId { get; set; }
        public string ErroDescription { get; set; }
        public string Path { get; set; }
    }
}
