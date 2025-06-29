using System.Runtime.Remoting.Channels;
using System.Security;

namespace System.Runtime.Remoting;

[Serializable]
internal sealed class ChannelInfo : IChannelInfo
{
	private object[] channelData;

	public object[] ChannelData
	{
		[SecurityCritical]
		get
		{
			return channelData;
		}
		[SecurityCritical]
		set
		{
			channelData = value;
		}
	}

	[SecurityCritical]
	internal ChannelInfo()
	{
		ChannelData = ChannelServices.CurrentChannelData;
	}
}
