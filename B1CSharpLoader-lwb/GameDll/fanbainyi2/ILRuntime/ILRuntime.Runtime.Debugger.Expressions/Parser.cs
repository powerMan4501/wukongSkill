using System;

namespace ILRuntime.Runtime.Debugger.Expressions;

public class Parser
{
	private Lexer lexer;

	public Parser(string exp)
	{
		lexer = new Lexer(exp);
	}

	public EvalExpression Parse()
	{
		Token nextToken = lexer.GetNextToken();
		EvalExpression evalExpression = null;
		while (nextToken.Type != TokenTypes.EOF)
		{
			if (evalExpression == null)
			{
				if (nextToken.Type != TokenTypes.Name)
				{
					throw new NotSupportedException("Unexpected token:" + nextToken.Type);
				}
				evalExpression = new NameExpression(((NameToken)nextToken).Content);
				evalExpression.IsRoot = true;
			}
			else if (!evalExpression.Parse(nextToken, lexer))
			{
				switch (nextToken.Type)
				{
				case TokenTypes.MemberAccess:
					evalExpression.IsRoot = false;
					evalExpression = new MemberAcessExpression(evalExpression);
					evalExpression.IsRoot = true;
					break;
				case TokenTypes.IndexStart:
					evalExpression.IsRoot = false;
					evalExpression = new IndexAccessExpression(evalExpression);
					evalExpression.IsRoot = true;
					break;
				case TokenTypes.InvocationStart:
					evalExpression.IsRoot = false;
					evalExpression = new InvocationExpression(evalExpression);
					evalExpression.IsRoot = true;
					break;
				default:
					throw new NotSupportedException("Unexpected token:" + nextToken.Type);
				}
			}
			nextToken = lexer.GetNextToken();
		}
		if (evalExpression != null && !evalExpression.Completed)
		{
			throw new NotSupportedException("Unexpected token: EOF");
		}
		return evalExpression;
	}
}
