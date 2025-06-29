namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
public sealed class DesignerCategoryAttribute : Attribute
{
	private string category;

	private string typeId;

	public static readonly DesignerCategoryAttribute Component = new DesignerCategoryAttribute("Component");

	public static readonly DesignerCategoryAttribute Default = new DesignerCategoryAttribute();

	public static readonly DesignerCategoryAttribute Form = new DesignerCategoryAttribute("Form");

	public static readonly DesignerCategoryAttribute Generic = new DesignerCategoryAttribute("Designer");

	public string Category => category;

	public override object TypeId
	{
		get
		{
			if (typeId == null)
			{
				typeId = GetType().FullName + Category;
			}
			return typeId;
		}
	}

	public DesignerCategoryAttribute()
	{
		category = string.Empty;
	}

	public DesignerCategoryAttribute(string category)
	{
		this.category = category;
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (obj is DesignerCategoryAttribute designerCategoryAttribute)
		{
			return designerCategoryAttribute.category == category;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return category.GetHashCode();
	}

	public override bool IsDefaultAttribute()
	{
		return category.Equals(Default.Category);
	}
}
