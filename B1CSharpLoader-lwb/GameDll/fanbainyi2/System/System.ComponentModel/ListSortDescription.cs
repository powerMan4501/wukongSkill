using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public class ListSortDescription
{
	private PropertyDescriptor property;

	private ListSortDirection sortDirection;

	public PropertyDescriptor PropertyDescriptor
	{
		get
		{
			return property;
		}
		set
		{
			property = value;
		}
	}

	public ListSortDirection SortDirection
	{
		get
		{
			return sortDirection;
		}
		set
		{
			sortDirection = value;
		}
	}

	public ListSortDescription(PropertyDescriptor property, ListSortDirection direction)
	{
		this.property = property;
		sortDirection = direction;
	}
}
