
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodMac.Models
{
    [Table("Foods")]
    public class Food
    {
        [Key]
        public int FoodId { get; set; }
        [Required(ErrorMessage = "O nome deve ser informado")]
        [Display(Name = "Nome do lanche")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no minimo {1} e no máximo {2}")]
        public string Name { get; set; }
        [Required(ErrorMessage = "O nome deve ser informado")]
        [Display(Name = "Descrição")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição pode exceder {1} caracteres")]
        public string ShortDescription { get; set; }
        [Required(ErrorMessage = "O nome deve ser informado")]
        [Display(Name = "Nome do lanche")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição pode exceder {1} caracteres")]
        public string DetailsDescription { get; set; }
        [Required(ErrorMessage = "Informe o preço do lanche")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1 a 999")]
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        [Display(Name = "Preferido ?")]
        public bool IsFavoriteFood { get; set; }
        [Display(Name ="InStock")]
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
