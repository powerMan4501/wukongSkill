namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.All)]
public sealed class ReadOnlyAttribute : Attribute
{
	private bool isReadOnly;

	public static readonly ReadOnlyAttribute Yes = new ReadOnlyAttribute(isReadOnly: true);

	public static readonly ReadOnlyAttribute No = new ReadOnlyAttribute(isReadOnly: false);

	public static readonly ReadOnlyAttribute Default = No;

	public bool IsReadOnly => isReadOnly;

	public ReadOnlyAttribute(bool isReadOnly)
	{
		this.isReadOnly = isReadOnly;
	}

	public override bool Equals(object value)
	{
		if (this == value)
		{
			return true;
		}
		if (value is ReadOnlyAttribute readOnlyAttribute)
		{
			return readOnlyAttribute.IsReadOnly == IsReadOnly;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	public override bool IsDefaultAttribute()
	{
		return IsReadOnly == Default.IsReadOnly;
	}
}
