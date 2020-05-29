using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    // public Category()
    // {
    //   this.Clients = new HashSet<Client>();
    // }

    public int StylistId { get; set; }
    public string Name { get; set; }
    public string Days { get; set; }
    public bool Monday { get; set; }
    public bool Tuesday { get; set; }
    public bool Wednesday { get; set; }
    public bool Thursday { get; set; }
    public bool Friday { get; set; }
    public bool Saturday { get; set; }
    public bool Sunday { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
  }
}