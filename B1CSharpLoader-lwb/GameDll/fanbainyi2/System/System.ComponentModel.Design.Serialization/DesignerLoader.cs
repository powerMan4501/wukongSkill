using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.ComponentModel.Design.Serialization;

[ComVisible(true)]
[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public abstract class DesignerLoader
{
	public virtual bool Loading => false;

	public abstract void BeginLoad(IDesignerLoaderHost host);

	public abstract void Dispose();

	public virtual void Flush()
	{
	}
}
