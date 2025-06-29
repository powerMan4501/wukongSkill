namespace System.ComponentModel;

[global::__DynamicallyInvokable]
public interface IRevertibleChangeTracking : IChangeTracking
{
	[global::__DynamicallyInvokable]
	void RejectChanges();
}
