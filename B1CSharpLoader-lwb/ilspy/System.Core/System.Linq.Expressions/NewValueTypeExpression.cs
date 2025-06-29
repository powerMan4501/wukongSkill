using System.Collections.ObjectModel;
using System.Reflection;

namespace System.Linq.Expressions;

internal class NewValueTypeExpression : NewExpression
{
	private readonly Type _valueType;

	public sealed override Type Type => _valueType;

	internal NewValueTypeExpression(Type type, ReadOnlyCollection<Expression> arguments, ReadOnlyCollection<MemberInfo> members)
		: base(null, arguments, members)
	{
		_valueType = type;
	}
}
