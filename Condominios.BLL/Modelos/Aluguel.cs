using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;

namespace Condominios.BLL.Modelos
{
    public class Aluguel
    {
        [Display(Name = "ID")]
        public int aluguelId { get; set; }
        [Required(ErrorMessage = "O {0} não pode ser nulo!")]
        [Range(0, int.MaxValue, ErrorMessage ="Valor inválido.")]
        [Display(Name = "Valor")]
        public decimal valor { get; set; }
        [Display(Name = "Mês")]
        public int mesId { get; set; }
        public virtual Mes mes { get; set; }
        [Required(ErrorMessage = "O {0} não pode ser nulo!")]
        [Range(2020, 2030, ErrorMessage = "Valor inválido.")]
        [Display(Name = "Ano")]
        public int ano { get; set; }
        public virtual ICollection<Pagamento> pagamentos { get; set; }
    }
}
