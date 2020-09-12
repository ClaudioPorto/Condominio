using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Condominios.BLL.Modelos
{
    public class ServicoPredio
    {
        [Display(Name = "ID")]
        public int servidoPredioId { get; set; }
        [Display(Name = "Serviço")]
        public int servicoId { get; set; }
        public virtual Servico servico { get; set; }
        [Display(Name = "Data")]
        public DateTime data { get; set; }
    }
}
