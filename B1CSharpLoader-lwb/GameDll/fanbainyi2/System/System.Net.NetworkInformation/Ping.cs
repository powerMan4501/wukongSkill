using System.ComponentModel;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.NetworkInformation;

public class Ping : Component
{
	internal class AsyncStateObject
	{
		internal byte[] buffer;

		internal string hostName;

		internal int timeout;

		internal PingOptions options;

		internal object userToken;

		internal AsyncStateObject(string hostName, byte[] buffer, int timeout, PingOptions options, object userToken)
		{
			this.hostName = hostName;
			this.buffer = buffer;
			this.timeout = timeout;
			this.options = options;
			this.userToken = userToken;
		}
	}

	private const int MaxUdpPacket = 65791;

	private const int MaxBufferSize = 65500;

	private const int DefaultTimeout = 5000;

	private const int DefaultSendBufferSize = 32;

	private byte[] defaultSendBuffer;

	private bool ipv6;

	private bool cancelled;

	private bool disposeRequested;

	private object lockObject = new object();

	internal ManualResetEvent pingEvent;

	private RegisteredWaitHandle registeredWait;

	private SafeLocalFree requestBuffer;

	private SafeLocalFree replyBuffer;

	private int sendSize;

	private SafeCloseIcmpHandle handlePingV4;

	private SafeCloseIcmpHandle handlePingV6;

	private AsyncOperation asyncOp;

	private SendOrPostCallback onPingCompletedDelegate;

	private ManualResetEvent asyncFinished;

	private const int Free = 0;

	private const int InProgress = 1;

	private new const int Disposed = 2;

	private int status;

	private bool InAsyncCall
	{
		get
		{
			if (asyncFinished == null)
			{
				return false;
			}
			return !asyncFinished.WaitOne(0);
		}
		set
		{
			if (asyncFinished == null)
			{
				asyncFinished = new ManualResetEvent(!value);
			}
			else if (value)
			{
				asyncFinished.Reset();
			}
			else
			{
				asyncFinished.Set();
			}
		}
	}

	private byte[] DefaultSendBuffer
	{
		get
		{
			if (defaultSendBuffer == null)
			{
				defaultSendBuffer = new byte[32];
				for (int i = 0; i < 32; i++)
				{
					defaultSendBuffer[i] = (byte)(97 + i % 23);
				}
			}
			return defaultSendBuffer;
		}
	}

	public event PingCompletedEventHandler PingCompleted;

	private void CheckStart(bool async)
	{
		if (disposeRequested)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		switch (Interlocked.CompareExchange(ref status, 1, 0))
		{
		case 1:
			throw new InvalidOperationException(SR.GetString("net_inasync"));
		case 2:
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (async)
		{
			InAsyncCall = true;
		}
	}

	private void Finish(bool async)
	{
		status = 0;
		if (async)
		{
			InAsyncCall = false;
		}
		if (disposeRequested)
		{
			InternalDispose();
		}
	}

	protected void OnPingCompleted(PingCompletedEventArgs e)
	{
		if (this.PingCompleted != null)
		{
			this.PingCompleted(this, e);
		}
	}

	private void PingCompletedWaitCallback(object operationState)
	{
		OnPingCompleted((PingCompletedEventArgs)operationState);
	}

	public Ping()
	{
		onPingCompletedDelegate = PingCompletedWaitCallback;
	}

	private void InternalDispose()
	{
		disposeRequested = true;
		if (Interlocked.CompareExchange(ref status, 2, 0) == 0)
		{
			if (handlePingV4 != null)
			{
				handlePingV4.Close();
				handlePingV4 = null;
			}
			if (handlePingV6 != null)
			{
				handlePingV6.Close();
				handlePingV6 = null;
			}
			UnregisterWaitHandle();
			if (pingEvent != null)
			{
				pingEvent.Close();
				pingEvent = null;
			}
			if (replyBuffer != null)
			{
				replyBuffer.Close();
				replyBuffer = null;
			}
			if (asyncFinished != null)
			{
				asyncFinished.Close();
				asyncFinished = null;
			}
		}
	}

	private void UnregisterWaitHandle()
	{
		lock (lockObject)
		{
			if (registeredWait != null)
			{
				registeredWait.Unregister(null);
				registeredWait = null;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			InternalDispose();
		}
		base.Dispose(disposing);
	}

	public void SendAsyncCancel()
	{
		lock (lockObject)
		{
			if (!InAsyncCall)
			{
				return;
			}
			cancelled = true;
		}
		asyncFinished.WaitOne();
	}

	private static void PingCallback(object state, bool signaled)
	{
		Ping ping = (Ping)state;
		PingCompletedEventArgs arg = null;
		bool flag = false;
		AsyncOperation asyncOperation = null;
		SendOrPostCallback d = null;
		try
		{
			lock (ping.lockObject)
			{
				flag = ping.cancelled;
				asyncOperation = ping.asyncOp;
				d = ping.onPingCompletedDelegate;
				if (!flag)
				{
					SafeLocalFree safeLocalFree = ping.replyBuffer;
					PingReply reply2;
					if (ping.ipv6)
					{
						Icmp6EchoReply reply = (Icmp6EchoReply)Marshal.PtrToStructure(safeLocalFree.DangerousGetHandle(), typeof(Icmp6EchoReply));
						reply2 = new PingReply(reply, safeLocalFree.DangerousGetHandle(), ping.sendSize);
					}
					else
					{
						IcmpEchoReply reply3 = (IcmpEchoReply)Marshal.PtrToStructure(safeLocalFree.DangerousGetHandle(), typeof(IcmpEchoReply));
						reply2 = new PingReply(reply3);
					}
					arg = new PingCompletedEventArgs(reply2, null, cancelled: false, asyncOperation.UserSuppliedState);
				}
				else
				{
					arg = new PingCompletedEventArgs(null, null, cancelled: true, asyncOperation.UserSuppliedState);
				}
			}
		}
		catch (Exception innerException)
		{
			PingException error = new PingException(SR.GetString("net_ping"), innerException);
			arg = new PingCompletedEventArgs(null, error, cancelled: false, asyncOperation.UserSuppliedState);
		}
		finally
		{
			ping.FreeUnmanagedStructures();
			ping.UnregisterWaitHandle();
			ping.Finish(async: true);
		}
		asyncOperation.PostOperationCompleted(d, arg);
	}

	public PingReply Send(string hostNameOrAddress)
	{
		return Send(hostNameOrAddress, 5000, DefaultSendBuffer, null);
	}

	public PingReply Send(string hostNameOrAddress, int timeout)
	{
		return Send(hostNameOrAddress, timeout, DefaultSendBuffer, null);
	}

	public PingReply Send(IPAddress address)
	{
		return Send(address, 5000, DefaultSendBuffer, null);
	}

	public PingReply Send(IPAddress address, int timeout)
	{
		return Send(address, timeout, DefaultSendBuffer, null);
	}

	public PingReply Send(string hostNameOrAddress, int timeout, byte[] buffer)
	{
		return Send(hostNameOrAddress, timeout, buffer, null);
	}

	public PingReply Send(IPAddress address, int timeout, byte[] buffer)
	{
		return Send(address, timeout, buffer, null);
	}

	public PingReply Send(string hostNameOrAddress, int timeout, byte[] buffer, PingOptions options)
	{
		if (ValidationHelper.IsBlankString(hostNameOrAddress))
		{
			throw new ArgumentNullException("hostNameOrAddress");
		}
		if (!IPAddress.TryParse(hostNameOrAddress, out var address))
		{
			try
			{
				address = Dns.GetHostAddresses(hostNameOrAddress)[0];
			}
			catch (ArgumentException)
			{
				throw;
			}
			catch (Exception innerException)
			{
				throw new PingException(SR.GetString("net_ping"), innerException);
			}
		}
		return Send(address, timeout, buffer, options);
	}

	public PingReply Send(IPAddress address, int timeout, byte[] buffer, PingOptions options)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (buffer.Length > 65500)
		{
			throw new ArgumentException(SR.GetString("net_invalidPingBufferSize"), "buffer");
		}
		if (timeout < 0)
		{
			throw new ArgumentOutOfRangeException("timeout");
		}
		if (address == null)
		{
			throw new ArgumentNullException("address");
		}
		TestIsIpSupported(address);
		if (address.Equals(IPAddress.Any) || address.Equals(IPAddress.IPv6Any))
		{
			throw new ArgumentException(SR.GetString("net_invalid_ip_addr"), "address");
		}
		IPAddress address2 = ((address.AddressFamily != AddressFamily.InterNetwork) ? new IPAddress(address.GetAddressBytes(), address.ScopeId) : new IPAddress(address.GetAddressBytes()));
		new NetworkInformationPermission(NetworkInformationAccess.Ping).Demand();
		CheckStart(async: false);
		try
		{
			return InternalSend(address2, buffer, timeout, options, async: false);
		}
		catch (Exception innerException)
		{
			throw new PingException(SR.GetString("net_ping"), innerException);
		}
		finally
		{
			Finish(async: false);
		}
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public void SendAsync(string hostNameOrAddress, object userToken)
	{
		SendAsync(hostNameOrAddress, 5000, DefaultSendBuffer, userToken);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public void SendAsync(string hostNameOrAddress, int timeout, object userToken)
	{
		SendAsync(hostNameOrAddress, timeout, DefaultSendBuffer, userToken);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public void SendAsync(IPAddress address, object userToken)
	{
		SendAsync(address, 5000, DefaultSendBuffer, userToken);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public void SendAsync(IPAddress address, int timeout, object userToken)
	{
		SendAsync(address, timeout, DefaultSendBuffer, userToken);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public void SendAsync(string hostNameOrAddress, int timeout, byte[] buffer, object userToken)
	{
		SendAsync(hostNameOrAddress, timeout, buffer, null, userToken);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public void SendAsync(IPAddress address, int timeout, byte[] buffer, object userToken)
	{
		SendAsync(address, timeout, buffer, null, userToken);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public void SendAsync(string hostNameOrAddress, int timeout, byte[] buffer, PingOptions options, object userToken)
	{
		if (ValidationHelper.IsBlankString(hostNameOrAddress))
		{
			throw new ArgumentNullException("hostNameOrAddress");
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (buffer.Length > 65500)
		{
			throw new ArgumentException(SR.GetString("net_invalidPingBufferSize"), "buffer");
		}
		if (timeout < 0)
		{
			throw new ArgumentOutOfRangeException("timeout");
		}
		if (IPAddress.TryParse(hostNameOrAddress, out var address))
		{
			SendAsync(address, timeout, buffer, options, userToken);
			return;
		}
		CheckStart(async: true);
		try
		{
			cancelled = false;
			asyncOp = AsyncOperationManager.CreateOperation(userToken);
			AsyncStateObject state = new AsyncStateObject(hostNameOrAddress, buffer, timeout, options, userToken);
			ThreadPool.QueueUserWorkItem(ContinueAsyncSend, state);
		}
		catch (Exception innerException)
		{
			Finish(async: true);
			throw new PingException(SR.GetString("net_ping"), innerException);
		}
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public void SendAsync(IPAddress address, int timeout, byte[] buffer, PingOptions options, object userToken)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (buffer.Length > 65500)
		{
			throw new ArgumentException(SR.GetString("net_invalidPingBufferSize"), "buffer");
		}
		if (timeout < 0)
		{
			throw new ArgumentOutOfRangeException("timeout");
		}
		if (address == null)
		{
			throw new ArgumentNullException("address");
		}
		TestIsIpSupported(address);
		if (address.Equals(IPAddress.Any) || address.Equals(IPAddress.IPv6Any))
		{
			throw new ArgumentException(SR.GetString("net_invalid_ip_addr"), "address");
		}
		IPAddress address2 = ((address.AddressFamily != AddressFamily.InterNetwork) ? new IPAddress(address.GetAddressBytes(), address.ScopeId) : new IPAddress(address.GetAddressBytes()));
		new NetworkInformationPermission(NetworkInformationAccess.Ping).Demand();
		CheckStart(async: true);
		try
		{
			cancelled = false;
			asyncOp = AsyncOperationManager.CreateOperation(userToken);
			InternalSend(address2, buffer, timeout, options, async: true);
		}
		catch (Exception innerException)
		{
			Finish(async: true);
			throw new PingException(SR.GetString("net_ping"), innerException);
		}
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public Task<PingReply> SendPingAsync(IPAddress address)
	{
		return SendPingAsyncCore(delegate(TaskCompletionSource<PingReply> tcs)
		{
			SendAsync(address, tcs);
		});
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public Task<PingReply> SendPingAsync(string hostNameOrAddress)
	{
		return SendPingAsyncCore(delegate(TaskCompletionSource<PingReply> tcs)
		{
			SendAsync(hostNameOrAddress, tcs);
		});
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public Task<PingReply> SendPingAsync(IPAddress address, int timeout)
	{
		return SendPingAsyncCore(delegate(TaskCompletionSource<PingReply> tcs)
		{
			SendAsync(address, timeout, tcs);
		});
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public Task<PingReply> SendPingAsync(string hostNameOrAddress, int timeout)
	{
		return SendPingAsyncCore(delegate(TaskCompletionSource<PingReply> tcs)
		{
			SendAsync(hostNameOrAddress, timeout, tcs);
		});
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public Task<PingReply> SendPingAsync(IPAddress address, int timeout, byte[] buffer)
	{
		return SendPingAsyncCore(delegate(TaskCompletionSource<PingReply> tcs)
		{
			SendAsync(address, timeout, buffer, tcs);
		});
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public Task<PingReply> SendPingAsync(string hostNameOrAddress, int timeout, byte[] buffer)
	{
		return SendPingAsyncCore(delegate(TaskCompletionSource<PingReply> tcs)
		{
			SendAsync(hostNameOrAddress, timeout, buffer, tcs);
		});
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public Task<PingReply> SendPingAsync(IPAddress address, int timeout, byte[] buffer, PingOptions options)
	{
		return SendPingAsyncCore(delegate(TaskCompletionSource<PingReply> tcs)
		{
			SendAsync(address, timeout, buffer, options, tcs);
		});
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public Task<PingReply> SendPingAsync(string hostNameOrAddress, int timeout, byte[] buffer, PingOptions options)
	{
		return SendPingAsyncCore(delegate(TaskCompletionSource<PingReply> tcs)
		{
			SendAsync(hostNameOrAddress, timeout, buffer, options, tcs);
		});
	}

	private Task<PingReply> SendPingAsyncCore(Action<TaskCompletionSource<PingReply>> sendAsync)
	{
		TaskCompletionSource<PingReply> tcs = new TaskCompletionSource<PingReply>();
		PingCompletedEventHandler handler = null;
		handler = delegate(object sender, PingCompletedEventArgs e)
		{
			HandleCompletion(tcs, e, handler);
		};
		PingCompleted += handler;
		try
		{
			sendAsync(tcs);
		}
		catch
		{
			PingCompleted -= handler;
			throw;
		}
		return tcs.Task;
	}

	private void HandleCompletion(TaskCompletionSource<PingReply> tcs, PingCompletedEventArgs e, PingCompletedEventHandler handler)
	{
		if (e.UserState != tcs)
		{
			return;
		}
		try
		{
			PingCompleted -= handler;
		}
		finally
		{
			if (e.Error != null)
			{
				tcs.TrySetException(e.Error);
			}
			else if (e.Cancelled)
			{
				tcs.TrySetCanceled();
			}
			else
			{
				tcs.TrySetResult(e.Reply);
			}
		}
	}

	private void ContinueAsyncSend(object state)
	{
		AsyncStateObject asyncStateObject = (AsyncStateObject)state;
		try
		{
			IPAddress address = Dns.GetHostAddresses(asyncStateObject.hostName)[0];
			new NetworkInformationPermission(NetworkInformationAccess.Ping).Demand();
			InternalSend(address, asyncStateObject.buffer, asyncStateObject.timeout, asyncStateObject.options, async: true);
		}
		catch (Exception innerException)
		{
			PingException error = new PingException(SR.GetString("net_ping"), innerException);
			PingCompletedEventArgs arg = new PingCompletedEventArgs(null, error, cancelled: false, asyncOp.UserSuppliedState);
			Finish(async: true);
			asyncOp.PostOperationCompleted(onPingCompletedDelegate, arg);
		}
	}

	private PingReply InternalSend(IPAddress address, byte[] buffer, int timeout, PingOptions options, bool async)
	{
		ipv6 = address.AddressFamily == AddressFamily.InterNetworkV6;
		sendSize = buffer.Length;
		if (!ipv6 && handlePingV4 == null)
		{
			handlePingV4 = UnsafeNetInfoNativeMethods.IcmpCreateFile();
			if (handlePingV4.IsInvalid)
			{
				handlePingV4 = null;
				throw new Win32Exception();
			}
		}
		else if (ipv6 && handlePingV6 == null)
		{
			handlePingV6 = UnsafeNetInfoNativeMethods.Icmp6CreateFile();
			if (handlePingV6.IsInvalid)
			{
				handlePingV6 = null;
				throw new Win32Exception();
			}
		}
		IPOptions options2 = new IPOptions(options);
		if (replyBuffer == null)
		{
			replyBuffer = SafeLocalFree.LocalAlloc(65791);
		}
		int num;
		try
		{
			if (async)
			{
				if (pingEvent == null)
				{
					pingEvent = new ManualResetEvent(initialState: false);
				}
				else
				{
					pingEvent.Reset();
				}
				registeredWait = ThreadPool.RegisterWaitForSingleObject(pingEvent, PingCallback, this, -1, executeOnlyOnce: true);
			}
			SetUnmanagedStructures(buffer);
			if (!ipv6)
			{
				num = (int)((!async) ? UnsafeNetInfoNativeMethods.IcmpSendEcho2(handlePingV4, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, (uint)address.m_Address, requestBuffer, (ushort)buffer.Length, ref options2, replyBuffer, 65791u, (uint)timeout) : UnsafeNetInfoNativeMethods.IcmpSendEcho2(handlePingV4, pingEvent.SafeWaitHandle, IntPtr.Zero, IntPtr.Zero, (uint)address.m_Address, requestBuffer, (ushort)buffer.Length, ref options2, replyBuffer, 65791u, (uint)timeout));
			}
			else
			{
				IPEndPoint iPEndPoint = new IPEndPoint(address, 0);
				SocketAddress socketAddress = iPEndPoint.Serialize();
				byte[] sourceSocketAddress = new byte[28];
				num = (int)((!async) ? UnsafeNetInfoNativeMethods.Icmp6SendEcho2(handlePingV6, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, sourceSocketAddress, socketAddress.m_Buffer, requestBuffer, (ushort)buffer.Length, ref options2, replyBuffer, 65791u, (uint)timeout) : UnsafeNetInfoNativeMethods.Icmp6SendEcho2(handlePingV6, pingEvent.SafeWaitHandle, IntPtr.Zero, IntPtr.Zero, sourceSocketAddress, socketAddress.m_Buffer, requestBuffer, (ushort)buffer.Length, ref options2, replyBuffer, 65791u, (uint)timeout));
			}
		}
		catch
		{
			UnregisterWaitHandle();
			throw;
		}
		if (num == 0)
		{
			num = Marshal.GetLastWin32Error();
			if (async && (long)num == 997)
			{
				return null;
			}
			FreeUnmanagedStructures();
			UnregisterWaitHandle();
			if (async || num < 11002 || num > 11045)
			{
				throw new Win32Exception(num);
			}
			return new PingReply((IPStatus)num);
		}
		if (async)
		{
			return null;
		}
		FreeUnmanagedStructures();
		PingReply result;
		if (ipv6)
		{
			Icmp6EchoReply reply = (Icmp6EchoReply)Marshal.PtrToStructure(replyBuffer.DangerousGetHandle(), typeof(Icmp6EchoReply));
			result = new PingReply(reply, replyBuffer.DangerousGetHandle(), sendSize);
		}
		else
		{
			IcmpEchoReply reply2 = (IcmpEchoReply)Marshal.PtrToStructure(replyBuffer.DangerousGetHandle(), typeof(IcmpEchoReply));
			result = new PingReply(reply2);
		}
		GC.KeepAlive(replyBuffer);
		return result;
	}

	private void TestIsIpSupported(IPAddress ip)
	{
		if (ip.AddressFamily == AddressFamily.InterNetwork && !Socket.OSSupportsIPv4)
		{
			throw new NotSupportedException(SR.GetString("net_ipv4_not_installed"));
		}
		if (ip.AddressFamily == AddressFamily.InterNetworkV6 && !Socket.OSSupportsIPv6)
		{
			throw new NotSupportedException(SR.GetString("net_ipv6_not_installed"));
		}
	}

	private unsafe void SetUnmanagedStructures(byte[] buffer)
	{
		requestBuffer = SafeLocalFree.LocalAlloc(buffer.Length);
		byte* ptr = (byte*)(void*)requestBuffer.DangerousGetHandle();
		for (int i = 0; i < buffer.Length; i++)
		{
			ptr[i] = buffer[i];
		}
	}

	private void FreeUnmanagedStructures()
	{
		if (requestBuffer != null)
		{
			requestBuffer.Close();
			requestBuffer = null;
		}
	}
}
