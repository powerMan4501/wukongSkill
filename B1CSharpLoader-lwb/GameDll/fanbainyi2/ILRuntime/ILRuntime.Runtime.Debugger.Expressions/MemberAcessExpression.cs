using System;

namespace ILRuntime.Runtime.Debugger.Expressions;

public class MemberAcessExpression : EvalExpression
{
	private EvalExpression body;

	private string member;

	public EvalExpression Body => body;

	public string Member => member;

	public override bool Completed => member != null;

	public MemberAcessExpression(EvalExpression body)
	{
		if (body is NameExpression || body is MemberAcessExpression || body is IndexAccessExpression || body is InvocationExpression)
		{
			this.body = body;
			return;
		}
		throw new NotSupportedException("Cannot retrive member for " + body);
	}

	internal override bool Parse(Token curToken, Lexer lexer)
	{
		if (member == null)
		{
			if (curToken.Type == TokenTypes.Name)
			{
				member = ((NameToken)curToken).Content;
				return true;
			}
			return false;
		}
		return false;
	}
}
