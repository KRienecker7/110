
namespace PropertyRental.Models
{
    public class Property
    {
        public int Id {get; set;}
        public string Title {get; set;}

        public decimal Price {get; set;}
        public int area {get; set;}
        public int beds {get; set;}
        public int baths {get; set;}
        public string inputAddress {get; set;}
        public string inputAddress2 {get; set;}
        public string inputCity {get; set;}
        public string inputState {get; set;}
        public string inputZip {get; set;}
        public string image {get; set;}
        public string description {get; set;}


    }
}

//create table called properties
//properties add column (id, int)