﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace psiconexao.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}