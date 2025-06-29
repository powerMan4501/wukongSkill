using System.Dynamic.Utils;

namespace System.Dynamic;

[global::__DynamicallyInvokable]
public abstract class InvokeMemberBinder : DynamicMetaObjectBinder
{
	private readonly string _name;

	private readonly bool _ignoreCase;

	private readonly CallInfo _callInfo;

	[global::__DynamicallyInvokable]
	public sealed override Type ReturnType
	{
		[global::__DynamicallyInvokable]
		get
		{
			return typeof(object);
		}
	}

	[global::__DynamicallyInvokable]
	public string Name
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _name;
		}
	}

	[global::__DynamicallyInvokable]
	public bool IgnoreCase
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _ignoreCase;
		}
	}

	[global::__DynamicallyInvokable]
	public CallInfo CallInfo
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _callInfo;
		}
	}

	internal sealed override bool IsStandardBinder => true;

	[global::__DynamicallyInvokable]
	protected InvokeMemberBinder(string name, bool ignoreCase, CallInfo callInfo)
	{
		ContractUtils.RequiresNotNull(name, "name");
		ContractUtils.RequiresNotNull(callInfo, "callInfo");
		_name = name;
		_ignoreCase = ignoreCase;
		_callInfo = callInfo;
	}

	[global::__DynamicallyInvokable]
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
	{
		ContractUtils.RequiresNotNull(target, "target");
		ContractUtils.RequiresNotNullItems(args, "args");
		return target.BindInvokeMember(this, args);
	}

	[global::__DynamicallyInvokable]
	public DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args)
	{
		return FallbackInvokeMember(target, args, null);
	}

	[global::__DynamicallyInvokable]
	public abstract DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);

	[global::__DynamicallyInvokable]
	public abstract DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);
}
