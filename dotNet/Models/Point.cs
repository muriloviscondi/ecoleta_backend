using System.ComponentModel.DataAnnotations;

namespace dotNet.Models
{
  public class Point
  {
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Campo obrigatório")]
    public string Image { get; set; }

    [Required(ErrorMessage = "Campo obrigatório")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Campo obrigatório")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Campo obrigatório")]
    public string Whatsapp { get; set; }

    [Required(ErrorMessage = "Campo obrigatório")]
    public string Latitude { get; set; }

    [Required(ErrorMessage = "Campo obrigatório")]
    public string Longitude { get; set; }

    [Required(ErrorMessage = "Campo obrigatório")]
    public string City { get; set; }

    [Required(ErrorMessage = "Campo obrigatório")]
    [MaxLength(2, ErrorMessage = "Campo obrigatório 2 caracteres")]
    [MinLength(2, ErrorMessage = "Campo obrigatório 2 caracteres")]
    public string UF { get; set; }

  }
}