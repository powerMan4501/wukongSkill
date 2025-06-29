using System.Security.Permissions;

namespace System.ComponentModel;

[global::__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public class RunWorkerCompletedEventArgs : AsyncCompletedEventArgs
{
	private object result;

	[global::__DynamicallyInvokable]
	public object Result
	{
		[global::__DynamicallyInvokable]
		get
		{
			RaiseExceptionIfNecessary();
			return result;
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[global::__DynamicallyInvokable]
	public new object UserState
	{
		[global::__DynamicallyInvokable]
		get
		{
			return base.UserState;
		}
	}

	[global::__DynamicallyInvokable]
	public RunWorkerCompletedEventArgs(object result, Exception error, bool cancelled)
		: base(error, cancelled, null)
	{
		this.result = result;
	}
}
