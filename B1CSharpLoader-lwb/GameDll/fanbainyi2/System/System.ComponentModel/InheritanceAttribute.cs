namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event)]
public sealed class InheritanceAttribute : Attribute
{
	private readonly InheritanceLevel inheritanceLevel;

	public static readonly InheritanceAttribute Inherited = new InheritanceAttribute(InheritanceLevel.Inherited);

	public static readonly InheritanceAttribute InheritedReadOnly = new InheritanceAttribute(InheritanceLevel.InheritedReadOnly);

	public static readonly InheritanceAttribute NotInherited = new InheritanceAttribute(InheritanceLevel.NotInherited);

	public static readonly InheritanceAttribute Default = NotInherited;

	public InheritanceLevel InheritanceLevel => inheritanceLevel;

	public InheritanceAttribute()
	{
		inheritanceLevel = Default.inheritanceLevel;
	}

	public InheritanceAttribute(InheritanceLevel inheritanceLevel)
	{
		this.inheritanceLevel = inheritanceLevel;
	}

	public override bool Equals(object value)
	{
		if (value == this)
		{
			return true;
		}
		if (!(value is InheritanceAttribute))
		{
			return false;
		}
		InheritanceLevel inheritanceLevel = ((InheritanceAttribute)value).InheritanceLevel;
		return inheritanceLevel == this.inheritanceLevel;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	public override bool IsDefaultAttribute()
	{
		return Equals(Default);
	}

	public override string ToString()
	{
		return TypeDescriptor.GetConverter(typeof(InheritanceLevel)).ConvertToString(InheritanceLevel);
	}
}
