using System.Collections.Generic;
using System.Security;
using System.Threading;

namespace System.Diagnostics.PerformanceData;

internal static class PerfProviderCollection
{
	private static object s_hiddenInternalSyncObject;

	private static List<PerfProvider> s_providerList = new List<PerfProvider>();

	private static Dictionary<object, int> s_counterSetList = new Dictionary<object, int>();

	private static CounterType[] s_counterTypes = (CounterType[])Enum.GetValues(typeof(CounterType));

	private static CounterSetInstanceType[] s_counterSetInstanceTypes = (CounterSetInstanceType[])Enum.GetValues(typeof(CounterSetInstanceType));

	private static object s_lockObject
	{
		get
		{
			if (s_hiddenInternalSyncObject == null)
			{
				object value = new object();
				Interlocked.CompareExchange(ref s_hiddenInternalSyncObject, value, null);
			}
			return s_hiddenInternalSyncObject;
		}
	}

	[SecurityCritical]
	internal static PerfProvider QueryProvider(Guid providerGuid)
	{
		lock (s_lockObject)
		{
			foreach (PerfProvider s_provider in s_providerList)
			{
				if (s_provider.m_providerGuid == providerGuid)
				{
					return s_provider;
				}
			}
			PerfProvider perfProvider = new PerfProvider(providerGuid);
			s_providerList.Add(perfProvider);
			return perfProvider;
		}
	}

	[SecurityCritical]
	internal static void RemoveProvider(Guid providerGuid)
	{
		lock (s_lockObject)
		{
			PerfProvider perfProvider = null;
			foreach (PerfProvider s_provider in s_providerList)
			{
				if (s_provider.m_providerGuid == providerGuid)
				{
					perfProvider = s_provider;
				}
			}
			if (perfProvider != null)
			{
				perfProvider.m_hProvider.Dispose();
				s_providerList.Remove(perfProvider);
			}
		}
	}

	internal static void RegisterCounterSet(Guid counterSetGuid)
	{
		lock (s_lockObject)
		{
			if (s_counterSetList.ContainsKey(counterSetGuid))
			{
				throw new ArgumentException(System.SR.GetString("Perflib_Argument_CounterSetAlreadyRegister", counterSetGuid), "CounterSetGuid");
			}
			s_counterSetList.Add(counterSetGuid, 0);
		}
	}

	internal static void UnregisterCounterSet(Guid counterSetGuid)
	{
		lock (s_lockObject)
		{
			s_counterSetList.Remove(counterSetGuid);
		}
	}

	internal static bool ValidateCounterType(CounterType inCounterType)
	{
		CounterType[] array = s_counterTypes;
		foreach (CounterType counterType in array)
		{
			if (counterType == inCounterType)
			{
				return true;
			}
		}
		return false;
	}

	internal static bool ValidateCounterSetInstanceType(CounterSetInstanceType inCounterSetInstanceType)
	{
		CounterSetInstanceType[] array = s_counterSetInstanceTypes;
		foreach (CounterSetInstanceType counterSetInstanceType in array)
		{
			if (counterSetInstanceType == inCounterSetInstanceType)
			{
				return true;
			}
		}
		return false;
	}
}
