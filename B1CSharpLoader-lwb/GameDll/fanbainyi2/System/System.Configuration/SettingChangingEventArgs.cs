using System.ComponentModel;

namespace System.Configuration;

public class SettingChangingEventArgs : CancelEventArgs
{
	private string _settingClass;

	private string _settingName;

	private string _settingKey;

	private object _newValue;

	public object NewValue => _newValue;

	public string SettingClass => _settingClass;

	public string SettingName => _settingName;

	public string SettingKey => _settingKey;

	public SettingChangingEventArgs(string settingName, string settingClass, string settingKey, object newValue, bool cancel)
		: base(cancel)
	{
		_settingName = settingName;
		_settingClass = settingClass;
		_settingKey = settingKey;
		_newValue = newValue;
	}
}
