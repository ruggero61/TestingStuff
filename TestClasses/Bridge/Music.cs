using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasses.Bridge;

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
    public void Play();
}

public class SoloPerformer : IPerformer
{
    private IInstrument _instrument;
    public SoloPerformer(IInstrument instrument)
    {
        _instrument = instrument;
    }
    public void Play()
    {
        _instrument.PlayMelody();
    }
}

public class BandPerformer : IPerformer
{
    private IInstrument _instrument;
    public BandPerformer(IInstrument instrument)
    {
        _instrument = instrument;
    }
    public void Play()
    {
        _instrument.PlayMelody();
    }
}


