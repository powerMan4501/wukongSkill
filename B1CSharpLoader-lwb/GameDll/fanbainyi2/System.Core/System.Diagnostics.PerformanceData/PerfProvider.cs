using System.ComponentModel;
using System.Security;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Diagnostics.PerformanceData;

internal sealed class PerfProvider
{
	internal Guid m_providerGuid;

	internal int m_counterSet;

	[SecurityCritical]
	internal SafePerfProviderHandle m_hProvider;

	[SecurityCritical]
	internal PerfProvider(Guid providerGuid)
	{
		m_providerGuid = providerGuid;
		uint num = Microsoft.Win32.UnsafeNativeMethods.PerfStartProvider(ref m_providerGuid, null, out m_hProvider);
		if (num != 0)
		{
			throw new Win32Exception((int)num);
		}
	}
}
