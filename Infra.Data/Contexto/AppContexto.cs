using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Contexto
{
    public class AppContexto : DbContext
    {
        public AppContexto(DbContextOptions<AppContexto> options)
            : base(options){}

        public DbSet<CadastroEntidades> Cadastro { get; set; }
    }
}
