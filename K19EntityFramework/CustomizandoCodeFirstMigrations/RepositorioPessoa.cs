using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace CustomizandoCodeFirstMigrations
{
    public class RepositorioPessoa
    {
        public kContext context { get; set; }

        public RepositorioPessoa()
        {
            context = new kContext();
        }

        public void Adicionar(Pessoa p)
        {
            context.Pessoas.Add(p);
            context.SaveChanges();
        }

        public List<Pessoa> Listar()
        {
            return context.Set<Pessoa>().ToList();
        }
    }
}
