using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstMigrations
{
    public class LivroRepositorio : Repositorio<Livro>, ILivroRepositorio
    {
        readonly Livro livro;

        public LivroRepositorio(Livro l)
        {
            livro = l;
        }

    }
}
