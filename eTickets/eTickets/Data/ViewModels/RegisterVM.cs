using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "Ad ve soyad")]
        [Required(ErrorMessage = "Ad ve soyad gereklidir.")]
        public string FullName { get; set; }

        [Display(Name = "Email Adresi")]
        [Required(ErrorMessage = "Email Adresi gereklidir.")]
        public string EmailAddress { get; set; }

        [Display(Name = "Şifre")]
        [Required]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Şifreniz minimum 8 karakterden oluşmalıdır.")]
        [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$", ErrorMessage = "Parola en az 8 karakter olmalı ve bir büyük harf, bir küçük harf, bir sayı ve bir özel karakter içermelidir: büyük harf (A-Z), küçük harf (a-z), sayı (0-9) ve özel karakter (ör. !@#$%^&*)")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Şifre Onay")]
        [Required(ErrorMessage = "Şifre Onaylama Gereklidir.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Şifreler Eşleşmiyor")]
        public string ConfirmPassword { get; set; }
    }
}
