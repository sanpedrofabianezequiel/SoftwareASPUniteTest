using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Opera
    {
        [Required]
        public int OperaId { get; set; }

        [Required]
        [StringLength(20)]
        public string Title { get; set; }

        [CheckValidYear]//validación personalizada
        public int Year { get; set; }

        [Required]
        [StringLength(50)]
        public string Composer { get; set; }

    }
}