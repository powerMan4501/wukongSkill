using System.Security.Permissions;

namespace System.ComponentModel.Design;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public class DesignerEventArgs : EventArgs
{
	private readonly IDesignerHost host;

	public IDesignerHost Designer => host;

	public DesignerEventArgs(IDesignerHost host)
	{
		this.host = host;
	}
}
