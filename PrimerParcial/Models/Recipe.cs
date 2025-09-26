using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PrimerParcial.Models
{
    public class Recipe
    {
        // Clave Primaria (PK)
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } // Ejemplo: "Pastel de Chocolate"

        [Required]
        public string Description { get; set; } // Ejemplo: "Receta fácil y deliciosa..."

        // Clave Foránea (FK): Vincula esta receta a una categoría
        public int CategoryId { get; set; }

        // Propiedad de Navegación: El lado 'uno'
        public Category Category { get; set; }

        // Propiedad de Navegación: El lado 'muchos'
        public List<Ingredient> Ingredients { get; set; }
    }
}