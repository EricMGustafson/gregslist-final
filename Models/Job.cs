

using System.ComponentModel.DataAnnotations;

namespace gregslist_final.Models
{
  public class Job
  {
    public string Id { get; set; }
    [Required]
    public string Company { get; set; }
    public string JobTitle { get; set; }
    public int Hours { get; set; }
    public int Rate { get; set; }
    public string Description { get; set; }

    public Job(string company, string jobTitle, int hours, int rate, string description)
    {
      this.Id = Guid.NewGuid().ToString();
      this.Company = company;
      this.JobTitle = jobTitle;
      this.Hours = hours;
      this.Rate = rate;
      this.Description = description;

    }
  }
}