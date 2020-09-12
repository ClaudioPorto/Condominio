using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Condominios.BLL.Modelos
{
    public class Veiculo
    {
        [Display(Name = "ID")]
        public string veiculoId { get; set; }
        [Required(ErrorMessage ="O {0} não pode ser nulo!")]
        [StringLength(20,ErrorMessage ="Informe no máximo {0} caracteres.")]
        [Display(Name = "Nome")]
        public string nome { get; set; }
        [Required(ErrorMessage = "O {0} não pode ser nulo!")]
        [StringLength(20, ErrorMessage = "Informe no máximo {0} caracteres.")]
        [Display(Name = "Marca")]
        public string marca { get; set; }
        [Required(ErrorMessage = "O {0} não pode ser nulo!")]
        [StringLength(20, ErrorMessage = "Informe no máximo {0} caracteres.")]
        [Display(Name = "Placa")]
        public string placa { get; set; }
        [Required(ErrorMessage = "O {0} não pode ser nulo!")]
        [StringLength(20, ErrorMessage = "Informe no máximo {0} caracteres.")]
        [Display(Name = "Cor")]
        public string cor { get; set; }
        [Display(Name = "Proprietário")]
        public string usuarioId { get; set; }
        public virtual Usuario usuario { get; set; }
    }
}
