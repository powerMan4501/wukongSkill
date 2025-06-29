using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public abstract class InstanceCreationEditor
{
	public virtual string Text => SR.GetString("InstanceCreationEditorDefaultText");

	public abstract object CreateInstance(ITypeDescriptorContext context, Type instanceType);
}
