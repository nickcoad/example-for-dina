// See https://aka.ms/new-console-template for more information
var processors = new BaseProcessor[] { new ProcessorA(), new ProcessorB() };

foreach (var processor in processors)
{
  processor.RunProcess();
}