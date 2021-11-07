using Biblioteca.Context;

namespace Biblioteca.Dao
{
    internal class PessoaDao
    {
        private AppDBContext context;

        public PessoaDao(AppDBContext context)
        {
            this.context = context;
        }
    }
}