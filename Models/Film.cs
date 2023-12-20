using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Film_Version_2.Models
{
    public class Film
    {
        
            
            public int Id { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]    
        [DisplayName("Название")]
        
            public string? Name { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [DisplayName("Описание")]
            public string? Description { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [DisplayName("Жанр")]
            public string? Jenre { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [DisplayName("Год")]
        [Range(1985,2024, ErrorMessage ="Недопустимый год")]
            public int Year { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [DisplayName("Режиссёр")]
            public string? Producer { get; set; }
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [DisplayName("Постер")]
            public string? Poster { get; set; }
        
    }
}
