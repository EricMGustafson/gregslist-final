

using System.ComponentModel.DataAnnotations;

namespace gregslist_final.Models
{
  public class Car
  {
    public string Id { get; set; }
    [Required]
    [MinLength(3)]
    [MaxLength(30)]
    public string Name { get; set; }
    public string Make { get; set; }
    public string Description { get; set; }
    [Range(0, int.MaxValue)]
    public int Price { get; set; }
    public string Color { get; set; }
    public string ImgUrl { get; set; }

    public Car(string name, string make, string description, int price, string color, string imgUrl)
    {
      Id = Guid.NewGuid().ToString();
      Name = name;
      Make = make;
      Description = description;
      Price = price;
      Color = color;
      ImgUrl = imgUrl;

    }
  }
}