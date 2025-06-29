using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;

namespace System.Linq.Expressions;

[global::__DynamicallyInvokable]
public sealed class MemberListBinding : MemberBinding
{
	private ReadOnlyCollection<ElementInit> _initializers;

	[global::__DynamicallyInvokable]
	public ReadOnlyCollection<ElementInit> Initializers
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _initializers;
		}
	}

	internal MemberListBinding(MemberInfo member, ReadOnlyCollection<ElementInit> initializers)
		: base(MemberBindingType.ListBinding, member)
	{
		_initializers = initializers;
	}

	[global::__DynamicallyInvokable]
	public MemberListBinding Update(IEnumerable<ElementInit> initializers)
	{
		if (initializers == Initializers)
		{
			return this;
		}
		return Expression.ListBind(base.Member, initializers);
	}
}
