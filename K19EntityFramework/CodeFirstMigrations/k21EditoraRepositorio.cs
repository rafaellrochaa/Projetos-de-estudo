using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace CodeFirstMigrations
{
    public class k21EditoraRepositorio
    {
        private DbContext context;

        public k21EditoraRepositorio(DbContext context)
        {
            this.context = context;
        }

        public void Adicionar(Editora e)
        {
            context.Set<Editora>().Add(e);
            context.SaveChanges();
        }

        public Editora Buscar(int id)
        {
            return context.Set<Editora>().Find(id);
        }

        public List<Editora> Listar()
        {
            var consulta = from e in context.Set<Editora>() select e;
            return consulta.ToList();
        }
    }
}
