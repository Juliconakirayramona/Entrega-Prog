using System.ComponentModel.DataAnnotations;

namespace lib_entidades
{
    public class Clientes
    {
        [Key] public int ID_Persona { get; set; }
        public string? Cedula { get; set; }
        public string? Nombre { get; set; }

    }
}
