using System.Dynamic.Utils;

namespace System.Dynamic;

[global::__DynamicallyInvokable]
public abstract class SetIndexBinder : DynamicMetaObjectBinder
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
	protected SetIndexBinder(CallInfo callInfo)
	{
		ContractUtils.RequiresNotNull(callInfo, "callInfo");
		_callInfo = callInfo;
	}

	[global::__DynamicallyInvokable]
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
	{
		ContractUtils.RequiresNotNull(target, "target");
		ContractUtils.RequiresNotNull(args, "args");
		ContractUtils.Requires(args.Length >= 2, "args");
		DynamicMetaObject value = args[args.Length - 1];
		DynamicMetaObject[] array = args.RemoveLast();
		ContractUtils.RequiresNotNull(value, "args");
		ContractUtils.RequiresNotNullItems(array, "args");
		return target.BindSetIndex(this, array, value);
	}

	[global::__DynamicallyInvokable]
	public DynamicMetaObject FallbackSetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject value)
	{
		return FallbackSetIndex(target, indexes, value, null);
	}

	[global::__DynamicallyInvokable]
	public abstract DynamicMetaObject FallbackSetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject value, DynamicMetaObject errorSuggestion);
}
