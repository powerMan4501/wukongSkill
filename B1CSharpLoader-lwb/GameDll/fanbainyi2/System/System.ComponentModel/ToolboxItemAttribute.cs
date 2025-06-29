using System.Globalization;

namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.All)]
public class ToolboxItemAttribute : Attribute
{
	private Type toolboxItemType;

	private string toolboxItemTypeName;

	public static readonly ToolboxItemAttribute Default = new ToolboxItemAttribute("System.Drawing.Design.ToolboxItem, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");

	public static readonly ToolboxItemAttribute None = new ToolboxItemAttribute(defaultType: false);

	public Type ToolboxItemType
	{
		get
		{
			if (toolboxItemType == null && toolboxItemTypeName != null)
			{
				try
				{
					toolboxItemType = Type.GetType(toolboxItemTypeName, throwOnError: true);
				}
				catch (Exception innerException)
				{
					throw new ArgumentException(SR.GetString("ToolboxItemAttributeFailedGetType", toolboxItemTypeName), innerException);
				}
			}
			return toolboxItemType;
		}
	}

	public string ToolboxItemTypeName
	{
		get
		{
			if (toolboxItemTypeName == null)
			{
				return string.Empty;
			}
			return toolboxItemTypeName;
		}
	}

	public override bool IsDefaultAttribute()
	{
		return Equals(Default);
	}

	public ToolboxItemAttribute(bool defaultType)
	{
		if (defaultType)
		{
			toolboxItemTypeName = "System.Drawing.Design.ToolboxItem, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
		}
	}

	public ToolboxItemAttribute(string toolboxItemTypeName)
	{
		string text = toolboxItemTypeName.ToUpper(CultureInfo.InvariantCulture);
		this.toolboxItemTypeName = toolboxItemTypeName;
	}

	public ToolboxItemAttribute(Type toolboxItemType)
	{
		this.toolboxItemType = toolboxItemType;
		toolboxItemTypeName = toolboxItemType.AssemblyQualifiedName;
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (obj is ToolboxItemAttribute toolboxItemAttribute)
		{
			return toolboxItemAttribute.ToolboxItemTypeName == ToolboxItemTypeName;
		}
		return false;
	}

	public override int GetHashCode()
	{
		if (toolboxItemTypeName != null)
		{
			return toolboxItemTypeName.GetHashCode();
		}
		return base.GetHashCode();
	}
}
