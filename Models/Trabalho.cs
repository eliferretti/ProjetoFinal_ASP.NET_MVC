using System;
using System.ComponentModel.DataAnnotations;

namespace Andor.Models
{
    public class Trabalho
    {
        [Key]
        public int      Id              { get; set; }
        public int      Id_pessoa       { get; set; }
        public string   Instituicao     { get; set; }
        public string   Nome            { get; set; }
        public string   Atividade       { get; set; }
        public string   Tipo            { get; set; }
        public double   Salario         { get; set; }
        public string   Endereco        { get; set; }
        public int      Numero          { get; set; }
        public int      CEP             { get; set; }
        public string   UF              { get; set; }
        public string   Cidade          { get; set; }
        public string   NomeContato     { get; set; }
        public string   TelefoneContato { get; set; }
        public string   EmailContato    { get; set; }
        public DateTime DataCadastro    { get; set; }
    }
}
