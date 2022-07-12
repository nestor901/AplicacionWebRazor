using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using AplicacionWebRazor.Data;
using Microsoft.EntityFrameworkCore;

namespace AplicacionWebRazor.Pages.Cursos
{
    public class Index : PageModel
    {
        private readonly AppRazorDbContext _Context;
        public Index(AppRazorDbContext context)
        {
            _Context = context;
        }
        public IEnumerable<Curso> curso {get; set;}

        public async Task OnGet()
        {
            curso = await _Context.cursos.ToListAsync();
        }
         public async Task<IActionResult> OnPostBorrar(int Id)
        {
           
            var curso = await _Context.cursos.FindAsync(Id);
            if (curso == null)
            {
                return NotFound();   
            }
            _Context.cursos.Remove(curso);
            await _Context.SaveChangesAsync();
            return RedirectToPage("Index");     
        }
    }
}