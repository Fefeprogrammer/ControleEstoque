using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleEstoque.Web.Models
{
    public class LoginViewModel
    {
        private string usuario;
        private string senha;
        private bool lembrarMe;

        [Display(Name = "Usuario:")]
        public string Usuario { get => usuario; set => usuario = value; }
        [Display(Name = "Senha:")]
        public string Senha { get => senha; set => senha = value; }
        [Display(Name = "Lembrar-me:")]
        public bool LembrarMe { get => lembrarMe; set => lembrarMe = value; }
    }
}