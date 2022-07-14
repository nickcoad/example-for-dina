public class ProcessorA : BaseProcessor
{
  protected override void ValidateFile()
  {
    // Validation steps unique to this processor
    Console.WriteLine("Validating using ProcessorA logic.");
  }

  protected override void ProcessFile()
  {
    // Processing steps unique to this processor
    Console.WriteLine("Processing using ProcessorA logic.");
  }
}