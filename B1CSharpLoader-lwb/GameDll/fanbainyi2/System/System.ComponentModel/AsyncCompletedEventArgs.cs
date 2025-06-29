using System.Reflection;
using System.Security.Permissions;

namespace System.ComponentModel;

[global::__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public class AsyncCompletedEventArgs : EventArgs
{
	private readonly Exception error;

	private readonly bool cancelled;

	private readonly object userState;

	[SRDescription("Async_AsyncEventArgs_Cancelled")]
	[global::__DynamicallyInvokable]
	public bool Cancelled
	{
		[global::__DynamicallyInvokable]
		get
		{
			return cancelled;
		}
	}

	[SRDescription("Async_AsyncEventArgs_Error")]
	[global::__DynamicallyInvokable]
	public Exception Error
	{
		[global::__DynamicallyInvokable]
		get
		{
			return error;
		}
	}

	[SRDescription("Async_AsyncEventArgs_UserState")]
	[global::__DynamicallyInvokable]
	public object UserState
	{
		[global::__DynamicallyInvokable]
		get
		{
			return userState;
		}
	}

	[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public AsyncCompletedEventArgs()
	{
	}

	[global::__DynamicallyInvokable]
	public AsyncCompletedEventArgs(Exception error, bool cancelled, object userState)
	{
		this.error = error;
		this.cancelled = cancelled;
		this.userState = userState;
	}

	[global::__DynamicallyInvokable]
	protected void RaiseExceptionIfNecessary()
	{
		if (Error != null)
		{
			throw new TargetInvocationException(SR.GetString("Async_ExceptionOccurred"), Error);
		}
		if (Cancelled)
		{
			throw new InvalidOperationException(SR.GetString("Async_OperationCancelled"));
		}
	}
}
