using System;
using System.ComponentModel.DataAnnotations;

namespace Andor.Models
{
    public class Moradia
    {
        [Key]
        public int Id { get; set; }
        public int Id_pessoa { get; set; }
        public string Name { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public double Preco { get; set; }    
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public int CEP { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string NomeContato { get; set; }
        public string TelefoneContato { get; set; }
        public string EmailContato { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
