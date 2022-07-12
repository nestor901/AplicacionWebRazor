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
    public class Editar : PageModel
    {
        private readonly AppRazorDbContext _Context;
        public Editar(AppRazorDbContext context)
        {
            _Context = context;            
        }
        [BindProperty]
        public Curso curso {get; set;}
        
        public async Task OnGet(int Id)
        {
            curso = await _Context.cursos.FindAsync(Id);
        }

         public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid){
                var CursoDesdeDb = await _Context.cursos.FindAsync(curso.Id);
                CursoDesdeDb.NombreCurso = curso.NombreCurso;
                CursoDesdeDb.CantidadClases = curso.CantidadClases;
                CursoDesdeDb.Precio = curso.Precio;
                await _Context.SaveChangesAsync();
                return RedirectToPage("Index");    
            }
            return RedirectToPage();
        }


    }
}