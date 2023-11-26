public class ExceptionManager : IExceptionManager
{
  public void ManageException(Exception ex)
  {
    Console.WriteLine(ex.Message);
  }
}
