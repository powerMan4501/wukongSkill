using System.Security.Permissions;

namespace System.ComponentModel;

[global::__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public class DataErrorsChangedEventArgs : EventArgs
{
	private readonly string propertyName;

	[global::__DynamicallyInvokable]
	public virtual string PropertyName
	{
		[global::__DynamicallyInvokable]
		get
		{
			return propertyName;
		}
	}

	[global::__DynamicallyInvokable]
	public DataErrorsChangedEventArgs(string propertyName)
	{
		this.propertyName = propertyName;
	}
}
