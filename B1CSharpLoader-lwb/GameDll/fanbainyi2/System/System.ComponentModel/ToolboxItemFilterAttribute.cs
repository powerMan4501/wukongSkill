namespace System.ComponentModel;

[Serializable]
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
public sealed class ToolboxItemFilterAttribute : Attribute
{
	private ToolboxItemFilterType filterType;

	private string filterString;

	private string typeId;

	public string FilterString => filterString;

	public ToolboxItemFilterType FilterType => filterType;

	public override object TypeId
	{
		get
		{
			if (typeId == null)
			{
				typeId = GetType().FullName + filterString;
			}
			return typeId;
		}
	}

	public ToolboxItemFilterAttribute(string filterString)
		: this(filterString, ToolboxItemFilterType.Allow)
	{
	}

	public ToolboxItemFilterAttribute(string filterString, ToolboxItemFilterType filterType)
	{
		if (filterString == null)
		{
			filterString = string.Empty;
		}
		this.filterString = filterString;
		this.filterType = filterType;
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (obj is ToolboxItemFilterAttribute { FilterType: var toolboxItemFilterType } toolboxItemFilterAttribute && toolboxItemFilterType.Equals(FilterType))
		{
			return toolboxItemFilterAttribute.FilterString.Equals(FilterString);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return filterString.GetHashCode();
	}

	public override bool Match(object obj)
	{
		if (!(obj is ToolboxItemFilterAttribute toolboxItemFilterAttribute))
		{
			return false;
		}
		if (!toolboxItemFilterAttribute.FilterString.Equals(FilterString))
		{
			return false;
		}
		return true;
	}

	public override string ToString()
	{
		return filterString + "," + Enum.GetName(typeof(ToolboxItemFilterType), filterType);
	}
}
