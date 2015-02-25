using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstMigrations
{
    public class Repositorio<TEntity> : IRepositorio<TEntity> where TEntity : class
    {
        private K21Context db = new K21Context();

        public void Incluir(TEntity obj)
        {
            db.Set<TEntity>().Add(obj);
            db.SaveChanges();
        }

        public void Alterar(TEntity obj)
        {
            db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void Excluir(int id)
        {
            var obj = db.Set<TEntity>().Find(id);
            db.Set<TEntity>().Remove(obj);
            db.SaveChanges();
        }

        public List<TEntity> Listar()
        {
            return db.Set<TEntity>().ToList();
        }

        public TEntity Buscar(int id)
        {
            return db.Set<TEntity>().Find(id);
        }
    }
}
