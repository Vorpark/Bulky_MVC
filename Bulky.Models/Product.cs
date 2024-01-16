using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bulky.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [Display(Name = "Титульник")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [Display(Name = "Автор")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [Display(Name = "Прейскурант")]
        [Range(1, 10000, ErrorMessage = "Допустимый диапазон от 1 до 10000")]
        public double ListPrice { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [Display(Name = "Цена за покупку 1-50 штук")]
        [Range(1, 10000, ErrorMessage = "Допустимый диапазон от 1 до 10000")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [Display(Name = "Цена за покупку 50-100 штук")]
        [Range(1, 10000, ErrorMessage = "Допустимый диапазон от 1 до 10000")]
        public double Price50 { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [Display(Name = "Цена за покупку 100+ штук")]
        [Range(1, 10000, ErrorMessage = "Допустимый диапазон от 1 до 10000")]
        public double Price100 { get; set; }

        [Required(ErrorMessage = "Нужно выбрать категорию")]
        [Display(Name = "Категория")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        public string ImageUrl { get; set; }
    }
}
