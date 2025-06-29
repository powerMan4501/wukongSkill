using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Channels;
using System.Security;

namespace System.Runtime.Remoting;

internal class DelayLoadClientChannelEntry
{
	private RemotingXmlConfigFileData.ChannelEntry _entry;

	private IChannelSender _channel;

	private bool _bRegistered;

	private bool _ensureSecurity;

	internal IChannelSender Channel
	{
		[SecurityCritical]
		get
		{
			if (_channel == null && !_bRegistered)
			{
				_channel = (IChannelSender)RemotingConfigHandler.CreateChannelFromConfigEntry(_entry);
				_entry = null;
			}
			return _channel;
		}
	}

	internal DelayLoadClientChannelEntry(RemotingXmlConfigFileData.ChannelEntry entry, bool ensureSecurity)
	{
		_entry = entry;
		_channel = null;
		_bRegistered = false;
		_ensureSecurity = ensureSecurity;
	}

	internal void RegisterChannel()
	{
		ChannelServices.RegisterChannel(_channel, _ensureSecurity);
		_bRegistered = true;
		_channel = null;
	}
}
