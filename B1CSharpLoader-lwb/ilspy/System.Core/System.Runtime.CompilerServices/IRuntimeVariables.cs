namespace System.Runtime.CompilerServices;

[global::__DynamicallyInvokable]
public interface IRuntimeVariables
{
	[global::__DynamicallyInvokable]
	int Count
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	object this[int index]
	{
		[global::__DynamicallyInvokable]
		get;
		[global::__DynamicallyInvokable]
		set;
	}
}
