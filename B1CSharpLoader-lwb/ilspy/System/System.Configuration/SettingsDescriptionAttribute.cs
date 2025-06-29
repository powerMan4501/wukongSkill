namespace System.Configuration;

[AttributeUsage(AttributeTargets.Property)]
public sealed class SettingsDescriptionAttribute : Attribute
{
	private readonly string _desc;

	public string Description => _desc;

	public SettingsDescriptionAttribute(string description)
	{
		_desc = description;
	}
}
