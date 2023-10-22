﻿namespace Crisan_Carina_Laborator2.Models
{
    public class Author
    {
        public int ID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Book>? Books { get; set; } //navigation property
    }
}
