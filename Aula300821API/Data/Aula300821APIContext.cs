using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aula300821API.Controllers.Model;

namespace Aula300821API.Models
{
    public class Aula300821APIContext : DbContext
    {
        public Aula300821APIContext (DbContextOptions<Aula300821APIContext> options)
            : base(options)
        {
        }

        public DbSet<Aula300821API.Controllers.Model.Person> Person { get; set; }
    }
}
