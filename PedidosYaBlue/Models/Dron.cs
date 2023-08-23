using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PedidosYaBlue.Interfaces;

namespace PedidosYaBlue.Models
{
    public class Dron : IRepartidor
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public IRepartidor Clonar()
        {
            return (Dron)this.MemberwiseClone();
        }
    }
}
