namespace System.Configuration;

[AttributeUsage(AttributeTargets.Property)]
public sealed class DefaultSettingValueAttribute : Attribute
{
	private readonly string _value;

	public string Value => _value;

	public DefaultSettingValueAttribute(string value)
	{
		_value = value;
	}
}
