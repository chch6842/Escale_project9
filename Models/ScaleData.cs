using System;
using System.ComponentModel.DataAnnotations;

namespace escale.Models
{
  public class ScaleData
  {
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int Grains { get; set; }
    public int Protein { get; set; }
    public int Dairy { get; set; }
    public int Vegetables { get; set; }
    public int Fruits { get; set; }
    public int OilsNuts { get; set; }
  }
}
