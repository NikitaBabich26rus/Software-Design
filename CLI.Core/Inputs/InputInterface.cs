using CLI.Core.Commands;

namespace CLI.Core.Inputs;

public interface InputInterface
{
    public List<Command> Commands { get; set; }

    public string Execute();
}