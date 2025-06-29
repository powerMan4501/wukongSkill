namespace System.Configuration;

public class SettingsLoadedEventArgs : EventArgs
{
	private SettingsProvider _provider;

	public SettingsProvider Provider => _provider;

	public SettingsLoadedEventArgs(SettingsProvider provider)
	{
		_provider = provider;
	}
}
