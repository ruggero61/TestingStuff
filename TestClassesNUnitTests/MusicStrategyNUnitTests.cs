using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClasses.Bridge;
using TestClasses.Strategy;

namespace TestClassesNUnitTests
{
  [TestFixture]
  public class MusicStrategyNUnitTests
  {
    [Test]
    public void MusicTest()
    {
      TestClasses.Strategy.Guitar guitar = new();
      Performer performer = new(guitar);
      performer.Play(guitar);
    }

  }
}
