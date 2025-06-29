namespace System.Runtime.Remoting;

internal class RemoteAppEntry
{
	private string _remoteAppName;

	private string _remoteAppURI;

	internal RemoteAppEntry(string appName, string appURI)
	{
		_remoteAppName = appName;
		_remoteAppURI = appURI;
	}

	internal string GetAppURI()
	{
		return _remoteAppURI;
	}
}
