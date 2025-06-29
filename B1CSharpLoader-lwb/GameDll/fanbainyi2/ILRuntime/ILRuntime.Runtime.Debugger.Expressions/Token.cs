namespace ILRuntime.Runtime.Debugger.Expressions;

internal abstract class Token
{
	public abstract TokenTypes Type { get; }

	public virtual void Parse(char c)
	{
	}
}
