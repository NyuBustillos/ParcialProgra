using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APIparcial.Models
{
        public enum UnitType
        {
            Conocido, //0
            CompañeroDeEstudio, //1
            ColegaDeTrabajo, //2
            Amigo, //3
            AmigoInfancia, //4
            Pariente //5
        }
        public enum StatusType
        {
            Activo,
            Inactivo
        }
        public class AdrianaBustillosFriend
        {
            [Key]
            public int FriendlD { get; set; }
            [Required]
            public string NombreCompleto { get; set; }
            public string Apodo { get; set; }
            public DateTime Cumpleaños { get; set; }
            [Required]
            public UnitType TipoDeAmigo { get; set; }
            public StatusType Estado { get; set; }

        }

}