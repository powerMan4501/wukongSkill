namespace System.Linq.Expressions;

[global::__DynamicallyInvokable]
public sealed class LabelTarget
{
	private readonly Type _type;

	private readonly string _name;

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
	public Type Type
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _type;
		}
	}

	internal LabelTarget(Type type, string name)
	{
		_type = type;
		_name = name;
	}

	[global::__DynamicallyInvokable]
	public override string ToString()
	{
		if (!string.IsNullOrEmpty(Name))
		{
			return Name;
		}
		return "UnamedLabel";
	}
}
