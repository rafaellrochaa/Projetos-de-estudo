using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace CustomizandoCodeFirstMigrations
{
    public class RepositorioPessoa
    {
        public DbContext context { get; set; }

        public RepositorioPessoa(DbContext context)
        {
            this.context = context;
        }

        public void Adicionar(Pessoa p)
        {
            context.Set<Pessoa>().Add(p);
            context.SaveChanges();
        }

        public List<Pessoa> Listar()
        {
            return context.Set<Pessoa>().ToList();
        }
    }
}
