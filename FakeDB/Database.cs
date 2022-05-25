using gregslist_final.Models;

namespace gregslist_final.FakeDB
{
  public static class Database
  {
    public static List<Car> Cars { get; set; } = new List<Car>()
    {
        new Car("The Sizzler", "Ford", "Dusty Red", 5000, "Red", "https://www.thisautomobiledoesnotexist.com/"),
        new Car("The Guzzler", "Chevy", "Blueish", 4999, "Blue", "https://www.thisautomobiledoesnotexist.com/"),
        new Car("The Muzzler", "Ford", "Dusty Red", 5001, "Red", "https://www.thisautomobiledoesnotexist.com/")
    };
    public static List<House> Houses { get; set; } = new List<House>()
    {
      new House("123 House Way", 4, 2, 1, "https://www.thisautomobiledoesnotexist.com/", 124000, "Roomy"),
      new House("133 House Way", 5, 3, 2, "https://www.thisautomobiledoesnotexist.com/", 500000, "Large"),
      new House("143 House Way", 1, 2, 1, "https://www.thisautomobiledoesnotexist.com/", 75000, "Big Enough")
    };
    public static List<Job> Jobs { get; set; } = new List<Job>()
    {
      new Job("Boot Shiners", "Shiner", 8, 8, "Shine Boots"),
      new Job("Flip Flopper", "Flipper", 8, 8, "Flop flippers"),
      new Job("Heel Cobbler", "Cobbler", 8, 8, "Cobble Heels")
    };
  }
}