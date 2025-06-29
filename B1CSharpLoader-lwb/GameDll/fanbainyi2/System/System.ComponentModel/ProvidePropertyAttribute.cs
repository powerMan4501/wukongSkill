namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class ProvidePropertyAttribute : Attribute
{
	private readonly string propertyName;

	private readonly string receiverTypeName;

	public string PropertyName => propertyName;

	public string ReceiverTypeName => receiverTypeName;

	public override object TypeId => GetType().FullName + propertyName;

	public ProvidePropertyAttribute(string propertyName, Type receiverType)
	{
		this.propertyName = propertyName;
		receiverTypeName = receiverType.AssemblyQualifiedName;
	}

	public ProvidePropertyAttribute(string propertyName, string receiverTypeName)
	{
		this.propertyName = propertyName;
		this.receiverTypeName = receiverTypeName;
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (obj is ProvidePropertyAttribute providePropertyAttribute && providePropertyAttribute.propertyName == propertyName)
		{
			return providePropertyAttribute.receiverTypeName == receiverTypeName;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return propertyName.GetHashCode() ^ receiverTypeName.GetHashCode();
	}
}
