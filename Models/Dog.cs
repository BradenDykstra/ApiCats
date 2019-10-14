using System;
using System.ComponentModel.DataAnnotations;

namespace cats.Models
{
  public class Dog
  {
    public Dog()
    {
      this.Id = String.Join("", Guid.NewGuid().ToString().Split('-'));
    }
    public Dog(string name, string color)
    {
      this.Name = name;
      this.Color = color;
      this.Id = String.Join("", Guid.NewGuid().ToString().Split('-'));
    }

    [Required]
    [MaxLength(10)]
    [MinLength(3)] //NOTE Attributes apply to the value below them
    public string Name { get; set; }
    [Required]
    public string Color { get; set; }
    public string Id { get; set; }
  }
}