using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Condominios.BLL.Modelos
{
    public class Mes
    {
        [Display(Name = "ID")]
        public int mesId { get; set; }
        [Display(Name = "Nome")]
        public string nome { get; set; }
        public virtual ICollection<Aluguel> alugueis { get; set; }
        public virtual ICollection<HistoricoRecurso> historicosRecursos { get; set; }
    }
}
