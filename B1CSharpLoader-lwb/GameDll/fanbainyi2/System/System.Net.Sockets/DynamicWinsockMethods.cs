using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace System.Net.Sockets;

internal sealed class DynamicWinsockMethods
{
	private static List<DynamicWinsockMethods> s_MethodTable = new List<DynamicWinsockMethods>();

	private AddressFamily addressFamily;

	private SocketType socketType;

	private ProtocolType protocolType;

	private object lockObject;

	private AcceptExDelegate acceptEx;

	private GetAcceptExSockaddrsDelegate getAcceptExSockaddrs;

	private ConnectExDelegate connectEx;

	private TransmitPacketsDelegate transmitPackets;

	private DisconnectExDelegate disconnectEx;

	private DisconnectExDelegate_Blocking disconnectEx_Blocking;

	private WSARecvMsgDelegate recvMsg;

	private WSARecvMsgDelegate_Blocking recvMsg_Blocking;

	public static DynamicWinsockMethods GetMethods(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)
	{
		lock (s_MethodTable)
		{
			DynamicWinsockMethods dynamicWinsockMethods;
			for (int i = 0; i < s_MethodTable.Count; i++)
			{
				dynamicWinsockMethods = s_MethodTable[i];
				if (dynamicWinsockMethods.addressFamily == addressFamily && dynamicWinsockMethods.socketType == socketType && dynamicWinsockMethods.protocolType == protocolType)
				{
					return dynamicWinsockMethods;
				}
			}
			dynamicWinsockMethods = new DynamicWinsockMethods(addressFamily, socketType, protocolType);
			s_MethodTable.Add(dynamicWinsockMethods);
			return dynamicWinsockMethods;
		}
	}

	private DynamicWinsockMethods(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)
	{
		this.addressFamily = addressFamily;
		this.socketType = socketType;
		this.protocolType = protocolType;
		lockObject = new object();
	}

	public T GetDelegate<T>(SafeCloseSocket socketHandle) where T : class
	{
		if (typeof(T) == typeof(AcceptExDelegate))
		{
			EnsureAcceptEx(socketHandle);
			return (T)(object)acceptEx;
		}
		if (typeof(T) == typeof(GetAcceptExSockaddrsDelegate))
		{
			EnsureGetAcceptExSockaddrs(socketHandle);
			return (T)(object)getAcceptExSockaddrs;
		}
		if (typeof(T) == typeof(ConnectExDelegate))
		{
			EnsureConnectEx(socketHandle);
			return (T)(object)connectEx;
		}
		if (typeof(T) == typeof(DisconnectExDelegate))
		{
			EnsureDisconnectEx(socketHandle);
			return (T)(object)disconnectEx;
		}
		if (typeof(T) == typeof(DisconnectExDelegate_Blocking))
		{
			EnsureDisconnectEx(socketHandle);
			return (T)(object)disconnectEx_Blocking;
		}
		if (typeof(T) == typeof(WSARecvMsgDelegate))
		{
			EnsureWSARecvMsg(socketHandle);
			return (T)(object)recvMsg;
		}
		if (typeof(T) == typeof(WSARecvMsgDelegate_Blocking))
		{
			EnsureWSARecvMsg(socketHandle);
			return (T)(object)recvMsg_Blocking;
		}
		if (typeof(T) == typeof(TransmitPacketsDelegate))
		{
			EnsureTransmitPackets(socketHandle);
			return (T)(object)transmitPackets;
		}
		return null;
	}

	private unsafe IntPtr LoadDynamicFunctionPointer(SafeCloseSocket socketHandle, ref Guid guid)
	{
		IntPtr funcPtr = IntPtr.Zero;
		if (UnsafeNclNativeMethods.OSSOCK.WSAIoctl(socketHandle, -939524090, ref guid, sizeof(Guid), out funcPtr, sizeof(IntPtr), out var _, IntPtr.Zero, IntPtr.Zero) != SocketError.Success)
		{
			throw new SocketException();
		}
		return funcPtr;
	}

	private void EnsureAcceptEx(SafeCloseSocket socketHandle)
	{
		if (acceptEx != null)
		{
			return;
		}
		lock (lockObject)
		{
			if (acceptEx == null)
			{
				Guid guid = new Guid("{0xb5367df1,0xcbac,0x11cf,{0x95, 0xca, 0x00, 0x80, 0x5f, 0x48, 0xa1, 0x92}}");
				IntPtr ptr = LoadDynamicFunctionPointer(socketHandle, ref guid);
				acceptEx = (AcceptExDelegate)Marshal.GetDelegateForFunctionPointer(ptr, typeof(AcceptExDelegate));
			}
		}
	}

	private void EnsureGetAcceptExSockaddrs(SafeCloseSocket socketHandle)
	{
		if (getAcceptExSockaddrs != null)
		{
			return;
		}
		lock (lockObject)
		{
			if (getAcceptExSockaddrs == null)
			{
				Guid guid = new Guid("{0xb5367df2,0xcbac,0x11cf,{0x95, 0xca, 0x00, 0x80, 0x5f, 0x48, 0xa1, 0x92}}");
				IntPtr ptr = LoadDynamicFunctionPointer(socketHandle, ref guid);
				getAcceptExSockaddrs = (GetAcceptExSockaddrsDelegate)Marshal.GetDelegateForFunctionPointer(ptr, typeof(GetAcceptExSockaddrsDelegate));
			}
		}
	}

	private void EnsureConnectEx(SafeCloseSocket socketHandle)
	{
		if (connectEx != null)
		{
			return;
		}
		lock (lockObject)
		{
			if (connectEx == null)
			{
				Guid guid = new Guid("{0x25a207b9,0x0ddf3,0x4660,{0x8e,0xe9,0x76,0xe5,0x8c,0x74,0x06,0x3e}}");
				IntPtr ptr = LoadDynamicFunctionPointer(socketHandle, ref guid);
				connectEx = (ConnectExDelegate)Marshal.GetDelegateForFunctionPointer(ptr, typeof(ConnectExDelegate));
			}
		}
	}

	private void EnsureDisconnectEx(SafeCloseSocket socketHandle)
	{
		if (disconnectEx != null)
		{
			return;
		}
		lock (lockObject)
		{
			if (disconnectEx == null)
			{
				Guid guid = new Guid("{0x7fda2e11,0x8630,0x436f,{0xa0, 0x31, 0xf5, 0x36, 0xa6, 0xee, 0xc1, 0x57}}");
				IntPtr ptr = LoadDynamicFunctionPointer(socketHandle, ref guid);
				disconnectEx = (DisconnectExDelegate)Marshal.GetDelegateForFunctionPointer(ptr, typeof(DisconnectExDelegate));
				disconnectEx_Blocking = (DisconnectExDelegate_Blocking)Marshal.GetDelegateForFunctionPointer(ptr, typeof(DisconnectExDelegate_Blocking));
			}
		}
	}

	private void EnsureWSARecvMsg(SafeCloseSocket socketHandle)
	{
		if (recvMsg != null)
		{
			return;
		}
		lock (lockObject)
		{
			if (recvMsg == null)
			{
				Guid guid = new Guid("{0xf689d7c8,0x6f1f,0x436b,{0x8a,0x53,0xe5,0x4f,0xe3,0x51,0xc3,0x22}}");
				IntPtr ptr = LoadDynamicFunctionPointer(socketHandle, ref guid);
				recvMsg = (WSARecvMsgDelegate)Marshal.GetDelegateForFunctionPointer(ptr, typeof(WSARecvMsgDelegate));
				recvMsg_Blocking = (WSARecvMsgDelegate_Blocking)Marshal.GetDelegateForFunctionPointer(ptr, typeof(WSARecvMsgDelegate_Blocking));
			}
		}
	}

	private void EnsureTransmitPackets(SafeCloseSocket socketHandle)
	{
		if (transmitPackets != null)
		{
			return;
		}
		lock (lockObject)
		{
			if (transmitPackets == null)
			{
				Guid guid = new Guid("{0xd9689da0,0x1f90,0x11d3,{0x99,0x71,0x00,0xc0,0x4f,0x68,0xc8,0x76}}");
				IntPtr ptr = LoadDynamicFunctionPointer(socketHandle, ref guid);
				transmitPackets = (TransmitPacketsDelegate)Marshal.GetDelegateForFunctionPointer(ptr, typeof(TransmitPacketsDelegate));
			}
		}
	}
}
