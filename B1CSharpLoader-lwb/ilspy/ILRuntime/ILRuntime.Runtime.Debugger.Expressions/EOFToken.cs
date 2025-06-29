namespace ILRuntime.Runtime.Debugger.Expressions;

internal class EOFToken : Token
{
	public override TokenTypes Type => TokenTypes.EOF;
}
