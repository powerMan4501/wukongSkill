using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Permissions;

namespace b1.Protobuf.DataAPI;

public abstract class BG_FileWatcher
{
	public delegate void Del_OnWatcherTriggered(in string fileFullPath);

	private ushort _allowedMinOpsInterval = 2000;

	private Dictionary<string, long> _fileTimestampDictionary = new Dictionary<string, long>();

	protected Del_OnWatcherTriggered _delOnWatcherTriggered;

	protected FileSystemWatcher _watcher;

	protected virtual bool IsOpAllowed(string fileName)
	{
		if (fileName.Contains("~$"))
		{
			return false;
		}
		long num = DateTimeOffset.Now.ToUnixTimeMilliseconds();
		if (!_fileTimestampDictionary.ContainsKey(fileName) || num - _fileTimestampDictionary[fileName] >= _allowedMinOpsInterval)
		{
			_fileTimestampDictionary[fileName] = num;
			return true;
		}
		return false;
	}

	protected abstract void OnTriggered(object source, FileSystemEventArgs e);

	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public virtual void StartWatching(Del_OnWatcherTriggered del)
	{
		_delOnWatcherTriggered = del;
		_watcher.EnableRaisingEvents = true;
	}

	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public virtual void StopWatching(Del_OnWatcherTriggered del)
	{
		_delOnWatcherTriggered = null;
		_watcher.EnableRaisingEvents = false;
	}
}
