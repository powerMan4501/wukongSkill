namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.All)]
public sealed class LocalizableAttribute : Attribute
{
	private bool isLocalizable;

	public static readonly LocalizableAttribute Yes = new LocalizableAttribute(isLocalizable: true);

	public static readonly LocalizableAttribute No = new LocalizableAttribute(isLocalizable: false);

	public static readonly LocalizableAttribute Default = No;

	public bool IsLocalizable => isLocalizable;

	public LocalizableAttribute(bool isLocalizable)
	{
		this.isLocalizable = isLocalizable;
	}

	public override bool IsDefaultAttribute()
	{
		return IsLocalizable == Default.IsLocalizable;
	}

	public override bool Equals(object obj)
	{
		if (obj is LocalizableAttribute localizableAttribute)
		{
			return localizableAttribute.IsLocalizable == isLocalizable;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}
}
