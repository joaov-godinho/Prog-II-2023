using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PSIUWeb.Models
{
    public class Midia
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "URL requerida.")]
        [Display(Name = "Link")]
        public string? URL { get; set; }

        [Required(ErrorMessage = "Tipo de Midia requerido.")]
        [Display(Name = "Midia")]

    }
}
