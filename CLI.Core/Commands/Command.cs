namespace CLI.Core.Commands;
using Infrastructure;

public abstract class Command
{
    public List<string> Arguments { get; }
    
    public Command(List<string> arguments)
    {
        Arguments = arguments;
    }

    public void Execute(Environment environment)
    {
        
    }
}