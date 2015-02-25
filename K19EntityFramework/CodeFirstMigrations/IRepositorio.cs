using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstMigrations
{
    public interface IRepositorio <TEntity> where TEntity : class
    {
        void Incluir (TEntity obj);
        void Alterar (TEntity obj);
        void Excluir(int id);
        List<TEntity> Listar();
        TEntity Buscar(int id);
    }
}
