namespace System.Diagnostics;

public class EntryWrittenEventArgs : EventArgs
{
	private EventLogEntry entry;

	public EventLogEntry Entry => entry;

	public EntryWrittenEventArgs()
	{
	}

	public EntryWrittenEventArgs(EventLogEntry entry)
	{
		this.entry = entry;
	}
}
