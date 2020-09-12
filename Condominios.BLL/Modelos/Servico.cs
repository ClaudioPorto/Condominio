using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Condominios.BLL.Modelos
{
    public class Servico
    {
        [Display(Name = "ID")]
        public int servicoId { get; set; }
        [Display(Name = "Nome")]
        public string nome { get; set; }
        [Display(Name = "Valor")]
        public decimal valor { get; set; }
        [Display(Name = "Situação")]
        public SituacaoServico situacao { get; set; }
        [Display(Name = "Usuário")]
        public string usuarioId { get; set; }
        public virtual Usuario usuario { get; set; }
        public virtual ICollection<ServicoPredio> servicosPredios { get; set; }
    }

    public enum SituacaoServico
    {
        Pendente, Recusado, Aceito
    }
}
