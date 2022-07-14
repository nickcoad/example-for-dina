public abstract class BaseProcessor
{
  public void RunProcess()
  {
    DoCommonStuff();
    ValidateFile();
    ProcessFile();
  }

  private void DoCommonStuff()
  {
    // Stuff that all processors should do
    Console.WriteLine("All processors will run this method.");
  }

  protected abstract void ValidateFile();

  protected abstract void ProcessFile();
}