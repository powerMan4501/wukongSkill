namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.Class)]
public sealed class ComplexBindingPropertiesAttribute : Attribute
{
	private readonly string dataSource;

	private readonly string dataMember;

	public static readonly ComplexBindingPropertiesAttribute Default = new ComplexBindingPropertiesAttribute();

	public string DataSource => dataSource;

	public string DataMember => dataMember;

	public ComplexBindingPropertiesAttribute()
	{
		dataSource = null;
		dataMember = null;
	}

	public ComplexBindingPropertiesAttribute(string dataSource)
	{
		this.dataSource = dataSource;
		dataMember = null;
	}

	public ComplexBindingPropertiesAttribute(string dataSource, string dataMember)
	{
		this.dataSource = dataSource;
		this.dataMember = dataMember;
	}

	public override bool Equals(object obj)
	{
		if (obj is ComplexBindingPropertiesAttribute complexBindingPropertiesAttribute && complexBindingPropertiesAttribute.DataSource == dataSource)
		{
			return complexBindingPropertiesAttribute.DataMember == dataMember;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}
}
