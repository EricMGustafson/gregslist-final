

using gregslist_final.FakeDB;
using gregslist_final.Models;

namespace gregslist_final.Services
{
  public class CarsService
  {
    internal List<Car> Get()
    {
      return Database.Cars;
    }

    internal Car Get(string id)
    {
      Car car = Database.Cars.Find(c => c.Id == id);
      if (car == null)
      {
        throw new Exception("Invalid Car Id");
      }
      return car;
    }
    internal Car Create(Car carData)
    {
      Database.Cars.Add(carData);
      return carData;
    }

    internal Car Edit(Car carData)
    {
      Car original = Get(carData.Id);
      original.Name = carData.Name ?? original.Name;
      original.Color = carData.Color ?? original.Color;
      original.Description = carData.Description ?? original.Description;
      original.ImgUrl = carData.ImgUrl ?? original.ImgUrl;
      original.Make = carData.Make ?? original.Make;
      original.Price = carData.Price;
      return original;
    }

    internal void Delete(string id)
    {
      Car found = Get(id);
      Database.Cars.Remove(found);
    }
  }
}
