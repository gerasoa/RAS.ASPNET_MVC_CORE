using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RAS.App.ViewModels;

namespace RAS.App.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<RAS.App.ViewModels.ProdutoViewModel> ProdutoViewModel { get; set; }
        //public DbSet<RAS.App.ViewModels.FornecedorViewModel> FornecedorViewModel { get; set; }
    }
}
