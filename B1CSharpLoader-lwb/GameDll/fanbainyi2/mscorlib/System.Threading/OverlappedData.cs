using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Threading;

internal sealed class OverlappedData
{
	internal IAsyncResult m_asyncResult;

	[SecurityCritical]
	internal IOCompletionCallback m_iocb;

	internal _IOCompletionCallback m_iocbHelper;

	internal Overlapped m_overlapped;

	private object m_userObject;

	private IntPtr m_pinSelf;

	private IntPtr m_userObjectInternal;

	private int m_AppDomainId;

	private byte m_isArray;

	private byte m_toBeCleaned;

	internal NativeOverlapped m_nativeOverlapped;

	[ComVisible(false)]
	internal IntPtr UserHandle
	{
		get
		{
			return m_nativeOverlapped.EventHandle;
		}
		set
		{
			m_nativeOverlapped.EventHandle = value;
		}
	}

	[SecurityCritical]
	internal void ReInitialize()
	{
		m_asyncResult = null;
		m_iocb = null;
		m_iocbHelper = null;
		m_overlapped = null;
		m_userObject = null;
		m_pinSelf = (IntPtr)0;
		m_userObjectInternal = (IntPtr)0;
		m_AppDomainId = 0;
		m_nativeOverlapped.EventHandle = (IntPtr)0;
		m_isArray = 0;
		m_nativeOverlapped.InternalLow = (IntPtr)0;
		m_nativeOverlapped.InternalHigh = (IntPtr)0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecurityCritical]
	internal unsafe NativeOverlapped* Pack(IOCompletionCallback iocb, object userData)
	{
		if (!m_pinSelf.IsNull())
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_Overlapped_Pack"));
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		if (iocb != null)
		{
			m_iocbHelper = new _IOCompletionCallback(iocb, ref stackMark);
			m_iocb = iocb;
		}
		else
		{
			m_iocbHelper = null;
			m_iocb = null;
		}
		m_userObject = userData;
		if (m_userObject != null)
		{
			if (m_userObject.GetType() == typeof(object[]))
			{
				m_isArray = 1;
			}
			else
			{
				m_isArray = 0;
			}
		}
		return AllocateNativeOverlapped();
	}

	[SecurityCritical]
	internal unsafe NativeOverlapped* UnsafePack(IOCompletionCallback iocb, object userData)
	{
		if (!m_pinSelf.IsNull())
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_Overlapped_Pack"));
		}
		m_userObject = userData;
		if (m_userObject != null)
		{
			if (m_userObject.GetType() == typeof(object[]))
			{
				m_isArray = 1;
			}
			else
			{
				m_isArray = 0;
			}
		}
		m_iocb = iocb;
		m_iocbHelper = null;
		return AllocateNativeOverlapped();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private unsafe extern NativeOverlapped* AllocateNativeOverlapped();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal unsafe static extern void FreeNativeOverlapped(NativeOverlapped* nativeOverlappedPtr);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal unsafe static extern OverlappedData GetOverlappedFromNative(NativeOverlapped* nativeOverlappedPtr);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal unsafe static extern void CheckVMForIOPacket(out NativeOverlapped* pOVERLAP, out uint errorCode, out uint numBytes);
}
