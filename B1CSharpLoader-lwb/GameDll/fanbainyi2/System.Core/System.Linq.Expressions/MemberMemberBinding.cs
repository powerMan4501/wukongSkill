using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;

namespace System.Linq.Expressions;

[global::__DynamicallyInvokable]
public sealed class MemberMemberBinding : MemberBinding
{
	private ReadOnlyCollection<MemberBinding> _bindings;

	[global::__DynamicallyInvokable]
	public ReadOnlyCollection<MemberBinding> Bindings
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _bindings;
		}
	}

	internal MemberMemberBinding(MemberInfo member, ReadOnlyCollection<MemberBinding> bindings)
		: base(MemberBindingType.MemberBinding, member)
	{
		_bindings = bindings;
	}

	[global::__DynamicallyInvokable]
	public MemberMemberBinding Update(IEnumerable<MemberBinding> bindings)
	{
		if (bindings == Bindings)
		{
			return this;
		}
		return Expression.MemberBind(base.Member, bindings);
	}
}
