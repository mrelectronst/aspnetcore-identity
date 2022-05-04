using System.ComponentModel.DataAnnotations;

namespace identity.Models.ViewModels
{
    public class UserViewModel
    {
        [Required(ErrorMessage ="Required User Name")]
        [Display(Name ="User Name")]
        public string UserName { get; set; }

        [Display(Name ="Phone Number")]
        public string PhoneNumber { get; set; }
        
        [Required(ErrorMessage ="Required Email")]
        [Display(Name ="Email")]
        [EmailAddress(ErrorMessage ="Invalid Email Format")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Required Password")]
        [Display(Name ="Password")]
        [DataType(DataType.Password)]               
        public string Password { get; set; }
        
    }
}