namespace System.ComponentModel;

[global::__DynamicallyInvokable]
public interface IEditableObject
{
	[global::__DynamicallyInvokable]
	void BeginEdit();

	[global::__DynamicallyInvokable]
	void EndEdit();

	[global::__DynamicallyInvokable]
	void CancelEdit();
}
