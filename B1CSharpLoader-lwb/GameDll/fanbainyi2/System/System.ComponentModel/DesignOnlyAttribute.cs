namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.All)]
public sealed class DesignOnlyAttribute : Attribute
{
	private bool isDesignOnly;

	public static readonly DesignOnlyAttribute Yes = new DesignOnlyAttribute(isDesignOnly: true);

	public static readonly DesignOnlyAttribute No = new DesignOnlyAttribute(isDesignOnly: false);

	public static readonly DesignOnlyAttribute Default = No;

	public bool IsDesignOnly => isDesignOnly;

	public DesignOnlyAttribute(bool isDesignOnly)
	{
		this.isDesignOnly = isDesignOnly;
	}

	public override bool IsDefaultAttribute()
	{
		return IsDesignOnly == Default.IsDesignOnly;
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (obj is DesignOnlyAttribute designOnlyAttribute)
		{
			return designOnlyAttribute.isDesignOnly == isDesignOnly;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return isDesignOnly.GetHashCode();
	}
}
