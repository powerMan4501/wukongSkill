using System;
using System.Collections.Generic;

namespace ILRuntime.Runtime.Debugger.Expressions;

public class InvocationExpression : EvalExpression
{
	private EvalExpression body;

	private List<EvalExpression> parameters = new List<EvalExpression>();

	private EvalExpression curParam;

	private bool isCompleted;

	public EvalExpression Body => body;

	public List<EvalExpression> Parameters => parameters;

	public override bool Completed => isCompleted;

	public InvocationExpression(EvalExpression body)
	{
		if (body is NameExpression || body is MemberAcessExpression || body is IndexAccessExpression || body is InvocationExpression)
		{
			this.body = body;
			return;
		}
		throw new NotSupportedException("Cannot make invocation  for " + body);
	}

	internal override bool Parse(Token curToken, Lexer lexer)
	{
		if (curParam == null)
		{
			switch (curToken.Type)
			{
			case TokenTypes.Name:
				curParam = new NameExpression(((NameToken)curToken).Content);
				return true;
			case TokenTypes.StringLiteral:
				curParam = new StringLiteralExpression(((StringLiteralToken)curToken).Content);
				return true;
			default:
				return false;
			}
		}
		if (!curParam.Completed)
		{
			return curParam.Parse(curToken, lexer);
		}
		if (!isCompleted)
		{
			switch (curToken.Type)
			{
			case TokenTypes.InvocationEnd:
				if (curParam != null)
				{
					parameters.Add(curParam);
				}
				isCompleted = true;
				return true;
			case TokenTypes.MemberAccess:
				curParam = new MemberAcessExpression(curParam);
				return true;
			case TokenTypes.IndexStart:
				curParam = new IndexAccessExpression(curParam);
				return true;
			case TokenTypes.InvocationStart:
				curParam = new InvocationExpression(curParam);
				return true;
			case TokenTypes.Comma:
				if (curParam != null)
				{
					parameters.Add(curParam);
					return true;
				}
				return false;
			default:
				return false;
			}
		}
		return false;
	}
}
