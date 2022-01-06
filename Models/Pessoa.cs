
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Andor.Models
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        [Required][Column(TypeName = "nvarchar(40)")]
        public string Nome { get; set; }
        [Required][Column(TypeName = "nvarchar(40)")]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public string CRNM { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public int CEP { get; set; }
        public string Sexo { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DataNascimento { get; set; }
        public string Nacionalidade { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DataCadastro { get; set; }
        public string Classe { get; set; }
    }
}
