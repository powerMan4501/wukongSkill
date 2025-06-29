using System.Security;
using Microsoft.Win32;

namespace System.Threading.Tasks;

internal class StackGuard
{
	private int m_inliningDepth;

	private const int MAX_UNCHECKED_INLINING_DEPTH = 20;

	private ulong m_lastKnownWatermark;

	private static int s_pageSize;

	private const long STACK_RESERVED_SPACE = 65536L;

	[SecuritySafeCritical]
	internal bool TryBeginInliningScope()
	{
		if (m_inliningDepth < 20 || CheckForSufficientStack())
		{
			m_inliningDepth++;
			return true;
		}
		return false;
	}

	internal void EndInliningScope()
	{
		m_inliningDepth--;
		if (m_inliningDepth < 0)
		{
			m_inliningDepth = 0;
		}
	}

	[SecurityCritical]
	private unsafe bool CheckForSufficientStack()
	{
		int num = s_pageSize;
		if (num == 0)
		{
			Win32Native.SYSTEM_INFO lpSystemInfo = default(Win32Native.SYSTEM_INFO);
			Win32Native.GetSystemInfo(ref lpSystemInfo);
			num = (s_pageSize = lpSystemInfo.dwPageSize);
		}
		Win32Native.MEMORY_BASIC_INFORMATION buffer = default(Win32Native.MEMORY_BASIC_INFORMATION);
		UIntPtr uIntPtr = new UIntPtr(&buffer - num);
		ulong num2 = uIntPtr.ToUInt64();
		if (m_lastKnownWatermark != 0L && num2 > m_lastKnownWatermark)
		{
			return true;
		}
		Win32Native.VirtualQuery(uIntPtr.ToPointer(), ref buffer, (UIntPtr)(ulong)sizeof(Win32Native.MEMORY_BASIC_INFORMATION));
		if (num2 - ((UIntPtr)buffer.AllocationBase).ToUInt64() > 65536)
		{
			m_lastKnownWatermark = num2;
			return true;
		}
		return false;
	}
}
