using System.ComponentModel.DataAnnotations;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string ClientName { get; set; }
    [Required(ErrorMessage = "Please add a stylist first")]
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}