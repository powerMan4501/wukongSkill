using System.Security.Permissions;
using System.Threading;

namespace System.ComponentModel;

[global::__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public static class AsyncOperationManager
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[global::__DynamicallyInvokable]
	public static SynchronizationContext SynchronizationContext
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (SynchronizationContext.Current == null)
			{
				SynchronizationContext.SetSynchronizationContext(new SynchronizationContext());
			}
			return SynchronizationContext.Current;
		}
		[global::__DynamicallyInvokable]
		[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
		set
		{
			SynchronizationContext.SetSynchronizationContext(value);
		}
	}

	[global::__DynamicallyInvokable]
	public static AsyncOperation CreateOperation(object userSuppliedState)
	{
		return AsyncOperation.CreateOperation(userSuppliedState, SynchronizationContext);
	}
}
