using System.ComponentModel.DataAnnotations;

namespace Concert.Shared.Entities
{
    public class Ticket
    {
        public int Id { get; set; }

		[Display(Name = "Fue Usada")]
		public bool FueUsada { get; set; } = false;

        [Display(Name = "Fecha de Uso")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public DateTime? FechaUso { get; set; } 


        [Display(Name = "Porteria")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(80, ErrorMessage = "El campo {0} no puede tener mas de {1} caractéres")]
        public string? Porteria { get; set; } 
    }
}
