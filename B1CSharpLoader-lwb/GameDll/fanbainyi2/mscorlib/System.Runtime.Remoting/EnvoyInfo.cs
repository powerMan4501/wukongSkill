using System.Runtime.Remoting.Messaging;
using System.Security;

namespace System.Runtime.Remoting;

[Serializable]
internal sealed class EnvoyInfo : IEnvoyInfo
{
	private IMessageSink envoySinks;

	public IMessageSink EnvoySinks
	{
		[SecurityCritical]
		get
		{
			return envoySinks;
		}
		[SecurityCritical]
		set
		{
			envoySinks = value;
		}
	}

	[SecurityCritical]
	internal static IEnvoyInfo CreateEnvoyInfo(ServerIdentity serverID)
	{
		IEnvoyInfo result = null;
		if (serverID != null)
		{
			if (serverID.EnvoyChain == null)
			{
				serverID.RaceSetEnvoyChain(serverID.ServerContext.CreateEnvoyChain(serverID.TPOrObject));
			}
			IMessageSink messageSink = serverID.EnvoyChain as EnvoyTerminatorSink;
			if (messageSink == null)
			{
				result = new EnvoyInfo(serverID.EnvoyChain);
			}
		}
		return result;
	}

	[SecurityCritical]
	private EnvoyInfo(IMessageSink sinks)
	{
		EnvoySinks = sinks;
	}
}
