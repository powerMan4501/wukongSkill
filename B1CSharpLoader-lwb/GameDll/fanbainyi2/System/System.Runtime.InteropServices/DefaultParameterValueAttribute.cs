namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Parameter)]
[global::__DynamicallyInvokable]
public sealed class DefaultParameterValueAttribute : Attribute
{
	private object value;

	[global::__DynamicallyInvokable]
	public object Value
	{
		[global::__DynamicallyInvokable]
		get
		{
			return value;
		}
	}

	[global::__DynamicallyInvokable]
	public DefaultParameterValueAttribute(object value)
	{
		this.value = value;
	}
}
