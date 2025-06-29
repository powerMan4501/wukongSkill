using System.Collections.Generic;
using System.ComponentModel;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using Microsoft.Win32;

namespace System.Diagnostics.PerformanceData;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public class CounterSet : IDisposable
{
	private static readonly bool s_platformNotSupported = Environment.OSVersion.Version.Major < 6;

	internal PerfProvider m_provider;

	internal Guid m_providerGuid;

	internal Guid m_counterSet;

	internal CounterSetInstanceType m_instType;

	private readonly object m_lockObject;

	private bool m_instanceCreated;

	internal Dictionary<string, int> m_stringToId;

	internal Dictionary<int, CounterType> m_idToCounter;

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Demand, Unrestricted = true)]
	public CounterSet(Guid providerGuid, Guid counterSetGuid, CounterSetInstanceType instanceType)
	{
		if (s_platformNotSupported)
		{
			throw new PlatformNotSupportedException(System.SR.GetString("Perflib_PlatformNotSupported"));
		}
		if (!PerfProviderCollection.ValidateCounterSetInstanceType(instanceType))
		{
			throw new ArgumentException(System.SR.GetString("Perflib_Argument_InvalidCounterSetInstanceType", instanceType), "instanceType");
		}
		m_providerGuid = providerGuid;
		m_counterSet = counterSetGuid;
		m_instType = instanceType;
		PerfProviderCollection.RegisterCounterSet(m_counterSet);
		m_provider = PerfProviderCollection.QueryProvider(m_providerGuid);
		m_lockObject = new object();
		m_stringToId = new Dictionary<string, int>();
		m_idToCounter = new Dictionary<int, CounterType>();
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	~CounterSet()
	{
		Dispose(disposing: false);
	}

	[SecuritySafeCritical]
	protected virtual void Dispose(bool disposing)
	{
		lock (this)
		{
			PerfProviderCollection.UnregisterCounterSet(m_counterSet);
			if (!m_instanceCreated || m_provider == null)
			{
				return;
			}
			lock (m_lockObject)
			{
				if (m_provider != null)
				{
					Interlocked.Decrement(ref m_provider.m_counterSet);
					if (m_provider.m_counterSet <= 0)
					{
						PerfProviderCollection.RemoveProvider(m_providerGuid);
					}
					m_provider = null;
				}
			}
		}
	}

	public void AddCounter(int counterId, CounterType counterType)
	{
		if (m_provider == null)
		{
			throw new InvalidOperationException(System.SR.GetString("Perflib_InvalidOperation_NoActiveProvider", m_providerGuid));
		}
		if (!PerfProviderCollection.ValidateCounterType(counterType))
		{
			throw new ArgumentException(System.SR.GetString("Perflib_Argument_InvalidCounterType", counterType), "counterType");
		}
		if (m_instanceCreated)
		{
			throw new InvalidOperationException(System.SR.GetString("Perflib_InvalidOperation_AddCounterAfterInstance", m_counterSet));
		}
		lock (m_lockObject)
		{
			if (m_instanceCreated)
			{
				throw new InvalidOperationException(System.SR.GetString("Perflib_InvalidOperation_AddCounterAfterInstance", m_counterSet));
			}
			if (m_idToCounter.ContainsKey(counterId))
			{
				throw new ArgumentException(System.SR.GetString("Perflib_Argument_CounterAlreadyExists", counterId, m_counterSet), "CounterId");
			}
			m_idToCounter.Add(counterId, counterType);
		}
	}

	public void AddCounter(int counterId, CounterType counterType, string counterName)
	{
		if (counterName == null)
		{
			throw new ArgumentNullException("CounterName");
		}
		if (counterName.Length == 0)
		{
			throw new ArgumentException(System.SR.GetString("Perflib_Argument_EmptyCounterName"), "counterName");
		}
		if (!PerfProviderCollection.ValidateCounterType(counterType))
		{
			throw new ArgumentException(System.SR.GetString("Perflib_Argument_InvalidCounterType", counterType), "counterType");
		}
		if (m_provider == null)
		{
			throw new InvalidOperationException(System.SR.GetString("Perflib_InvalidOperation_NoActiveProvider", m_providerGuid));
		}
		if (m_instanceCreated)
		{
			throw new InvalidOperationException(System.SR.GetString("Perflib_InvalidOperation_AddCounterAfterInstance", m_counterSet));
		}
		lock (m_lockObject)
		{
			if (m_instanceCreated)
			{
				throw new InvalidOperationException(System.SR.GetString("Perflib_InvalidOperation_AddCounterAfterInstance", m_counterSet));
			}
			if (m_stringToId.ContainsKey(counterName))
			{
				throw new ArgumentException(System.SR.GetString("Perflib_Argument_CounterNameAlreadyExists", counterName, m_counterSet), "CounterName");
			}
			if (m_idToCounter.ContainsKey(counterId))
			{
				throw new ArgumentException(System.SR.GetString("Perflib_Argument_CounterAlreadyExists", counterId, m_counterSet), "CounterId");
			}
			m_stringToId.Add(counterName, counterId);
			m_idToCounter.Add(counterId, counterType);
		}
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Demand, Unrestricted = true)]
	public unsafe CounterSetInstance CreateCounterSetInstance(string instanceName)
	{
		if (instanceName == null)
		{
			throw new ArgumentNullException("instanceName");
		}
		if (instanceName.Length == 0)
		{
			throw new ArgumentException(System.SR.GetString("Perflib_Argument_EmptyInstanceName"), "instanceName");
		}
		if (m_provider == null)
		{
			throw new InvalidOperationException(System.SR.GetString("Perflib_InvalidOperation_NoActiveProvider", m_providerGuid));
		}
		if (!m_instanceCreated)
		{
			lock (m_lockObject)
			{
				if (!m_instanceCreated)
				{
					if (m_provider == null)
					{
						throw new ArgumentException(System.SR.GetString("Perflib_Argument_ProviderNotFound", m_providerGuid), "ProviderGuid");
					}
					if (m_provider.m_hProvider.IsInvalid)
					{
						throw new InvalidOperationException(System.SR.GetString("Perflib_InvalidOperation_NoActiveProvider", m_providerGuid));
					}
					if (m_idToCounter.Count == 0)
					{
						throw new InvalidOperationException(System.SR.GetString("Perflib_InvalidOperation_CounterSetContainsNoCounter", m_counterSet));
					}
					uint num = 0u;
					uint num2 = (uint)(sizeof(Microsoft.Win32.UnsafeNativeMethods.PerfCounterSetInfoStruct) + m_idToCounter.Count * sizeof(Microsoft.Win32.UnsafeNativeMethods.PerfCounterInfoStruct));
					uint num3 = 0u;
					byte* ptr = stackalloc byte[(int)num2];
					if (ptr == null)
					{
						throw new InsufficientMemoryException(System.SR.GetString("Perflib_InsufficientMemory_CounterSetTemplate", m_counterSet, num2));
					}
					uint num4 = 0u;
					uint num5 = 0u;
					Microsoft.Win32.UnsafeNativeMethods.PerfCounterSetInfoStruct* ptr2 = (Microsoft.Win32.UnsafeNativeMethods.PerfCounterSetInfoStruct*)ptr;
					ptr2->CounterSetGuid = m_counterSet;
					ptr2->ProviderGuid = m_providerGuid;
					ptr2->NumCounters = (uint)m_idToCounter.Count;
					ptr2->InstanceType = (uint)m_instType;
					foreach (KeyValuePair<int, CounterType> item in m_idToCounter)
					{
						num3 = (uint)(sizeof(Microsoft.Win32.UnsafeNativeMethods.PerfCounterSetInfoStruct) + (int)num4 * sizeof(Microsoft.Win32.UnsafeNativeMethods.PerfCounterInfoStruct));
						if (num3 < num2)
						{
							Microsoft.Win32.UnsafeNativeMethods.PerfCounterInfoStruct* ptr3 = (Microsoft.Win32.UnsafeNativeMethods.PerfCounterInfoStruct*)(ptr + num3);
							ptr3->CounterId = (uint)item.Key;
							ptr3->CounterType = (uint)item.Value;
							ptr3->Attrib = 1L;
							ptr3->Size = (uint)sizeof(void*);
							ptr3->DetailLevel = 100u;
							ptr3->Scale = 0u;
							ptr3->Offset = num5;
							num5 += ptr3->Size;
						}
						num4++;
					}
					num = Microsoft.Win32.UnsafeNativeMethods.PerfSetCounterSetInfo(m_provider.m_hProvider, ptr2, num2);
					switch (num)
					{
					case 183u:
						throw new ArgumentException(System.SR.GetString("Perflib_Argument_CounterSetAlreadyRegister", m_counterSet), "CounterSetGuid");
					default:
						throw new Win32Exception((int)num);
					case 0u:
						Interlocked.Increment(ref m_provider.m_counterSet);
						m_instanceCreated = true;
						break;
					}
				}
			}
		}
		return new CounterSetInstance(this, instanceName);
	}
}
