using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public abstract class License : IDisposable
{
	public abstract string LicenseKey { get; }

	public abstract void Dispose();
}
