using System.Security.Permissions;

namespace System.Diagnostics.Eventing.Reader;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class EventRecordWrittenEventArgs : EventArgs
{
	private EventRecord record;

	private Exception exception;

	public EventRecord EventRecord => record;

	public Exception EventException => exception;

	internal EventRecordWrittenEventArgs(EventLogRecord record)
	{
		this.record = record;
	}

	internal EventRecordWrittenEventArgs(Exception exception)
	{
		this.exception = exception;
	}
}
