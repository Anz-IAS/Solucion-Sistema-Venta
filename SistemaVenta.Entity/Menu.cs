using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity
{
    public partial class Menu
    {
        public Menu()
        {
            RolMenus = new HashSet<RolMenu>();
        }

        public int IdMenu { get; set; }
        public string? Descripcion { get; set; }
        public string? Controlador { get; set; }
        public string? PaginaAccion { get; set; }
        public bool? EsActivo { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual ICollection<RolMenu> RolMenus { get; set; }
        public virtual Menu? IdMenuPadreNavigation { get; set; }
        public virtual ICollection<Menu> InverseIdMenuPadreNavigation { get; set; }

    }
}
