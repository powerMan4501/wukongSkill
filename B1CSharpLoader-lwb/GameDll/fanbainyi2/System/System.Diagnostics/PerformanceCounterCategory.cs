using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Threading;

namespace System.Diagnostics;

[HostProtection(SecurityAction.LinkDemand, Synchronization = true, SharedState = true)]
public sealed class PerformanceCounterCategory
{
	private string categoryName;

	private string categoryHelp;

	private string machineName;

	internal const int MaxCategoryNameLength = 80;

	internal const int MaxCounterNameLength = 32767;

	internal const int MaxHelpLength = 32767;

	private const string perfMutexName = "netfxperf.1.0";

	public string CategoryName
	{
		get
		{
			return categoryName;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value.Length == 0)
			{
				throw new ArgumentException(SR.GetString("InvalidProperty", "CategoryName", value));
			}
			lock (this)
			{
				PerformanceCounterPermission performanceCounterPermission = new PerformanceCounterPermission(PerformanceCounterPermissionAccess.Browse, machineName, value);
				performanceCounterPermission.Demand();
				categoryName = value;
			}
		}
	}

	public string CategoryHelp
	{
		get
		{
			if (categoryName == null)
			{
				throw new InvalidOperationException(SR.GetString("CategoryNameNotSet"));
			}
			if (categoryHelp == null)
			{
				categoryHelp = PerformanceCounterLib.GetCategoryHelp(machineName, categoryName);
			}
			return categoryHelp;
		}
	}

	public PerformanceCounterCategoryType CategoryType
	{
		get
		{
			CategorySample categorySample = PerformanceCounterLib.GetCategorySample(machineName, categoryName);
			if (categorySample.IsMultiInstance)
			{
				return PerformanceCounterCategoryType.MultiInstance;
			}
			if (PerformanceCounterLib.IsCustomCategory(".", categoryName))
			{
				return PerformanceCounterLib.GetCategoryType(".", categoryName);
			}
			return PerformanceCounterCategoryType.SingleInstance;
		}
	}

	public string MachineName
	{
		get
		{
			return machineName;
		}
		set
		{
			if (!SyntaxCheck.CheckMachineName(value))
			{
				throw new ArgumentException(SR.GetString("InvalidProperty", "MachineName", value));
			}
			lock (this)
			{
				if (categoryName != null)
				{
					PerformanceCounterPermission performanceCounterPermission = new PerformanceCounterPermission(PerformanceCounterPermissionAccess.Browse, value, categoryName);
					performanceCounterPermission.Demand();
				}
				machineName = value;
			}
		}
	}

	public PerformanceCounterCategory()
	{
		machineName = ".";
	}

	public PerformanceCounterCategory(string categoryName)
		: this(categoryName, ".")
	{
	}

	public PerformanceCounterCategory(string categoryName, string machineName)
	{
		if (categoryName == null)
		{
			throw new ArgumentNullException("categoryName");
		}
		if (categoryName.Length == 0)
		{
			throw new ArgumentException(SR.GetString("InvalidParameter", "categoryName", categoryName));
		}
		if (!SyntaxCheck.CheckMachineName(machineName))
		{
			throw new ArgumentException(SR.GetString("InvalidParameter", "machineName", machineName));
		}
		PerformanceCounterPermission performanceCounterPermission = new PerformanceCounterPermission(PerformanceCounterPermissionAccess.Browse, machineName, categoryName);
		performanceCounterPermission.Demand();
		this.categoryName = categoryName;
		this.machineName = machineName;
	}

	public bool CounterExists(string counterName)
	{
		if (counterName == null)
		{
			throw new ArgumentNullException("counterName");
		}
		if (categoryName == null)
		{
			throw new InvalidOperationException(SR.GetString("CategoryNameNotSet"));
		}
		return PerformanceCounterLib.CounterExists(machineName, categoryName, counterName);
	}

	public static bool CounterExists(string counterName, string categoryName)
	{
		return CounterExists(counterName, categoryName, ".");
	}

	public static bool CounterExists(string counterName, string categoryName, string machineName)
	{
		if (counterName == null)
		{
			throw new ArgumentNullException("counterName");
		}
		if (categoryName == null)
		{
			throw new ArgumentNullException("categoryName");
		}
		if (categoryName.Length == 0)
		{
			throw new ArgumentException(SR.GetString("InvalidParameter", "categoryName", categoryName));
		}
		if (!SyntaxCheck.CheckMachineName(machineName))
		{
			throw new ArgumentException(SR.GetString("InvalidParameter", "machineName", machineName));
		}
		PerformanceCounterPermission performanceCounterPermission = new PerformanceCounterPermission(PerformanceCounterPermissionAccess.Browse, machineName, categoryName);
		performanceCounterPermission.Demand();
		return PerformanceCounterLib.CounterExists(machineName, categoryName, counterName);
	}

	[Obsolete("This method has been deprecated.  Please use System.Diagnostics.PerformanceCounterCategory.Create(string categoryName, string categoryHelp, PerformanceCounterCategoryType categoryType, string counterName, string counterHelp) instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	public static PerformanceCounterCategory Create(string categoryName, string categoryHelp, string counterName, string counterHelp)
	{
		CounterCreationData counterCreationData = new CounterCreationData(counterName, counterHelp, PerformanceCounterType.NumberOfItems32);
		return Create(categoryName, categoryHelp, PerformanceCounterCategoryType.Unknown, new CounterCreationDataCollection(new CounterCreationData[1] { counterCreationData }));
	}

	public static PerformanceCounterCategory Create(string categoryName, string categoryHelp, PerformanceCounterCategoryType categoryType, string counterName, string counterHelp)
	{
		CounterCreationData counterCreationData = new CounterCreationData(counterName, counterHelp, PerformanceCounterType.NumberOfItems32);
		return Create(categoryName, categoryHelp, categoryType, new CounterCreationDataCollection(new CounterCreationData[1] { counterCreationData }));
	}

	[Obsolete("This method has been deprecated.  Please use System.Diagnostics.PerformanceCounterCategory.Create(string categoryName, string categoryHelp, PerformanceCounterCategoryType categoryType, CounterCreationDataCollection counterData) instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	public static PerformanceCounterCategory Create(string categoryName, string categoryHelp, CounterCreationDataCollection counterData)
	{
		return Create(categoryName, categoryHelp, PerformanceCounterCategoryType.Unknown, counterData);
	}

	public static PerformanceCounterCategory Create(string categoryName, string categoryHelp, PerformanceCounterCategoryType categoryType, CounterCreationDataCollection counterData)
	{
		if (categoryType < PerformanceCounterCategoryType.Unknown || categoryType > PerformanceCounterCategoryType.MultiInstance)
		{
			throw new ArgumentOutOfRangeException("categoryType");
		}
		if (counterData == null)
		{
			throw new ArgumentNullException("counterData");
		}
		CheckValidCategory(categoryName);
		if (categoryHelp != null)
		{
			CheckValidHelp(categoryHelp);
		}
		string machine = ".";
		PerformanceCounterPermission performanceCounterPermission = new PerformanceCounterPermission(PerformanceCounterPermissionAccess.Administer, machine, categoryName);
		performanceCounterPermission.Demand();
		SharedUtils.CheckNtEnvironment();
		Mutex mutex = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			SharedUtils.EnterMutex("netfxperf.1.0", ref mutex);
			if (PerformanceCounterLib.IsCustomCategory(machine, categoryName) || PerformanceCounterLib.CategoryExists(machine, categoryName))
			{
				throw new InvalidOperationException(SR.GetString("PerformanceCategoryExists", categoryName));
			}
			CheckValidCounterLayout(counterData);
			PerformanceCounterLib.RegisterCategory(categoryName, categoryType, categoryHelp, counterData);
			return new PerformanceCounterCategory(categoryName, machine);
		}
		finally
		{
			if (mutex != null)
			{
				mutex.ReleaseMutex();
				mutex.Close();
			}
		}
	}

	internal static void CheckValidCategory(string categoryName)
	{
		if (categoryName == null)
		{
			throw new ArgumentNullException("categoryName");
		}
		if (!CheckValidId(categoryName, 80))
		{
			throw new ArgumentException(SR.GetString("PerfInvalidCategoryName", 1, 80));
		}
		if (categoryName.Length > 1024 - "netfxcustomperfcounters.1.0".Length)
		{
			throw new ArgumentException(SR.GetString("CategoryNameTooLong"));
		}
	}

	internal static void CheckValidCounter(string counterName)
	{
		if (counterName == null)
		{
			throw new ArgumentNullException("counterName");
		}
		if (!CheckValidId(counterName, 32767))
		{
			throw new ArgumentException(SR.GetString("PerfInvalidCounterName", 1, 32767));
		}
	}

	internal static bool CheckValidId(string id, int maxLength)
	{
		if (id.Length == 0 || id.Length > maxLength)
		{
			return false;
		}
		for (int i = 0; i < id.Length; i++)
		{
			char c = id[i];
			if ((i == 0 || i == id.Length - 1) && c == ' ')
			{
				return false;
			}
			if (c == '"')
			{
				return false;
			}
			if (char.IsControl(c))
			{
				return false;
			}
		}
		return true;
	}

	internal static void CheckValidHelp(string help)
	{
		if (help == null)
		{
			throw new ArgumentNullException("help");
		}
		if (help.Length > 32767)
		{
			throw new ArgumentException(SR.GetString("PerfInvalidHelp", 0, 32767));
		}
	}

	internal static void CheckValidCounterLayout(CounterCreationDataCollection counterData)
	{
		Hashtable hashtable = new Hashtable();
		for (int i = 0; i < counterData.Count; i++)
		{
			if (counterData[i].CounterName == null || counterData[i].CounterName.Length == 0)
			{
				throw new ArgumentException(SR.GetString("InvalidCounterName"));
			}
			int counterType = (int)counterData[i].CounterType;
			if (counterType == 1073874176 || counterType == 575735040 || counterType == 592512256 || counterType == 574686464 || counterType == 591463680 || counterType == 537003008 || counterType == 549585920 || counterType == 805438464)
			{
				if (counterData.Count <= i + 1)
				{
					throw new InvalidOperationException(SR.GetString("CounterLayout"));
				}
				counterType = (int)counterData[i + 1].CounterType;
				if (!PerformanceCounterLib.IsBaseCounter(counterType))
				{
					throw new InvalidOperationException(SR.GetString("CounterLayout"));
				}
			}
			else if (PerformanceCounterLib.IsBaseCounter(counterType))
			{
				if (i == 0)
				{
					throw new InvalidOperationException(SR.GetString("CounterLayout"));
				}
				counterType = (int)counterData[i - 1].CounterType;
				if (counterType != 1073874176 && counterType != 575735040 && counterType != 592512256 && counterType != 574686464 && counterType != 591463680 && counterType != 537003008 && counterType != 549585920 && counterType != 805438464)
				{
					throw new InvalidOperationException(SR.GetString("CounterLayout"));
				}
			}
			if (hashtable.ContainsKey(counterData[i].CounterName))
			{
				throw new ArgumentException(SR.GetString("DuplicateCounterName", counterData[i].CounterName));
			}
			hashtable.Add(counterData[i].CounterName, string.Empty);
			if (counterData[i].CounterHelp == null || counterData[i].CounterHelp.Length == 0)
			{
				counterData[i].CounterHelp = counterData[i].CounterName;
			}
		}
	}

	public static void Delete(string categoryName)
	{
		CheckValidCategory(categoryName);
		string machine = ".";
		PerformanceCounterPermission performanceCounterPermission = new PerformanceCounterPermission(PerformanceCounterPermissionAccess.Administer, machine, categoryName);
		performanceCounterPermission.Demand();
		SharedUtils.CheckNtEnvironment();
		categoryName = categoryName.ToLower(CultureInfo.InvariantCulture);
		Mutex mutex = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			SharedUtils.EnterMutex("netfxperf.1.0", ref mutex);
			if (!PerformanceCounterLib.IsCustomCategory(machine, categoryName))
			{
				throw new InvalidOperationException(SR.GetString("CantDeleteCategory"));
			}
			SharedPerformanceCounter.RemoveAllInstances(categoryName);
			PerformanceCounterLib.UnregisterCategory(categoryName);
			PerformanceCounterLib.CloseAllLibraries();
		}
		finally
		{
			if (mutex != null)
			{
				mutex.ReleaseMutex();
				mutex.Close();
			}
		}
	}

	public static bool Exists(string categoryName)
	{
		return Exists(categoryName, ".");
	}

	public static bool Exists(string categoryName, string machineName)
	{
		if (categoryName == null)
		{
			throw new ArgumentNullException("categoryName");
		}
		if (categoryName.Length == 0)
		{
			throw new ArgumentException(SR.GetString("InvalidParameter", "categoryName", categoryName));
		}
		if (!SyntaxCheck.CheckMachineName(machineName))
		{
			throw new ArgumentException(SR.GetString("InvalidParameter", "machineName", machineName));
		}
		PerformanceCounterPermission performanceCounterPermission = new PerformanceCounterPermission(PerformanceCounterPermissionAccess.Browse, machineName, categoryName);
		performanceCounterPermission.Demand();
		if (PerformanceCounterLib.IsCustomCategory(machineName, categoryName))
		{
			return true;
		}
		return PerformanceCounterLib.CategoryExists(machineName, categoryName);
	}

	internal static string[] GetCounterInstances(string categoryName, string machineName)
	{
		PerformanceCounterPermission performanceCounterPermission = new PerformanceCounterPermission(PerformanceCounterPermissionAccess.Browse, machineName, categoryName);
		performanceCounterPermission.Demand();
		CategorySample categorySample = PerformanceCounterLib.GetCategorySample(machineName, categoryName);
		if (categorySample.InstanceNameTable.Count == 0)
		{
			return new string[0];
		}
		string[] array = new string[categorySample.InstanceNameTable.Count];
		categorySample.InstanceNameTable.Keys.CopyTo(array, 0);
		if (array.Length == 1 && array[0].CompareTo("systemdiagnosticsperfcounterlibsingleinstance") == 0)
		{
			return new string[0];
		}
		return array;
	}

	public PerformanceCounter[] GetCounters()
	{
		if (GetInstanceNames().Length != 0)
		{
			throw new ArgumentException(SR.GetString("InstanceNameRequired"));
		}
		return GetCounters("");
	}

	public PerformanceCounter[] GetCounters(string instanceName)
	{
		if (instanceName == null)
		{
			throw new ArgumentNullException("instanceName");
		}
		if (categoryName == null)
		{
			throw new InvalidOperationException(SR.GetString("CategoryNameNotSet"));
		}
		if (instanceName.Length != 0 && !InstanceExists(instanceName))
		{
			throw new InvalidOperationException(SR.GetString("MissingInstance", instanceName, categoryName));
		}
		string[] counters = PerformanceCounterLib.GetCounters(machineName, categoryName);
		PerformanceCounter[] array = new PerformanceCounter[counters.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = new PerformanceCounter(categoryName, counters[i], instanceName, machineName, skipInit: true);
		}
		return array;
	}

	public static PerformanceCounterCategory[] GetCategories()
	{
		return GetCategories(".");
	}

	public static PerformanceCounterCategory[] GetCategories(string machineName)
	{
		if (!SyntaxCheck.CheckMachineName(machineName))
		{
			throw new ArgumentException(SR.GetString("InvalidParameter", "machineName", machineName));
		}
		PerformanceCounterPermission performanceCounterPermission = new PerformanceCounterPermission(PerformanceCounterPermissionAccess.Browse, machineName, "*");
		performanceCounterPermission.Demand();
		string[] categories = PerformanceCounterLib.GetCategories(machineName);
		PerformanceCounterCategory[] array = new PerformanceCounterCategory[categories.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = new PerformanceCounterCategory(categories[i], machineName);
		}
		return array;
	}

	public string[] GetInstanceNames()
	{
		if (categoryName == null)
		{
			throw new InvalidOperationException(SR.GetString("CategoryNameNotSet"));
		}
		return GetCounterInstances(categoryName, machineName);
	}

	public bool InstanceExists(string instanceName)
	{
		if (instanceName == null)
		{
			throw new ArgumentNullException("instanceName");
		}
		if (categoryName == null)
		{
			throw new InvalidOperationException(SR.GetString("CategoryNameNotSet"));
		}
		CategorySample categorySample = PerformanceCounterLib.GetCategorySample(machineName, categoryName);
		return categorySample.InstanceNameTable.ContainsKey(instanceName);
	}

	public static bool InstanceExists(string instanceName, string categoryName)
	{
		return InstanceExists(instanceName, categoryName, ".");
	}

	public static bool InstanceExists(string instanceName, string categoryName, string machineName)
	{
		if (instanceName == null)
		{
			throw new ArgumentNullException("instanceName");
		}
		if (categoryName == null)
		{
			throw new ArgumentNullException("categoryName");
		}
		if (categoryName.Length == 0)
		{
			throw new ArgumentException(SR.GetString("InvalidParameter", "categoryName", categoryName));
		}
		if (!SyntaxCheck.CheckMachineName(machineName))
		{
			throw new ArgumentException(SR.GetString("InvalidParameter", "machineName", machineName));
		}
		PerformanceCounterCategory performanceCounterCategory = new PerformanceCounterCategory(categoryName, machineName);
		return performanceCounterCategory.InstanceExists(instanceName);
	}

	public InstanceDataCollectionCollection ReadCategory()
	{
		if (categoryName == null)
		{
			throw new InvalidOperationException(SR.GetString("CategoryNameNotSet"));
		}
		CategorySample categorySample = PerformanceCounterLib.GetCategorySample(machineName, categoryName);
		return categorySample.ReadCategory();
	}
}
