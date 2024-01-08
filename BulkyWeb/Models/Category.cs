using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DisplayName("Имя категории")]
        [MaxLength(30)]
        public string Name { get; set; }
        [DisplayName("Порядок отображения категории")]
        [Range (1, 100, ErrorMessage = "Допустимый диапазон от 1 до 100")]
        public int DisplayOrder { get; set; }
    }
}
