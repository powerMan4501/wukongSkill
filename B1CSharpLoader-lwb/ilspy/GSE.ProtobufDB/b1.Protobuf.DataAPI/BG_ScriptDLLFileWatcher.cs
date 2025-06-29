using System.IO;
using UnrealEngine.Engine;

namespace b1.Protobuf.DataAPI;

public class BG_ScriptDLLFileWatcher : BG_FileWatcher
{
	private static BG_ScriptDLLFileWatcher _instance;

	public static BG_ScriptDLLFileWatcher Get()
	{
		if (_instance == null)
		{
			_instance = new BG_ScriptDLLFileWatcher();
		}
		return _instance;
	}

	private BG_ScriptDLLFileWatcher()
	{
		_watcher = new FileSystemWatcher
		{
			Path = USystemLibrary.GetProjectDirectory().Replace("/", "\\") + "Binaries\\Managed\\",
			NotifyFilter = NotifyFilters.LastAccess,
			Filter = "Protobuf.RunTime.dll"
		};
	}

	public override void StartWatching(Del_OnWatcherTriggered del)
	{
		_watcher.Changed += OnTriggered;
		base.StartWatching(del);
	}

	public override void StopWatching(Del_OnWatcherTriggered del)
	{
		_watcher.Changed -= OnTriggered;
		base.StartWatching(del);
	}

	protected override void OnTriggered(object source, FileSystemEventArgs e)
	{
		if (IsOpAllowed(e.Name))
		{
			_delOnWatcherTriggered(e.FullPath);
		}
	}
}
