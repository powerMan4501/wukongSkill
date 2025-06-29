using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using Microsoft.Win32;

namespace System.Diagnostics.PerformanceData;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class CounterSetInstance : IDisposable
{
	internal CounterSet m_counterSet;

	internal string m_instName;

	private int m_active;

	private CounterSetInstanceCounterDataSet m_counters;

	[SecurityCritical]
	internal unsafe Microsoft.Win32.UnsafeNativeMethods.PerfCounterSetInstanceStruct* m_nativeInst;

	public CounterSetInstanceCounterDataSet Counters => m_counters;

	[SecurityCritical]
	internal unsafe CounterSetInstance(CounterSet counterSetDefined, string instanceName)
	{
		if (counterSetDefined == null)
		{
			throw new ArgumentNullException("counterSetDefined");
		}
		if (instanceName == null)
		{
			throw new ArgumentNullException("InstanceName");
		}
		if (instanceName.Length == 0)
		{
			throw new ArgumentException(System.SR.GetString("Perflib_Argument_EmptyInstanceName"), "InstanceName");
		}
		m_counterSet = counterSetDefined;
		m_instName = instanceName;
		m_nativeInst = Microsoft.Win32.UnsafeNativeMethods.PerfCreateInstance(m_counterSet.m_provider.m_hProvider, ref m_counterSet.m_counterSet, m_instName, 0u);
		int num = ((m_nativeInst == null) ? Marshal.GetLastWin32Error() : 0);
		if (m_nativeInst != null)
		{
			m_counters = new CounterSetInstanceCounterDataSet(this);
			m_active = 1;
			return;
		}
		switch (num)
		{
		case 183:
			throw new ArgumentException(System.SR.GetString("Perflib_Argument_InstanceAlreadyExists", m_instName, m_counterSet.m_counterSet), "InstanceName");
		case 1168:
			throw new InvalidOperationException(System.SR.GetString("Perflib_InvalidOperation_CounterSetNotInstalled", m_counterSet.m_counterSet));
		case 87:
			if (m_counterSet.m_instType == CounterSetInstanceType.Single)
			{
				throw new ArgumentException(System.SR.GetString("Perflib_Argument_InvalidInstance", m_counterSet.m_counterSet), "InstanceName");
			}
			throw new Win32Exception(num);
		default:
			throw new Win32Exception(num);
		}
	}

	[SecurityCritical]
	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[SecurityCritical]
	~CounterSetInstance()
	{
		Dispose(disposing: false);
	}

	[SecurityCritical]
	private unsafe void Dispose(bool disposing)
	{
		if (disposing && m_counters != null)
		{
			m_counters.Dispose();
			m_counters = null;
		}
		if (m_nativeInst == null || Interlocked.Exchange(ref m_active, 0) == 0 || m_nativeInst == null)
		{
			return;
		}
		lock (m_counterSet)
		{
			if (m_counterSet.m_provider != null)
			{
				uint num = Microsoft.Win32.UnsafeNativeMethods.PerfDeleteInstance(m_counterSet.m_provider.m_hProvider, m_nativeInst);
			}
			m_nativeInst = null;
		}
	}
}
