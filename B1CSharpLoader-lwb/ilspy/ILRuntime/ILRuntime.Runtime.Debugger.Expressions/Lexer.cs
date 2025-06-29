using System;

namespace ILRuntime.Runtime.Debugger.Expressions;

internal class Lexer
{
	private char[] content;

	private int idx;

	public Token LastToken { get; set; }

	public Lexer(string exp)
	{
		content = exp.ToCharArray();
	}

	public Token PeekNextToken()
	{
		int num = idx;
		Token lastToken = LastToken;
		Token nextToken = GetNextToken();
		idx = num;
		LastToken = lastToken;
		return nextToken;
	}

	public Token GetNextToken()
	{
		int num = content.Length;
		Token token = null;
		while (idx < num)
		{
			char c = content[idx++];
			switch (c)
			{
			case '"':
				if (token != null)
				{
					if (token.Type == TokenTypes.StringLiteral)
					{
						LastToken = token;
						return token;
					}
					throw new NotSupportedException();
				}
				token = new StringLiteralToken();
				break;
			case '[':
				if (token != null)
				{
					if (token.Type == TokenTypes.StringLiteral)
					{
						token.Parse(c);
						break;
					}
					idx--;
					LastToken = token;
					return token;
				}
				LastToken = new IndexStartToken();
				return LastToken;
			case ']':
				if (token != null)
				{
					if (token.Type == TokenTypes.StringLiteral)
					{
						token.Parse(c);
						break;
					}
					idx--;
					LastToken = token;
					return token;
				}
				LastToken = new IndexEndToken();
				return LastToken;
			case '(':
				if (token != null)
				{
					if (token.Type == TokenTypes.StringLiteral)
					{
						token.Parse(c);
						break;
					}
					idx--;
					LastToken = token;
					return token;
				}
				LastToken = new InvocationStartToken();
				return LastToken;
			case ')':
				if (token != null)
				{
					if (token.Type == TokenTypes.StringLiteral)
					{
						token.Parse(c);
						break;
					}
					idx--;
					LastToken = token;
					return token;
				}
				LastToken = new InvocationEndToken();
				return LastToken;
			case ',':
				if (token != null)
				{
					if (token.Type == TokenTypes.StringLiteral)
					{
						token.Parse(c);
						break;
					}
					idx--;
					LastToken = token;
					return token;
				}
				LastToken = new CommaToken();
				return LastToken;
			case ' ':
				if (token != null)
				{
					if (token.Type != TokenTypes.StringLiteral)
					{
						idx--;
						LastToken = token;
						return token;
					}
					token.Parse(c);
				}
				break;
			case '.':
				if (token != null)
				{
					if (token.Type == TokenTypes.StringLiteral)
					{
						token.Parse(c);
						break;
					}
					idx--;
					LastToken = token;
					return token;
				}
				LastToken = new MemberAccessToken();
				return LastToken;
			default:
				if (token == null)
				{
					token = new NameToken();
				}
				token.Parse(c);
				break;
			}
		}
		if (token == null)
		{
			token = new EOFToken();
		}
		LastToken = token;
		return token;
	}
}
