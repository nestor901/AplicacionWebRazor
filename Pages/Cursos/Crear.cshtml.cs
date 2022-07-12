using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplicacionWebRazor.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AplicacionWebRazor.Pages.Cursos
{
    public class Crear : PageModel
    {
        private readonly AppRazorDbContext _Context;
        public Crear(AppRazorDbContext context)
        {
            _Context = context;            
        }
        [BindProperty]
        public Curso curso {get; set;}
        
        public async Task<IActionResult> OnPost()
        {
            if(!ModelState.IsValid){
                return Page();
            }
            curso.FechaCreacion = DateTime.Now;
            _Context.Add(curso);
            await _Context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}