using System.ComponentModel.DataAnnotations;

namespace dotNet.Models
{
  public class Item
  {
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Campo obrigatório")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Campo obrigatório")]
    public string Image { get; set; }

  }
}