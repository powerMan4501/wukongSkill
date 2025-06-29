using System.Security;
using System.Security.Permissions;
using System.Threading;

namespace System.Diagnostics.PerformanceData;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class CounterData
{
	[SecurityCritical]
	private unsafe long* m_offset;

	public unsafe long Value
	{
		[SecurityCritical]
		get
		{
			return Interlocked.Read(ref *m_offset);
		}
		[SecurityCritical]
		set
		{
			Interlocked.Exchange(ref *m_offset, value);
		}
	}

	public unsafe long RawValue
	{
		[SecurityCritical]
		get
		{
			return *m_offset;
		}
		[SecurityCritical]
		set
		{
			*m_offset = value;
		}
	}

	[SecurityCritical]
	internal unsafe CounterData(long* pCounterData)
	{
		m_offset = pCounterData;
		*m_offset = 0L;
	}

	[SecurityCritical]
	public unsafe void Increment()
	{
		Interlocked.Increment(ref *m_offset);
	}

	[SecurityCritical]
	public unsafe void Decrement()
	{
		Interlocked.Decrement(ref *m_offset);
	}

	[SecurityCritical]
	public unsafe void IncrementBy(long value)
	{
		Interlocked.Add(ref *m_offset, value);
	}
}
