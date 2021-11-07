using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Model
{
    [Table("artigo")] // mapeamento de Tabelas oriundas de herança da classe Exemplar no BD
    class Artigo : Exemplar
    {
        private String conferencia;

        [Column("conferencia")] //mapeamento de colunas no BD
        public String Conferencia
        {
            get
            {
                return this.conferencia;
            }
            set
            {
                this.conferencia = value;
            }
        }
        public Artigo (String titulo, String area, int codRegistro, int codTipoExemplar, String conferencia) : base(titulo, area, codRegistro, codTipoExemplar)
        {
            this.Conferencia = conferencia;
        }
    }
}
