

using System.ComponentModel.DataAnnotations;

namespace gregslist_final.Models
{
  public class House
  {
    public string Id { get; set; }
    [Required]
    public string Address { get; set; }
    public int Bedrooms { get; set; }
    public int Bathrooms { get; set; }
    public int Levels { get; set; }
    public string ImgUrl { get; set; }
    public int Price { get; set; }
    public string Description { get; set; }

    public House(string address, int bedrooms, int bathrooms, int levels, string imgUrl, int price, string description)
    {
      Id = Guid.NewGuid().ToString();
      Address = address;
      Bedrooms = bedrooms;
      Bathrooms = bathrooms;
      Levels = levels;
      ImgUrl = imgUrl;
      Price = price;
      Description = description;

    }
  }
}