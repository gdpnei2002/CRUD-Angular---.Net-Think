using System.ComponentModel.DataAnnotations;

namespace projet.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}