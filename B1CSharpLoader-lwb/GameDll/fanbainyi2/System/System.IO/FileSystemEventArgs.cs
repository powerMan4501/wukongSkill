namespace System.IO;

public class FileSystemEventArgs : EventArgs
{
	private WatcherChangeTypes changeType;

	private string name;

	private string fullPath;

	public WatcherChangeTypes ChangeType => changeType;

	public string FullPath => fullPath;

	public string Name => name;

	public FileSystemEventArgs(WatcherChangeTypes changeType, string directory, string name)
	{
		this.changeType = changeType;
		this.name = name;
		if (!directory.EndsWith("\\", StringComparison.Ordinal))
		{
			directory += "\\";
		}
		fullPath = directory + name;
	}
}
