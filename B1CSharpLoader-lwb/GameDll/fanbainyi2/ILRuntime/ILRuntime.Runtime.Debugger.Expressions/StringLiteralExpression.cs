namespace ILRuntime.Runtime.Debugger.Expressions;

public class StringLiteralExpression : EvalExpression
{
	private string content;

	public string Content => content;

	public StringLiteralExpression(string content)
	{
		this.content = content;
	}

	internal override bool Parse(Token curToken, Lexer lexer)
	{
		return false;
	}
}
