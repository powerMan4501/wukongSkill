using System.Security.Permissions;

namespace System.ComponentModel;

public interface ISynchronizeInvoke
{
	bool InvokeRequired { get; }

	[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
	IAsyncResult BeginInvoke(Delegate method, object[] args);

	object EndInvoke(IAsyncResult result);

	object Invoke(Delegate method, object[] args);
}
