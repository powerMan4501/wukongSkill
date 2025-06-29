using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;

namespace System.Net.NetworkInformation;

internal class SystemIPGlobalProperties : IPGlobalProperties
{
	private FixedInfo fixedInfo;

	private bool fixedInfoInitialized;

	private static volatile string hostName = null;

	private static volatile string domainName = null;

	private static object syncObject = new object();

	internal FixedInfo FixedInfo
	{
		get
		{
			if (!fixedInfoInitialized)
			{
				lock (this)
				{
					if (!fixedInfoInitialized)
					{
						fixedInfo = GetFixedInfo();
						fixedInfoInitialized = true;
					}
				}
			}
			return fixedInfo;
		}
	}

	public override string HostName
	{
		get
		{
			if (hostName == null)
			{
				lock (syncObject)
				{
					if (hostName == null)
					{
						hostName = FixedInfo.HostName;
						domainName = FixedInfo.DomainName;
					}
				}
			}
			return hostName;
		}
	}

	public override string DomainName
	{
		get
		{
			if (domainName == null)
			{
				lock (syncObject)
				{
					if (domainName == null)
					{
						hostName = FixedInfo.HostName;
						domainName = FixedInfo.DomainName;
					}
				}
			}
			return domainName;
		}
	}

	public override NetBiosNodeType NodeType => FixedInfo.NodeType;

	public override string DhcpScopeName => FixedInfo.ScopeId;

	public override bool IsWinsProxy => FixedInfo.EnableProxy;

	internal SystemIPGlobalProperties()
	{
	}

	internal static FixedInfo GetFixedInfo()
	{
		uint pOutBufLen = 0u;
		SafeLocalFree safeLocalFree = null;
		FixedInfo result = default(FixedInfo);
		uint networkParams = UnsafeNetInfoNativeMethods.GetNetworkParams(SafeLocalFree.Zero, ref pOutBufLen);
		while (true)
		{
			switch (networkParams)
			{
			case 111u:
				try
				{
					safeLocalFree = SafeLocalFree.LocalAlloc((int)pOutBufLen);
					networkParams = UnsafeNetInfoNativeMethods.GetNetworkParams(safeLocalFree, ref pOutBufLen);
					if (networkParams == 0)
					{
						result = new FixedInfo((FIXED_INFO)Marshal.PtrToStructure(safeLocalFree.DangerousGetHandle(), typeof(FIXED_INFO)));
					}
				}
				finally
				{
					safeLocalFree?.Close();
				}
				break;
			default:
				throw new NetworkInformationException((int)networkParams);
			case 0u:
				return result;
			}
		}
	}

	public override TcpConnectionInformation[] GetActiveTcpConnections()
	{
		List<TcpConnectionInformation> list = new List<TcpConnectionInformation>();
		List<SystemTcpConnectionInformation> allTcpConnections = GetAllTcpConnections();
		foreach (SystemTcpConnectionInformation item in allTcpConnections)
		{
			if (item.State != TcpState.Listen)
			{
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	public override IPEndPoint[] GetActiveTcpListeners()
	{
		List<IPEndPoint> list = new List<IPEndPoint>();
		List<SystemTcpConnectionInformation> allTcpConnections = GetAllTcpConnections();
		foreach (SystemTcpConnectionInformation item in allTcpConnections)
		{
			if (item.State == TcpState.Listen)
			{
				list.Add(item.LocalEndPoint);
			}
		}
		return list.ToArray();
	}

	private List<SystemTcpConnectionInformation> GetAllTcpConnections()
	{
		uint dwOutBufLen = 0u;
		uint num = 0u;
		SafeLocalFree safeLocalFree = null;
		List<SystemTcpConnectionInformation> list = new List<SystemTcpConnectionInformation>();
		if (Socket.OSSupportsIPv4)
		{
			num = UnsafeNetInfoNativeMethods.GetTcpTable(SafeLocalFree.Zero, ref dwOutBufLen, order: true);
			while (true)
			{
				switch (num)
				{
				case 122u:
					try
					{
						safeLocalFree = SafeLocalFree.LocalAlloc((int)dwOutBufLen);
						num = UnsafeNetInfoNativeMethods.GetTcpTable(safeLocalFree, ref dwOutBufLen, order: true);
						if (num != 0)
						{
							continue;
						}
						IntPtr intPtr = safeLocalFree.DangerousGetHandle();
						MibTcpTable mibTcpTable = (MibTcpTable)Marshal.PtrToStructure(intPtr, typeof(MibTcpTable));
						if (mibTcpTable.numberOfEntries != 0)
						{
							intPtr = (IntPtr)((long)intPtr + Marshal.SizeOf((object)mibTcpTable.numberOfEntries));
							for (int i = 0; i < mibTcpTable.numberOfEntries; i++)
							{
								MibTcpRow mibTcpRow = (MibTcpRow)Marshal.PtrToStructure(intPtr, typeof(MibTcpRow));
								list.Add(new SystemTcpConnectionInformation(mibTcpRow));
								intPtr = (IntPtr)((long)intPtr + Marshal.SizeOf((object)mibTcpRow));
							}
						}
					}
					finally
					{
						safeLocalFree?.Close();
					}
					continue;
				default:
					throw new NetworkInformationException((int)num);
				case 0u:
				case 232u:
					break;
				}
				break;
			}
		}
		if (Socket.OSSupportsIPv6)
		{
			dwOutBufLen = 0u;
			num = UnsafeNetInfoNativeMethods.GetExtendedTcpTable(SafeLocalFree.Zero, ref dwOutBufLen, order: true, 23u, TcpTableClass.TcpTableOwnerPidAll, 0u);
			while (true)
			{
				switch (num)
				{
				case 122u:
					try
					{
						safeLocalFree = SafeLocalFree.LocalAlloc((int)dwOutBufLen);
						num = UnsafeNetInfoNativeMethods.GetExtendedTcpTable(safeLocalFree, ref dwOutBufLen, order: true, 23u, TcpTableClass.TcpTableOwnerPidAll, 0u);
						if (num != 0)
						{
							continue;
						}
						IntPtr intPtr2 = safeLocalFree.DangerousGetHandle();
						MibTcp6TableOwnerPid mibTcp6TableOwnerPid = (MibTcp6TableOwnerPid)Marshal.PtrToStructure(intPtr2, typeof(MibTcp6TableOwnerPid));
						if (mibTcp6TableOwnerPid.numberOfEntries != 0)
						{
							intPtr2 = (IntPtr)((long)intPtr2 + Marshal.SizeOf((object)mibTcp6TableOwnerPid.numberOfEntries));
							for (int j = 0; j < mibTcp6TableOwnerPid.numberOfEntries; j++)
							{
								MibTcp6RowOwnerPid mibTcp6RowOwnerPid = (MibTcp6RowOwnerPid)Marshal.PtrToStructure(intPtr2, typeof(MibTcp6RowOwnerPid));
								list.Add(new SystemTcpConnectionInformation(mibTcp6RowOwnerPid));
								intPtr2 = (IntPtr)((long)intPtr2 + Marshal.SizeOf((object)mibTcp6RowOwnerPid));
							}
						}
					}
					finally
					{
						safeLocalFree?.Close();
					}
					continue;
				default:
					throw new NetworkInformationException((int)num);
				case 0u:
				case 232u:
					break;
				}
				break;
			}
		}
		return list;
	}

	public override IPEndPoint[] GetActiveUdpListeners()
	{
		uint dwOutBufLen = 0u;
		uint num = 0u;
		SafeLocalFree safeLocalFree = null;
		List<IPEndPoint> list = new List<IPEndPoint>();
		if (Socket.OSSupportsIPv4)
		{
			num = UnsafeNetInfoNativeMethods.GetUdpTable(SafeLocalFree.Zero, ref dwOutBufLen, order: true);
			while (true)
			{
				switch (num)
				{
				case 122u:
					try
					{
						safeLocalFree = SafeLocalFree.LocalAlloc((int)dwOutBufLen);
						num = UnsafeNetInfoNativeMethods.GetUdpTable(safeLocalFree, ref dwOutBufLen, order: true);
						if (num != 0)
						{
							continue;
						}
						IntPtr intPtr = safeLocalFree.DangerousGetHandle();
						MibUdpTable mibUdpTable = (MibUdpTable)Marshal.PtrToStructure(intPtr, typeof(MibUdpTable));
						if (mibUdpTable.numberOfEntries != 0)
						{
							intPtr = (IntPtr)((long)intPtr + Marshal.SizeOf((object)mibUdpTable.numberOfEntries));
							for (int i = 0; i < mibUdpTable.numberOfEntries; i++)
							{
								MibUdpRow mibUdpRow = (MibUdpRow)Marshal.PtrToStructure(intPtr, typeof(MibUdpRow));
								int port = (mibUdpRow.localPort1 << 8) | mibUdpRow.localPort2;
								list.Add(new IPEndPoint(mibUdpRow.localAddr, port));
								intPtr = (IntPtr)((long)intPtr + Marshal.SizeOf((object)mibUdpRow));
							}
						}
					}
					finally
					{
						safeLocalFree?.Close();
					}
					continue;
				default:
					throw new NetworkInformationException((int)num);
				case 0u:
				case 232u:
					break;
				}
				break;
			}
		}
		if (Socket.OSSupportsIPv6)
		{
			dwOutBufLen = 0u;
			num = UnsafeNetInfoNativeMethods.GetExtendedUdpTable(SafeLocalFree.Zero, ref dwOutBufLen, order: true, 23u, UdpTableClass.UdpTableOwnerPid, 0u);
			while (true)
			{
				switch (num)
				{
				case 122u:
					try
					{
						safeLocalFree = SafeLocalFree.LocalAlloc((int)dwOutBufLen);
						num = UnsafeNetInfoNativeMethods.GetExtendedUdpTable(safeLocalFree, ref dwOutBufLen, order: true, 23u, UdpTableClass.UdpTableOwnerPid, 0u);
						if (num != 0)
						{
							continue;
						}
						IntPtr intPtr2 = safeLocalFree.DangerousGetHandle();
						MibUdp6TableOwnerPid mibUdp6TableOwnerPid = (MibUdp6TableOwnerPid)Marshal.PtrToStructure(intPtr2, typeof(MibUdp6TableOwnerPid));
						if (mibUdp6TableOwnerPid.numberOfEntries != 0)
						{
							intPtr2 = (IntPtr)((long)intPtr2 + Marshal.SizeOf((object)mibUdp6TableOwnerPid.numberOfEntries));
							for (int j = 0; j < mibUdp6TableOwnerPid.numberOfEntries; j++)
							{
								MibUdp6RowOwnerPid mibUdp6RowOwnerPid = (MibUdp6RowOwnerPid)Marshal.PtrToStructure(intPtr2, typeof(MibUdp6RowOwnerPid));
								int port2 = (mibUdp6RowOwnerPid.localPort1 << 8) | mibUdp6RowOwnerPid.localPort2;
								list.Add(new IPEndPoint(new IPAddress(mibUdp6RowOwnerPid.localAddr, mibUdp6RowOwnerPid.localScopeId), port2));
								intPtr2 = (IntPtr)((long)intPtr2 + Marshal.SizeOf((object)mibUdp6RowOwnerPid));
							}
						}
					}
					finally
					{
						safeLocalFree?.Close();
					}
					continue;
				default:
					throw new NetworkInformationException((int)num);
				case 0u:
				case 232u:
					break;
				}
				break;
			}
		}
		return list.ToArray();
	}

	public override IPGlobalStatistics GetIPv4GlobalStatistics()
	{
		return new SystemIPGlobalStatistics(AddressFamily.InterNetwork);
	}

	public override IPGlobalStatistics GetIPv6GlobalStatistics()
	{
		return new SystemIPGlobalStatistics(AddressFamily.InterNetworkV6);
	}

	public override TcpStatistics GetTcpIPv4Statistics()
	{
		return new SystemTcpStatistics(AddressFamily.InterNetwork);
	}

	public override TcpStatistics GetTcpIPv6Statistics()
	{
		return new SystemTcpStatistics(AddressFamily.InterNetworkV6);
	}

	public override UdpStatistics GetUdpIPv4Statistics()
	{
		return new SystemUdpStatistics(AddressFamily.InterNetwork);
	}

	public override UdpStatistics GetUdpIPv6Statistics()
	{
		return new SystemUdpStatistics(AddressFamily.InterNetworkV6);
	}

	public override IcmpV4Statistics GetIcmpV4Statistics()
	{
		return new SystemIcmpV4Statistics();
	}

	public override IcmpV6Statistics GetIcmpV6Statistics()
	{
		return new SystemIcmpV6Statistics();
	}

	public override UnicastIPAddressInformationCollection GetUnicastAddresses()
	{
		using (ManualResetEvent manualResetEvent = new ManualResetEvent(initialState: false))
		{
			if (!TeredoHelper.UnsafeNotifyStableUnicastIpAddressTable(StableUnicastAddressTableCallback, manualResetEvent))
			{
				manualResetEvent.WaitOne();
			}
		}
		return GetUnicastAddressTable();
	}

	public override IAsyncResult BeginGetUnicastAddresses(AsyncCallback callback, object state)
	{
		ContextAwareResult contextAwareResult = new ContextAwareResult(captureIdentity: false, forceCaptureContext: false, this, state, callback);
		contextAwareResult.StartPostingAsyncOp(lockCapture: false);
		if (TeredoHelper.UnsafeNotifyStableUnicastIpAddressTable(StableUnicastAddressTableCallback, contextAwareResult))
		{
			contextAwareResult.InvokeCallback();
		}
		contextAwareResult.FinishPostingAsyncOp();
		return contextAwareResult;
	}

	public override UnicastIPAddressInformationCollection EndGetUnicastAddresses(IAsyncResult asyncResult)
	{
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (!(asyncResult is ContextAwareResult { AsyncObject: not null } contextAwareResult) || contextAwareResult.AsyncObject.GetType() != typeof(SystemIPGlobalProperties))
		{
			throw new ArgumentException(SR.GetString("net_io_invalidasyncresult"));
		}
		if (contextAwareResult.EndCalled)
		{
			throw new InvalidOperationException(SR.GetString("net_io_invalidendcall", "EndGetStableUnicastAddresses"));
		}
		contextAwareResult.InternalWaitForCompletion();
		contextAwareResult.EndCalled = true;
		return GetUnicastAddressTable();
	}

	private static void StableUnicastAddressTableCallback(object param)
	{
		if (param is EventWaitHandle eventWaitHandle)
		{
			eventWaitHandle.Set();
			return;
		}
		LazyAsyncResult lazyAsyncResult = (LazyAsyncResult)param;
		lazyAsyncResult.InvokeCallback();
	}

	private static UnicastIPAddressInformationCollection GetUnicastAddressTable()
	{
		UnicastIPAddressInformationCollection unicastIPAddressInformationCollection = new UnicastIPAddressInformationCollection();
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		for (int i = 0; i < allNetworkInterfaces.Length; i++)
		{
			UnicastIPAddressInformationCollection unicastAddresses = allNetworkInterfaces[i].GetIPProperties().UnicastAddresses;
			foreach (UnicastIPAddressInformation item in unicastAddresses)
			{
				if (!unicastIPAddressInformationCollection.Contains(item))
				{
					unicastIPAddressInformationCollection.InternalAdd(item);
				}
			}
		}
		return unicastIPAddressInformationCollection;
	}
}
