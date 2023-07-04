using System.ComponentModel.DataAnnotations;

namespace SpryStore.PresentationLayer.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Ad Alanı Boş Geçilemez")]
        [StringLength(5,ErrorMessage ="En Fazla 5 Karakter Giriniz")]
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Password { get; set; }
    }
}
