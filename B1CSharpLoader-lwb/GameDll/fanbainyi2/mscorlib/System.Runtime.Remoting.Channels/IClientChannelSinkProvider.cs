using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.Remoting.Channels;

[ComVisible(true)]
public interface IClientChannelSinkProvider
{
	IClientChannelSinkProvider Next
	{
		[SecurityCritical]
		get;
		[SecurityCritical]
		set;
	}

	[SecurityCritical]
	IClientChannelSink CreateSink(IChannelSender channel, string url, object remoteChannelData);
}
