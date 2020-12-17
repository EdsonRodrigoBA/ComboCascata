using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoArtigos.Data;
using ProjetoArtigos.Models;

namespace ProjetoArtigos.Controllers
{
    public class CadastrosController : Controller
    {
        private readonly ProjetoDataContext _context;
        public CadastrosController(ProjetoDataContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
           
            ViewData["ID_ESTADO"] = new SelectList(_context.Estados, "id_estado", "descricao");
            return View(new ClienteViewModel());
        }

        public async Task<IActionResult> BuscarCidades_Estados(int id)
        {
            System.Threading.Thread.Sleep(5000);
            var cidades = await _context.Cidades.Where(x => x.Id_estado == id).ToListAsync();
            return Json(cidades);
        }
    }
}
