using BiblioNetAPP.Validations;
using System.ComponentModel.DataAnnotations;

namespace BiblioNetAPP.Models
{
    public class Books
    {
        public int Id { set; get; }
        [Required(ErrorMessage="{0} is required")]
        [FirstUpperCase]
        public string BookName { set; get; }
        public int AuthorId { set; get; }
        public float Price { set; get; }
    }
}
