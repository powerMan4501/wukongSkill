using System.Security.Permissions;

namespace System.Diagnostics.Eventing.Reader;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class EventLogStatus
{
	private string channelName;

	private int win32ErrorCode;

	public string LogName => channelName;

	public int StatusCode => win32ErrorCode;

	internal EventLogStatus(string channelName, int win32ErrorCode)
	{
		this.channelName = channelName;
		this.win32ErrorCode = win32ErrorCode;
	}
}
