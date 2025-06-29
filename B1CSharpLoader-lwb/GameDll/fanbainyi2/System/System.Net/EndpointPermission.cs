using System.Globalization;
using System.Security;

namespace System.Net;

[Serializable]
public class EndpointPermission
{
	private enum EndPointType
	{
		Invalid,
		IPv6,
		DnsOrWildcard,
		IPv4
	}

	internal string hostname;

	internal int port;

	internal TransportType transport;

	internal bool wildcard;

	internal IPAddress[] address;

	internal bool cached;

	private static char[] DotSeparator = new char[1] { '.' };

	private const string encSeperator = "#";

	public string Hostname => hostname;

	public TransportType Transport => transport;

	public int Port => port;

	internal bool IsDns
	{
		get
		{
			if (IsValidWildcard)
			{
				return false;
			}
			return CheckEndPointName(hostname) == EndPointType.DnsOrWildcard;
		}
	}

	private bool IsValidWildcard
	{
		get
		{
			int length = hostname.Length;
			if (length < 3)
			{
				return false;
			}
			if (hostname[0] == '.' || hostname[length - 1] == '.')
			{
				return false;
			}
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < hostname.Length; i++)
			{
				if (hostname[i] == '.')
				{
					num++;
				}
				else if (hostname[i] == '*')
				{
					num2++;
				}
				else if (!char.IsDigit(hostname[i]))
				{
					return false;
				}
			}
			if (num == 3)
			{
				return num2 > 0;
			}
			return false;
		}
	}

	internal EndpointPermission(string epname, int port, TransportType trtype)
	{
		if (CheckEndPointName(epname) == EndPointType.Invalid)
		{
			throw new ArgumentException(SR.GetString("net_perm_epname", epname), "epname");
		}
		if (!ValidationHelper.ValidateTcpPort(port) && port != -1)
		{
			throw new ArgumentOutOfRangeException("port", SR.GetString("net_perm_invalid_val", "Port", port.ToString(NumberFormatInfo.InvariantInfo)));
		}
		hostname = epname;
		this.port = port;
		transport = trtype;
		wildcard = false;
	}

	public override bool Equals(object obj)
	{
		EndpointPermission endpointPermission = (EndpointPermission)obj;
		if (string.Compare(hostname, endpointPermission.hostname, StringComparison.OrdinalIgnoreCase) != 0)
		{
			return false;
		}
		if (port != endpointPermission.port)
		{
			return false;
		}
		if (transport != endpointPermission.transport)
		{
			return false;
		}
		return true;
	}

	public override int GetHashCode()
	{
		return ToString().GetHashCode();
	}

	internal bool MatchAddress(EndpointPermission e)
	{
		if (Hostname.Length == 0 || e.Hostname.Length == 0)
		{
			return false;
		}
		if (Hostname.Equals("0.0.0.0"))
		{
			if (e.Hostname.Equals("*.*.*.*") || e.Hostname.Equals("0.0.0.0"))
			{
				return true;
			}
			return false;
		}
		if (IsDns && e.IsDns)
		{
			return string.Compare(hostname, e.hostname, StringComparison.OrdinalIgnoreCase) == 0;
		}
		Resolve();
		e.Resolve();
		if ((address == null && !wildcard) || (e.address == null && !e.wildcard))
		{
			return false;
		}
		if (wildcard && !e.wildcard)
		{
			return false;
		}
		if (e.wildcard)
		{
			if (wildcard)
			{
				if (MatchWildcard(e.hostname))
				{
					return true;
				}
			}
			else
			{
				for (int i = 0; i < address.Length; i++)
				{
					if (e.MatchWildcard(address[i].ToString()))
					{
						return true;
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < address.Length; j++)
			{
				for (int k = 0; k < e.address.Length; k++)
				{
					if (address[j].Equals(e.address[k]))
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	internal bool MatchWildcard(string str)
	{
		string[] array = hostname.Split(DotSeparator);
		string[] array2 = str.Split(DotSeparator);
		if (array2.Length != 4 || array.Length != 4)
		{
			return false;
		}
		for (int i = 0; i < 4; i++)
		{
			if (array2[i] != array[i] && array[i] != "*")
			{
				return false;
			}
		}
		return true;
	}

	internal void Resolve()
	{
		if (cached || wildcard)
		{
			return;
		}
		if (IsValidWildcard)
		{
			wildcard = true;
			cached = true;
			return;
		}
		if (IPAddress.TryParse(hostname, out var iPAddress))
		{
			address = new IPAddress[1];
			address[0] = iPAddress;
			cached = true;
			return;
		}
		try
		{
			if (Dns.TryInternalResolve(hostname, out var result))
			{
				address = result.AddressList;
			}
		}
		catch (SecurityException)
		{
			throw;
		}
		catch
		{
		}
	}

	internal bool SubsetMatch(EndpointPermission e)
	{
		if ((transport == e.transport || e.transport == TransportType.All) && (port == e.port || e.port == -1 || port == 0))
		{
			return MatchAddress(e);
		}
		return false;
	}

	public override string ToString()
	{
		string[] obj = new string[5]
		{
			hostname,
			"#",
			port.ToString(),
			"#",
			null
		};
		int num = (int)transport;
		obj[4] = num.ToString(NumberFormatInfo.InvariantInfo);
		return string.Concat(obj);
	}

	internal EndpointPermission Intersect(EndpointPermission E)
	{
		string text = null;
		TransportType trtype;
		if (transport == E.transport)
		{
			trtype = transport;
		}
		else if (transport == TransportType.All)
		{
			trtype = E.transport;
		}
		else
		{
			if (E.transport != TransportType.All)
			{
				return null;
			}
			trtype = transport;
		}
		int num;
		if (port == E.port)
		{
			num = port;
		}
		else if (port == -1)
		{
			num = E.port;
		}
		else
		{
			if (E.port != -1)
			{
				return null;
			}
			num = port;
		}
		if (Hostname.Equals("0.0.0.0"))
		{
			if (!E.Hostname.Equals("*.*.*.*") && !E.Hostname.Equals("0.0.0.0"))
			{
				return null;
			}
			text = Hostname;
		}
		else if (E.Hostname.Equals("0.0.0.0"))
		{
			if (!Hostname.Equals("*.*.*.*") && !Hostname.Equals("0.0.0.0"))
			{
				return null;
			}
			text = E.Hostname;
		}
		else if (IsDns && E.IsDns)
		{
			if (string.Compare(hostname, E.hostname, StringComparison.OrdinalIgnoreCase) != 0)
			{
				return null;
			}
			text = hostname;
		}
		else
		{
			Resolve();
			E.Resolve();
			if ((address == null && !wildcard) || (E.address == null && !E.wildcard))
			{
				return null;
			}
			if (wildcard && E.wildcard)
			{
				string[] array = hostname.Split(DotSeparator);
				string[] array2 = E.hostname.Split(DotSeparator);
				string text2 = "";
				if (array2.Length != 4 || array.Length != 4)
				{
					return null;
				}
				for (int i = 0; i < 4; i++)
				{
					if (i != 0)
					{
						text2 += ".";
					}
					if (array2[i] == array[i])
					{
						text2 += array2[i];
						continue;
					}
					if (array2[i] == "*")
					{
						text2 += array[i];
						continue;
					}
					if (array[i] == "*")
					{
						text2 += array2[i];
						continue;
					}
					return null;
				}
				text = text2;
			}
			else if (wildcard)
			{
				for (int j = 0; j < E.address.Length; j++)
				{
					if (MatchWildcard(E.address[j].ToString()))
					{
						text = E.hostname;
						break;
					}
				}
			}
			else if (E.wildcard)
			{
				for (int k = 0; k < address.Length; k++)
				{
					if (E.MatchWildcard(address[k].ToString()))
					{
						text = hostname;
						break;
					}
				}
			}
			else
			{
				if (address == E.address)
				{
					text = hostname;
				}
				int num2 = 0;
				while (text == null && num2 < address.Length)
				{
					for (int l = 0; l < E.address.Length; l++)
					{
						if (address[num2].Equals(E.address[l]))
						{
							text = hostname;
							break;
						}
					}
					num2++;
				}
			}
			if (text == null)
			{
				return null;
			}
		}
		return new EndpointPermission(text, num, trtype);
	}

	private static EndPointType CheckEndPointName(string name)
	{
		if (name == null)
		{
			return EndPointType.Invalid;
		}
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		foreach (char c in name)
		{
			switch (c)
			{
			case '*':
			case '-':
			case '_':
				flag2 = true;
				continue;
			case '%':
			case ':':
				flag = true;
				continue;
			case '.':
				continue;
			}
			if ((c > 'f' && c <= 'z') || (c > 'F' && c <= 'Z'))
			{
				flag2 = true;
			}
			else if ((c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F'))
			{
				flag3 = true;
			}
			else if (c < '0' || c > '9')
			{
				return EndPointType.Invalid;
			}
		}
		if (!flag)
		{
			if (!flag2)
			{
				if (!flag3)
				{
					return EndPointType.IPv4;
				}
				return EndPointType.DnsOrWildcard;
			}
			return EndPointType.DnsOrWildcard;
		}
		if (!flag2)
		{
			return EndPointType.IPv6;
		}
		return EndPointType.Invalid;
	}
}
