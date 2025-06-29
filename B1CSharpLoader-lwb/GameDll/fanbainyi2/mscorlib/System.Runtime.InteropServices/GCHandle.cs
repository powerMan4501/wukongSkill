using System.Runtime.CompilerServices;
using System.Security;
using System.Threading;

namespace System.Runtime.InteropServices;

[ComVisible(true)]
[__DynamicallyInvokable]
public struct GCHandle
{
	private const GCHandleType MaxHandleType = GCHandleType.Pinned;

	private IntPtr m_handle;

	private static volatile GCHandleCookieTable s_cookieTable;

	private static volatile bool s_probeIsActive;

	[__DynamicallyInvokable]
	public object Target
	{
		[SecurityCritical]
		[__DynamicallyInvokable]
		get
		{
			if (m_handle == IntPtr.Zero)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_HandleIsNotInitialized"));
			}
			return InternalGet(GetHandleValue());
		}
		[SecurityCritical]
		[__DynamicallyInvokable]
		set
		{
			if (m_handle == IntPtr.Zero)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_HandleIsNotInitialized"));
			}
			InternalSet(GetHandleValue(), value, IsPinned());
		}
	}

	[__DynamicallyInvokable]
	public bool IsAllocated
	{
		[__DynamicallyInvokable]
		get
		{
			return m_handle != IntPtr.Zero;
		}
	}

	[SecuritySafeCritical]
	static GCHandle()
	{
		s_probeIsActive = Mda.IsInvalidGCHandleCookieProbeEnabled();
		if (s_probeIsActive)
		{
			s_cookieTable = new GCHandleCookieTable();
		}
	}

	[SecurityCritical]
	internal GCHandle(object value, GCHandleType type)
	{
		if ((uint)type > 3u)
		{
			throw new ArgumentOutOfRangeException("type", Environment.GetResourceString("ArgumentOutOfRange_Enum"));
		}
		m_handle = InternalAlloc(value, type);
		if (type == GCHandleType.Pinned)
		{
			SetIsPinned();
		}
	}

	[SecurityCritical]
	internal GCHandle(IntPtr handle)
	{
		InternalCheckDomain(handle);
		m_handle = handle;
	}

	[SecurityCritical]
	[__DynamicallyInvokable]
	public static GCHandle Alloc(object value)
	{
		return new GCHandle(value, GCHandleType.Normal);
	}

	[SecurityCritical]
	[__DynamicallyInvokable]
	public static GCHandle Alloc(object value, GCHandleType type)
	{
		return new GCHandle(value, type);
	}

	[SecurityCritical]
	[__DynamicallyInvokable]
	public void Free()
	{
		IntPtr handle = m_handle;
		if (handle != IntPtr.Zero && Interlocked.CompareExchange(ref m_handle, IntPtr.Zero, handle) == handle)
		{
			if (s_probeIsActive)
			{
				s_cookieTable.RemoveHandleIfPresent(handle);
			}
			InternalFree((IntPtr)((int)handle & -2));
			return;
		}
		throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_HandleIsNotInitialized"));
	}

	[SecurityCritical]
	public IntPtr AddrOfPinnedObject()
	{
		if (!IsPinned())
		{
			if (m_handle == IntPtr.Zero)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_HandleIsNotInitialized"));
			}
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_HandleIsNotPinned"));
		}
		return InternalAddrOfPinnedObject(GetHandleValue());
	}

	[SecurityCritical]
	public static explicit operator GCHandle(IntPtr value)
	{
		return FromIntPtr(value);
	}

	[SecurityCritical]
	public static GCHandle FromIntPtr(IntPtr value)
	{
		if (value == IntPtr.Zero)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_HandleIsNotInitialized"));
		}
		IntPtr intPtr = value;
		if (s_probeIsActive)
		{
			intPtr = s_cookieTable.GetHandle(value);
			if (IntPtr.Zero == intPtr)
			{
				Mda.FireInvalidGCHandleCookieProbe(value);
				return new GCHandle(IntPtr.Zero);
			}
		}
		return new GCHandle(intPtr);
	}

	public static explicit operator IntPtr(GCHandle value)
	{
		return ToIntPtr(value);
	}

	public static IntPtr ToIntPtr(GCHandle value)
	{
		if (s_probeIsActive)
		{
			return s_cookieTable.FindOrAddHandle(value.m_handle);
		}
		return value.m_handle;
	}

	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return m_handle.GetHashCode();
	}

	[__DynamicallyInvokable]
	public override bool Equals(object o)
	{
		if (o == null || !(o is GCHandle gCHandle))
		{
			return false;
		}
		return m_handle == gCHandle.m_handle;
	}

	[__DynamicallyInvokable]
	public static bool operator ==(GCHandle a, GCHandle b)
	{
		return a.m_handle == b.m_handle;
	}

	[__DynamicallyInvokable]
	public static bool operator !=(GCHandle a, GCHandle b)
	{
		return a.m_handle != b.m_handle;
	}

	internal IntPtr GetHandleValue()
	{
		return new IntPtr((int)m_handle & -2);
	}

	internal bool IsPinned()
	{
		return ((int)m_handle & 1) != 0;
	}

	internal void SetIsPinned()
	{
		m_handle = new IntPtr((int)m_handle | 1);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern IntPtr InternalAlloc(object value, GCHandleType type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void InternalFree(IntPtr handle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern object InternalGet(IntPtr handle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void InternalSet(IntPtr handle, object value, bool isPinned);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern object InternalCompareExchange(IntPtr handle, object value, object oldValue, bool isPinned);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern IntPtr InternalAddrOfPinnedObject(IntPtr handle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void InternalCheckDomain(IntPtr handle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern GCHandleType InternalGetHandleType(IntPtr handle);
}
