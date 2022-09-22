using System.ComponentModel.DataAnnotations;

namespace Blog_MVC.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [EmailAddress(ErrorMessage = "Email Format Problem")]
        [Required(ErrorMessage ="Where is Email Address ?!!!")]
        [Display(Name="Email Address")]
        public string Email { get; set; }
        [Display(Name ="Title")]
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
