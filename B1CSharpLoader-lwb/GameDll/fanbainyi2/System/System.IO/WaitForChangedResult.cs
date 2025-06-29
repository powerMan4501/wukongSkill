namespace System.IO;

public struct WaitForChangedResult
{
	private WatcherChangeTypes changeType;

	private string name;

	private string oldName;

	private bool timedOut;

	internal static readonly WaitForChangedResult TimedOutResult = new WaitForChangedResult((WatcherChangeTypes)0, null, timedOut: true);

	public WatcherChangeTypes ChangeType
	{
		get
		{
			return changeType;
		}
		set
		{
			changeType = value;
		}
	}

	public string Name
	{
		get
		{
			return name;
		}
		set
		{
			name = value;
		}
	}

	public string OldName
	{
		get
		{
			return oldName;
		}
		set
		{
			oldName = value;
		}
	}

	public bool TimedOut
	{
		get
		{
			return timedOut;
		}
		set
		{
			timedOut = value;
		}
	}

	internal WaitForChangedResult(WatcherChangeTypes changeType, string name, bool timedOut)
		: this(changeType, name, null, timedOut)
	{
	}

	internal WaitForChangedResult(WatcherChangeTypes changeType, string name, string oldName, bool timedOut)
	{
		this.changeType = changeType;
		this.name = name;
		this.oldName = oldName;
		this.timedOut = timedOut;
	}
}
