using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Bulky.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [Display(Name = "Титульник")]
        public string Title { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [Display(Name = "Автор")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [Display(Name = "Прейскурант")]
        [Range(0, 10000)]
        public double ListPrice { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [Display(Name = "Цена за покупку 1-50 штук")]
        [Range(0, 10000)]
        public double Price { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [Display(Name = "Цена за покупку 50-100 штук")]
        [Range(0, 10000)]
        public double Price50 { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [Display(Name = "Цена за покупку 100+ штук")]
        [Range(0, 10000)]
        public double Price100 { get; set; }
    }
}
