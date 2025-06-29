using System.Globalization;
using System.Net.Sockets;
using System.Text;

namespace System.Net;

[Serializable]
[global::__DynamicallyInvokable]
public class IPAddress
{
	[global::__DynamicallyInvokable]
	public static readonly IPAddress Any = new IPAddress(0);

	[global::__DynamicallyInvokable]
	public static readonly IPAddress Loopback = new IPAddress(16777343);

	[global::__DynamicallyInvokable]
	public static readonly IPAddress Broadcast = new IPAddress(4294967295L);

	[global::__DynamicallyInvokable]
	public static readonly IPAddress None = Broadcast;

	internal const long LoopbackMask = 255L;

	internal long m_Address;

	[NonSerialized]
	internal string m_ToString;

	[global::__DynamicallyInvokable]
	public static readonly IPAddress IPv6Any = new IPAddress(new byte[16], 0L);

	[global::__DynamicallyInvokable]
	public static readonly IPAddress IPv6Loopback = new IPAddress(new byte[16]
	{
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 1
	}, 0L);

	[global::__DynamicallyInvokable]
	public static readonly IPAddress IPv6None = new IPAddress(new byte[16], 0L);

	private AddressFamily m_Family = AddressFamily.InterNetwork;

	private ushort[] m_Numbers = new ushort[8];

	private long m_ScopeId;

	private int m_HashCode;

	internal const int IPv4AddressBytes = 4;

	internal const int IPv6AddressBytes = 16;

	internal const int NumberOfLabels = 8;

	[Obsolete("This property has been deprecated. It is address family dependent. Please use IPAddress.Equals method to perform comparisons. http://go.microsoft.com/fwlink/?linkid=14202")]
	public long Address
	{
		get
		{
			if (m_Family == AddressFamily.InterNetworkV6)
			{
				throw new SocketException(SocketError.OperationNotSupported);
			}
			return m_Address;
		}
		set
		{
			if (m_Family == AddressFamily.InterNetworkV6)
			{
				throw new SocketException(SocketError.OperationNotSupported);
			}
			if (m_Address != value)
			{
				m_ToString = null;
				m_Address = value;
			}
		}
	}

	[global::__DynamicallyInvokable]
	public AddressFamily AddressFamily
	{
		[global::__DynamicallyInvokable]
		get
		{
			return m_Family;
		}
	}

	[global::__DynamicallyInvokable]
	public long ScopeId
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (m_Family == AddressFamily.InterNetwork)
			{
				throw new SocketException(SocketError.OperationNotSupported);
			}
			return m_ScopeId;
		}
		[global::__DynamicallyInvokable]
		set
		{
			if (m_Family == AddressFamily.InterNetwork)
			{
				throw new SocketException(SocketError.OperationNotSupported);
			}
			if (value < 0 || value > uint.MaxValue)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			if (m_ScopeId != value)
			{
				m_Address = value;
				m_ScopeId = value;
				m_ToString = null;
			}
		}
	}

	internal bool IsBroadcast
	{
		get
		{
			if (m_Family == AddressFamily.InterNetworkV6)
			{
				return false;
			}
			return m_Address == Broadcast.m_Address;
		}
	}

	[global::__DynamicallyInvokable]
	public bool IsIPv6Multicast
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (m_Family == AddressFamily.InterNetworkV6)
			{
				return (m_Numbers[0] & 0xFF00) == 65280;
			}
			return false;
		}
	}

	[global::__DynamicallyInvokable]
	public bool IsIPv6LinkLocal
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (m_Family == AddressFamily.InterNetworkV6)
			{
				return (m_Numbers[0] & 0xFFC0) == 65152;
			}
			return false;
		}
	}

	[global::__DynamicallyInvokable]
	public bool IsIPv6SiteLocal
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (m_Family == AddressFamily.InterNetworkV6)
			{
				return (m_Numbers[0] & 0xFFC0) == 65216;
			}
			return false;
		}
	}

	[global::__DynamicallyInvokable]
	public bool IsIPv6Teredo
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (m_Family == AddressFamily.InterNetworkV6 && m_Numbers[0] == 8193)
			{
				return m_Numbers[1] == 0;
			}
			return false;
		}
	}

	[global::__DynamicallyInvokable]
	public bool IsIPv4MappedToIPv6
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (AddressFamily != AddressFamily.InterNetworkV6)
			{
				return false;
			}
			for (int i = 0; i < 5; i++)
			{
				if (m_Numbers[i] != 0)
				{
					return false;
				}
			}
			return m_Numbers[5] == ushort.MaxValue;
		}
	}

	[global::__DynamicallyInvokable]
	public IPAddress(long newAddress)
	{
		if (newAddress < 0 || newAddress > uint.MaxValue)
		{
			throw new ArgumentOutOfRangeException("newAddress");
		}
		m_Address = newAddress;
	}

	[global::__DynamicallyInvokable]
	public IPAddress(byte[] address, long scopeid)
	{
		if (address == null)
		{
			throw new ArgumentNullException("address");
		}
		if (address.Length != 16)
		{
			throw new ArgumentException(SR.GetString("dns_bad_ip_address"), "address");
		}
		m_Family = AddressFamily.InterNetworkV6;
		for (int i = 0; i < 8; i++)
		{
			m_Numbers[i] = (ushort)(address[i * 2] * 256 + address[i * 2 + 1]);
		}
		if (scopeid < 0 || scopeid > uint.MaxValue)
		{
			throw new ArgumentOutOfRangeException("scopeid");
		}
		m_ScopeId = scopeid;
	}

	private IPAddress(ushort[] address, uint scopeid)
	{
		m_Family = AddressFamily.InterNetworkV6;
		m_Numbers = address;
		m_ScopeId = scopeid;
	}

	[global::__DynamicallyInvokable]
	public IPAddress(byte[] address)
	{
		if (address == null)
		{
			throw new ArgumentNullException("address");
		}
		if (address.Length != 4 && address.Length != 16)
		{
			throw new ArgumentException(SR.GetString("dns_bad_ip_address"), "address");
		}
		if (address.Length == 4)
		{
			m_Family = AddressFamily.InterNetwork;
			m_Address = ((address[3] << 24) | (address[2] << 16) | (address[1] << 8) | address[0]) & 0xFFFFFFFFu;
			return;
		}
		m_Family = AddressFamily.InterNetworkV6;
		for (int i = 0; i < 8; i++)
		{
			m_Numbers[i] = (ushort)(address[i * 2] * 256 + address[i * 2 + 1]);
		}
	}

	internal IPAddress(int newAddress)
	{
		m_Address = newAddress & 0xFFFFFFFFu;
	}

	[global::__DynamicallyInvokable]
	public static bool TryParse(string ipString, out IPAddress address)
	{
		address = InternalParse(ipString, tryParse: true);
		return address != null;
	}

	[global::__DynamicallyInvokable]
	public static IPAddress Parse(string ipString)
	{
		return InternalParse(ipString, tryParse: false);
	}

	private unsafe static IPAddress InternalParse(string ipString, bool tryParse)
	{
		if (ipString == null)
		{
			if (tryParse)
			{
				return null;
			}
			throw new ArgumentNullException("ipString");
		}
		if (ipString.IndexOf(':') != -1)
		{
			SocketException ex = null;
			long num = 0L;
			if (Socket.OSSupportsIPv6)
			{
				byte[] array = new byte[16];
				SocketAddress socketAddress = new SocketAddress(AddressFamily.InterNetworkV6, 28);
				if (UnsafeNclNativeMethods.OSSOCK.WSAStringToAddress(ipString, AddressFamily.InterNetworkV6, IntPtr.Zero, socketAddress.m_Buffer, ref socketAddress.m_Size) == SocketError.Success)
				{
					for (int i = 0; i < 16; i++)
					{
						array[i] = socketAddress[i + 8];
					}
					num = (socketAddress[27] << 24) + (socketAddress[26] << 16) + (socketAddress[25] << 8) + socketAddress[24];
					return new IPAddress(array, num);
				}
				if (tryParse)
				{
					return null;
				}
				ex = new SocketException();
			}
			else
			{
				int start = 0;
				if (ipString[0] != '[')
				{
					ipString += "]";
				}
				else
				{
					start = 1;
				}
				int end = ipString.Length;
				fixed (char* name = ipString)
				{
					if (IPv6AddressHelper.IsValidStrict(name, start, ref end) || end != ipString.Length)
					{
						ushort[] array2 = new ushort[8];
						string scopeId = null;
						fixed (ushort* numbers = array2)
						{
							IPv6AddressHelper.Parse(ipString, numbers, 0, ref scopeId);
						}
						if (scopeId == null || scopeId.Length == 0)
						{
							return new IPAddress(array2, 0u);
						}
						scopeId = scopeId.Substring(1);
						if (uint.TryParse(scopeId, NumberStyles.None, null, out var result))
						{
							return new IPAddress(array2, result);
						}
					}
				}
				if (tryParse)
				{
					return null;
				}
				ex = new SocketException(SocketError.InvalidArgument);
			}
			throw new FormatException(SR.GetString("dns_bad_ip_address"), ex);
		}
		Socket.InitializeSockets();
		int end2 = ipString.Length;
		long num2;
		fixed (char* name2 = ipString)
		{
			num2 = IPv4AddressHelper.ParseNonCanonical(name2, 0, ref end2, notImplicitFile: true);
		}
		if (num2 == -1 || end2 != ipString.Length)
		{
			if (tryParse)
			{
				return null;
			}
			throw new FormatException(SR.GetString("dns_bad_ip_address"));
		}
		num2 = ((num2 & 0xFF) << 24) | (((num2 & 0xFF00) << 8) | (((num2 & 0xFF0000) >> 8) | ((num2 & 0xFF000000u) >> 24)));
		return new IPAddress(num2);
	}

	[global::__DynamicallyInvokable]
	public byte[] GetAddressBytes()
	{
		byte[] array;
		if (m_Family != AddressFamily.InterNetworkV6)
		{
			array = new byte[4]
			{
				(byte)m_Address,
				(byte)(m_Address >> 8),
				(byte)(m_Address >> 16),
				(byte)(m_Address >> 24)
			};
		}
		else
		{
			array = new byte[16];
			int num = 0;
			for (int i = 0; i < 8; i++)
			{
				array[num++] = (byte)((m_Numbers[i] >> 8) & 0xFF);
				array[num++] = (byte)(m_Numbers[i] & 0xFF);
			}
		}
		return array;
	}

	[global::__DynamicallyInvokable]
	public unsafe override string ToString()
	{
		if (m_ToString == null)
		{
			if (m_Family == AddressFamily.InterNetworkV6)
			{
				int addressStringLength = 256;
				StringBuilder stringBuilder = new StringBuilder(addressStringLength);
				if (Socket.OSSupportsIPv6)
				{
					SocketAddress socketAddress = new SocketAddress(AddressFamily.InterNetworkV6, 28);
					int num = 8;
					for (int i = 0; i < 8; i++)
					{
						socketAddress[num++] = (byte)(m_Numbers[i] >> 8);
						socketAddress[num++] = (byte)m_Numbers[i];
					}
					if (m_ScopeId > 0)
					{
						socketAddress[24] = (byte)m_ScopeId;
						socketAddress[25] = (byte)(m_ScopeId >> 8);
						socketAddress[26] = (byte)(m_ScopeId >> 16);
						socketAddress[27] = (byte)(m_ScopeId >> 24);
					}
					if (UnsafeNclNativeMethods.OSSOCK.WSAAddressToString(socketAddress.m_Buffer, socketAddress.m_Size, IntPtr.Zero, stringBuilder, ref addressStringLength) != SocketError.Success)
					{
						throw new SocketException();
					}
				}
				else
				{
					string value = string.Format(CultureInfo.InvariantCulture, "{0:x4}:{1:x4}:{2:x4}:{3:x4}:{4:x4}:{5:x4}:{6}.{7}.{8}.{9}", m_Numbers[0], m_Numbers[1], m_Numbers[2], m_Numbers[3], m_Numbers[4], m_Numbers[5], (m_Numbers[6] >> 8) & 0xFF, m_Numbers[6] & 0xFF, (m_Numbers[7] >> 8) & 0xFF, m_Numbers[7] & 0xFF);
					stringBuilder.Append(value);
					if (m_ScopeId != 0L)
					{
						stringBuilder.Append('%').Append((uint)m_ScopeId);
					}
				}
				m_ToString = stringBuilder.ToString();
			}
			else
			{
				int num2 = 15;
				char* ptr = stackalloc char[15];
				int num3 = (int)((m_Address >> 24) & 0xFF);
				do
				{
					ptr[--num2] = (char)(48 + num3 % 10);
					num3 /= 10;
				}
				while (num3 > 0);
				ptr[--num2] = '.';
				num3 = (int)((m_Address >> 16) & 0xFF);
				do
				{
					ptr[--num2] = (char)(48 + num3 % 10);
					num3 /= 10;
				}
				while (num3 > 0);
				ptr[--num2] = '.';
				num3 = (int)((m_Address >> 8) & 0xFF);
				do
				{
					ptr[--num2] = (char)(48 + num3 % 10);
					num3 /= 10;
				}
				while (num3 > 0);
				ptr[--num2] = '.';
				num3 = (int)(m_Address & 0xFF);
				do
				{
					ptr[--num2] = (char)(48 + num3 % 10);
					num3 /= 10;
				}
				while (num3 > 0);
				m_ToString = new string(ptr, num2, 15 - num2);
			}
		}
		return m_ToString;
	}

	[global::__DynamicallyInvokable]
	public static long HostToNetworkOrder(long host)
	{
		return ((HostToNetworkOrder((int)host) & 0xFFFFFFFFu) << 32) | (HostToNetworkOrder((int)(host >> 32)) & 0xFFFFFFFFu);
	}

	[global::__DynamicallyInvokable]
	public static int HostToNetworkOrder(int host)
	{
		return ((HostToNetworkOrder((short)host) & 0xFFFF) << 16) | (HostToNetworkOrder((short)(host >> 16)) & 0xFFFF);
	}

	[global::__DynamicallyInvokable]
	public static short HostToNetworkOrder(short host)
	{
		return (short)(((host & 0xFF) << 8) | ((host >> 8) & 0xFF));
	}

	[global::__DynamicallyInvokable]
	public static long NetworkToHostOrder(long network)
	{
		return HostToNetworkOrder(network);
	}

	[global::__DynamicallyInvokable]
	public static int NetworkToHostOrder(int network)
	{
		return HostToNetworkOrder(network);
	}

	[global::__DynamicallyInvokable]
	public static short NetworkToHostOrder(short network)
	{
		return HostToNetworkOrder(network);
	}

	[global::__DynamicallyInvokable]
	public static bool IsLoopback(IPAddress address)
	{
		if (address == null)
		{
			throw new ArgumentNullException("address");
		}
		if (address.m_Family == AddressFamily.InterNetworkV6)
		{
			return address.Equals(IPv6Loopback);
		}
		return (address.m_Address & 0xFF) == (Loopback.m_Address & 0xFF);
	}

	internal bool Equals(object comparandObj, bool compareScopeId)
	{
		if (!(comparandObj is IPAddress iPAddress))
		{
			return false;
		}
		if (m_Family != iPAddress.m_Family)
		{
			return false;
		}
		if (m_Family == AddressFamily.InterNetworkV6)
		{
			for (int i = 0; i < 8; i++)
			{
				if (iPAddress.m_Numbers[i] != m_Numbers[i])
				{
					return false;
				}
			}
			if (iPAddress.m_ScopeId == m_ScopeId)
			{
				return true;
			}
			if (!compareScopeId)
			{
				return true;
			}
			return false;
		}
		return iPAddress.m_Address == m_Address;
	}

	[global::__DynamicallyInvokable]
	public override bool Equals(object comparand)
	{
		return Equals(comparand, compareScopeId: true);
	}

	[global::__DynamicallyInvokable]
	public override int GetHashCode()
	{
		if (m_Family == AddressFamily.InterNetworkV6)
		{
			if (m_HashCode == 0)
			{
				m_HashCode = StringComparer.InvariantCultureIgnoreCase.GetHashCode(ToString());
			}
			return m_HashCode;
		}
		return (int)m_Address;
	}

	internal IPAddress Snapshot()
	{
		return m_Family switch
		{
			AddressFamily.InterNetwork => new IPAddress(m_Address), 
			AddressFamily.InterNetworkV6 => new IPAddress(m_Numbers, (uint)m_ScopeId), 
			_ => throw new InternalException(), 
		};
	}

	[global::__DynamicallyInvokable]
	public IPAddress MapToIPv6()
	{
		if (AddressFamily == AddressFamily.InterNetworkV6)
		{
			return this;
		}
		return new IPAddress(new ushort[8]
		{
			0,
			0,
			0,
			0,
			0,
			65535,
			(ushort)(((m_Address & 0xFF00) >> 8) | ((m_Address & 0xFF) << 8)),
			(ushort)(((m_Address & 0xFF000000u) >> 24) | ((m_Address & 0xFF0000) >> 8))
		}, 0u);
	}

	[global::__DynamicallyInvokable]
	public IPAddress MapToIPv4()
	{
		if (AddressFamily == AddressFamily.InterNetwork)
		{
			return this;
		}
		long newAddress = (uint)(((m_Numbers[6] & 0xFF00) >>> 8) | ((m_Numbers[6] & 0xFF) << 8) | ((((m_Numbers[7] & 0xFF00) >>> 8) | ((m_Numbers[7] & 0xFF) << 8)) << 16));
		return new IPAddress(newAddress);
	}
}
