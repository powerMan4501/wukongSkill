namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.All)]
public sealed class MergablePropertyAttribute : Attribute
{
	public static readonly MergablePropertyAttribute Yes = new MergablePropertyAttribute(allowMerge: true);

	public static readonly MergablePropertyAttribute No = new MergablePropertyAttribute(allowMerge: false);

	public static readonly MergablePropertyAttribute Default = Yes;

	private bool allowMerge;

	public bool AllowMerge => allowMerge;

	public MergablePropertyAttribute(bool allowMerge)
	{
		this.allowMerge = allowMerge;
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (obj is MergablePropertyAttribute mergablePropertyAttribute)
		{
			return mergablePropertyAttribute.AllowMerge == allowMerge;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	public override bool IsDefaultAttribute()
	{
		return Equals(Default);
	}
}
