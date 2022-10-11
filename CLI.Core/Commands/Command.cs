namespace CLI.Core.Commands;
using Infrastructure;

public abstract class Command
{
    public List<string> Arguments { get; }
    
    public Command(List<string> arguments)
    {
        Arguments = arguments;
    }

    /// <summary>
    /// Обращается в к Environment
    /// Возвращает код возврата и строку ошибки
    /// </summary>
    public void Execute()
    {
        
    }
}