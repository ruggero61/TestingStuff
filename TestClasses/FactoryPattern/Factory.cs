public class Factory<E, C> where C : class where E : Enum 
{
  private Dictionary<E, C> _classes = new();

  public Factory(IAddClasses<E, C> addClasses)
  {
    _classes = addClasses.GetClasses(); 
  }
  public C? Create(E classType)
  {
    return _classes.ContainsKey(classType) ? _classes[classType] : null;
  }
}


