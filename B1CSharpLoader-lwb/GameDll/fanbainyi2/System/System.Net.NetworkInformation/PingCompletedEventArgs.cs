using System.ComponentModel;

namespace System.Net.NetworkInformation;

public class PingCompletedEventArgs : AsyncCompletedEventArgs
{
	private PingReply reply;

	public PingReply Reply => reply;

	internal PingCompletedEventArgs(PingReply reply, Exception error, bool cancelled, object userToken)
		: base(error, cancelled, userToken)
	{
		this.reply = reply;
	}
}
