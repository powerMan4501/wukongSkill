using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.ComponentModel.Design;

[ComVisible(true)]
[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
public sealed class ComponentChangedEventArgs : EventArgs
{
	private object component;

	private MemberDescriptor member;

	private object oldValue;

	private object newValue;

	public object Component => component;

	public MemberDescriptor Member => member;

	public object NewValue => newValue;

	public object OldValue => oldValue;

	public ComponentChangedEventArgs(object component, MemberDescriptor member, object oldValue, object newValue)
	{
		this.component = component;
		this.member = member;
		this.oldValue = oldValue;
		this.newValue = newValue;
	}
}
