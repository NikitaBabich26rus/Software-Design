namespace CLI.Core.Commands;

public class ExternalCommand: Command
{
    private string _commandName;

    public ExternalCommand(List<string> arguments, string commandName) : base(arguments)
    {
        _commandName = commandName;
    }
}