
using System.ComponentModel.DataAnnotations;

namespace DEMO09.Types
{
    public class UserForgotPassword
    {
        [Required(ErrorMessage ="El email es requerido")]
        [MaxLength(100)]
        [RegularExpression(@"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b", ErrorMessage = "No es email válido")]
        public string Email { get; set; }
    }
}
