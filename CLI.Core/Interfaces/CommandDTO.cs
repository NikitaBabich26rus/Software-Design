namespace CLI.Core.Interfaces;

public class CommandDTO
{
    public string CommandName { get; set; }
    
    public List<string> Arguments { get; set; }
    
    public string? Char { get; set; }
}