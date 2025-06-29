using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using Microsoft.Win32;

namespace System.Diagnostics.PerformanceData;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class CounterSetInstanceCounterDataSet : IDisposable
{
	internal CounterSetInstance m_instance;

	private Dictionary<int, CounterData> m_counters;

	private int m_disposed;

	[SecurityCritical]
	internal unsafe byte* m_dataBlock;

	public CounterData this[int counterId]
	{
		get
		{
			if (m_disposed != 0)
			{
				return null;
			}
			try
			{
				return m_counters[counterId];
			}
			catch (KeyNotFoundException)
			{
				return null;
			}
			catch
			{
				throw;
			}
		}
	}

	public CounterData this[string counterName]
	{
		get
		{
			if (counterName == null)
			{
				throw new ArgumentNullException("CounterName");
			}
			if (counterName.Length == 0)
			{
				throw new ArgumentNullException("CounterName");
			}
			if (m_disposed != 0)
			{
				return null;
			}
			try
			{
				int key = m_instance.m_counterSet.m_stringToId[counterName];
				try
				{
					return m_counters[key];
				}
				catch (KeyNotFoundException)
				{
					return null;
				}
				catch
				{
					throw;
				}
			}
			catch (KeyNotFoundException)
			{
				return null;
			}
			catch
			{
				throw;
			}
		}
	}

	[SecurityCritical]
	internal unsafe CounterSetInstanceCounterDataSet(CounterSetInstance thisInst)
	{
		m_instance = thisInst;
		m_counters = new Dictionary<int, CounterData>();
		if (m_instance.m_counterSet.m_provider == null)
		{
			throw new ArgumentException(System.SR.GetString("Perflib_Argument_ProviderNotFound", m_instance.m_counterSet.m_providerGuid), "ProviderGuid");
		}
		if (m_instance.m_counterSet.m_provider.m_hProvider.IsInvalid)
		{
			throw new InvalidOperationException(System.SR.GetString("Perflib_InvalidOperation_NoActiveProvider", m_instance.m_counterSet.m_providerGuid));
		}
		m_dataBlock = (byte*)(void*)Marshal.AllocHGlobal(m_instance.m_counterSet.m_idToCounter.Count * 8);
		if (m_dataBlock == null)
		{
			throw new InsufficientMemoryException(System.SR.GetString("Perflib_InsufficientMemory_InstanceCounterBlock", m_instance.m_counterSet.m_counterSet, m_instance.m_instName));
		}
		int num = 0;
		foreach (KeyValuePair<int, CounterType> item in m_instance.m_counterSet.m_idToCounter)
		{
			CounterData value = new CounterData((long*)(m_dataBlock + num * 8));
			m_counters.Add(item.Key, value);
			uint num2 = Microsoft.Win32.UnsafeNativeMethods.PerfSetCounterRefValue(m_instance.m_counterSet.m_provider.m_hProvider, m_instance.m_nativeInst, (uint)item.Key, m_dataBlock + num * 8);
			if (num2 != 0)
			{
				Dispose(disposing: true);
				if (num2 == 1168)
				{
					throw new InvalidOperationException(System.SR.GetString("Perflib_InvalidOperation_CounterRefValue", m_instance.m_counterSet.m_counterSet, item.Key, m_instance.m_instName));
				}
				throw new Win32Exception((int)num2);
			}
			num++;
		}
	}

	[SecurityCritical]
	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[SecurityCritical]
	~CounterSetInstanceCounterDataSet()
	{
		Dispose(disposing: false);
	}

	[SecurityCritical]
	private unsafe void Dispose(bool disposing)
	{
		if (Interlocked.Exchange(ref m_disposed, 1) == 0 && m_dataBlock != null)
		{
			Marshal.FreeHGlobal((IntPtr)m_dataBlock);
			m_dataBlock = null;
		}
	}
}
