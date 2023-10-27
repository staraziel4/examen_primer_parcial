using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Musica
    {
        [Key]
        public int id_musica { get; set; }
        public string titulo { get; set; }
        public string genero { get; set; }
        public int n_reproducciones { get; set; }
        public int id_disco { get; set; }
    }
}