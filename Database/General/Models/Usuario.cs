using System;
using System.Collections.Generic;

namespace Database.General.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
        }

        public int IdUsuario { get; set; }
        public string UserName { get; set; }
    }
}
