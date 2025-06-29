namespace System.Diagnostics.Eventing.Reader;

public class EventLogQuery
{
	private string query;

	private string path;

	private EventLogSession session;

	private PathType pathType;

	private bool tolerateErrors;

	private bool reverseDirection;

	public EventLogSession Session
	{
		get
		{
			return session;
		}
		set
		{
			session = value;
		}
	}

	public bool TolerateQueryErrors
	{
		get
		{
			return tolerateErrors;
		}
		set
		{
			tolerateErrors = value;
		}
	}

	public bool ReverseDirection
	{
		get
		{
			return reverseDirection;
		}
		set
		{
			reverseDirection = value;
		}
	}

	internal string Path => path;

	internal PathType ThePathType => pathType;

	internal string Query => query;

	public EventLogQuery(string path, PathType pathType)
		: this(path, pathType, null)
	{
	}

	public EventLogQuery(string path, PathType pathType, string query)
	{
		session = EventLogSession.GlobalSession;
		this.path = path;
		this.pathType = pathType;
		if (query == null)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
		}
		else
		{
			this.query = query;
		}
	}
}
