using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial1_RaynerJimmyTapiaCaballero.Models
{
    public class Products
    {
        [Key]


        public int ProductID { get; set; }

        [Required]
        [StringLength(30,ErrorMessage ="Ingrese una descripcion de entre 3 a 30 caracteres",MinimumLength =3)]
        
        public string Description { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public int Price { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        public DateTime LastBuy { get; set; }
    }
}