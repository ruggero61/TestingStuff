using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasses.Prototype;

public class CopySample : ICloneable
{
  public int Age { get; set; }
  public string Name { get; set; }

  public object Clone()
  {
    return this.MemberwiseClone();
  }
}

public class Sample
{
  
}


