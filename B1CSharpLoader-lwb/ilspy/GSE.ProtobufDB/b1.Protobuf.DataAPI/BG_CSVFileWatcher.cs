using System.IO;

namespace b1.Protobuf.DataAPI;

public class BG_CSVFileWatcher : BG_FileWatcher
{
	private static BG_CSVFileWatcher _instance;

	private string _tempKeyword;

	private bool _bEnableOffice365Mode;

	public static BG_CSVFileWatcher Get()
	{
		if (_instance == null)
		{
			_instance = new BG_CSVFileWatcher();
		}
		return _instance;
	}

	private BG_CSVFileWatcher()
	{
		_watcher = new FileSystemWatcher
		{
			Path = (_bEnableOffice365Mode ? BG_ProtobufDataLoader.Get().GetTableCSVFolder() : BG_ProtobufDataLoader.Get().GetTableRootPath()),
			NotifyFilter = NotifyFilters.FileName,
			Filter = "*.csv",
			IncludeSubdirectories = true
		};
		_tempKeyword = "-temp";
	}

	protected bool IsDesiredFiles(string fileFullPath)
	{
		if (!_bEnableOffice365Mode)
		{
			string[] tableFolders = BG_ProtobufDataLoader.Get().GetTableFolders();
			bool flag = false;
			string[] array = tableFolders;
			foreach (string value in array)
			{
				flag |= fileFullPath.Contains(value);
			}
			return flag;
		}
		string tableCSVFolder = BG_ProtobufDataLoader.Get().GetTableCSVFolder();
		return fileFullPath.Contains(tableCSVFolder);
	}

	protected override void OnTriggered(object source, FileSystemEventArgs e)
	{
		if (IsOpAllowed(e.Name) && IsDesiredFiles(e.FullPath) && !e.Name.Contains(_tempKeyword))
		{
			_delOnWatcherTriggered(e.FullPath);
		}
	}

	public void SetEnableOffice365Mode(bool bEnable)
	{
		_bEnableOffice365Mode = bEnable;
		_watcher.Path = (_bEnableOffice365Mode ? BG_ProtobufDataLoader.Get().GetTableCSVFolder() : BG_ProtobufDataLoader.Get().GetTableRootPath());
	}

	public override void StartWatching(Del_OnWatcherTriggered del)
	{
		_watcher.Renamed += OnTriggered;
		base.StartWatching(del);
	}

	public override void StopWatching(Del_OnWatcherTriggered del)
	{
		_watcher.Renamed -= OnTriggered;
		base.StopWatching(del);
	}
}
