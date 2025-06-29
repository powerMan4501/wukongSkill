using System.Security.Permissions;

namespace System.ComponentModel.Design.Serialization;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public class ResolveNameEventArgs : EventArgs
{
	private string name;

	private object value;

	public string Name => name;

	public object Value
	{
		get
		{
			return value;
		}
		set
		{
			this.value = value;
		}
	}

	public ResolveNameEventArgs(string name)
	{
		this.name = name;
		value = null;
	}
}
