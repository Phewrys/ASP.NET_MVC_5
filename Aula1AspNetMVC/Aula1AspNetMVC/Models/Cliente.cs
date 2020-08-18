using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aula1AspNetMVC.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150, ErrorMessage = "Máximo de caracteres excedido.")]
        [MinLength(2, ErrorMessage = "Mínimo de 2 caracteres.")]
        [DisplayName("Nome do Cliente")]
        [Required(ErrorMessage = "Preencher campo nome.")]
        public string Nome { get; set; }

        [MaxLength(150, ErrorMessage = "Máximo de caracteres excedido.")]
        [MinLength(2, ErrorMessage = "Mínimo de 2 caracteres.")]
        [DisplayName("Sobrenome do Cliente")]
        [Required(ErrorMessage = "Preencher campo sobrenome.")]
        public string SobreNome { get; set; }
        
        [ScaffoldColumn(false)] // Vai ignorar essa coluna durante o processo de criação via Scaffold.
        public DateTime DataCadastro { get; set; }

        [MaxLength(150, ErrorMessage = "Máximo de caracteres excedido.")]
        [MinLength(2, ErrorMessage = "Mínimo de 2 caracteres.")]
        [DisplayName("E-mail")]
        [Required(ErrorMessage = "Preencher campo E-mail.")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }
    }
}