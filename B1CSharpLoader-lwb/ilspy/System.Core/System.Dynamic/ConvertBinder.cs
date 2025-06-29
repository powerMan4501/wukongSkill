using System.Dynamic.Utils;

namespace System.Dynamic;

[global::__DynamicallyInvokable]
public abstract class ConvertBinder : DynamicMetaObjectBinder
{
	private readonly Type _type;

	private readonly bool _explicit;

	[global::__DynamicallyInvokable]
	public Type Type
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _type;
		}
	}

	[global::__DynamicallyInvokable]
	public bool Explicit
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _explicit;
		}
	}

	internal sealed override bool IsStandardBinder => true;

	[global::__DynamicallyInvokable]
	public sealed override Type ReturnType
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _type;
		}
	}

	[global::__DynamicallyInvokable]
	protected ConvertBinder(Type type, bool @explicit)
	{
		ContractUtils.RequiresNotNull(type, "type");
		_type = type;
		_explicit = @explicit;
	}

	[global::__DynamicallyInvokable]
	public DynamicMetaObject FallbackConvert(DynamicMetaObject target)
	{
		return FallbackConvert(target, null);
	}

	[global::__DynamicallyInvokable]
	public abstract DynamicMetaObject FallbackConvert(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

	[global::__DynamicallyInvokable]
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
	{
		ContractUtils.RequiresNotNull(target, "target");
		ContractUtils.Requires(args == null || args.Length == 0, "args");
		return target.BindConvert(this);
	}
}
