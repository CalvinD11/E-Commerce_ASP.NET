using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }


        //Relationship between Movie models and Actor models
        /*
         * Karena Movie dan Actor pada kasus ini termasuk kedalam hubungan many to many, maka dari itu kita perlu membagi hubungan tersebut dengan
         * kelas baru. Ini disebut dengan Join Class. Pada program ini dibuatkan Join Class dengan nama Actor_Movie.cs. Dengan begitu, tabel Movie
         * dapat terhubung dengan Actor_Movie dengan hubungan one to many, dan hal yang sama juga terjadi dengan tabel Actor
         */

        public List<Actor_Movie> Actors_Movies { get; set; }

    }
}
