using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;

namespace System.Net.Sockets;

public class SocketAsyncEventArgs : EventArgs, IDisposable
{
	private enum PinState
	{
		None,
		NoBuffer,
		SingleAcceptBuffer,
		SingleBuffer,
		MultipleBuffer,
		SendPackets
	}

	internal static readonly int s_ControlDataSize = Marshal.SizeOf(typeof(UnsafeNclNativeMethods.OSSOCK.ControlData));

	internal static readonly int s_ControlDataIPv6Size = Marshal.SizeOf(typeof(UnsafeNclNativeMethods.OSSOCK.ControlDataIPv6));

	internal static readonly int s_WSAMsgSize = Marshal.SizeOf(typeof(UnsafeNclNativeMethods.OSSOCK.WSAMsg));

	internal Socket m_AcceptSocket;

	private Socket m_ConnectSocket;

	internal byte[] m_Buffer;

	internal WSABuffer m_WSABuffer;

	internal IntPtr m_PtrSingleBuffer;

	internal int m_Count;

	internal int m_Offset;

	internal IList<ArraySegment<byte>> m_BufferList;

	private bool m_BufferListChanged;

	internal WSABuffer[] m_WSABufferArray;

	private int m_BytesTransferred;

	private bool m_CompletedChanged;

	private bool m_DisconnectReuseSocket;

	private SocketAsyncOperation m_CompletedOperation;

	private IPPacketInformation m_ReceiveMessageFromPacketInfo;

	private EndPoint m_RemoteEndPoint;

	internal TransmitFileOptions m_SendPacketsFlags;

	internal int m_SendPacketsSendSize;

	internal SendPacketsElement[] m_SendPacketsElements;

	private SendPacketsElement[] m_SendPacketsElementsInternal;

	internal int m_SendPacketsElementsFileCount;

	internal int m_SendPacketsElementsBufferCount;

	private SocketError m_SocketError;

	private Exception m_ConnectByNameError;

	internal SocketFlags m_SocketFlags;

	private object m_UserToken;

	internal byte[] m_AcceptBuffer;

	internal int m_AcceptAddressBufferCount;

	internal IntPtr m_PtrAcceptBuffer;

	internal SocketAddress m_SocketAddress;

	private GCHandle m_SocketAddressGCHandle;

	private SocketAddress m_PinnedSocketAddress;

	internal IntPtr m_PtrSocketAddressBuffer;

	internal IntPtr m_PtrSocketAddressBufferSize;

	private byte[] m_WSAMessageBuffer;

	private GCHandle m_WSAMessageBufferGCHandle;

	internal IntPtr m_PtrWSAMessageBuffer;

	private byte[] m_ControlBuffer;

	private GCHandle m_ControlBufferGCHandle;

	internal IntPtr m_PtrControlBuffer;

	private WSABuffer[] m_WSARecvMsgWSABufferArray;

	private GCHandle m_WSARecvMsgWSABufferArrayGCHandle;

	private IntPtr m_PtrWSARecvMsgWSABufferArray;

	internal FileStream[] m_SendPacketsFileStreams;

	internal SafeHandle[] m_SendPacketsFileHandles;

	internal UnsafeNclNativeMethods.OSSOCK.TransmitPacketsElement[] m_SendPacketsDescriptor;

	internal IntPtr m_PtrSendPacketsDescriptor;

	private ExecutionContext m_Context;

	private ExecutionContext m_ContextCopy;

	private ContextCallback m_ExecutionCallback;

	private Socket m_CurrentSocket;

	private bool m_DisposeCalled;

	private const int Configuring = -1;

	private const int Free = 0;

	private const int InProgress = 1;

	private const int Disposed = 2;

	private int m_Operating;

	internal SafeNativeOverlapped m_PtrNativeOverlapped;

	private Overlapped m_Overlapped;

	private object[] m_ObjectsToPin;

	private PinState m_PinState;

	private byte[] m_PinnedAcceptBuffer;

	private byte[] m_PinnedSingleBuffer;

	private int m_PinnedSingleBufferOffset;

	private int m_PinnedSingleBufferCount;

	private MultipleConnectAsync m_MultipleConnect;

	private static bool s_LoggingEnabled = Logging.On;

	[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SocketClientAccessPolicyProtocol SocketClientAccessPolicyProtocol { get; set; }

	public Socket AcceptSocket
	{
		get
		{
			return m_AcceptSocket;
		}
		set
		{
			m_AcceptSocket = value;
		}
	}

	public Socket ConnectSocket => m_ConnectSocket;

	public byte[] Buffer => m_Buffer;

	public int Offset => m_Offset;

	public int Count => m_Count;

	public IList<ArraySegment<byte>> BufferList
	{
		get
		{
			return m_BufferList;
		}
		set
		{
			StartConfiguring();
			try
			{
				if (value != null && m_Buffer != null)
				{
					throw new ArgumentException(SR.GetString("net_ambiguousbuffers", "Buffer"));
				}
				m_BufferList = value;
				m_BufferListChanged = true;
				CheckPinMultipleBuffers();
			}
			finally
			{
				Complete();
			}
		}
	}

	public int BytesTransferred => m_BytesTransferred;

	public bool DisconnectReuseSocket
	{
		get
		{
			return m_DisconnectReuseSocket;
		}
		set
		{
			m_DisconnectReuseSocket = value;
		}
	}

	public SocketAsyncOperation LastOperation => m_CompletedOperation;

	public IPPacketInformation ReceiveMessageFromPacketInfo => m_ReceiveMessageFromPacketInfo;

	public EndPoint RemoteEndPoint
	{
		get
		{
			return m_RemoteEndPoint;
		}
		set
		{
			m_RemoteEndPoint = value;
		}
	}

	public SendPacketsElement[] SendPacketsElements
	{
		get
		{
			return m_SendPacketsElements;
		}
		set
		{
			StartConfiguring();
			try
			{
				m_SendPacketsElements = value;
				m_SendPacketsElementsInternal = null;
			}
			finally
			{
				Complete();
			}
		}
	}

	public TransmitFileOptions SendPacketsFlags
	{
		get
		{
			return m_SendPacketsFlags;
		}
		set
		{
			m_SendPacketsFlags = value;
		}
	}

	public int SendPacketsSendSize
	{
		get
		{
			return m_SendPacketsSendSize;
		}
		set
		{
			m_SendPacketsSendSize = value;
		}
	}

	public SocketError SocketError
	{
		get
		{
			return m_SocketError;
		}
		set
		{
			m_SocketError = value;
		}
	}

	public Exception ConnectByNameError => m_ConnectByNameError;

	public SocketFlags SocketFlags
	{
		get
		{
			return m_SocketFlags;
		}
		set
		{
			m_SocketFlags = value;
		}
	}

	public object UserToken
	{
		get
		{
			return m_UserToken;
		}
		set
		{
			m_UserToken = value;
		}
	}

	private event EventHandler<SocketAsyncEventArgs> m_Completed;

	public event EventHandler<SocketAsyncEventArgs> Completed
	{
		add
		{
			m_Completed += value;
			m_CompletedChanged = true;
		}
		remove
		{
			m_Completed -= value;
			m_CompletedChanged = true;
		}
	}

	public SocketAsyncEventArgs()
	{
		m_ExecutionCallback = ExecutionCallback;
		m_SendPacketsSendSize = 0;
	}

	protected virtual void OnCompleted(SocketAsyncEventArgs e)
	{
		this.m_Completed?.Invoke(e.m_CurrentSocket, e);
	}

	public void SetBuffer(byte[] buffer, int offset, int count)
	{
		SetBufferInternal(buffer, offset, count);
	}

	public void SetBuffer(int offset, int count)
	{
		SetBufferInternal(m_Buffer, offset, count);
	}

	private void SetBufferInternal(byte[] buffer, int offset, int count)
	{
		StartConfiguring();
		try
		{
			if (buffer == null)
			{
				m_Buffer = null;
				m_Offset = 0;
				m_Count = 0;
			}
			else
			{
				if (m_BufferList != null)
				{
					throw new ArgumentException(SR.GetString("net_ambiguousbuffers", "BufferList"));
				}
				if (offset < 0 || offset > buffer.Length)
				{
					throw new ArgumentOutOfRangeException("offset");
				}
				if (count < 0 || count > buffer.Length - offset)
				{
					throw new ArgumentOutOfRangeException("count");
				}
				m_Buffer = buffer;
				m_Offset = offset;
				m_Count = count;
			}
			CheckPinSingleBuffer(pinUsersBuffer: true);
		}
		finally
		{
			Complete();
		}
	}

	internal void SetResults(SocketError socketError, int bytesTransferred, SocketFlags flags)
	{
		m_SocketError = socketError;
		m_ConnectByNameError = null;
		m_BytesTransferred = bytesTransferred;
		m_SocketFlags = flags;
	}

	internal void SetResults(Exception exception, int bytesTransferred, SocketFlags flags)
	{
		m_ConnectByNameError = exception;
		m_BytesTransferred = bytesTransferred;
		m_SocketFlags = flags;
		if (exception == null)
		{
			m_SocketError = SocketError.Success;
		}
		else if (exception is SocketException ex)
		{
			m_SocketError = ex.SocketErrorCode;
		}
		else
		{
			m_SocketError = SocketError.SocketError;
		}
	}

	private void ExecutionCallback(object ignored)
	{
		OnCompleted(this);
	}

	internal void Complete()
	{
		m_Operating = 0;
		if (m_DisposeCalled)
		{
			Dispose();
		}
	}

	public void Dispose()
	{
		m_DisposeCalled = true;
		if (Interlocked.CompareExchange(ref m_Operating, 2, 0) == 0)
		{
			FreeOverlapped(checkForShutdown: false);
			GC.SuppressFinalize(this);
		}
	}

	~SocketAsyncEventArgs()
	{
		FreeOverlapped(checkForShutdown: true);
	}

	private void StartConfiguring()
	{
		switch (Interlocked.CompareExchange(ref m_Operating, -1, 0))
		{
		case -1:
		case 1:
			throw new InvalidOperationException(SR.GetString("net_socketopinprogress"));
		case 2:
			throw new ObjectDisposedException(GetType().FullName);
		}
	}

	internal void StartOperationCommon(Socket socket)
	{
		if (Interlocked.CompareExchange(ref m_Operating, 1, 0) != 0)
		{
			if (m_DisposeCalled)
			{
				throw new ObjectDisposedException(GetType().FullName);
			}
			throw new InvalidOperationException(SR.GetString("net_socketopinprogress"));
		}
		if (ExecutionContext.IsFlowSuppressed())
		{
			m_Context = null;
			m_ContextCopy = null;
		}
		else
		{
			if (m_CompletedChanged || socket != m_CurrentSocket)
			{
				m_CompletedChanged = false;
				m_Context = null;
				m_ContextCopy = null;
			}
			if (m_Context == null)
			{
				m_Context = ExecutionContext.Capture();
			}
			if (m_Context != null)
			{
				m_ContextCopy = m_Context.CreateCopy();
			}
		}
		m_CurrentSocket = socket;
	}

	internal void StartOperationAccept()
	{
		m_CompletedOperation = SocketAsyncOperation.Accept;
		m_AcceptAddressBufferCount = 2 * (m_CurrentSocket.m_RightEndPoint.Serialize().Size + 16);
		if (m_Buffer != null)
		{
			if (m_Count < m_AcceptAddressBufferCount)
			{
				throw new ArgumentException(SR.GetString("net_buffercounttoosmall", "Count"));
			}
		}
		else
		{
			if (m_AcceptBuffer == null || m_AcceptBuffer.Length < m_AcceptAddressBufferCount)
			{
				m_AcceptBuffer = new byte[m_AcceptAddressBufferCount];
			}
			CheckPinSingleBuffer(pinUsersBuffer: false);
		}
	}

	internal void StartOperationConnect()
	{
		m_CompletedOperation = SocketAsyncOperation.Connect;
		m_MultipleConnect = null;
		m_ConnectSocket = null;
		PinSocketAddressBuffer();
		CheckPinNoBuffer();
	}

	internal void StartOperationWrapperConnect(MultipleConnectAsync args)
	{
		m_CompletedOperation = SocketAsyncOperation.Connect;
		m_MultipleConnect = args;
		m_ConnectSocket = null;
	}

	internal void CancelConnectAsync()
	{
		if (m_Operating == 1 && m_CompletedOperation == SocketAsyncOperation.Connect)
		{
			if (m_MultipleConnect != null)
			{
				m_MultipleConnect.Cancel();
			}
			else
			{
				m_CurrentSocket.Close();
			}
		}
	}

	internal void StartOperationDisconnect()
	{
		m_CompletedOperation = SocketAsyncOperation.Disconnect;
		CheckPinNoBuffer();
	}

	internal void StartOperationReceive()
	{
		m_CompletedOperation = SocketAsyncOperation.Receive;
	}

	internal void StartOperationReceiveFrom()
	{
		m_CompletedOperation = SocketAsyncOperation.ReceiveFrom;
		PinSocketAddressBuffer();
	}

	internal unsafe void StartOperationReceiveMessageFrom()
	{
		m_CompletedOperation = SocketAsyncOperation.ReceiveMessageFrom;
		PinSocketAddressBuffer();
		if (m_WSAMessageBuffer == null)
		{
			m_WSAMessageBuffer = new byte[s_WSAMsgSize];
			m_WSAMessageBufferGCHandle = GCHandle.Alloc(m_WSAMessageBuffer, GCHandleType.Pinned);
			m_PtrWSAMessageBuffer = Marshal.UnsafeAddrOfPinnedArrayElement((Array)m_WSAMessageBuffer, 0);
		}
		IPAddress iPAddress = ((m_SocketAddress.Family == AddressFamily.InterNetworkV6) ? m_SocketAddress.GetIPAddress() : null);
		bool flag = m_CurrentSocket.AddressFamily == AddressFamily.InterNetwork || (iPAddress?.IsIPv4MappedToIPv6 ?? false);
		bool flag2 = m_CurrentSocket.AddressFamily == AddressFamily.InterNetworkV6;
		if (flag && (m_ControlBuffer == null || m_ControlBuffer.Length != s_ControlDataSize))
		{
			if (m_ControlBufferGCHandle.IsAllocated)
			{
				m_ControlBufferGCHandle.Free();
			}
			m_ControlBuffer = new byte[s_ControlDataSize];
		}
		else if (flag2 && (m_ControlBuffer == null || m_ControlBuffer.Length != s_ControlDataIPv6Size))
		{
			if (m_ControlBufferGCHandle.IsAllocated)
			{
				m_ControlBufferGCHandle.Free();
			}
			m_ControlBuffer = new byte[s_ControlDataIPv6Size];
		}
		if (!m_ControlBufferGCHandle.IsAllocated)
		{
			m_ControlBufferGCHandle = GCHandle.Alloc(m_ControlBuffer, GCHandleType.Pinned);
			m_PtrControlBuffer = Marshal.UnsafeAddrOfPinnedArrayElement((Array)m_ControlBuffer, 0);
		}
		if (m_Buffer != null)
		{
			if (m_WSARecvMsgWSABufferArray == null)
			{
				m_WSARecvMsgWSABufferArray = new WSABuffer[1];
			}
			m_WSARecvMsgWSABufferArray[0].Pointer = m_PtrSingleBuffer;
			m_WSARecvMsgWSABufferArray[0].Length = m_Count;
			m_WSARecvMsgWSABufferArrayGCHandle = GCHandle.Alloc(m_WSARecvMsgWSABufferArray, GCHandleType.Pinned);
			m_PtrWSARecvMsgWSABufferArray = Marshal.UnsafeAddrOfPinnedArrayElement((Array)m_WSARecvMsgWSABufferArray, 0);
		}
		else
		{
			m_WSARecvMsgWSABufferArrayGCHandle = GCHandle.Alloc(m_WSABufferArray, GCHandleType.Pinned);
			m_PtrWSARecvMsgWSABufferArray = Marshal.UnsafeAddrOfPinnedArrayElement((Array)m_WSABufferArray, 0);
		}
		UnsafeNclNativeMethods.OSSOCK.WSAMsg* ptr = (UnsafeNclNativeMethods.OSSOCK.WSAMsg*)(void*)m_PtrWSAMessageBuffer;
		ptr->socketAddress = m_PtrSocketAddressBuffer;
		ptr->addressLength = (uint)m_SocketAddress.Size;
		ptr->buffers = m_PtrWSARecvMsgWSABufferArray;
		if (m_Buffer != null)
		{
			ptr->count = 1u;
		}
		else
		{
			ptr->count = (uint)m_WSABufferArray.Length;
		}
		if (m_ControlBuffer != null)
		{
			ptr->controlBuffer.Pointer = m_PtrControlBuffer;
			ptr->controlBuffer.Length = m_ControlBuffer.Length;
		}
		ptr->flags = m_SocketFlags;
	}

	internal void StartOperationSend()
	{
		m_CompletedOperation = SocketAsyncOperation.Send;
	}

	internal void StartOperationSendPackets()
	{
		m_CompletedOperation = SocketAsyncOperation.SendPackets;
		if (m_SendPacketsElements != null)
		{
			m_SendPacketsElementsInternal = (SendPacketsElement[])m_SendPacketsElements.Clone();
		}
		m_SendPacketsElementsFileCount = 0;
		m_SendPacketsElementsBufferCount = 0;
		SendPacketsElement[] sendPacketsElementsInternal = m_SendPacketsElementsInternal;
		foreach (SendPacketsElement sendPacketsElement in sendPacketsElementsInternal)
		{
			if (sendPacketsElement != null)
			{
				if (sendPacketsElement.m_FilePath != null)
				{
					m_SendPacketsElementsFileCount++;
				}
				if (sendPacketsElement.m_Buffer != null && sendPacketsElement.m_Count > 0)
				{
					m_SendPacketsElementsBufferCount++;
				}
			}
		}
		if (m_SendPacketsElementsFileCount > 0)
		{
			m_SendPacketsFileStreams = new FileStream[m_SendPacketsElementsFileCount];
			m_SendPacketsFileHandles = new SafeHandle[m_SendPacketsElementsFileCount];
			int num = 0;
			SendPacketsElement[] sendPacketsElementsInternal2 = m_SendPacketsElementsInternal;
			foreach (SendPacketsElement sendPacketsElement2 in sendPacketsElementsInternal2)
			{
				if (sendPacketsElement2 == null || sendPacketsElement2.m_FilePath == null)
				{
					continue;
				}
				Exception ex = null;
				try
				{
					m_SendPacketsFileStreams[num] = new FileStream(sendPacketsElement2.m_FilePath, FileMode.Open, FileAccess.Read, FileShare.Read);
				}
				catch (Exception ex2)
				{
					ex = ex2;
				}
				if (ex != null)
				{
					for (int k = 0; k < m_SendPacketsElementsFileCount; k++)
					{
						m_SendPacketsFileHandles[k] = null;
						if (m_SendPacketsFileStreams[k] != null)
						{
							m_SendPacketsFileStreams[k].Close();
							m_SendPacketsFileStreams[k] = null;
						}
					}
					throw ex;
				}
				ExceptionHelper.UnmanagedPermission.Assert();
				try
				{
					m_SendPacketsFileHandles[num] = m_SendPacketsFileStreams[num].SafeFileHandle;
				}
				finally
				{
					CodeAccessPermission.RevertAssert();
				}
				num++;
			}
		}
		CheckPinSendPackets();
	}

	internal void StartOperationSendTo()
	{
		m_CompletedOperation = SocketAsyncOperation.SendTo;
		PinSocketAddressBuffer();
	}

	private void CheckPinNoBuffer()
	{
		if (m_PinState == PinState.None)
		{
			SetupOverlappedSingle(pinSingleBuffer: true);
		}
	}

	private void CheckPinSingleBuffer(bool pinUsersBuffer)
	{
		if (pinUsersBuffer)
		{
			if (m_Buffer == null)
			{
				if (m_PinState == PinState.SingleBuffer)
				{
					FreeOverlapped(checkForShutdown: false);
				}
			}
			else if (m_PinState == PinState.SingleBuffer && m_PinnedSingleBuffer == m_Buffer)
			{
				if (m_Offset != m_PinnedSingleBufferOffset)
				{
					m_PinnedSingleBufferOffset = m_Offset;
					m_PtrSingleBuffer = Marshal.UnsafeAddrOfPinnedArrayElement((Array)m_Buffer, m_Offset);
					m_WSABuffer.Pointer = m_PtrSingleBuffer;
				}
				if (m_Count != m_PinnedSingleBufferCount)
				{
					m_PinnedSingleBufferCount = m_Count;
					m_WSABuffer.Length = m_Count;
				}
			}
			else
			{
				FreeOverlapped(checkForShutdown: false);
				SetupOverlappedSingle(pinSingleBuffer: true);
			}
		}
		else if (m_PinState != PinState.SingleAcceptBuffer || m_PinnedSingleBuffer != m_AcceptBuffer)
		{
			FreeOverlapped(checkForShutdown: false);
			SetupOverlappedSingle(pinSingleBuffer: false);
		}
	}

	private void CheckPinMultipleBuffers()
	{
		if (m_BufferList == null)
		{
			if (m_PinState == PinState.MultipleBuffer)
			{
				FreeOverlapped(checkForShutdown: false);
			}
		}
		else if (m_PinState != PinState.MultipleBuffer || m_BufferListChanged)
		{
			m_BufferListChanged = false;
			FreeOverlapped(checkForShutdown: false);
			try
			{
				SetupOverlappedMultiple();
			}
			catch (Exception)
			{
				FreeOverlapped(checkForShutdown: false);
				throw;
			}
		}
	}

	private void CheckPinSendPackets()
	{
		if (m_PinState != PinState.None)
		{
			FreeOverlapped(checkForShutdown: false);
		}
		SetupOverlappedSendPackets();
	}

	private void PinSocketAddressBuffer()
	{
		if (m_PinnedSocketAddress != m_SocketAddress)
		{
			if (m_SocketAddressGCHandle.IsAllocated)
			{
				m_SocketAddressGCHandle.Free();
			}
			m_SocketAddressGCHandle = GCHandle.Alloc(m_SocketAddress.m_Buffer, GCHandleType.Pinned);
			m_SocketAddress.CopyAddressSizeIntoBuffer();
			m_PtrSocketAddressBuffer = Marshal.UnsafeAddrOfPinnedArrayElement((Array)m_SocketAddress.m_Buffer, 0);
			m_PtrSocketAddressBufferSize = Marshal.UnsafeAddrOfPinnedArrayElement((Array)m_SocketAddress.m_Buffer, m_SocketAddress.GetAddressSizeOffset());
			m_PinnedSocketAddress = m_SocketAddress;
		}
	}

	private void FreeOverlapped(bool checkForShutdown)
	{
		if (!checkForShutdown || !NclUtilities.HasShutdownStarted)
		{
			if (m_PtrNativeOverlapped != null && !m_PtrNativeOverlapped.IsInvalid)
			{
				m_PtrNativeOverlapped.Dispose();
				m_PtrNativeOverlapped = null;
				m_Overlapped = null;
				m_PinState = PinState.None;
				m_PinnedAcceptBuffer = null;
				m_PinnedSingleBuffer = null;
				m_PinnedSingleBufferOffset = 0;
				m_PinnedSingleBufferCount = 0;
			}
			if (m_SocketAddressGCHandle.IsAllocated)
			{
				m_SocketAddressGCHandle.Free();
			}
			if (m_WSAMessageBufferGCHandle.IsAllocated)
			{
				m_WSAMessageBufferGCHandle.Free();
			}
			if (m_WSARecvMsgWSABufferArrayGCHandle.IsAllocated)
			{
				m_WSARecvMsgWSABufferArrayGCHandle.Free();
			}
			if (m_ControlBufferGCHandle.IsAllocated)
			{
				m_ControlBufferGCHandle.Free();
			}
		}
	}

	private unsafe void SetupOverlappedSingle(bool pinSingleBuffer)
	{
		m_Overlapped = new Overlapped();
		if (pinSingleBuffer)
		{
			if (m_Buffer != null)
			{
				m_PtrNativeOverlapped = new SafeNativeOverlapped(m_Overlapped.UnsafePack(CompletionPortCallback, m_Buffer));
				m_PinnedSingleBuffer = m_Buffer;
				m_PinnedSingleBufferOffset = m_Offset;
				m_PinnedSingleBufferCount = m_Count;
				m_PtrSingleBuffer = Marshal.UnsafeAddrOfPinnedArrayElement((Array)m_Buffer, m_Offset);
				m_PtrAcceptBuffer = IntPtr.Zero;
				m_WSABuffer.Pointer = m_PtrSingleBuffer;
				m_WSABuffer.Length = m_Count;
				m_PinState = PinState.SingleBuffer;
			}
			else
			{
				m_PtrNativeOverlapped = new SafeNativeOverlapped(m_Overlapped.UnsafePack(CompletionPortCallback, null));
				m_PinnedSingleBuffer = null;
				m_PinnedSingleBufferOffset = 0;
				m_PinnedSingleBufferCount = 0;
				m_PtrSingleBuffer = IntPtr.Zero;
				m_PtrAcceptBuffer = IntPtr.Zero;
				m_WSABuffer.Pointer = m_PtrSingleBuffer;
				m_WSABuffer.Length = m_Count;
				m_PinState = PinState.NoBuffer;
			}
		}
		else
		{
			m_PtrNativeOverlapped = new SafeNativeOverlapped(m_Overlapped.UnsafePack(CompletionPortCallback, m_AcceptBuffer));
			m_PinnedAcceptBuffer = m_AcceptBuffer;
			m_PtrAcceptBuffer = Marshal.UnsafeAddrOfPinnedArrayElement((Array)m_AcceptBuffer, 0);
			m_PtrSingleBuffer = IntPtr.Zero;
			m_PinState = PinState.SingleAcceptBuffer;
		}
	}

	private unsafe void SetupOverlappedMultiple()
	{
		ArraySegment<byte>[] array = new ArraySegment<byte>[m_BufferList.Count];
		m_BufferList.CopyTo(array, 0);
		m_Overlapped = new Overlapped();
		if (m_ObjectsToPin == null || m_ObjectsToPin.Length != array.Length)
		{
			m_ObjectsToPin = new object[array.Length];
		}
		bool flag = false;
		if (m_WSABufferArray == null || m_WSABufferArray.Length != array.Length)
		{
			flag = true;
		}
		for (int i = 0; i < array.Length; i++)
		{
			m_ObjectsToPin[i] = array[i].Array;
			if (!flag && array[i].Count != m_WSABufferArray[i].Length)
			{
				flag = true;
			}
		}
		if (flag)
		{
			m_WSABufferArray = new WSABuffer[array.Length];
		}
		m_PtrNativeOverlapped = new SafeNativeOverlapped(m_Overlapped.UnsafePack(CompletionPortCallback, m_ObjectsToPin));
		for (int j = 0; j < array.Length; j++)
		{
			ArraySegment<byte> segment = array[j];
			ValidationHelper.ValidateSegment(segment);
			m_WSABufferArray[j].Pointer = Marshal.UnsafeAddrOfPinnedArrayElement((Array)segment.Array, segment.Offset);
			m_WSABufferArray[j].Length = segment.Count;
		}
		m_PinState = PinState.MultipleBuffer;
	}

	private unsafe void SetupOverlappedSendPackets()
	{
		m_Overlapped = new Overlapped();
		m_SendPacketsDescriptor = new UnsafeNclNativeMethods.OSSOCK.TransmitPacketsElement[m_SendPacketsElementsFileCount + m_SendPacketsElementsBufferCount];
		if (m_ObjectsToPin == null || m_ObjectsToPin.Length != m_SendPacketsElementsBufferCount + 1)
		{
			m_ObjectsToPin = new object[m_SendPacketsElementsBufferCount + 1];
		}
		m_ObjectsToPin[0] = m_SendPacketsDescriptor;
		int num = 1;
		SendPacketsElement[] sendPacketsElementsInternal = m_SendPacketsElementsInternal;
		foreach (SendPacketsElement sendPacketsElement in sendPacketsElementsInternal)
		{
			if (sendPacketsElement != null && sendPacketsElement.m_Buffer != null && sendPacketsElement.m_Count > 0)
			{
				m_ObjectsToPin[num] = sendPacketsElement.m_Buffer;
				num++;
			}
		}
		m_PtrNativeOverlapped = new SafeNativeOverlapped(m_Overlapped.UnsafePack(CompletionPortCallback, m_ObjectsToPin));
		m_PtrSendPacketsDescriptor = Marshal.UnsafeAddrOfPinnedArrayElement((Array)m_SendPacketsDescriptor, 0);
		int num2 = 0;
		int num3 = 0;
		SendPacketsElement[] sendPacketsElementsInternal2 = m_SendPacketsElementsInternal;
		foreach (SendPacketsElement sendPacketsElement2 in sendPacketsElementsInternal2)
		{
			if (sendPacketsElement2 != null)
			{
				if (sendPacketsElement2.m_Buffer != null && sendPacketsElement2.m_Count > 0)
				{
					m_SendPacketsDescriptor[num2].buffer = Marshal.UnsafeAddrOfPinnedArrayElement((Array)sendPacketsElement2.m_Buffer, sendPacketsElement2.m_Offset);
					m_SendPacketsDescriptor[num2].length = (uint)sendPacketsElement2.m_Count;
					m_SendPacketsDescriptor[num2].flags = sendPacketsElement2.m_Flags;
					num2++;
				}
				else if (sendPacketsElement2.m_FilePath != null)
				{
					m_SendPacketsDescriptor[num2].fileHandle = m_SendPacketsFileHandles[num3].DangerousGetHandle();
					m_SendPacketsDescriptor[num2].fileOffset = sendPacketsElement2.m_Offset;
					m_SendPacketsDescriptor[num2].length = (uint)sendPacketsElement2.m_Count;
					m_SendPacketsDescriptor[num2].flags = sendPacketsElement2.m_Flags;
					num3++;
					num2++;
				}
			}
		}
		m_PinState = PinState.SendPackets;
	}

	internal void LogBuffer(int size)
	{
		switch (m_PinState)
		{
		case PinState.SingleAcceptBuffer:
			Logging.Dump(Logging.Sockets, m_CurrentSocket, "FinishOperation(" + m_CompletedOperation.ToString() + "Async)", m_AcceptBuffer, 0, size);
			break;
		case PinState.SingleBuffer:
			Logging.Dump(Logging.Sockets, m_CurrentSocket, "FinishOperation(" + m_CompletedOperation.ToString() + "Async)", m_Buffer, m_Offset, size);
			break;
		case PinState.MultipleBuffer:
		{
			WSABuffer[] wSABufferArray = m_WSABufferArray;
			for (int i = 0; i < wSABufferArray.Length; i++)
			{
				WSABuffer wSABuffer = wSABufferArray[i];
				Logging.Dump(Logging.Sockets, m_CurrentSocket, "FinishOperation(" + m_CompletedOperation.ToString() + "Async)", wSABuffer.Pointer, Math.Min(wSABuffer.Length, size));
				if ((size -= wSABuffer.Length) <= 0)
				{
					break;
				}
			}
			break;
		}
		}
	}

	internal void LogSendPacketsBuffers(int size)
	{
		SendPacketsElement[] sendPacketsElementsInternal = m_SendPacketsElementsInternal;
		foreach (SendPacketsElement sendPacketsElement in sendPacketsElementsInternal)
		{
			if (sendPacketsElement != null)
			{
				if (sendPacketsElement.m_Buffer != null && sendPacketsElement.m_Count > 0)
				{
					Logging.Dump(Logging.Sockets, m_CurrentSocket, "FinishOperation(" + m_CompletedOperation.ToString() + "Async)Buffer", sendPacketsElement.m_Buffer, sendPacketsElement.m_Offset, Math.Min(sendPacketsElement.m_Count, size));
				}
				else if (sendPacketsElement.m_FilePath != null)
				{
					Logging.PrintInfo(Logging.Sockets, m_CurrentSocket, "FinishOperation(" + m_CompletedOperation.ToString() + "Async)", SR.GetString("net_log_socket_not_logged_file", sendPacketsElement.m_FilePath));
				}
			}
		}
	}

	internal void UpdatePerfCounters(int size, bool sendOp)
	{
		if (sendOp)
		{
			NetworkingPerfCounters.Instance.Increment(NetworkingPerfCounterName.SocketBytesSent, size);
			if (m_CurrentSocket.Transport == TransportType.Udp)
			{
				NetworkingPerfCounters.Instance.Increment(NetworkingPerfCounterName.SocketDatagramsSent);
			}
		}
		else
		{
			NetworkingPerfCounters.Instance.Increment(NetworkingPerfCounterName.SocketBytesReceived, size);
			if (m_CurrentSocket.Transport == TransportType.Udp)
			{
				NetworkingPerfCounters.Instance.Increment(NetworkingPerfCounterName.SocketDatagramsReceived);
			}
		}
	}

	internal void FinishOperationSyncFailure(SocketError socketError, int bytesTransferred, SocketFlags flags)
	{
		SetResults(socketError, bytesTransferred, flags);
		if (m_CurrentSocket != null)
		{
			m_CurrentSocket.UpdateStatusAfterSocketError(socketError);
		}
		Complete();
	}

	internal void FinishConnectByNameSyncFailure(Exception exception, int bytesTransferred, SocketFlags flags)
	{
		SetResults(exception, bytesTransferred, flags);
		if (m_CurrentSocket != null)
		{
			m_CurrentSocket.UpdateStatusAfterSocketError(m_SocketError);
		}
		Complete();
	}

	internal void FinishOperationAsyncFailure(SocketError socketError, int bytesTransferred, SocketFlags flags)
	{
		SetResults(socketError, bytesTransferred, flags);
		if (m_CurrentSocket != null)
		{
			m_CurrentSocket.UpdateStatusAfterSocketError(socketError);
		}
		Complete();
		if (m_Context == null)
		{
			OnCompleted(this);
		}
		else
		{
			ExecutionContext.Run(m_ContextCopy, m_ExecutionCallback, null);
		}
	}

	internal void FinishOperationAsyncFailure(Exception exception, int bytesTransferred, SocketFlags flags)
	{
		SetResults(exception, bytesTransferred, flags);
		if (m_CurrentSocket != null)
		{
			m_CurrentSocket.UpdateStatusAfterSocketError(m_SocketError);
		}
		Complete();
		if (m_Context == null)
		{
			OnCompleted(this);
		}
		else
		{
			ExecutionContext.Run(m_ContextCopy, m_ExecutionCallback, null);
		}
	}

	internal void FinishWrapperConnectSuccess(Socket connectSocket, int bytesTransferred, SocketFlags flags)
	{
		SetResults(SocketError.Success, bytesTransferred, flags);
		m_CurrentSocket = connectSocket;
		m_ConnectSocket = connectSocket;
		Complete();
		if (m_ContextCopy == null)
		{
			OnCompleted(this);
		}
		else
		{
			ExecutionContext.Run(m_ContextCopy, m_ExecutionCallback, null);
		}
	}

	internal unsafe void FinishOperationSuccess(SocketError socketError, int bytesTransferred, SocketFlags flags)
	{
		SetResults(socketError, bytesTransferred, flags);
		switch (m_CompletedOperation)
		{
		case SocketAsyncOperation.Accept:
		{
			if (bytesTransferred > 0)
			{
				if (s_LoggingEnabled)
				{
					LogBuffer(bytesTransferred);
				}
				if (Socket.s_PerfCountersEnabled)
				{
					UpdatePerfCounters(bytesTransferred, sendOp: false);
				}
			}
			SocketAddress socketAddress2 = m_CurrentSocket.m_RightEndPoint.Serialize();
			try
			{
				m_CurrentSocket.GetAcceptExSockaddrs((m_PtrSingleBuffer != IntPtr.Zero) ? m_PtrSingleBuffer : m_PtrAcceptBuffer, (m_Count != 0) ? (m_Count - m_AcceptAddressBufferCount) : 0, m_AcceptAddressBufferCount / 2, m_AcceptAddressBufferCount / 2, out var _, out var _, out var remoteSocketAddress, out socketAddress2.m_Size);
				Marshal.Copy(remoteSocketAddress, socketAddress2.m_Buffer, 0, socketAddress2.m_Size);
				IntPtr pointer = m_CurrentSocket.SafeHandle.DangerousGetHandle();
				socketError = UnsafeNclNativeMethods.OSSOCK.setsockopt(m_AcceptSocket.SafeHandle, SocketOptionLevel.Socket, SocketOptionName.UpdateAcceptContext, ref pointer, Marshal.SizeOf((object)(nint)pointer));
				if (socketError == SocketError.SocketError)
				{
					socketError = (SocketError)Marshal.GetLastWin32Error();
				}
			}
			catch (ObjectDisposedException)
			{
				socketError = SocketError.OperationAborted;
			}
			if (socketError == SocketError.Success)
			{
				m_AcceptSocket = m_CurrentSocket.UpdateAcceptSocket(m_AcceptSocket, m_CurrentSocket.m_RightEndPoint.Create(socketAddress2), needCancelSelect: false);
				if (s_LoggingEnabled)
				{
					Logging.PrintInfo(Logging.Sockets, m_AcceptSocket, SR.GetString("net_log_socket_accepted", m_AcceptSocket.RemoteEndPoint, m_AcceptSocket.LocalEndPoint));
				}
			}
			else
			{
				SetResults(socketError, bytesTransferred, SocketFlags.None);
				m_AcceptSocket = null;
			}
			break;
		}
		case SocketAsyncOperation.Connect:
			if (bytesTransferred > 0)
			{
				if (s_LoggingEnabled)
				{
					LogBuffer(bytesTransferred);
				}
				if (Socket.s_PerfCountersEnabled)
				{
					UpdatePerfCounters(bytesTransferred, sendOp: true);
				}
			}
			try
			{
				socketError = UnsafeNclNativeMethods.OSSOCK.setsockopt(m_CurrentSocket.SafeHandle, SocketOptionLevel.Socket, SocketOptionName.UpdateConnectContext, null, 0);
				if (socketError == SocketError.SocketError)
				{
					socketError = (SocketError)Marshal.GetLastWin32Error();
				}
			}
			catch (ObjectDisposedException)
			{
				socketError = SocketError.OperationAborted;
			}
			if (socketError == SocketError.Success)
			{
				if (s_LoggingEnabled)
				{
					Logging.PrintInfo(Logging.Sockets, m_CurrentSocket, SR.GetString("net_log_socket_connected", m_CurrentSocket.LocalEndPoint, m_CurrentSocket.RemoteEndPoint));
				}
				m_CurrentSocket.SetToConnected();
				m_ConnectSocket = m_CurrentSocket;
			}
			break;
		case SocketAsyncOperation.Disconnect:
			m_CurrentSocket.SetToDisconnected();
			m_CurrentSocket.m_RemoteEndPoint = null;
			break;
		case SocketAsyncOperation.Receive:
			if (bytesTransferred > 0)
			{
				if (s_LoggingEnabled)
				{
					LogBuffer(bytesTransferred);
				}
				if (Socket.s_PerfCountersEnabled)
				{
					UpdatePerfCounters(bytesTransferred, sendOp: false);
				}
			}
			break;
		case SocketAsyncOperation.ReceiveFrom:
		{
			if (bytesTransferred > 0)
			{
				if (s_LoggingEnabled)
				{
					LogBuffer(bytesTransferred);
				}
				if (Socket.s_PerfCountersEnabled)
				{
					UpdatePerfCounters(bytesTransferred, sendOp: false);
				}
			}
			m_SocketAddress.SetSize(m_PtrSocketAddressBufferSize);
			SocketAddress socketAddress = m_RemoteEndPoint.Serialize();
			if (!socketAddress.Equals(m_SocketAddress))
			{
				try
				{
					m_RemoteEndPoint = m_RemoteEndPoint.Create(m_SocketAddress);
				}
				catch
				{
				}
			}
			break;
		}
		case SocketAsyncOperation.ReceiveMessageFrom:
		{
			if (bytesTransferred > 0)
			{
				if (s_LoggingEnabled)
				{
					LogBuffer(bytesTransferred);
				}
				if (Socket.s_PerfCountersEnabled)
				{
					UpdatePerfCounters(bytesTransferred, sendOp: false);
				}
			}
			m_SocketAddress.SetSize(m_PtrSocketAddressBufferSize);
			SocketAddress socketAddress = m_RemoteEndPoint.Serialize();
			if (!socketAddress.Equals(m_SocketAddress))
			{
				try
				{
					m_RemoteEndPoint = m_RemoteEndPoint.Create(m_SocketAddress);
				}
				catch
				{
				}
			}
			IPAddress iPAddress = null;
			UnsafeNclNativeMethods.OSSOCK.WSAMsg* ptr = (UnsafeNclNativeMethods.OSSOCK.WSAMsg*)(void*)Marshal.UnsafeAddrOfPinnedArrayElement((Array)m_WSAMessageBuffer, 0);
			if (m_ControlBuffer.Length == s_ControlDataSize)
			{
				UnsafeNclNativeMethods.OSSOCK.ControlData controlData = (UnsafeNclNativeMethods.OSSOCK.ControlData)Marshal.PtrToStructure(ptr->controlBuffer.Pointer, typeof(UnsafeNclNativeMethods.OSSOCK.ControlData));
				if (controlData.length != UIntPtr.Zero)
				{
					iPAddress = new IPAddress(controlData.address);
				}
				m_ReceiveMessageFromPacketInfo = new IPPacketInformation((iPAddress != null) ? iPAddress : IPAddress.None, (int)controlData.index);
			}
			else if (m_ControlBuffer.Length == s_ControlDataIPv6Size)
			{
				UnsafeNclNativeMethods.OSSOCK.ControlDataIPv6 controlDataIPv = (UnsafeNclNativeMethods.OSSOCK.ControlDataIPv6)Marshal.PtrToStructure(ptr->controlBuffer.Pointer, typeof(UnsafeNclNativeMethods.OSSOCK.ControlDataIPv6));
				if (controlDataIPv.length != UIntPtr.Zero)
				{
					iPAddress = new IPAddress(controlDataIPv.address);
				}
				m_ReceiveMessageFromPacketInfo = new IPPacketInformation((iPAddress != null) ? iPAddress : IPAddress.IPv6None, (int)controlDataIPv.index);
			}
			else
			{
				m_ReceiveMessageFromPacketInfo = default(IPPacketInformation);
			}
			break;
		}
		case SocketAsyncOperation.Send:
			if (bytesTransferred > 0)
			{
				if (s_LoggingEnabled)
				{
					LogBuffer(bytesTransferred);
				}
				if (Socket.s_PerfCountersEnabled)
				{
					UpdatePerfCounters(bytesTransferred, sendOp: true);
				}
			}
			break;
		case SocketAsyncOperation.SendPackets:
			if (bytesTransferred > 0)
			{
				if (s_LoggingEnabled)
				{
					LogSendPacketsBuffers(bytesTransferred);
				}
				if (Socket.s_PerfCountersEnabled)
				{
					UpdatePerfCounters(bytesTransferred, sendOp: true);
				}
			}
			if (m_SendPacketsFileStreams != null)
			{
				for (int i = 0; i < m_SendPacketsElementsFileCount; i++)
				{
					m_SendPacketsFileHandles[i] = null;
					if (m_SendPacketsFileStreams[i] != null)
					{
						m_SendPacketsFileStreams[i].Close();
						m_SendPacketsFileStreams[i] = null;
					}
				}
			}
			m_SendPacketsFileStreams = null;
			m_SendPacketsFileHandles = null;
			break;
		case SocketAsyncOperation.SendTo:
			if (bytesTransferred > 0)
			{
				if (s_LoggingEnabled)
				{
					LogBuffer(bytesTransferred);
				}
				if (Socket.s_PerfCountersEnabled)
				{
					UpdatePerfCounters(bytesTransferred, sendOp: true);
				}
			}
			break;
		}
		if (socketError != SocketError.Success)
		{
			SetResults(socketError, bytesTransferred, flags);
			m_CurrentSocket.UpdateStatusAfterSocketError(socketError);
		}
		Complete();
		if (m_ContextCopy == null)
		{
			OnCompleted(this);
		}
		else
		{
			ExecutionContext.Run(m_ContextCopy, m_ExecutionCallback, null);
		}
	}

	private unsafe void CompletionPortCallback(uint errorCode, uint numBytes, NativeOverlapped* nativeOverlapped)
	{
		SocketFlags socketFlags = SocketFlags.None;
		SocketError socketError = (SocketError)errorCode;
		switch (socketError)
		{
		case SocketError.Success:
			FinishOperationSuccess(socketError, (int)numBytes, socketFlags);
			return;
		default:
			if (m_CurrentSocket.CleanedUp)
			{
				socketError = SocketError.OperationAborted;
				break;
			}
			try
			{
				bool flag = UnsafeNclNativeMethods.OSSOCK.WSAGetOverlappedResult(m_CurrentSocket.SafeHandle, m_PtrNativeOverlapped, out numBytes, wait: false, out socketFlags);
				socketError = (SocketError)Marshal.GetLastWin32Error();
			}
			catch
			{
				socketError = SocketError.OperationAborted;
			}
			break;
		case SocketError.OperationAborted:
			break;
		}
		FinishOperationAsyncFailure(socketError, (int)numBytes, socketFlags);
	}
}
