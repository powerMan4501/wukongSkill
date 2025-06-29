namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.Class)]
public sealed class DefaultPropertyAttribute : Attribute
{
	private readonly string name;

	public static readonly DefaultPropertyAttribute Default = new DefaultPropertyAttribute(null);

	public string Name => name;

	public DefaultPropertyAttribute(string name)
	{
		this.name = name;
	}

	public override bool Equals(object obj)
	{
		if (obj is DefaultPropertyAttribute defaultPropertyAttribute)
		{
			return defaultPropertyAttribute.Name == name;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}
}
