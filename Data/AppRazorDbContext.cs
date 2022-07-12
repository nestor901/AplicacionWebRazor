using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AplicacionWebRazor.Data
{
    public partial class AppRazorDbContext : DbContext
    {
        public AppRazorDbContext(DbContextOptions<AppRazorDbContext> options): base(options)
        {
            
        }
        public DbSet<Curso> cursos {get; set;}
    }
}
