using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Condominios.BLL.Modelos
{
    public class Usuario : IdentityUser<string>
    {
        [Display(Name = "CPF")]
        public string cpf { get; set; }
        [Display(Name = "Foto")]
        public string foto { get; set; }
        [Display(Name = "Primeiro Acesso")]
        public bool primeiroAcesso { get; set; }
        [Display(Name = "Situação")]
        public SituacaoUsuario situacao { get; set; }
        public virtual ICollection<Apartamento> moradores { get; set; }
        public virtual ICollection<Apartamento> proprietarios { get; set; }
        public virtual ICollection<Veiculo> veiculos { get; set; }
        public virtual ICollection<Evento>  eventos { get; set; }
        public virtual ICollection<Servico> servicos { get; set; }
        public virtual ICollection<Pagamento> pagamentos { get; set; }
    }

    public enum SituacaoUsuario
    {
        Analisando, Aprovado, Reprovado
    }
}
