namespace System.ComponentModel;

[global::__DynamicallyInvokable]
public interface IChangeTracking
{
	[global::__DynamicallyInvokable]
	bool IsChanged
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	void AcceptChanges();
}
