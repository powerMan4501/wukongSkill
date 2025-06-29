using System.ComponentModel;
using System.Diagnostics;
using System.Net.Configuration;
using System.Runtime.Versioning;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;

namespace System.Net;

internal sealed class NetworkingPerfCounters
{
	private class CounterPair
	{
		private PerformanceCounter instanceCounter;

		private PerformanceCounter globalCounter;

		public PerformanceCounter InstanceCounter => instanceCounter;

		public PerformanceCounter GlobalCounter => globalCounter;

		public CounterPair(PerformanceCounter instanceCounter, PerformanceCounter globalCounter)
		{
			this.instanceCounter = instanceCounter;
			this.globalCounter = globalCounter;
		}
	}

	private const int instanceNameMaxLength = 127;

	private const string categoryName = ".NET CLR Networking 4.0.0.0";

	private const string globalInstanceName = "_Global_";

	private static readonly string[] counterNames = new string[13]
	{
		"Connections Established", "Bytes Received", "Bytes Sent", "Datagrams Received", "Datagrams Sent", "HttpWebRequests Created/Sec", "HttpWebRequests Average Lifetime", "HttpWebRequests Average Lifetime Base", "HttpWebRequests Queued/Sec", "HttpWebRequests Average Queue Time",
		"HttpWebRequests Average Queue Time Base", "HttpWebRequests Aborted/Sec", "HttpWebRequests Failed/Sec"
	};

	private static volatile NetworkingPerfCounters instance;

	private static object lockObject = new object();

	private volatile bool initDone;

	private bool initSuccessful;

	private CounterPair[] counters;

	private bool enabled;

	private volatile bool cleanupCalled;

	public static NetworkingPerfCounters Instance
	{
		get
		{
			if (instance == null)
			{
				lock (lockObject)
				{
					if (instance == null)
					{
						CreateInstance();
					}
				}
			}
			return instance;
		}
	}

	public bool Enabled => enabled;

	private NetworkingPerfCounters()
	{
		enabled = SettingsSectionInternal.Section.PerformanceCountersEnabled;
	}

	public static long GetTimestamp()
	{
		return Stopwatch.GetTimestamp();
	}

	public void Increment(NetworkingPerfCounterName perfCounter)
	{
		Increment(perfCounter, 1L);
	}

	public void Increment(NetworkingPerfCounterName perfCounter, long amount)
	{
		if (!CounterAvailable())
		{
			return;
		}
		try
		{
			CounterPair counterPair = counters[(int)perfCounter];
			counterPair.InstanceCounter.IncrementBy(amount);
			counterPair.GlobalCounter.IncrementBy(amount);
		}
		catch (InvalidOperationException e)
		{
			if (Logging.On)
			{
				Logging.Exception(Logging.Web, "NetworkingPerfCounters", "Increment", e);
			}
		}
		catch (Win32Exception e2)
		{
			if (Logging.On)
			{
				Logging.Exception(Logging.Web, "NetworkingPerfCounters", "Increment", e2);
			}
		}
	}

	public void Decrement(NetworkingPerfCounterName perfCounter)
	{
		Increment(perfCounter, -1L);
	}

	public void Decrement(NetworkingPerfCounterName perfCounter, long amount)
	{
		Increment(perfCounter, -amount);
	}

	public void IncrementAverage(NetworkingPerfCounterName perfCounter, long startTimestamp)
	{
		if (CounterAvailable())
		{
			long timestamp = GetTimestamp();
			long amount = (timestamp - startTimestamp) * 1000 / Stopwatch.Frequency;
			Increment(perfCounter, amount);
			Increment(perfCounter + 1, 1L);
		}
	}

	private void Initialize(object state)
	{
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, SR.GetString("net_perfcounter_initialization_started"));
		}
		PerformanceCounterPermission performanceCounterPermission = new PerformanceCounterPermission(PermissionState.Unrestricted);
		performanceCounterPermission.Assert();
		try
		{
			if (!PerformanceCounterCategory.Exists(".NET CLR Networking 4.0.0.0"))
			{
				if (Logging.On)
				{
					Logging.PrintError(Logging.Web, SR.GetString("net_perfcounter_nocategory", ".NET CLR Networking 4.0.0.0"));
				}
				return;
			}
			string instanceName = GetInstanceName();
			counters = new CounterPair[counterNames.Length];
			for (int i = 0; i < counterNames.Length; i++)
			{
				counters[i] = CreateCounterPair(counterNames[i], instanceName);
			}
			AppDomain.CurrentDomain.DomainUnload += UnloadEventHandler;
			AppDomain.CurrentDomain.ProcessExit += ExitEventHandler;
			AppDomain.CurrentDomain.UnhandledException += ExceptionEventHandler;
			initSuccessful = true;
		}
		catch (Win32Exception e)
		{
			if (Logging.On)
			{
				Logging.Exception(Logging.Web, "NetworkingPerfCounters", "Initialize", e);
			}
			Cleanup();
		}
		catch (InvalidOperationException e2)
		{
			if (Logging.On)
			{
				Logging.Exception(Logging.Web, "NetworkingPerfCounters", "Initialize", e2);
			}
			Cleanup();
		}
		finally
		{
			CodeAccessPermission.RevertAssert();
			initDone = true;
			if (Logging.On)
			{
				if (initSuccessful)
				{
					Logging.PrintInfo(Logging.Web, SR.GetString("net_perfcounter_initialized_success"));
				}
				else
				{
					Logging.PrintInfo(Logging.Web, SR.GetString("net_perfcounter_initialized_error"));
				}
			}
		}
	}

	private static void CreateInstance()
	{
		instance = new NetworkingPerfCounters();
		if (instance.Enabled && !ThreadPool.QueueUserWorkItem(instance.Initialize) && Logging.On)
		{
			Logging.PrintError(Logging.Web, SR.GetString("net_perfcounter_cant_queue_workitem"));
		}
	}

	private static CounterPair CreateCounterPair(string counterName, string instanceName)
	{
		PerformanceCounter globalCounter = new PerformanceCounter(".NET CLR Networking 4.0.0.0", counterName, "_Global_", readOnly: false);
		PerformanceCounter performanceCounter = new PerformanceCounter();
		performanceCounter.CategoryName = ".NET CLR Networking 4.0.0.0";
		performanceCounter.CounterName = counterName;
		performanceCounter.InstanceName = instanceName;
		performanceCounter.InstanceLifetime = PerformanceCounterInstanceLifetime.Process;
		performanceCounter.ReadOnly = false;
		performanceCounter.RawValue = 0L;
		return new CounterPair(performanceCounter, globalCounter);
	}

	private void ExceptionEventHandler(object sender, UnhandledExceptionEventArgs e)
	{
		if (e.IsTerminating)
		{
			Cleanup();
		}
	}

	private void UnloadEventHandler(object sender, EventArgs e)
	{
		Cleanup();
	}

	private void ExitEventHandler(object sender, EventArgs e)
	{
		Cleanup();
	}

	private void Cleanup()
	{
		lock (lockObject)
		{
			if (cleanupCalled)
			{
				return;
			}
			cleanupCalled = true;
			if (counters == null)
			{
				return;
			}
			CounterPair[] array = counters;
			foreach (CounterPair counterPair in array)
			{
				if (Environment.HasShutdownStarted || counterPair == null)
				{
					continue;
				}
				try
				{
					counterPair.InstanceCounter.RemoveInstance();
				}
				catch (InvalidOperationException e)
				{
					if (Logging.On)
					{
						Logging.Exception(Logging.Web, "NetworkingPerfCounters", "Cleanup", e);
					}
				}
				catch (Win32Exception e2)
				{
					if (Logging.On)
					{
						Logging.Exception(Logging.Web, "NetworkingPerfCounters", "Cleanup", e2);
					}
				}
			}
		}
	}

	private static string GetInstanceName()
	{
		string text = ReplaceInvalidChars(AppDomain.CurrentDomain.FriendlyName);
		string text2 = VersioningHelper.MakeVersionSafeName(string.Empty, ResourceScope.Machine, ResourceScope.AppDomain);
		string text3 = text + text2;
		if (text3.Length > 127)
		{
			text3 = text.Substring(0, 127 - text2.Length) + text2;
		}
		return text3;
	}

	private static string ReplaceInvalidChars(string instanceName)
	{
		StringBuilder stringBuilder = new StringBuilder(instanceName);
		for (int i = 0; i < stringBuilder.Length; i++)
		{
			switch (stringBuilder[i])
			{
			case '(':
				stringBuilder[i] = '[';
				break;
			case ')':
				stringBuilder[i] = ']';
				break;
			case '#':
			case '/':
			case '\\':
				stringBuilder[i] = '_';
				break;
			}
		}
		return stringBuilder.ToString();
	}

	private bool CounterAvailable()
	{
		if (!enabled || cleanupCalled)
		{
			return false;
		}
		if (initDone)
		{
			return initSuccessful;
		}
		return false;
	}
}
