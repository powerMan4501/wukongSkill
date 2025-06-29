using System.Text;

namespace ILRuntime.Runtime.Debugger.Expressions;

internal class StringLiteralToken : Token
{
	private StringBuilder sb = new StringBuilder();

	public override TokenTypes Type => TokenTypes.StringLiteral;

	public string Content => sb.ToString();

	public override void Parse(char c)
	{
		sb.Append(c);
	}
}
