using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.ComponentModel.Design;

[ComVisible(true)]
[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public class ComponentEventArgs : EventArgs
{
	private IComponent component;

	public virtual IComponent Component => component;

	public ComponentEventArgs(IComponent component)
	{
		this.component = component;
	}
}
