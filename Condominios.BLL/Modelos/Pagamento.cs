using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Condominios.BLL.Modelos
{
    public class Pagamento
    {
        [Display(Name = "ID")]
        public int pagamentoId { get; set; }
        [Display(Name = "Usuário")]
        public string usuarioId { get; set; }
        public virtual Usuario usuario { get; set; }
        [Display(Name = "Aluguel")]
        public int aluguelId { get; set; }
        public virtual Aluguel aluguel { get; set; }
        [Display(Name = "Dt. Pgto")]
        public DateTime? data { get; set; }
        [Display(Name = "Situação")]
        public SituacaoPagamento situacao { get; set; }
    }

    public enum SituacaoPagamento
    {
        Pago, Pendente, Atrasado
    }
}
