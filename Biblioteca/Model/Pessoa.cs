using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Model
{
    class Pessoa
    {
        private String nome;
        private String cpf;
        private String rg;
        private int codPessoa;
        private int codTipoPessoa;

        [Column("nome")] 
        [MaxLength(100)] 
        public String Nome
        {
            get {return this.nome;}
            set {this.nome = value;}
        }
        [Column("cpf")]
        public String Cpf
        {
            get {return this.cpf;}
            set {this.cpf = value;}
        }
        [Column("rg")]
        public String Rg
        {
            get {return this.rg;}
            set {this.rg = value;}
        }
        [Key] // Chave primária
        [Column("codpessoa")]
        public int CodPessoa
        {
            get {return this.codPessoa;}
            set {this.codPessoa = value;}
        }
        [Column("tipopessoa")]
        public int CodTipoPessoa
        {
            get {return this.codTipoPessoa;}
            set {this.codTipoPessoa = value;}
        }
        public Pessoa(string nome, string cpf, string rg, int codPessoa, int codTipoPessoa)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Rg = rg;
            this.CodPessoa = codPessoa;
            this.CodTipoPessoa = codTipoPessoa;
        }

    }
}
