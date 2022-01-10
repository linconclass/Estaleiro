using Estaleiro.Models.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Estaleiro.Models
{
    public class Conteiner
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Cliente { get; set; }

        [StringLength(11)]
        public string NumeroConteiner { get; set; }

        public TipoConteiner TipoConteiner { get; set; }
        public StatusConteiner StatusConteiner { get; set; }
        public CategoriaConteiner CategoriaConteiner { get; set; }


    }
}
