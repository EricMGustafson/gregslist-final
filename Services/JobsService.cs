using gregslist_final.FakeDB;
using gregslist_final.Models;

namespace gregslist_final.Services
{
  public class JobsService
  {
    internal List<Job> Get()
    {
      return Database.Jobs;
    }
    internal Job Get(string id)
    {
      Job job = Database.Jobs.Find(j => j.Id == id);
      if (job == null)
      {
        throw new Exception("Invalid Job Id.");
      }
      return job;
    }
    internal Job Create(Job newJob)
    {
      Database.Jobs.Add(newJob);
      return newJob;
    }
    internal Job Edit(Job jobData)
    {
      Job original = Get(jobData.Id);
      original.Company = jobData.Company ?? original.Company;
      original.Description = jobData.Description ?? original.Description;
      original.JobTitle = jobData.JobTitle ?? original.JobTitle;
      original.Hours = jobData.Hours;
      original.Rate = jobData.Rate;
      return original;
    }
    internal void Delete(string id)
    {
      Job found = Get(id);
      Database.Jobs.Remove(found);
    }
  }
}