using System;

namespace ILRuntime.Runtime.Debugger.Expressions;

public class IndexAccessExpression : EvalExpression
{
	private EvalExpression body;

	private EvalExpression index;

	private bool isCompleted;

	public EvalExpression Body => body;

	public EvalExpression Index => index;

	public override bool Completed => isCompleted;

	public IndexAccessExpression(EvalExpression body)
	{
		if (body is NameExpression || body is MemberAcessExpression || body is IndexAccessExpression || body is InvocationExpression)
		{
			this.body = body;
			return;
		}
		throw new NotSupportedException("Cannot get index for " + body);
	}

	internal override bool Parse(Token curToken, Lexer lexer)
	{
		if (index == null)
		{
			switch (curToken.Type)
			{
			case TokenTypes.Name:
				index = new NameExpression(((NameToken)curToken).Content);
				return true;
			case TokenTypes.StringLiteral:
				index = new StringLiteralExpression(((StringLiteralToken)curToken).Content);
				return true;
			default:
				return false;
			}
		}
		if (!index.Completed)
		{
			return index.Parse(curToken, lexer);
		}
		if (!isCompleted)
		{
			switch (curToken.Type)
			{
			case TokenTypes.IndexEnd:
				isCompleted = true;
				return true;
			case TokenTypes.MemberAccess:
				index = new MemberAcessExpression(index);
				return true;
			case TokenTypes.IndexStart:
				index = new IndexAccessExpression(index);
				return true;
			case TokenTypes.InvocationStart:
				index = new InvocationExpression(index);
				return true;
			default:
				return false;
			}
		}
		return false;
	}
}
