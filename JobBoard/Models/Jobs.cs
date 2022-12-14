using System.Collections.Generic;

namespace JobBoard.Models
{
  public class Jobs
  {
    public string Title { get; set; }

    public string Description { get; set; }

    public string Number { get; set; }

    public string Email { get; set; }

    private static List<Jobs> _instances = new List<Jobs> { };

    public Jobs(string title, string description, string number, string email) 
    {
      Title = title;
      Description = description;
      Number = Number; 
      Email = email;
      _instances.Add(this);
    }
  }
}