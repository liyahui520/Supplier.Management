using System.ComponentModel.DataAnnotations;

namespace Supplier.Management.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}