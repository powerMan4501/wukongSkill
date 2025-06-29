using System.Globalization;

namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.All)]
public sealed class TypeConverterAttribute : Attribute
{
	private string typeName;

	public static readonly TypeConverterAttribute Default = new TypeConverterAttribute();

	public string ConverterTypeName => typeName;

	public TypeConverterAttribute()
	{
		typeName = string.Empty;
	}

	public TypeConverterAttribute(Type type)
	{
		typeName = type.AssemblyQualifiedName;
	}

	public TypeConverterAttribute(string typeName)
	{
		string text = typeName.ToUpper(CultureInfo.InvariantCulture);
		this.typeName = typeName;
	}

	public override bool Equals(object obj)
	{
		if (obj is TypeConverterAttribute typeConverterAttribute)
		{
			return typeConverterAttribute.ConverterTypeName == typeName;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return typeName.GetHashCode();
	}
}
