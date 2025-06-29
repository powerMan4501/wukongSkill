using System.Collections.Generic;
using System.Globalization;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Net;

internal class WebProxyScriptHelper : IReflect
{
	private class MyMethodInfo : MethodInfo
	{
		private string name;

		public override Type ReturnType
		{
			get
			{
				Type result = null;
				if (string.Compare(name, "isPlainHostName", StringComparison.Ordinal) == 0)
				{
					result = typeof(bool);
				}
				else if (string.Compare(name, "dnsDomainIs", StringComparison.Ordinal) == 0)
				{
					result = typeof(bool);
				}
				else if (string.Compare(name, "localHostOrDomainIs", StringComparison.Ordinal) == 0)
				{
					result = typeof(bool);
				}
				else if (string.Compare(name, "isResolvable", StringComparison.Ordinal) == 0)
				{
					result = typeof(bool);
				}
				else if (string.Compare(name, "dnsResolve", StringComparison.Ordinal) == 0)
				{
					result = typeof(string);
				}
				else if (string.Compare(name, "myIpAddress", StringComparison.Ordinal) == 0)
				{
					result = typeof(string);
				}
				else if (string.Compare(name, "dnsDomainLevels", StringComparison.Ordinal) == 0)
				{
					result = typeof(int);
				}
				else if (string.Compare(name, "isInNet", StringComparison.Ordinal) == 0)
				{
					result = typeof(bool);
				}
				else if (string.Compare(name, "shExpMatch", StringComparison.Ordinal) == 0)
				{
					result = typeof(bool);
				}
				else if (string.Compare(name, "weekdayRange", StringComparison.Ordinal) == 0)
				{
					result = typeof(bool);
				}
				else if (Socket.OSSupportsIPv6)
				{
					if (string.Compare(name, "dnsResolveEx", StringComparison.Ordinal) == 0)
					{
						result = typeof(string);
					}
					else if (string.Compare(name, "isResolvableEx", StringComparison.Ordinal) == 0)
					{
						result = typeof(bool);
					}
					else if (string.Compare(name, "myIpAddressEx", StringComparison.Ordinal) == 0)
					{
						result = typeof(string);
					}
					else if (string.Compare(name, "isInNetEx", StringComparison.Ordinal) == 0)
					{
						result = typeof(bool);
					}
					else if (string.Compare(name, "sortIpAddressList", StringComparison.Ordinal) == 0)
					{
						result = typeof(string);
					}
					else if (string.Compare(name, "getClientVersion", StringComparison.Ordinal) == 0)
					{
						result = typeof(string);
					}
				}
				return result;
			}
		}

		public override ICustomAttributeProvider ReturnTypeCustomAttributes => null;

		public override RuntimeMethodHandle MethodHandle => default(RuntimeMethodHandle);

		public override MethodAttributes Attributes => MethodAttributes.Public;

		public override string Name => name;

		public override Type DeclaringType => typeof(MyMethodInfo);

		public override Type ReflectedType => null;

		public override Module Module => GetType().Module;

		public MyMethodInfo(string name)
		{
			this.name = name;
		}

		public override object[] GetCustomAttributes(bool inherit)
		{
			return null;
		}

		public override object[] GetCustomAttributes(Type type, bool inherit)
		{
			return null;
		}

		public override bool IsDefined(Type type, bool inherit)
		{
			return type.Equals(typeof(WebProxyScriptHelper));
		}

		public override object Invoke(object target, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture)
		{
			return typeof(WebProxyScriptHelper).GetMethod(name, (BindingFlags)(-1)).Invoke(target, (BindingFlags)(-1), binder, args, culture);
		}

		public override ParameterInfo[] GetParameters()
		{
			return typeof(WebProxyScriptHelper).GetMethod(name, (BindingFlags)(-1)).GetParameters();
		}

		public override MethodImplAttributes GetMethodImplementationFlags()
		{
			return MethodImplAttributes.IL;
		}

		public override MethodInfo GetBaseDefinition()
		{
			return null;
		}
	}

	private static int MAX_IPADDRESS_LIST_LENGTH = 1024;

	Type IReflect.UnderlyingSystemType => null;

	MethodInfo IReflect.GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	MethodInfo IReflect.GetMethod(string name, BindingFlags bindingAttr)
	{
		return null;
	}

	MethodInfo[] IReflect.GetMethods(BindingFlags bindingAttr)
	{
		return new MethodInfo[0];
	}

	FieldInfo IReflect.GetField(string name, BindingFlags bindingAttr)
	{
		return null;
	}

	FieldInfo[] IReflect.GetFields(BindingFlags bindingAttr)
	{
		return new FieldInfo[0];
	}

	PropertyInfo IReflect.GetProperty(string name, BindingFlags bindingAttr)
	{
		return null;
	}

	PropertyInfo IReflect.GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	PropertyInfo[] IReflect.GetProperties(BindingFlags bindingAttr)
	{
		return new PropertyInfo[0];
	}

	MemberInfo[] IReflect.GetMember(string name, BindingFlags bindingAttr)
	{
		return new MemberInfo[1]
		{
			new MyMethodInfo(name)
		};
	}

	MemberInfo[] IReflect.GetMembers(BindingFlags bindingAttr)
	{
		return new MemberInfo[0];
	}

	object IReflect.InvokeMember(string name, BindingFlags bindingAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
	{
		return null;
	}

	public bool isPlainHostName(string hostName)
	{
		if (hostName == null)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.Web, SR.GetString("net_log_proxy_called_with_null_parameter", "WebProxyScriptHelper.isPlainHostName()", "hostName"));
			}
			throw new ArgumentNullException("hostName");
		}
		return hostName.IndexOf('.') == -1;
	}

	public bool dnsDomainIs(string host, string domain)
	{
		if (host == null)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.Web, SR.GetString("net_log_proxy_called_with_null_parameter", "WebProxyScriptHelper.dnsDomainIs()", "host"));
			}
			throw new ArgumentNullException("host");
		}
		if (domain == null)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.Web, SR.GetString("net_log_proxy_called_with_null_parameter", "WebProxyScriptHelper.dnsDomainIs()", "domain"));
			}
			throw new ArgumentNullException("domain");
		}
		int num = host.LastIndexOf(domain);
		if (num != -1)
		{
			return num + domain.Length == host.Length;
		}
		return false;
	}

	public bool localHostOrDomainIs(string host, string hostDom)
	{
		if (host == null)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.Web, SR.GetString("net_log_proxy_called_with_null_parameter", "WebProxyScriptHelper.localHostOrDomainIs()", "host"));
			}
			throw new ArgumentNullException("host");
		}
		if (hostDom == null)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.Web, SR.GetString("net_log_proxy_called_with_null_parameter", "WebProxyScriptHelper.localHostOrDomainIs()", "hostDom"));
			}
			throw new ArgumentNullException("hostDom");
		}
		if (isPlainHostName(host))
		{
			int num = hostDom.IndexOf('.');
			if (num > 0)
			{
				hostDom = hostDom.Substring(0, num);
			}
		}
		return string.Compare(host, hostDom, StringComparison.OrdinalIgnoreCase) == 0;
	}

	public bool isResolvable(string host)
	{
		if (host == null)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.Web, SR.GetString("net_log_proxy_called_with_null_parameter", "WebProxyScriptHelper.isResolvable()", "host"));
			}
			throw new ArgumentNullException("host");
		}
		IPHostEntry iPHostEntry = null;
		try
		{
			iPHostEntry = Dns.InternalGetHostByName(host);
		}
		catch
		{
		}
		if (iPHostEntry == null)
		{
			return false;
		}
		for (int i = 0; i < iPHostEntry.AddressList.Length; i++)
		{
			if (iPHostEntry.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
			{
				return true;
			}
		}
		return false;
	}

	public string dnsResolve(string host)
	{
		if (host == null)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.Web, SR.GetString("net_log_proxy_called_with_null_parameter", "WebProxyScriptHelper.dnsResolve()", "host"));
			}
			throw new ArgumentNullException("host");
		}
		IPHostEntry iPHostEntry = null;
		try
		{
			iPHostEntry = Dns.InternalGetHostByName(host);
		}
		catch
		{
		}
		if (iPHostEntry == null)
		{
			return string.Empty;
		}
		for (int i = 0; i < iPHostEntry.AddressList.Length; i++)
		{
			if (iPHostEntry.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
			{
				return iPHostEntry.AddressList[i].ToString();
			}
		}
		return string.Empty;
	}

	public string myIpAddress()
	{
		IPAddress[] localAddresses = NclUtilities.LocalAddresses;
		for (int i = 0; i < localAddresses.Length; i++)
		{
			if (!IPAddress.IsLoopback(localAddresses[i]) && localAddresses[i].AddressFamily == AddressFamily.InterNetwork)
			{
				return localAddresses[i].ToString();
			}
		}
		return string.Empty;
	}

	public int dnsDomainLevels(string host)
	{
		if (host == null)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.Web, SR.GetString("net_log_proxy_called_with_null_parameter", "WebProxyScriptHelper.dnsDomainLevels()", "host"));
			}
			throw new ArgumentNullException("host");
		}
		int startIndex = 0;
		int num = 0;
		while ((startIndex = host.IndexOf('.', startIndex)) != -1)
		{
			num++;
			startIndex++;
		}
		return num;
	}

	public bool isInNet(string host, string pattern, string mask)
	{
		if (host == null)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.Web, SR.GetString("net_log_proxy_called_with_null_parameter", "WebProxyScriptHelper.isInNet()", "host"));
			}
			throw new ArgumentNullException("host");
		}
		if (pattern == null)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.Web, SR.GetString("net_log_proxy_called_with_null_parameter", "WebProxyScriptHelper.isInNet()", "pattern"));
			}
			throw new ArgumentNullException("pattern");
		}
		if (mask == null)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.Web, SR.GetString("net_log_proxy_called_with_null_parameter", "WebProxyScriptHelper.isInNet()", "mask"));
			}
			throw new ArgumentNullException("mask");
		}
		try
		{
			IPAddress iPAddress = IPAddress.Parse(host);
			IPAddress iPAddress2 = IPAddress.Parse(pattern);
			IPAddress iPAddress3 = IPAddress.Parse(mask);
			byte[] addressBytes = iPAddress3.GetAddressBytes();
			byte[] addressBytes2 = iPAddress.GetAddressBytes();
			byte[] addressBytes3 = iPAddress2.GetAddressBytes();
			if (addressBytes.Length != addressBytes2.Length || addressBytes.Length != addressBytes3.Length)
			{
				return false;
			}
			for (int i = 0; i < addressBytes.Length; i++)
			{
				if ((addressBytes3[i] & addressBytes[i]) != (addressBytes2[i] & addressBytes[i]))
				{
					return false;
				}
			}
		}
		catch
		{
			return false;
		}
		return true;
	}

	public bool shExpMatch(string host, string pattern)
	{
		if (host == null)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.Web, SR.GetString("net_log_proxy_called_with_null_parameter", "WebProxyScriptHelper.shExpMatch()", "host"));
			}
			throw new ArgumentNullException("host");
		}
		if (pattern == null)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.Web, SR.GetString("net_log_proxy_called_with_null_parameter", "WebProxyScriptHelper.shExpMatch()", "pattern"));
			}
			throw new ArgumentNullException("pattern");
		}
		try
		{
			return new ShellExpression(pattern).IsMatch(host);
		}
		catch (FormatException)
		{
			return false;
		}
	}

	public bool weekdayRange(string wd1, [Optional] object wd2, [Optional] object gmt)
	{
		if (wd1 == null)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.Web, SR.GetString("net_log_proxy_called_with_null_parameter", "WebProxyScriptHelper.weekdayRange()", "wd1"));
			}
			throw new ArgumentNullException("wd1");
		}
		string text = null;
		string text2 = null;
		if (gmt != null && gmt != DBNull.Value && gmt != Missing.Value)
		{
			text = gmt as string;
			if (text == null)
			{
				throw new ArgumentException(SR.GetString("net_param_not_string", gmt.GetType().FullName), "gmt");
			}
		}
		if (wd2 != null && wd2 != DBNull.Value && gmt != Missing.Value)
		{
			text2 = wd2 as string;
			if (text2 == null)
			{
				throw new ArgumentException(SR.GetString("net_param_not_string", wd2.GetType().FullName), "wd2");
			}
		}
		if (text != null)
		{
			if (!isGMT(text))
			{
				if (Logging.On)
				{
					Logging.PrintWarning(Logging.Web, SR.GetString("net_log_proxy_called_with_null_parameter", "WebProxyScriptHelper.weekdayRange()", "gmt"));
				}
				throw new ArgumentException(SR.GetString("net_proxy_not_gmt"), "gmt");
			}
			return weekdayRangeInternal(DateTime.UtcNow, dayOfWeek(wd1), dayOfWeek(text2));
		}
		if (text2 != null)
		{
			if (isGMT(text2))
			{
				return weekdayRangeInternal(DateTime.UtcNow, dayOfWeek(wd1), dayOfWeek(wd1));
			}
			return weekdayRangeInternal(DateTime.Now, dayOfWeek(wd1), dayOfWeek(text2));
		}
		return weekdayRangeInternal(DateTime.Now, dayOfWeek(wd1), dayOfWeek(wd1));
	}

	private static bool isGMT(string gmt)
	{
		return string.Compare(gmt, "GMT", StringComparison.OrdinalIgnoreCase) == 0;
	}

	private static DayOfWeek dayOfWeek(string weekDay)
	{
		if (weekDay != null && weekDay.Length == 3)
		{
			if (weekDay[0] == 'T' || weekDay[0] == 't')
			{
				if ((weekDay[1] == 'U' || weekDay[1] == 'u') && (weekDay[2] == 'E' || weekDay[2] == 'e'))
				{
					return DayOfWeek.Tuesday;
				}
				if ((weekDay[1] == 'H' || weekDay[1] == 'h') && (weekDay[2] == 'U' || weekDay[2] == 'u'))
				{
					return DayOfWeek.Thursday;
				}
			}
			if (weekDay[0] == 'S' || weekDay[0] == 's')
			{
				if ((weekDay[1] == 'U' || weekDay[1] == 'u') && (weekDay[2] == 'N' || weekDay[2] == 'n'))
				{
					return DayOfWeek.Sunday;
				}
				if ((weekDay[1] == 'A' || weekDay[1] == 'a') && (weekDay[2] == 'T' || weekDay[2] == 't'))
				{
					return DayOfWeek.Saturday;
				}
			}
			if ((weekDay[0] == 'M' || weekDay[0] == 'm') && (weekDay[1] == 'O' || weekDay[1] == 'o') && (weekDay[2] == 'N' || weekDay[2] == 'n'))
			{
				return DayOfWeek.Monday;
			}
			if ((weekDay[0] == 'W' || weekDay[0] == 'w') && (weekDay[1] == 'E' || weekDay[1] == 'e') && (weekDay[2] == 'D' || weekDay[2] == 'd'))
			{
				return DayOfWeek.Wednesday;
			}
			if ((weekDay[0] == 'F' || weekDay[0] == 'f') && (weekDay[1] == 'R' || weekDay[1] == 'r') && (weekDay[2] == 'I' || weekDay[2] == 'i'))
			{
				return DayOfWeek.Friday;
			}
		}
		return (DayOfWeek)(-1);
	}

	private static bool weekdayRangeInternal(DateTime now, DayOfWeek wd1, DayOfWeek wd2)
	{
		if (wd1 < DayOfWeek.Sunday || wd2 < DayOfWeek.Sunday)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.Web, SR.GetString("net_log_proxy_called_with_invalid_parameter", "WebProxyScriptHelper.weekdayRange()"));
			}
			throw new ArgumentException(SR.GetString("net_proxy_invalid_dayofweek"), (wd1 < DayOfWeek.Sunday) ? "wd1" : "wd2");
		}
		if (wd1 <= wd2)
		{
			if (wd1 <= now.DayOfWeek)
			{
				return now.DayOfWeek <= wd2;
			}
			return false;
		}
		if (wd2 < now.DayOfWeek)
		{
			return now.DayOfWeek >= wd1;
		}
		return true;
	}

	public string getClientVersion()
	{
		return "1.0";
	}

	public unsafe string sortIpAddressList(string IPAddressList)
	{
		if (IPAddressList == null || IPAddressList.Length == 0)
		{
			return string.Empty;
		}
		string[] array = IPAddressList.Split(';');
		if (array.Length > MAX_IPADDRESS_LIST_LENGTH)
		{
			throw new ArgumentException(string.Format(SR.GetString("net_max_ip_address_list_length_exceeded"), MAX_IPADDRESS_LIST_LENGTH), "IPAddressList");
		}
		if (array.Length == 1)
		{
			return IPAddressList;
		}
		SocketAddress[] array2 = new SocketAddress[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = array[i].Trim();
			if (array[i].Length == 0)
			{
				throw new ArgumentException(SR.GetString("dns_bad_ip_address"), "IPAddressList");
			}
			SocketAddress socketAddress = new SocketAddress(AddressFamily.InterNetworkV6, 28);
			if (UnsafeNclNativeMethods.OSSOCK.WSAStringToAddress(array[i], AddressFamily.InterNetworkV6, IntPtr.Zero, socketAddress.m_Buffer, ref socketAddress.m_Size) != SocketError.Success)
			{
				SocketAddress socketAddress2 = new SocketAddress(AddressFamily.InterNetwork, 16);
				if (UnsafeNclNativeMethods.OSSOCK.WSAStringToAddress(array[i], AddressFamily.InterNetwork, IntPtr.Zero, socketAddress2.m_Buffer, ref socketAddress2.m_Size) != SocketError.Success)
				{
					throw new ArgumentException(SR.GetString("dns_bad_ip_address"), "IPAddressList");
				}
				IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, 0);
				IPEndPoint iPEndPoint2 = (IPEndPoint)iPEndPoint.Create(socketAddress2);
				byte[] addressBytes = iPEndPoint2.Address.GetAddressBytes();
				byte[] array3 = new byte[16];
				for (int j = 0; j < 10; j++)
				{
					array3[j] = 0;
				}
				array3[10] = byte.MaxValue;
				array3[11] = byte.MaxValue;
				array3[12] = addressBytes[0];
				array3[13] = addressBytes[1];
				array3[14] = addressBytes[2];
				array3[15] = addressBytes[3];
				IPAddress address = new IPAddress(array3);
				IPEndPoint iPEndPoint3 = new IPEndPoint(address, iPEndPoint2.Port);
				socketAddress = iPEndPoint3.Serialize();
			}
			array2[i] = socketAddress;
		}
		int num = Marshal.SizeOf(typeof(UnsafeNclNativeMethods.OSSOCK.SOCKET_ADDRESS_LIST)) + (array2.Length - 1) * Marshal.SizeOf(typeof(UnsafeNclNativeMethods.OSSOCK.SOCKET_ADDRESS));
		Dictionary<IntPtr, KeyValuePair<SocketAddress, string>> dictionary = new Dictionary<IntPtr, KeyValuePair<SocketAddress, string>>();
		GCHandle[] array4 = new GCHandle[array2.Length];
		for (int k = 0; k < array2.Length; k++)
		{
			array4[k] = GCHandle.Alloc(array2[k].m_Buffer, GCHandleType.Pinned);
		}
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		try
		{
			UnsafeNclNativeMethods.OSSOCK.SOCKET_ADDRESS_LIST* ptr = (UnsafeNclNativeMethods.OSSOCK.SOCKET_ADDRESS_LIST*)(void*)intPtr;
			ptr->iAddressCount = array2.Length;
			UnsafeNclNativeMethods.OSSOCK.SOCKET_ADDRESS* ptr2 = &ptr->Addresses;
			for (int l = 0; l < ptr->iAddressCount; l++)
			{
				ptr2[l].iSockaddrLength = 28;
				ptr2[l].lpSockAddr = array4[l].AddrOfPinnedObject();
				dictionary[ptr2[l].lpSockAddr] = new KeyValuePair<SocketAddress, string>(array2[l], array[l]);
			}
			Socket socket = new Socket(AddressFamily.InterNetworkV6, SocketType.Stream, ProtocolType.Tcp);
			int num2 = socket.IOControl(IOControlCode.AddressListSort, intPtr, num, intPtr, num);
			StringBuilder stringBuilder = new StringBuilder();
			for (int m = 0; m < ptr->iAddressCount; m++)
			{
				IntPtr lpSockAddr = ptr2[m].lpSockAddr;
				stringBuilder.Append(dictionary[lpSockAddr].Value);
				if (m != ptr->iAddressCount - 1)
				{
					stringBuilder.Append(";");
				}
			}
			return stringBuilder.ToString();
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
			for (int n = 0; n < array4.Length; n++)
			{
				if (array4[n].IsAllocated)
				{
					array4[n].Free();
				}
			}
		}
	}

	public bool isInNetEx(string ipAddress, string ipPrefix)
	{
		if (ipAddress == null)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.Web, SR.GetString("net_log_proxy_called_with_null_parameter", "WebProxyScriptHelper.isResolvable()", "ipAddress"));
			}
			throw new ArgumentNullException("ipAddress");
		}
		if (ipPrefix == null)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.Web, SR.GetString("net_log_proxy_called_with_null_parameter", "WebProxyScriptHelper.isResolvable()", "ipPrefix"));
			}
			throw new ArgumentNullException("ipPrefix");
		}
		if (!IPAddress.TryParse(ipAddress, out var address))
		{
			throw new FormatException(SR.GetString("dns_bad_ip_address"));
		}
		int num = ipPrefix.IndexOf("/");
		if (num < 0)
		{
			throw new FormatException(SR.GetString("net_bad_ip_address_prefix"));
		}
		string[] array = ipPrefix.Split('/');
		if (array.Length != 2 || array[0] == null || array[0].Length == 0 || array[1] == null || array[1].Length == 0 || array[1].Length > 2)
		{
			throw new FormatException(SR.GetString("net_bad_ip_address_prefix"));
		}
		if (!IPAddress.TryParse(array[0], out var address2))
		{
			throw new FormatException(SR.GetString("dns_bad_ip_address"));
		}
		int result = 0;
		if (!int.TryParse(array[1], out result))
		{
			throw new FormatException(SR.GetString("net_bad_ip_address_prefix"));
		}
		if (address.AddressFamily != address2.AddressFamily)
		{
			throw new FormatException(SR.GetString("net_bad_ip_address_prefix"));
		}
		if ((address.AddressFamily == AddressFamily.InterNetworkV6 && (result < 1 || result > 64)) || (address.AddressFamily == AddressFamily.InterNetwork && (result < 1 || result > 32)))
		{
			throw new FormatException(SR.GetString("net_bad_ip_address_prefix"));
		}
		byte[] addressBytes = address2.GetAddressBytes();
		byte b = (byte)(result / 8);
		byte b2 = (byte)(result % 8);
		byte b3 = b;
		if (b2 != 0)
		{
			if ((0xFF & (addressBytes[b] << (int)b2)) != 0)
			{
				throw new FormatException(SR.GetString("net_bad_ip_address_prefix"));
			}
			b3++;
		}
		int num2 = ((address2.AddressFamily == AddressFamily.InterNetworkV6) ? 16 : 4);
		while (b3 < num2)
		{
			if (addressBytes[b3++] != 0)
			{
				throw new FormatException(SR.GetString("net_bad_ip_address_prefix"));
			}
		}
		byte[] addressBytes2 = address.GetAddressBytes();
		for (b3 = 0; b3 < b; b3++)
		{
			if (addressBytes2[b3] != addressBytes[b3])
			{
				return false;
			}
		}
		if (b2 > 0)
		{
			byte b4 = addressBytes2[b];
			byte b5 = addressBytes[b];
			b4 = (byte)(b4 >> 8 - b2);
			b4 = (byte)(b4 << 8 - b2);
			if (b4 != b5)
			{
				return false;
			}
		}
		return true;
	}

	public string myIpAddressEx()
	{
		StringBuilder stringBuilder = new StringBuilder();
		try
		{
			IPAddress[] localAddresses = NclUtilities.LocalAddresses;
			for (int i = 0; i < localAddresses.Length; i++)
			{
				if (!IPAddress.IsLoopback(localAddresses[i]))
				{
					stringBuilder.Append(localAddresses[i].ToString());
					if (i != localAddresses.Length - 1)
					{
						stringBuilder.Append(";");
					}
				}
			}
		}
		catch
		{
		}
		if (stringBuilder.Length <= 0)
		{
			return string.Empty;
		}
		return stringBuilder.ToString();
	}

	public string dnsResolveEx(string host)
	{
		if (host == null)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.Web, SR.GetString("net_log_proxy_called_with_null_parameter", "WebProxyScriptHelper.dnsResolve()", "host"));
			}
			throw new ArgumentNullException("host");
		}
		IPHostEntry iPHostEntry = null;
		try
		{
			iPHostEntry = Dns.InternalGetHostByName(host);
		}
		catch
		{
		}
		if (iPHostEntry == null)
		{
			return string.Empty;
		}
		IPAddress[] addressList = iPHostEntry.AddressList;
		if (addressList.Length == 0)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < addressList.Length; i++)
		{
			stringBuilder.Append(addressList[i].ToString());
			if (i != addressList.Length - 1)
			{
				stringBuilder.Append(";");
			}
		}
		if (stringBuilder.Length <= 0)
		{
			return string.Empty;
		}
		return stringBuilder.ToString();
	}

	public bool isResolvableEx(string host)
	{
		if (host == null)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.Web, SR.GetString("net_log_proxy_called_with_null_parameter", "WebProxyScriptHelper.dnsResolve()", "host"));
			}
			throw new ArgumentNullException("host");
		}
		IPHostEntry iPHostEntry = null;
		try
		{
			iPHostEntry = Dns.InternalGetHostByName(host);
		}
		catch
		{
		}
		if (iPHostEntry == null)
		{
			return false;
		}
		IPAddress[] addressList = iPHostEntry.AddressList;
		if (addressList.Length == 0)
		{
			return false;
		}
		return true;
	}
}
