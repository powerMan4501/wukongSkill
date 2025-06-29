using System.Net;
using System.Net.Sockets;

namespace STUN;

public class StunServer
{
	private const ushort DefaultPort = 3478;

	public string Hostname { get; }

	public ushort Port { get; }

	public StunServer()
	{
		Hostname = "stun.syncthing.net";
		Port = 3478;
	}

	private StunServer(string hostname, ushort port)
	{
		Hostname = hostname;
		Port = port;
	}

	public static bool TryParse(string s, out StunServer result)
	{
		if (!HostnameEndpoint.TryParse(s, out var result2, 3478))
		{
			result = null;
			return false;
		}
		result = new StunServer(result2.Hostname, result2.Port);
		return true;
	}

	public override string ToString()
	{
		if (Port == 3478)
		{
			return Hostname;
		}
		if (IPAddress.TryParse(Hostname, out var address) && address.AddressFamily == AddressFamily.InterNetworkV6)
		{
			return $"[{address}]:{Port}";
		}
		return $"{Hostname}:{Port}";
	}
}
