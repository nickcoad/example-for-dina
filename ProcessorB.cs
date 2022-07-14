public class ProcessorB : BaseProcessor
{
  protected override void ValidateFile()
  {
    // Validation steps unique to this processor
    Console.WriteLine("Validating using ProcessorB logic.");
  }

  protected override void ProcessFile()
  {
    // Processing steps unique to this processor
    Console.WriteLine("Processing using ProcessorB logic.");
  }
}