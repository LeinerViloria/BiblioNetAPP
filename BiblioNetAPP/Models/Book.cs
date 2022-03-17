using System.ComponentModel.DataAnnotations;

namespace BiblioNetAPP.Models
{
    public class Book
    {
        public int Id { set; get; }
        [Required(ErrorMessage="{0} is required")]
        public string BookName { set; get; }
        public string Author { set; get; }
        public float Price { set; get; }
    }
}
