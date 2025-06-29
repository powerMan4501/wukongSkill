namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.Class)]
public sealed class LookupBindingPropertiesAttribute : Attribute
{
	private readonly string dataSource;

	private readonly string displayMember;

	private readonly string valueMember;

	private readonly string lookupMember;

	public static readonly LookupBindingPropertiesAttribute Default = new LookupBindingPropertiesAttribute();

	public string DataSource => dataSource;

	public string DisplayMember => displayMember;

	public string ValueMember => valueMember;

	public string LookupMember => lookupMember;

	public LookupBindingPropertiesAttribute()
	{
		dataSource = null;
		displayMember = null;
		valueMember = null;
		lookupMember = null;
	}

	public LookupBindingPropertiesAttribute(string dataSource, string displayMember, string valueMember, string lookupMember)
	{
		this.dataSource = dataSource;
		this.displayMember = displayMember;
		this.valueMember = valueMember;
		this.lookupMember = lookupMember;
	}

	public override bool Equals(object obj)
	{
		if (obj is LookupBindingPropertiesAttribute lookupBindingPropertiesAttribute && lookupBindingPropertiesAttribute.DataSource == dataSource && lookupBindingPropertiesAttribute.displayMember == displayMember && lookupBindingPropertiesAttribute.valueMember == valueMember)
		{
			return lookupBindingPropertiesAttribute.lookupMember == lookupMember;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}
}
