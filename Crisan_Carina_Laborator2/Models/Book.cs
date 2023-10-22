using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Crisan_Carina_Laborator2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Display(Name = "Book Title")]//daca dorim sa apara book title in loc de title
        public string? Title { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price {  get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }//navigation property
    
        public int? AuthorID { get; set; }
        public Author? Author { get; set; }//navigation property
    } 
}

