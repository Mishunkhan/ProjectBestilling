using System;
namespace ProjectBestilling.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; } =string.Empty;
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
    }
}

/*
 
 Note:
(Line6) The member variables must begin with upper case letters.
(Line7) The strings and classes must be declared with
default values (string.Empty or default! for class) to state
the value is a mandatory value OR 
(Line9) must be following with a question mark to state it is nullable.
  
 */