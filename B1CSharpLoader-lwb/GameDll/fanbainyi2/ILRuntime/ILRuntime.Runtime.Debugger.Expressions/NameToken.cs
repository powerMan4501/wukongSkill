namespace ILRuntime.Runtime.Debugger.Expressions;

internal class NameToken : StringLiteralToken
{
	public override TokenTypes Type => TokenTypes.Name;
}
