using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.Remoting.Channels;

[ComVisible(true)]
public interface IServerChannelSinkProvider
{
	IServerChannelSinkProvider Next
	{
		[SecurityCritical]
		get;
		[SecurityCritical]
		set;
	}

	[SecurityCritical]
	void GetChannelData(IChannelDataStore channelData);

	[SecurityCritical]
	IServerChannelSink CreateSink(IChannelReceiver channel);
}
