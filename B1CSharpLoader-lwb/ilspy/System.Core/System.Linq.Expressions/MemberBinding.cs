using System.Reflection;

namespace System.Linq.Expressions;

[global::__DynamicallyInvokable]
public abstract class MemberBinding
{
	private MemberBindingType _type;

	private MemberInfo _member;

	[global::__DynamicallyInvokable]
	public MemberBindingType BindingType
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _type;
		}
	}

	[global::__DynamicallyInvokable]
	public MemberInfo Member
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _member;
		}
	}

	[Obsolete("Do not use this constructor. It will be removed in future releases.")]
	protected MemberBinding(MemberBindingType type, MemberInfo member)
	{
		_type = type;
		_member = member;
	}

	[global::__DynamicallyInvokable]
	public override string ToString()
	{
		return ExpressionStringBuilder.MemberBindingToString(this);
	}
}
