using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasses.GenericSample
{
  public class GenericSample
  {
  }
}


public class GenericTestClass<T> 
{
  public T FieldName;
  public void MethodName(T param)
  {
    Console.WriteLine(param);
  }
}
