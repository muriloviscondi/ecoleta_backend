using System.ComponentModel.DataAnnotations;

namespace dotNet.Models
{
  public class CreateItem
  {
    [Key]
    public int Id { get; set; }

    public Point Point { get; set; }
    public Item Item { get; set; }
  }
}