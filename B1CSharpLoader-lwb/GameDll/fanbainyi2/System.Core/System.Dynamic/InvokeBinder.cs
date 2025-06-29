using System.Dynamic.Utils;

namespace System.Dynamic;

[global::__DynamicallyInvokable]
public abstract class InvokeBinder : DynamicMetaObjectBinder
{
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
	protected InvokeBinder(CallInfo callInfo)
	{
		ContractUtils.RequiresNotNull(callInfo, "callInfo");
		_callInfo = callInfo;
	}

	[global::__DynamicallyInvokable]
	public DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args)
	{
		return FallbackInvoke(target, args, null);
	}

	[global::__DynamicallyInvokable]
	public abstract DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);

	[global::__DynamicallyInvokable]
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
	{
		ContractUtils.RequiresNotNull(target, "target");
		ContractUtils.RequiresNotNullItems(args, "args");
		return target.BindInvoke(this, args);
	}
}
