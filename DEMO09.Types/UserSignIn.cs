
using System;
using System.ComponentModel.DataAnnotations;

namespace DEMO09.Types
{
    public class UserSignIn:TypeBase
    {
        [Required(ErrorMessage = "El email es un campo requerido")]
        [MaxLength(100)]
        [RegularExpression(@"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b", ErrorMessage = "No es email valido")]
        public string Email { get; set; }

        [Required(ErrorMessage ="La contraseña es un campo requerido")]
        [MinLength(6, ErrorMessage = "La contraseña debe contener un mínimo de 6 caracteres")]
        [MaxLength(15, ErrorMessage ="La contraseña debe contener un máximo de 15 caracteres")]
        public string Password { get; set; }

    }
}
