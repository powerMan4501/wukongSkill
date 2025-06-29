using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public abstract class ContainerFilterService
{
	public virtual ComponentCollection FilterComponents(ComponentCollection components)
	{
		return components;
	}
}
