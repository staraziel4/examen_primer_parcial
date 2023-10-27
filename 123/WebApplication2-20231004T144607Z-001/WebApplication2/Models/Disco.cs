using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Modelsss
{
    public class Disco
    {
        [Key]
        public int id_disco { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
        public int anio { get; set; }
    }
}
