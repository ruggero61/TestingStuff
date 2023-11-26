using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasses.Strategy;

public interface IInstrument
{
    public void PlayMelody();
}

public class Piano : IInstrument
{
    public void PlayMelody()
    {
        Console.WriteLine("Melody is played with Piano");
    }
}

public class Guitar : IInstrument
{
    public void PlayMelody()
    {
        Console.WriteLine("Melody is played with Guitar");
    }
}


public interface IPerformer
{
    public void Play(IInstrument instrument);
}

public class Performer : IPerformer
{
    private IInstrument _instrument;

    public Performer(IInstrument instrument)
    {
        _instrument = instrument;
    }
    public void Play(IInstrument instrument)
    {
        instrument.PlayMelody();
    }
}
