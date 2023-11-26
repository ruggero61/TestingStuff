using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClasses.Bridge;

namespace TestClassesNUnitTests
{
  [TestFixture]
  public class MusicBridgeNUnitTests
  {
    [Test]
    public void MusicTest()
    {
      TestClasses.Bridge.Guitar guitar = new();
      TestClasses.Bridge.BandPerformer performer = new(guitar);
      performer.Play();
    }
  }
}
