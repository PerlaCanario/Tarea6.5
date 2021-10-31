﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea6._5.Entidades;

namespace Tarea6._5.DAL
{
    public class Contexto : DbContext 
    {
        public DbSet<Personas> Personas { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Grupos> Grupos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA\PeopleGestor.db");
        }
    }
}
