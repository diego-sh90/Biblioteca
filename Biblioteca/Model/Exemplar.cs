using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Model
{
    public class Exemplar
    {
        private string titulo;
        private string area;
        private int codRegistro;
        private int codTipoExemplar;


        [Key] // Chave primária
        [Column("codregistro")]
        public int CodRegistro
        {
            get {return this.codRegistro;}
            set {this.codRegistro = value;}
        }
        [Column("codtipoexemplar")]
        public int CodTipoExemplar
        {
            get {return this.codTipoExemplar;}
            set {this.codTipoExemplar = value;}
        }
        [Column("titulo")] // mapeamento de colunas no BD
        [MaxLength(100)] // restrição de tamanho da String
        public string Titulo
        {
            get {return this.titulo;}
            set {this.titulo = value;}
        }
        [Column("area")]
        public string Area
        {
            get {return this.area;}
            set {this.area = value;}
        }

        public Exemplar(string titulo, string area, int codRegistro, int codTipoExemplar)
        {
            this.titulo = titulo;
            this.area = area;
            this.codRegistro = codRegistro;
            this.codTipoExemplar = codTipoExemplar;
        }

    }
}
