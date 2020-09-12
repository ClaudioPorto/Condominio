using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Condominios.BLL.Modelos
{
    public class Funcao : IdentityRole<string>
    {
        public string descricao { get; set; }
    }
}
