using System.Security.Permissions;

namespace System.IO;

public class RenamedEventArgs : FileSystemEventArgs
{
	private string oldName;

	private string oldFullPath;

	public string OldFullPath
	{
		get
		{
			new FileIOPermission(FileIOPermissionAccess.Read, Path.GetPathRoot(oldFullPath)).Demand();
			return oldFullPath;
		}
	}

	public string OldName => oldName;

	public RenamedEventArgs(WatcherChangeTypes changeType, string directory, string name, string oldName)
		: base(changeType, directory, name)
	{
		if (!directory.EndsWith("\\", StringComparison.Ordinal))
		{
			directory += "\\";
		}
		this.oldName = oldName;
		oldFullPath = directory + oldName;
	}
}
