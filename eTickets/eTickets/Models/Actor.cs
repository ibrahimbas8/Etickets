using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Actor:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profil Resmi")]
        [Required(ErrorMessage = "Profil resmi gereklidir")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Adınız ve Soyadınız")]
        [Required(ErrorMessage = "Adınız ve Soyadınız gereklidir.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Adınız ve Soyadınız 3 ile 50 karakter arası olmalıdır.")]
        public string FullName { get; set; }

        [Display(Name = "Biyografi")]
        [Required(ErrorMessage = "Biyografi gereklidir.")]
        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
