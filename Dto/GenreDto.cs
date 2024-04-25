using System.ComponentModel.DataAnnotations;

namespace FirstProjectAPI.Dto
{
    public class GenreDto
    {
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
