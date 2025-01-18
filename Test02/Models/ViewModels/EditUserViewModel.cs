using System.ComponentModel.DataAnnotations;

namespace Test02.Models.ViewModels
{
    public class EditUserViewModel
    {
        public string Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
