
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace BatuTravelProje.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Adınızı Giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz")]
        public string Surname  { get; set; }
        [Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Giriniz")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Lütfen Mail Adresinizi Giriniz")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Girdiğiniz Şifreyi Aynı Şekilde Tekrar Giriniz")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
