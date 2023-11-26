public interface IAddClasses<E, C> where C : class where E : Enum
{
  public Dictionary<E, C> GetClasses();
}


