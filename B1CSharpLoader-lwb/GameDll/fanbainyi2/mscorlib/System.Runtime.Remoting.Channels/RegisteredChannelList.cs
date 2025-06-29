using System.Security;

namespace System.Runtime.Remoting.Channels;

internal class RegisteredChannelList
{
	private RegisteredChannel[] _channels;

	internal RegisteredChannel[] RegisteredChannels => _channels;

	internal int Count
	{
		get
		{
			if (_channels == null)
			{
				return 0;
			}
			return _channels.Length;
		}
	}

	internal int ReceiverCount
	{
		get
		{
			if (_channels == null)
			{
				return 0;
			}
			int num = 0;
			for (int i = 0; i < _channels.Length; i++)
			{
				if (IsReceiver(i))
				{
					num++;
				}
			}
			return num;
		}
	}

	internal RegisteredChannelList()
	{
		_channels = new RegisteredChannel[0];
	}

	internal RegisteredChannelList(RegisteredChannel[] channels)
	{
		_channels = channels;
	}

	internal IChannel GetChannel(int index)
	{
		return _channels[index].Channel;
	}

	internal bool IsSender(int index)
	{
		return _channels[index].IsSender();
	}

	internal bool IsReceiver(int index)
	{
		return _channels[index].IsReceiver();
	}

	internal int FindChannelIndex(IChannel channel)
	{
		for (int i = 0; i < _channels.Length; i++)
		{
			if (channel == GetChannel(i))
			{
				return i;
			}
		}
		return -1;
	}

	[SecurityCritical]
	internal int FindChannelIndex(string name)
	{
		for (int i = 0; i < _channels.Length; i++)
		{
			if (string.Compare(name, GetChannel(i).ChannelName, StringComparison.OrdinalIgnoreCase) == 0)
			{
				return i;
			}
		}
		return -1;
	}
}
