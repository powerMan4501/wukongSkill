namespace System.Configuration;

[AttributeUsage(AttributeTargets.Class)]
public sealed class SettingsGroupDescriptionAttribute : Attribute
{
	private readonly string _desc;

	public string Description => _desc;

	public SettingsGroupDescriptionAttribute(string description)
	{
		_desc = description;
	}
}
