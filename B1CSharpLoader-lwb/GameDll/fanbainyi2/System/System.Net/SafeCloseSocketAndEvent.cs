using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Threading;
using Microsoft.Win32.SafeHandles;

namespace System.Net;

[SuppressUnmanagedCodeSecurity]
internal sealed class SafeCloseSocketAndEvent : SafeCloseSocket
{
	private AutoResetEvent waitHandle;

	internal SafeCloseSocketAndEvent()
	{
	}

	protected override bool ReleaseHandle()
	{
		bool result = base.ReleaseHandle();
		DeleteEvent();
		return result;
	}

	internal static SafeCloseSocketAndEvent CreateWSASocketWithEvent(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType, bool autoReset, bool signaled)
	{
		SafeCloseSocketAndEvent safeCloseSocketAndEvent = new SafeCloseSocketAndEvent();
		SafeCloseSocket.CreateSocket(InnerSafeCloseSocket.CreateWSASocket(addressFamily, socketType, protocolType), safeCloseSocketAndEvent);
		if (safeCloseSocketAndEvent.IsInvalid)
		{
			throw new SocketException();
		}
		safeCloseSocketAndEvent.waitHandle = new AutoResetEvent(initialState: false);
		CompleteInitialization(safeCloseSocketAndEvent);
		return safeCloseSocketAndEvent;
	}

	internal static void CompleteInitialization(SafeCloseSocketAndEvent socketAndEventHandle)
	{
		SafeWaitHandle safeWaitHandle = socketAndEventHandle.waitHandle.SafeWaitHandle;
		bool success = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			safeWaitHandle.DangerousAddRef(ref success);
		}
		catch
		{
			if (success)
			{
				safeWaitHandle.DangerousRelease();
				socketAndEventHandle.waitHandle = null;
				success = false;
			}
		}
		finally
		{
			if (success)
			{
				safeWaitHandle.Dispose();
			}
		}
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private void DeleteEvent()
	{
		try
		{
			if (waitHandle != null)
			{
				waitHandle.SafeWaitHandle.DangerousRelease();
			}
		}
		catch
		{
		}
	}

	internal WaitHandle GetEventHandle()
	{
		return waitHandle;
	}
}
