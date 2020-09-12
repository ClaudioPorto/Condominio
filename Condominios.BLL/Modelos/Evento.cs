using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Condominios.BLL.Modelos
{
    public class Evento
    {
        [Display(Name = "ID")]
        public int eventoId { get; set; }
        [Required(ErrorMessage = "O {0} não pode ser nulo!")]
        [MaxLength(50,ErrorMessage ="Informe no máximo {0} caracteres.")]
        [Display(Name = "Nome")]
        public string nome { get; set; }
        [Display(Name = "Data")]
        public DateTime data { get; set; }
        [Display(Name = "Número")]
        public string usuarioId { get; set; }
        public virtual Usuario usuario { get; set; }
    }
}
