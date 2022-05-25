using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gregslist_final.FakeDB;
using gregslist_final.Models;

namespace gregslist_final.Services
{
  public class HousesService
  {
    internal List<House> Get()
    {
      return Database.Houses;
    }

    internal House Get(string id)
    {
      House house = Database.Houses.Find(h => h.Id == id);
      if (house == null)
      {
        throw new Exception("Invalid Cat Id");
      }
      return house;
    }
    internal House Create(House houseData)
    {
      Database.Houses.Add(houseData);
      return houseData;
    }

    internal House Edit(House houseData)
    {
      House original = Get(houseData.Id);
      original.Address = houseData.Address ?? original.Address;
      original.Bedrooms = houseData.Bedrooms;
      original.Bathrooms = houseData.Bathrooms;
      original.Levels = houseData.Levels;
      original.ImgUrl = houseData.ImgUrl ?? original.ImgUrl;
      original.Price = houseData.Price;
      original.Description = houseData.Description ?? original.Description;
      return original;
    }

    internal void Delete(string id)
    {
      House found = Get(id);
      Database.Houses.Remove(found);
    }
  }
}