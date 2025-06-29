namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.All)]
public sealed class BrowsableAttribute : Attribute
{
	public static readonly BrowsableAttribute Yes = new BrowsableAttribute(browsable: true);

	public static readonly BrowsableAttribute No = new BrowsableAttribute(browsable: false);

	public static readonly BrowsableAttribute Default = Yes;

	private bool browsable = true;

	public bool Browsable => browsable;

	public BrowsableAttribute(bool browsable)
	{
		this.browsable = browsable;
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (obj is BrowsableAttribute browsableAttribute)
		{
			return browsableAttribute.Browsable == browsable;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return browsable.GetHashCode();
	}

	public override bool IsDefaultAttribute()
	{
		return Equals(Default);
	}
}
