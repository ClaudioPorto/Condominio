using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Condominios.BLL.Modelos
{
    public class HistoricoRecurso
    {
        [Display(Name = "ID")] 
        public int historicoRecursoId { get; set; }
        [Required(ErrorMessage = "O {0} não pode ser nulo!")]
        [Range(1, int.MaxValue, ErrorMessage = "Valor incorreto.")]
        [Display(Name = "Valor")]
        public decimal valor { get; set; }
        [Range(1, 31, ErrorMessage = "Informe um numero entre {0} e {1}.")]
        [Display(Name = "Dia")]
        public int dia { get; set; }
        [Display(Name = "Mês")]
        public int mesId { get; set; }
        public virtual Mes mes { get; set; }
        [Display(Name = "Ano")]
        public int ano { get; set; }
        [Display(Name = "Tipo")]
        public TipoHistoricoRecurso tipo { get; set; }
    }

    public enum TipoHistoricoRecurso
    {
        Entrada, Saida
    }
}
