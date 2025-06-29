using System.Dynamic.Utils;

namespace System.Dynamic;

[global::__DynamicallyInvokable]
public abstract class DeleteMemberBinder : DynamicMetaObjectBinder
{
	private readonly string _name;

	private readonly bool _ignoreCase;

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
	public sealed override Type ReturnType
	{
		[global::__DynamicallyInvokable]
		get
		{
			return typeof(void);
		}
	}

	internal sealed override bool IsStandardBinder => true;

	[global::__DynamicallyInvokable]
	protected DeleteMemberBinder(string name, bool ignoreCase)
	{
		ContractUtils.RequiresNotNull(name, "name");
		_name = name;
		_ignoreCase = ignoreCase;
	}

	[global::__DynamicallyInvokable]
	public DynamicMetaObject FallbackDeleteMember(DynamicMetaObject target)
	{
		return FallbackDeleteMember(target, null);
	}

	[global::__DynamicallyInvokable]
	public abstract DynamicMetaObject FallbackDeleteMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

	[global::__DynamicallyInvokable]
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
	{
		ContractUtils.RequiresNotNull(target, "target");
		ContractUtils.Requires(args == null || args.Length == 0);
		return target.BindDeleteMember(this);
	}
}
