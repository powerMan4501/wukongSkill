namespace ILRuntime.Runtime.Debugger.Expressions;

public abstract class EvalExpression
{
	public virtual bool Completed => true;

	public bool IsRoot { get; set; }

	internal abstract bool Parse(Token curToken, Lexer lexer);
}
