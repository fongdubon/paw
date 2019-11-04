namespace Paw.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Product : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="El campo {0} es requerido")]
        [MaxLength(50, ErrorMessage ="El campo {0} debe tener máximo {1} caracteres")]
        [Display(Name="Nombre del producto->")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Precio:")]
        public decimal Price  { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Cantidad")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(150, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        [Display(Name = "Descripción del producto->")]
        public string Description { get; set; }
    }
}