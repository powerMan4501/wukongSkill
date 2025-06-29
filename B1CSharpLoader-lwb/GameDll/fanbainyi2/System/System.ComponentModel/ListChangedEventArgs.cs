using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public class ListChangedEventArgs : EventArgs
{
	private ListChangedType listChangedType;

	private int newIndex;

	private int oldIndex;

	private PropertyDescriptor propDesc;

	public ListChangedType ListChangedType => listChangedType;

	public int NewIndex => newIndex;

	public int OldIndex => oldIndex;

	public PropertyDescriptor PropertyDescriptor => propDesc;

	public ListChangedEventArgs(ListChangedType listChangedType, int newIndex)
		: this(listChangedType, newIndex, -1)
	{
	}

	public ListChangedEventArgs(ListChangedType listChangedType, int newIndex, PropertyDescriptor propDesc)
		: this(listChangedType, newIndex)
	{
		this.propDesc = propDesc;
		oldIndex = newIndex;
	}

	public ListChangedEventArgs(ListChangedType listChangedType, PropertyDescriptor propDesc)
	{
		this.listChangedType = listChangedType;
		this.propDesc = propDesc;
	}

	public ListChangedEventArgs(ListChangedType listChangedType, int newIndex, int oldIndex)
	{
		this.listChangedType = listChangedType;
		this.newIndex = newIndex;
		this.oldIndex = oldIndex;
	}
}
