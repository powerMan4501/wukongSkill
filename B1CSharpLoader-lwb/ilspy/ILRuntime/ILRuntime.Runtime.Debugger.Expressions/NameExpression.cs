namespace ILRuntime.Runtime.Debugger.Expressions;

public class NameExpression : EvalExpression
{
	private string content;

	public string Content => content;

	public NameExpression(string content)
	{
		this.content = content;
	}

	internal override bool Parse(Token curToken, Lexer lexer)
	{
		return false;
	}
}
