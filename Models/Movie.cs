using eTickets.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Movie Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        public double Price { get; set; }

        [Display(Name = "Movie Image")]
        public string ImageURL { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }

        //Relationship between Cinema Models and Movie Models
        /*
         * Karena Cinema Models dengan Movie Models bersifat one to many, dalam artian dalam suatu Cinema dapat menampun beberapa Movie, sedangkan 
         * Movie hanya dapat ditayangkan dalam satu Cinema.
         * Foreign Key merupakan key atau kunci yang menghubungkan suatu tabel ke tabel lainnya. Dalam kasus ini, CinemaId akan menjadi foreign key
         * yang menghubungkan tabel Movie dengan Cinema.
        */
        [ForeignKey("CinemaId")]
        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }


        [ForeignKey("Producerid")]
        public int ProducerId { get; set; }
        public Producer Producer { get; set; }

        //Relationship between Movie models and Actor models
        /*
         * Karena Movie dan Actor pada kasus ini termasuk kedalam hubungan many to many, maka dari itu kita perlu membagi hubungan tersebut dengan
         * kelas baru. Ini disebut dengan Join Class. Pada program ini dibuatkan Join Class dengan nama Actor_Movie.cs. Dengan begitu, tabel Movie
         * dapat terhubung dengan Actor_Movie dengan hubungan one to many, dan hal yang sama juga terjadi dengan tabel Actor
         */
        public List<Actor_Movie> Actors_Movies { get; set; }

    }
}
