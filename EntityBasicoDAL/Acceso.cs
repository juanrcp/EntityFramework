using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityBasicoDAL
{
    public class empleado
    {
        public int Id { get; set; }
        [Required]
        public string nombre_empleado { get; set; }
        public List<nivel_acc> nivel_accesos { get; set; }

    }

    public class nivel_acc
    {
        public int Id { get; set; }
        [Required]

        public string nivel_acceso { get; set; }

        public string desc_acceso { get; set; }
    }
}
