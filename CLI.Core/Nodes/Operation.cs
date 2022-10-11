namespace CLI.Core.Nodes;

public abstract class Operation: INode
{
    public List<INode> Children { get; set; }

    abstract public string Execute();
}