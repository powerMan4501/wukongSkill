using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;

namespace System.Net.WebSockets;

internal static class WebSocketProtocolComponent
{
	internal static class Errors
	{
		internal const int E_INVALID_OPERATION = -2147483568;

		internal const int E_INVALID_PROTOCOL_OPERATION = -2147483567;

		internal const int E_INVALID_PROTOCOL_FORMAT = -2147483566;

		internal const int E_NUMERIC_OVERFLOW = -2147483565;

		internal const int E_FAIL = -2147467259;
	}

	internal enum Action
	{
		NoAction,
		SendToNetwork,
		IndicateSendComplete,
		ReceiveFromNetwork,
		IndicateReceiveComplete
	}

	internal enum BufferType : uint
	{
		None = 0u,
		UTF8Message = 2147483648u,
		UTF8Fragment = 2147483649u,
		BinaryMessage = 2147483650u,
		BinaryFragment = 2147483651u,
		Close = 2147483652u,
		PingPong = 2147483653u,
		UnsolicitedPong = 2147483654u
	}

	internal enum PropertyType
	{
		ReceiveBufferSize,
		SendBufferSize,
		DisableMasking,
		AllocatedBuffer,
		DisableUtf8Verification,
		KeepAliveInterval
	}

	internal enum ActionQueue
	{
		Send = 1,
		Receive
	}

	internal struct Property
	{
		internal PropertyType Type;

		internal IntPtr PropertyData;

		internal uint PropertySize;
	}

	[StructLayout(LayoutKind.Explicit)]
	internal struct Buffer
	{
		[FieldOffset(0)]
		internal DataBuffer Data;

		[FieldOffset(0)]
		internal CloseBuffer CloseStatus;
	}

	internal struct DataBuffer
	{
		internal IntPtr BufferData;

		internal uint BufferLength;
	}

	internal struct CloseBuffer
	{
		internal IntPtr ReasonData;

		internal uint ReasonLength;

		internal ushort CloseStatus;
	}

	internal struct HttpHeader
	{
		[MarshalAs(UnmanagedType.LPStr)]
		internal string Name;

		internal uint NameLength;

		[MarshalAs(UnmanagedType.LPStr)]
		internal string Value;

		internal uint ValueLength;
	}

	private const string WEBSOCKET = "websocket.dll";

	private static readonly string s_DllFileName;

	private static readonly string s_DummyWebsocketKeyBase64;

	private static readonly SafeLoadLibrary s_WebSocketDllHandle;

	private static readonly string s_SupportedVersion;

	private static readonly HttpHeader[] s_InitialClientRequestHeaders;

	private static readonly HttpHeader[] s_ServerFakeRequestHeaders;

	internal static string SupportedVersion
	{
		get
		{
			if (s_WebSocketDllHandle.IsInvalid)
			{
				WebSocketHelpers.ThrowPlatformNotSupportedException_WSPC();
			}
			return s_SupportedVersion;
		}
	}

	internal static bool IsSupported => !s_WebSocketDllHandle.IsInvalid;

	[SecuritySafeCritical]
	[FileIOPermission(SecurityAction.Assert, AllFiles = FileIOPermissionAccess.PathDiscovery)]
	static WebSocketProtocolComponent()
	{
		s_DummyWebsocketKeyBase64 = Convert.ToBase64String(new byte[16]);
		s_InitialClientRequestHeaders = new HttpHeader[2]
		{
			new HttpHeader
			{
				Name = "Connection",
				NameLength = (uint)"Connection".Length,
				Value = "Upgrade",
				ValueLength = (uint)"Upgrade".Length
			},
			new HttpHeader
			{
				Name = "Upgrade",
				NameLength = (uint)"Upgrade".Length,
				Value = "websocket",
				ValueLength = (uint)"websocket".Length
			}
		};
		s_DllFileName = Path.Combine(Environment.SystemDirectory, "websocket.dll");
		s_WebSocketDllHandle = SafeLoadLibrary.LoadLibraryEx(s_DllFileName);
		if (!s_WebSocketDllHandle.IsInvalid)
		{
			s_SupportedVersion = GetSupportedVersion();
			s_ServerFakeRequestHeaders = new HttpHeader[5]
			{
				new HttpHeader
				{
					Name = "Connection",
					NameLength = (uint)"Connection".Length,
					Value = "Upgrade",
					ValueLength = (uint)"Upgrade".Length
				},
				new HttpHeader
				{
					Name = "Upgrade",
					NameLength = (uint)"Upgrade".Length,
					Value = "websocket",
					ValueLength = (uint)"websocket".Length
				},
				new HttpHeader
				{
					Name = "Host",
					NameLength = (uint)"Host".Length,
					Value = string.Empty,
					ValueLength = 0u
				},
				new HttpHeader
				{
					Name = "Sec-WebSocket-Version",
					NameLength = (uint)"Sec-WebSocket-Version".Length,
					Value = s_SupportedVersion,
					ValueLength = (uint)s_SupportedVersion.Length
				},
				new HttpHeader
				{
					Name = "Sec-WebSocket-Key",
					NameLength = (uint)"Sec-WebSocket-Key".Length,
					Value = s_DummyWebsocketKeyBase64,
					ValueLength = (uint)s_DummyWebsocketKeyBase64.Length
				}
			};
		}
	}

	[DllImport("websocket.dll", EntryPoint = "WebSocketCreateClientHandle", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern int WebSocketCreateClientHandle_Raw([In] Property[] properties, [In] uint propertyCount, out SafeWebSocketHandle webSocketHandle);

	[DllImport("websocket.dll", EntryPoint = "WebSocketBeginClientHandshake", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern int WebSocketBeginClientHandshake_Raw([In] SafeHandle webSocketHandle, [In] IntPtr subProtocols, [In] uint subProtocolCount, [In] IntPtr extensions, [In] uint extensionCount, [In] HttpHeader[] initialHeaders, [In] uint initialHeaderCount, out IntPtr additionalHeadersPtr, out uint additionalHeaderCount);

	[DllImport("websocket.dll", EntryPoint = "WebSocketEndClientHandshake", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern int WebSocketEndClientHandshake_Raw([In] SafeHandle webSocketHandle, [In] HttpHeader[] responseHeaders, [In] uint responseHeaderCount, [In][Out] IntPtr selectedExtensions, [In] IntPtr selectedExtensionCount, [In] IntPtr selectedSubProtocol);

	[DllImport("websocket.dll", EntryPoint = "WebSocketBeginServerHandshake", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern int WebSocketBeginServerHandshake_Raw([In] SafeHandle webSocketHandle, [In] IntPtr subProtocol, [In] IntPtr extensions, [In] uint extensionCount, [In] HttpHeader[] requestHeaders, [In] uint requestHeaderCount, out IntPtr responseHeadersPtr, out uint responseHeaderCount);

	[DllImport("websocket.dll", EntryPoint = "WebSocketEndServerHandshake", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern int WebSocketEndServerHandshake_Raw([In] SafeHandle webSocketHandle);

	[DllImport("websocket.dll", EntryPoint = "WebSocketCreateServerHandle", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern int WebSocketCreateServerHandle_Raw([In] Property[] properties, [In] uint propertyCount, out SafeWebSocketHandle webSocketHandle);

	[DllImport("websocket.dll", EntryPoint = "WebSocketAbortHandle", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern void WebSocketAbortHandle_Raw([In] SafeHandle webSocketHandle);

	[DllImport("websocket.dll", EntryPoint = "WebSocketDeleteHandle", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern void WebSocketDeleteHandle_Raw([In] IntPtr webSocketHandle);

	[DllImport("websocket.dll", EntryPoint = "WebSocketSend", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern int WebSocketSend_Raw([In] SafeHandle webSocketHandle, [In] BufferType bufferType, [In] ref Buffer buffer, [In] IntPtr applicationContext);

	[DllImport("websocket.dll", EntryPoint = "WebSocketSend", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern int WebSocketSendWithoutBody_Raw([In] SafeHandle webSocketHandle, [In] BufferType bufferType, [In] IntPtr buffer, [In] IntPtr applicationContext);

	[DllImport("websocket.dll", EntryPoint = "WebSocketReceive", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern int WebSocketReceive_Raw([In] SafeHandle webSocketHandle, [In] IntPtr buffers, [In] IntPtr applicationContext);

	[DllImport("websocket.dll", EntryPoint = "WebSocketGetAction", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern int WebSocketGetAction_Raw([In] SafeHandle webSocketHandle, [In] ActionQueue actionQueue, [In][Out] Buffer[] dataBuffers, [In][Out] ref uint dataBufferCount, out Action action, out BufferType bufferType, out IntPtr applicationContext, out IntPtr actionContext);

	[DllImport("websocket.dll", EntryPoint = "WebSocketCompleteAction", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern void WebSocketCompleteAction_Raw([In] SafeHandle webSocketHandle, [In] IntPtr actionContext, [In] uint bytesTransferred);

	[DllImport("websocket.dll", EntryPoint = "WebSocketGetGlobalProperty", ExactSpelling = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern int WebSocketGetGlobalProperty_Raw([In] PropertyType property, [In][Out] ref uint value, [In][Out] ref uint size);

	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	internal static string GetSupportedVersion()
	{
		if (s_WebSocketDllHandle.IsInvalid)
		{
			WebSocketHelpers.ThrowPlatformNotSupportedException_WSPC();
		}
		SafeWebSocketHandle webSocketHandle = null;
		try
		{
			int errorCode = WebSocketCreateClientHandle_Raw(null, 0u, out webSocketHandle);
			ThrowOnError(errorCode);
			if (webSocketHandle == null || webSocketHandle.IsInvalid)
			{
				WebSocketHelpers.ThrowPlatformNotSupportedException_WSPC();
			}
			errorCode = WebSocketBeginClientHandshake_Raw(webSocketHandle, IntPtr.Zero, 0u, IntPtr.Zero, 0u, s_InitialClientRequestHeaders, (uint)s_InitialClientRequestHeaders.Length, out var additionalHeadersPtr, out var additionalHeaderCount);
			ThrowOnError(errorCode);
			HttpHeader[] array = MarshalHttpHeaders(additionalHeadersPtr, (int)additionalHeaderCount);
			string result = null;
			HttpHeader[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				HttpHeader httpHeader = array2[i];
				if (string.Compare(httpHeader.Name, "Sec-WebSocket-Version", StringComparison.OrdinalIgnoreCase) == 0)
				{
					result = httpHeader.Value;
					break;
				}
			}
			return result;
		}
		finally
		{
			webSocketHandle?.Dispose();
		}
	}

	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	internal static void WebSocketCreateClientHandle(Property[] properties, out SafeWebSocketHandle webSocketHandle)
	{
		uint propertyCount = ((properties != null) ? ((uint)properties.Length) : 0u);
		if (s_WebSocketDllHandle.IsInvalid)
		{
			WebSocketHelpers.ThrowPlatformNotSupportedException_WSPC();
		}
		int errorCode = WebSocketCreateClientHandle_Raw(properties, propertyCount, out webSocketHandle);
		ThrowOnError(errorCode);
		if (webSocketHandle == null || webSocketHandle.IsInvalid)
		{
			WebSocketHelpers.ThrowPlatformNotSupportedException_WSPC();
		}
		errorCode = WebSocketBeginClientHandshake_Raw(webSocketHandle, IntPtr.Zero, 0u, IntPtr.Zero, 0u, s_InitialClientRequestHeaders, (uint)s_InitialClientRequestHeaders.Length, out var additionalHeadersPtr, out var additionalHeaderCount);
		ThrowOnError(errorCode);
		HttpHeader[] array = MarshalHttpHeaders(additionalHeadersPtr, (int)additionalHeaderCount);
		string secWebSocketKey = null;
		HttpHeader[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			HttpHeader httpHeader = array2[i];
			if (string.Compare(httpHeader.Name, "Sec-WebSocket-Key", StringComparison.OrdinalIgnoreCase) == 0)
			{
				secWebSocketKey = httpHeader.Value;
				break;
			}
		}
		string secWebSocketAcceptString = WebSocketHelpers.GetSecWebSocketAcceptString(secWebSocketKey);
		HttpHeader[] array3 = new HttpHeader[3]
		{
			new HttpHeader
			{
				Name = "Connection",
				NameLength = (uint)"Connection".Length,
				Value = "Upgrade",
				ValueLength = (uint)"Upgrade".Length
			},
			new HttpHeader
			{
				Name = "Upgrade",
				NameLength = (uint)"Upgrade".Length,
				Value = "websocket",
				ValueLength = (uint)"websocket".Length
			},
			new HttpHeader
			{
				Name = "Sec-WebSocket-Accept",
				NameLength = (uint)"Sec-WebSocket-Accept".Length,
				Value = secWebSocketAcceptString,
				ValueLength = (uint)secWebSocketAcceptString.Length
			}
		};
		errorCode = WebSocketEndClientHandshake_Raw(webSocketHandle, array3, (uint)array3.Length, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
		ThrowOnError(errorCode);
	}

	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	internal static void WebSocketCreateServerHandle(Property[] properties, int propertyCount, out SafeWebSocketHandle webSocketHandle)
	{
		if (s_WebSocketDllHandle.IsInvalid)
		{
			WebSocketHelpers.ThrowPlatformNotSupportedException_WSPC();
		}
		int errorCode = WebSocketCreateServerHandle_Raw(properties, (uint)propertyCount, out webSocketHandle);
		ThrowOnError(errorCode);
		if (webSocketHandle == null || webSocketHandle.IsInvalid)
		{
			WebSocketHelpers.ThrowPlatformNotSupportedException_WSPC();
		}
		errorCode = WebSocketBeginServerHandshake_Raw(webSocketHandle, IntPtr.Zero, IntPtr.Zero, 0u, s_ServerFakeRequestHeaders, (uint)s_ServerFakeRequestHeaders.Length, out var responseHeadersPtr, out var responseHeaderCount);
		ThrowOnError(errorCode);
		HttpHeader[] array = MarshalHttpHeaders(responseHeadersPtr, (int)responseHeaderCount);
		errorCode = WebSocketEndServerHandshake_Raw(webSocketHandle);
		ThrowOnError(errorCode);
	}

	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	internal static void WebSocketAbortHandle(SafeHandle webSocketHandle)
	{
		WebSocketAbortHandle_Raw(webSocketHandle);
		DrainActionQueue(webSocketHandle, ActionQueue.Send);
		DrainActionQueue(webSocketHandle, ActionQueue.Receive);
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	internal static void WebSocketDeleteHandle(IntPtr webSocketPtr)
	{
		WebSocketDeleteHandle_Raw(webSocketPtr);
	}

	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	internal static void WebSocketSend(WebSocketBase webSocket, BufferType bufferType, Buffer buffer)
	{
		ThrowIfSessionHandleClosed(webSocket);
		int errorCode;
		try
		{
			errorCode = WebSocketSend_Raw(webSocket.SessionHandle, bufferType, ref buffer, IntPtr.Zero);
		}
		catch (ObjectDisposedException innerException)
		{
			throw ConvertObjectDisposedException(webSocket, innerException);
		}
		ThrowOnError(errorCode);
	}

	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	internal static void WebSocketSendWithoutBody(WebSocketBase webSocket, BufferType bufferType)
	{
		ThrowIfSessionHandleClosed(webSocket);
		int errorCode;
		try
		{
			errorCode = WebSocketSendWithoutBody_Raw(webSocket.SessionHandle, bufferType, IntPtr.Zero, IntPtr.Zero);
		}
		catch (ObjectDisposedException innerException)
		{
			throw ConvertObjectDisposedException(webSocket, innerException);
		}
		ThrowOnError(errorCode);
	}

	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	internal static void WebSocketReceive(WebSocketBase webSocket)
	{
		ThrowIfSessionHandleClosed(webSocket);
		int errorCode;
		try
		{
			errorCode = WebSocketReceive_Raw(webSocket.SessionHandle, IntPtr.Zero, IntPtr.Zero);
		}
		catch (ObjectDisposedException innerException)
		{
			throw ConvertObjectDisposedException(webSocket, innerException);
		}
		ThrowOnError(errorCode);
	}

	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	internal static void WebSocketGetAction(WebSocketBase webSocket, ActionQueue actionQueue, Buffer[] dataBuffers, ref uint dataBufferCount, out Action action, out BufferType bufferType, out IntPtr actionContext)
	{
		action = Action.NoAction;
		bufferType = BufferType.None;
		actionContext = IntPtr.Zero;
		ThrowIfSessionHandleClosed(webSocket);
		int errorCode;
		try
		{
			errorCode = WebSocketGetAction_Raw(webSocket.SessionHandle, actionQueue, dataBuffers, ref dataBufferCount, out action, out bufferType, out var _, out actionContext);
		}
		catch (ObjectDisposedException innerException)
		{
			throw ConvertObjectDisposedException(webSocket, innerException);
		}
		ThrowOnError(errorCode);
		webSocket.ValidateNativeBuffers(action, bufferType, dataBuffers, dataBufferCount);
	}

	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	internal static void WebSocketCompleteAction(WebSocketBase webSocket, IntPtr actionContext, int bytesTransferred)
	{
		if (webSocket.SessionHandle.IsClosed)
		{
			return;
		}
		try
		{
			WebSocketCompleteAction_Raw(webSocket.SessionHandle, actionContext, (uint)bytesTransferred);
		}
		catch (ObjectDisposedException)
		{
		}
	}

	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	internal static TimeSpan WebSocketGetDefaultKeepAliveInterval()
	{
		uint value = 0u;
		uint size = 4u;
		int hr = WebSocketGetGlobalProperty_Raw(PropertyType.KeepAliveInterval, ref value, ref size);
		if (!Succeeded(hr))
		{
			return Timeout.InfiniteTimeSpan;
		}
		return TimeSpan.FromMilliseconds(value);
	}

	private static void DrainActionQueue(SafeHandle webSocketHandle, ActionQueue actionQueue)
	{
		while (true)
		{
			Buffer[] dataBuffers = new Buffer[1];
			uint dataBufferCount = 1u;
			Action action;
			BufferType bufferType;
			IntPtr applicationContext;
			IntPtr actionContext;
			int hr = WebSocketGetAction_Raw(webSocketHandle, actionQueue, dataBuffers, ref dataBufferCount, out action, out bufferType, out applicationContext, out actionContext);
			if (!Succeeded(hr) || action == Action.NoAction)
			{
				break;
			}
			WebSocketCompleteAction_Raw(webSocketHandle, actionContext, 0u);
		}
	}

	private static void MarshalAndVerifyHttpHeader(IntPtr httpHeaderPtr, ref HttpHeader httpHeader)
	{
		IntPtr intPtr = Marshal.ReadIntPtr(httpHeaderPtr);
		IntPtr ptr = IntPtr.Add(httpHeaderPtr, IntPtr.Size);
		int num = Marshal.ReadInt32(ptr);
		if (intPtr != IntPtr.Zero)
		{
			httpHeader.Name = Marshal.PtrToStringAnsi(intPtr, num);
		}
		if ((httpHeader.Name == null && num != 0) || (httpHeader.Name != null && num != httpHeader.Name.Length))
		{
			throw new AccessViolationException();
		}
		int offset = 2 * IntPtr.Size;
		int offset2 = 3 * IntPtr.Size;
		IntPtr ptr2 = Marshal.ReadIntPtr(IntPtr.Add(httpHeaderPtr, offset));
		ptr = IntPtr.Add(httpHeaderPtr, offset2);
		num = Marshal.ReadInt32(ptr);
		httpHeader.Value = Marshal.PtrToStringAnsi(ptr2, num);
		if ((httpHeader.Value == null && num != 0) || (httpHeader.Value != null && num != httpHeader.Value.Length))
		{
			throw new AccessViolationException();
		}
	}

	private static HttpHeader[] MarshalHttpHeaders(IntPtr nativeHeadersPtr, int nativeHeaderCount)
	{
		HttpHeader[] array = new HttpHeader[nativeHeaderCount];
		int num = 4 * IntPtr.Size;
		for (int i = 0; i < nativeHeaderCount; i++)
		{
			int offset = num * i;
			IntPtr httpHeaderPtr = IntPtr.Add(nativeHeadersPtr, offset);
			MarshalAndVerifyHttpHeader(httpHeaderPtr, ref array[i]);
		}
		return array;
	}

	public static bool Succeeded(int hr)
	{
		return hr >= 0;
	}

	private static void ThrowOnError(int errorCode)
	{
		if (Succeeded(errorCode))
		{
			return;
		}
		throw new WebSocketException(errorCode);
	}

	private static void ThrowIfSessionHandleClosed(WebSocketBase webSocket)
	{
		if (webSocket.SessionHandle.IsClosed)
		{
			throw new WebSocketException(WebSocketError.InvalidState, SR.GetString("net_WebSockets_InvalidState_ClosedOrAborted", webSocket.GetType().FullName, webSocket.State));
		}
	}

	private static WebSocketException ConvertObjectDisposedException(WebSocketBase webSocket, ObjectDisposedException innerException)
	{
		return new WebSocketException(WebSocketError.InvalidState, SR.GetString("net_WebSockets_InvalidState_ClosedOrAborted", webSocket.GetType().FullName, webSocket.State), innerException);
	}
}
