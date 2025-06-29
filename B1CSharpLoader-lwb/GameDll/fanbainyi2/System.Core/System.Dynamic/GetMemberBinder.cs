using System.Dynamic.Utils;

namespace System.Dynamic;

[global::__DynamicallyInvokable]
public abstract class GetMemberBinder : DynamicMetaObjectBinder
{
	private readonly string _name;

	private readonly bool _ignoreCase;

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

	internal sealed override bool IsStandardBinder => true;

	[global::__DynamicallyInvokable]
	protected GetMemberBinder(string name, bool ignoreCase)
	{
		ContractUtils.RequiresNotNull(name, "name");
		_name = name;
		_ignoreCase = ignoreCase;
	}

	[global::__DynamicallyInvokable]
	public DynamicMetaObject FallbackGetMember(DynamicMetaObject target)
	{
		return FallbackGetMember(target, null);
	}

	[global::__DynamicallyInvokable]
	public abstract DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

	[global::__DynamicallyInvokable]
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
	{
		ContractUtils.RequiresNotNull(target, "target");
		ContractUtils.Requires(args == null || args.Length == 0, "args");
		return target.BindGetMember(this);
	}
}
