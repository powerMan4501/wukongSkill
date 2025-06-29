namespace ILRuntime.Runtime.Debugger.Expressions;

internal enum TokenTypes
{
	Unknown,
	Name,
	StringLiteral,
	MemberAccess,
	IndexStart,
	IndexEnd,
	MethodStart,
	MethodEnd,
	InvocationStart,
	InvocationEnd,
	Comma,
	EOF
}
