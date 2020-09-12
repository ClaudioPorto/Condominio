using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Condominios.BLL.Modelos
{
    public class Apartamento
    {
        [Display(Name = "ID")]
        public int apartamentoId { get; set; }
        [Required(ErrorMessage = "O {0} não pode ser nulo!")]
        [Range(1, 1000, ErrorMessage = "Informe um numero entre {0} e {1}.")]
        [Display(Name ="Número")]
        public int numero { get; set; }
        [Required(ErrorMessage = "O {0} não pode ser nulo!")]
        [Range(1, 10, ErrorMessage = "Informe um numero entre {0} e {1}.")]
        [Display(Name = "Andar")]
        public int andar { get; set; }
        [Display(Name = "Foto")]
        public string foto { get; set; }
        [Display(Name = "Morador")]
        public string moradorId { get; set; }
        public virtual Usuario morador { get; set; }
        [Display(Name = "Proprietário")]
        public string proprietarioId { get; set; }
        public virtual Usuario proprietario { get; set; }
    }
}
