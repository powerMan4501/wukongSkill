namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.All)]
public sealed class ImmutableObjectAttribute : Attribute
{
	public static readonly ImmutableObjectAttribute Yes = new ImmutableObjectAttribute(immutable: true);

	public static readonly ImmutableObjectAttribute No = new ImmutableObjectAttribute(immutable: false);

	public static readonly ImmutableObjectAttribute Default = No;

	private bool immutable = true;

	public bool Immutable => immutable;

	public ImmutableObjectAttribute(bool immutable)
	{
		this.immutable = immutable;
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (obj is ImmutableObjectAttribute immutableObjectAttribute)
		{
			return immutableObjectAttribute.Immutable == immutable;
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
