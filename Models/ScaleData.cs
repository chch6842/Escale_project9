using System;

namespace escale.Models
{
  public class ScaleData
  {
    public DateTime Date { get; set; }
    public int Grains { get; set; }
    public int Protein { get; set; }
    public int Dairy { get; set; }
    public int Vegetables { get; set; }
    public int Fruits { get; set; }
    public int OilsNuts { get; set; }
  }
}
