namespace System.Runtime.CompilerServices;

[global::__DynamicallyInvokable]
public class StrongBox<T> : IStrongBox
{
	[global::__DynamicallyInvokable]
	public T Value;

	[global::__DynamicallyInvokable]
	object IStrongBox.Value
	{
		[global::__DynamicallyInvokable]
		get
		{
			return Value;
		}
		[global::__DynamicallyInvokable]
		set
		{
			Value = (T)value;
		}
	}

	[global::__DynamicallyInvokable]
	public StrongBox()
	{
	}

	[global::__DynamicallyInvokable]
	public StrongBox(T value)
	{
		Value = value;
	}
}
