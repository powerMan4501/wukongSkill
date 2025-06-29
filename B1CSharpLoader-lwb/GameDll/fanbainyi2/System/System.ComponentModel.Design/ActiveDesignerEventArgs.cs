using System.Security.Permissions;

namespace System.ComponentModel.Design;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public class ActiveDesignerEventArgs : EventArgs
{
	private readonly IDesignerHost oldDesigner;

	private readonly IDesignerHost newDesigner;

	public IDesignerHost OldDesigner => oldDesigner;

	public IDesignerHost NewDesigner => newDesigner;

	public ActiveDesignerEventArgs(IDesignerHost oldDesigner, IDesignerHost newDesigner)
	{
		this.oldDesigner = oldDesigner;
		this.newDesigner = newDesigner;
	}
}
