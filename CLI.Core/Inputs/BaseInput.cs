using CLI.Core.Commands;

namespace CLI.Core.Inputs;

public class BaseInput: InputInterface
{
    public List<Command> Commands { get; set; }
    
    public string Execute()
    {
        throw new NotImplementedException();
    }
}