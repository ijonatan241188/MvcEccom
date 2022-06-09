using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcClientes.Models;

namespace MvcClientes.Data
{
    public class MvcClientesContext : DbContext
    {
        public MvcClientesContext (DbContextOptions<MvcClientesContext> options)
            : base(options)
        {
        }

        public DbSet<MvcClientes.Models.Cliente> Cliente { get; set; }

        public DbSet<MvcClientes.Models.Productos> Productos { get; set; }
    }
}
