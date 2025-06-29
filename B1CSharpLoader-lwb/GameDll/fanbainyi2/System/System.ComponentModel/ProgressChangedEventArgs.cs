using System.Security.Permissions;

namespace System.ComponentModel;

[global::__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public class ProgressChangedEventArgs : EventArgs
{
	private readonly int progressPercentage;

	private readonly object userState;

	[SRDescription("Async_ProgressChangedEventArgs_ProgressPercentage")]
	[global::__DynamicallyInvokable]
	public int ProgressPercentage
	{
		[global::__DynamicallyInvokable]
		get
		{
			return progressPercentage;
		}
	}

	[SRDescription("Async_ProgressChangedEventArgs_UserState")]
	[global::__DynamicallyInvokable]
	public object UserState
	{
		[global::__DynamicallyInvokable]
		get
		{
			return userState;
		}
	}

	[global::__DynamicallyInvokable]
	public ProgressChangedEventArgs(int progressPercentage, object userState)
	{
		this.progressPercentage = progressPercentage;
		this.userState = userState;
	}
}
