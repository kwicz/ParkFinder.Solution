using System.ComponentModel.DataAnnotations;

namespace ParkFinder.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Location { get; set; }
    [Required]
    public string DateEstablished { get; set; }
    public string Area { get; set; }
    public string Description { get; set; }
  }
}