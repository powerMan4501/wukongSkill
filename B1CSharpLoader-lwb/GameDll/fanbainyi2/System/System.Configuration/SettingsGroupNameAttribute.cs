namespace System.Configuration;

[AttributeUsage(AttributeTargets.Class)]
public sealed class SettingsGroupNameAttribute : Attribute
{
	private readonly string _groupName;

	public string GroupName => _groupName;

	public SettingsGroupNameAttribute(string groupName)
	{
		_groupName = groupName;
	}
}
