using System.Collections;

namespace System.ComponentModel;

[global::__DynamicallyInvokable]
public interface INotifyDataErrorInfo
{
	[global::__DynamicallyInvokable]
	bool HasErrors
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

	[global::__DynamicallyInvokable]
	IEnumerable GetErrors(string propertyName);
}
