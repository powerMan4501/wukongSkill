using System.Collections;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using Microsoft.Win32;

namespace System.Diagnostics;

internal class PerformanceCounterLib
{
	internal const string PerfShimName = "netfxperf.dll";

	private const string PerfShimFullNameSuffix = "\\netfxperf.dll";

	private const string PerfShimPathExp = "%systemroot%\\system32\\netfxperf.dll";

	internal const string OpenEntryPoint = "OpenPerformanceData";

	internal const string CollectEntryPoint = "CollectPerformanceData";

	internal const string CloseEntryPoint = "ClosePerformanceData";

	internal const string SingleInstanceName = "systemdiagnosticsperfcounterlibsingleinstance";

	private const string PerflibPath = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Perflib";

	internal const string ServicePath = "SYSTEM\\CurrentControlSet\\Services";

	private const string categorySymbolPrefix = "OBJECT_";

	private const string conterSymbolPrefix = "DEVICE_COUNTER_";

	private const string helpSufix = "_HELP";

	private const string nameSufix = "_NAME";

	private const string textDefinition = "[text]";

	private const string infoDefinition = "[info]";

	private const string languageDefinition = "[languages]";

	private const string objectDefinition = "[objects]";

	private const string driverNameKeyword = "drivername";

	private const string symbolFileKeyword = "symbolfile";

	private const string defineKeyword = "#define";

	private const string languageKeyword = "language";

	private const string DllName = "netfxperf.dll";

	private const int EnglishLCID = 9;

	private static volatile string computerName;

	private static volatile string iniFilePath;

	private static volatile string symbolFilePath;

	private PerformanceMonitor performanceMonitor;

	private string machineName;

	private string perfLcid;

	private Hashtable customCategoryTable;

	private static volatile Hashtable libraryTable;

	private Hashtable categoryTable;

	private Hashtable nameTable;

	private Hashtable helpTable;

	private readonly object CategoryTableLock = new object();

	private readonly object NameTableLock = new object();

	private readonly object HelpTableLock = new object();

	private static object s_InternalSyncObject;

	private static object InternalSyncObject
	{
		get
		{
			if (s_InternalSyncObject == null)
			{
				object value = new object();
				Interlocked.CompareExchange(ref s_InternalSyncObject, value, null);
			}
			return s_InternalSyncObject;
		}
	}

	internal static string ComputerName
	{
		get
		{
			if (computerName == null)
			{
				lock (InternalSyncObject)
				{
					if (computerName == null)
					{
						StringBuilder stringBuilder = new StringBuilder(256);
						Microsoft.Win32.SafeNativeMethods.GetComputerName(stringBuilder, new int[1] { stringBuilder.Capacity });
						computerName = stringBuilder.ToString();
					}
				}
			}
			return computerName;
		}
	}

	private unsafe Hashtable CategoryTable
	{
		get
		{
			if (categoryTable == null)
			{
				lock (CategoryTableLock)
				{
					if (categoryTable == null)
					{
						byte[] performanceData = GetPerformanceData("Global");
						fixed (byte* value = performanceData)
						{
							IntPtr intPtr = new IntPtr(value);
							IntPtr intPtr2 = intPtr;
							Microsoft.Win32.NativeMethods.PERF_DATA_BLOCK.ValidateBeforeRead(intPtr, performanceData.Length, intPtr2);
							Microsoft.Win32.NativeMethods.PERF_DATA_BLOCK pERF_DATA_BLOCK = new Microsoft.Win32.NativeMethods.PERF_DATA_BLOCK();
							Marshal.PtrToStructure(intPtr2, (object)pERF_DATA_BLOCK);
							pERF_DATA_BLOCK.Validate(performanceData.Length);
							intPtr2 = (IntPtr)((long)intPtr2 + pERF_DATA_BLOCK.HeaderLength);
							int numObjectTypes = pERF_DATA_BLOCK.NumObjectTypes;
							long num = (long)new IntPtr(value) + pERF_DATA_BLOCK.TotalByteLength;
							Hashtable hashtable = new Hashtable(numObjectTypes, StringComparer.OrdinalIgnoreCase);
							for (int i = 0; i < numObjectTypes; i++)
							{
								if ((long)intPtr2 >= num)
								{
									break;
								}
								Microsoft.Win32.NativeMethods.PERF_OBJECT_TYPE.ValidateBeforeRead(intPtr, performanceData.Length, intPtr2);
								Microsoft.Win32.NativeMethods.PERF_OBJECT_TYPE pERF_OBJECT_TYPE = new Microsoft.Win32.NativeMethods.PERF_OBJECT_TYPE();
								Marshal.PtrToStructure(intPtr2, (object)pERF_OBJECT_TYPE);
								pERF_OBJECT_TYPE.Validate(performanceData.Length - (int)((long)intPtr2 - (long)intPtr));
								CategoryEntry categoryEntry = new CategoryEntry(pERF_OBJECT_TYPE);
								IntPtr intPtr3 = (IntPtr)((long)intPtr2 + pERF_OBJECT_TYPE.TotalByteLength);
								intPtr2 = (IntPtr)((long)intPtr2 + pERF_OBJECT_TYPE.HeaderLength);
								int num2 = 0;
								int num3 = -1;
								for (int j = 0; j < categoryEntry.CounterIndexes.Length; j++)
								{
									Microsoft.Win32.NativeMethods.PERF_COUNTER_DEFINITION.ValidateBeforeRead(intPtr, performanceData.Length, intPtr2);
									Microsoft.Win32.NativeMethods.PERF_COUNTER_DEFINITION pERF_COUNTER_DEFINITION = new Microsoft.Win32.NativeMethods.PERF_COUNTER_DEFINITION();
									Marshal.PtrToStructure(intPtr2, (object)pERF_COUNTER_DEFINITION);
									pERF_COUNTER_DEFINITION.Validate(performanceData.Length - (int)((long)intPtr2 - (long)intPtr));
									if (pERF_COUNTER_DEFINITION.CounterNameTitleIndex != num3)
									{
										categoryEntry.CounterIndexes[num2] = pERF_COUNTER_DEFINITION.CounterNameTitleIndex;
										categoryEntry.HelpIndexes[num2] = pERF_COUNTER_DEFINITION.CounterHelpTitleIndex;
										num3 = pERF_COUNTER_DEFINITION.CounterNameTitleIndex;
										num2++;
									}
									intPtr2 = (IntPtr)((long)intPtr2 + pERF_COUNTER_DEFINITION.ByteLength);
								}
								if (num2 < categoryEntry.CounterIndexes.Length)
								{
									int[] array = new int[num2];
									int[] array2 = new int[num2];
									Array.Copy(categoryEntry.CounterIndexes, array, num2);
									Array.Copy(categoryEntry.HelpIndexes, array2, num2);
									categoryEntry.CounterIndexes = array;
									categoryEntry.HelpIndexes = array2;
								}
								string text = (string)NameTable[categoryEntry.NameIndex];
								if (text != null)
								{
									hashtable[text] = categoryEntry;
								}
								intPtr2 = intPtr3;
							}
							categoryTable = hashtable;
						}
					}
				}
			}
			return categoryTable;
		}
	}

	internal Hashtable HelpTable
	{
		get
		{
			if (helpTable == null)
			{
				lock (HelpTableLock)
				{
					if (helpTable == null)
					{
						helpTable = GetStringTable(isHelp: true);
					}
				}
			}
			return helpTable;
		}
	}

	private static string IniFilePath
	{
		get
		{
			if (iniFilePath == null)
			{
				lock (InternalSyncObject)
				{
					if (iniFilePath == null)
					{
						EnvironmentPermission environmentPermission = new EnvironmentPermission(PermissionState.Unrestricted);
						environmentPermission.Assert();
						try
						{
							iniFilePath = Path.GetTempFileName();
						}
						finally
						{
							CodeAccessPermission.RevertAssert();
						}
					}
				}
			}
			return iniFilePath;
		}
	}

	internal Hashtable NameTable
	{
		get
		{
			if (nameTable == null)
			{
				lock (NameTableLock)
				{
					if (nameTable == null)
					{
						nameTable = GetStringTable(isHelp: false);
					}
				}
			}
			return nameTable;
		}
	}

	private static string SymbolFilePath
	{
		get
		{
			if (symbolFilePath == null)
			{
				lock (InternalSyncObject)
				{
					if (symbolFilePath == null)
					{
						EnvironmentPermission environmentPermission = new EnvironmentPermission(PermissionState.Unrestricted);
						environmentPermission.Assert();
						string tempPath = Path.GetTempPath();
						CodeAccessPermission.RevertAssert();
						PermissionSet permissionSet = new PermissionSet(PermissionState.None);
						permissionSet.AddPermission(new EnvironmentPermission(PermissionState.Unrestricted));
						permissionSet.AddPermission(new FileIOPermission(FileIOPermissionAccess.Write, tempPath));
						permissionSet.Assert();
						try
						{
							symbolFilePath = Path.GetTempFileName();
						}
						finally
						{
							PermissionSet.RevertAssert();
						}
					}
				}
			}
			return symbolFilePath;
		}
	}

	internal PerformanceCounterLib(string machineName, string lcid)
	{
		this.machineName = machineName;
		perfLcid = lcid;
	}

	internal static bool CategoryExists(string machine, string category)
	{
		PerformanceCounterLib performanceCounterLib = GetPerformanceCounterLib(machine, new CultureInfo(9));
		if (performanceCounterLib.CategoryExists(category))
		{
			return true;
		}
		if (CultureInfo.CurrentCulture.Parent.LCID != 9)
		{
			for (CultureInfo cultureInfo = CultureInfo.CurrentCulture; cultureInfo != CultureInfo.InvariantCulture; cultureInfo = cultureInfo.Parent)
			{
				performanceCounterLib = GetPerformanceCounterLib(machine, cultureInfo);
				if (performanceCounterLib.CategoryExists(category))
				{
					return true;
				}
			}
		}
		return false;
	}

	internal bool CategoryExists(string category)
	{
		return CategoryTable.ContainsKey(category);
	}

	internal static void CloseAllLibraries()
	{
		if (libraryTable == null)
		{
			return;
		}
		foreach (PerformanceCounterLib value in libraryTable.Values)
		{
			value.Close();
		}
		libraryTable = null;
	}

	internal static void CloseAllTables()
	{
		if (libraryTable == null)
		{
			return;
		}
		foreach (PerformanceCounterLib value in libraryTable.Values)
		{
			value.CloseTables();
		}
	}

	internal void CloseTables()
	{
		nameTable = null;
		helpTable = null;
		categoryTable = null;
		customCategoryTable = null;
	}

	internal void Close()
	{
		if (performanceMonitor != null)
		{
			performanceMonitor.Close();
			performanceMonitor = null;
		}
		CloseTables();
	}

	internal static bool CounterExists(string machine, string category, string counter)
	{
		PerformanceCounterLib performanceCounterLib = GetPerformanceCounterLib(machine, new CultureInfo(9));
		bool categoryExists = false;
		bool flag = performanceCounterLib.CounterExists(category, counter, ref categoryExists);
		if (!categoryExists && CultureInfo.CurrentCulture.Parent.LCID != 9)
		{
			for (CultureInfo cultureInfo = CultureInfo.CurrentCulture; cultureInfo != CultureInfo.InvariantCulture; cultureInfo = cultureInfo.Parent)
			{
				performanceCounterLib = GetPerformanceCounterLib(machine, cultureInfo);
				flag = performanceCounterLib.CounterExists(category, counter, ref categoryExists);
				if (flag)
				{
					break;
				}
			}
		}
		if (!categoryExists)
		{
			throw new InvalidOperationException(SR.GetString("MissingCategory"));
		}
		return flag;
	}

	private bool CounterExists(string category, string counter, ref bool categoryExists)
	{
		categoryExists = false;
		if (!CategoryTable.ContainsKey(category))
		{
			return false;
		}
		categoryExists = true;
		CategoryEntry categoryEntry = (CategoryEntry)CategoryTable[category];
		for (int i = 0; i < categoryEntry.CounterIndexes.Length; i++)
		{
			int num = categoryEntry.CounterIndexes[i];
			string text = (string)NameTable[num];
			if (text == null)
			{
				text = string.Empty;
			}
			if (string.Compare(text, counter, StringComparison.OrdinalIgnoreCase) == 0)
			{
				return true;
			}
		}
		return false;
	}

	private static void CreateIniFile(string categoryName, string categoryHelp, CounterCreationDataCollection creationData, string[] languageIds)
	{
		FileIOPermission fileIOPermission = new FileIOPermission(PermissionState.Unrestricted);
		fileIOPermission.Assert();
		try
		{
			StreamWriter streamWriter = new StreamWriter(IniFilePath, append: false, Encoding.Unicode);
			try
			{
				streamWriter.WriteLine("");
				streamWriter.WriteLine("[info]");
				streamWriter.Write("drivername");
				streamWriter.Write("=");
				streamWriter.WriteLine(categoryName);
				streamWriter.Write("symbolfile");
				streamWriter.Write("=");
				streamWriter.WriteLine(Path.GetFileName(SymbolFilePath));
				streamWriter.WriteLine("");
				streamWriter.WriteLine("[languages]");
				foreach (string value in languageIds)
				{
					streamWriter.Write(value);
					streamWriter.Write("=");
					streamWriter.Write("language");
					streamWriter.WriteLine(value);
				}
				streamWriter.WriteLine("");
				streamWriter.WriteLine("[objects]");
				foreach (string value2 in languageIds)
				{
					streamWriter.Write("OBJECT_");
					streamWriter.Write("1_");
					streamWriter.Write(value2);
					streamWriter.Write("_NAME");
					streamWriter.Write("=");
					streamWriter.WriteLine(categoryName);
				}
				streamWriter.WriteLine("");
				streamWriter.WriteLine("[text]");
				foreach (string value3 in languageIds)
				{
					streamWriter.Write("OBJECT_");
					streamWriter.Write("1_");
					streamWriter.Write(value3);
					streamWriter.Write("_NAME");
					streamWriter.Write("=");
					streamWriter.WriteLine(categoryName);
					streamWriter.Write("OBJECT_");
					streamWriter.Write("1_");
					streamWriter.Write(value3);
					streamWriter.Write("_HELP");
					streamWriter.Write("=");
					if (categoryHelp == null || categoryHelp == string.Empty)
					{
						streamWriter.WriteLine(SR.GetString("HelpNotAvailable"));
					}
					else
					{
						streamWriter.WriteLine(categoryHelp);
					}
					int num = 0;
					foreach (CounterCreationData creationDatum in creationData)
					{
						num++;
						streamWriter.WriteLine("");
						streamWriter.Write("DEVICE_COUNTER_");
						streamWriter.Write(num.ToString(CultureInfo.InvariantCulture));
						streamWriter.Write("_");
						streamWriter.Write(value3);
						streamWriter.Write("_NAME");
						streamWriter.Write("=");
						streamWriter.WriteLine(creationDatum.CounterName);
						streamWriter.Write("DEVICE_COUNTER_");
						streamWriter.Write(num.ToString(CultureInfo.InvariantCulture));
						streamWriter.Write("_");
						streamWriter.Write(value3);
						streamWriter.Write("_HELP");
						streamWriter.Write("=");
						streamWriter.WriteLine(creationDatum.CounterHelp);
					}
				}
				streamWriter.WriteLine("");
			}
			finally
			{
				streamWriter.Close();
			}
		}
		finally
		{
			CodeAccessPermission.RevertAssert();
		}
	}

	private static void CreateRegistryEntry(string categoryName, PerformanceCounterCategoryType categoryType, CounterCreationDataCollection creationData, ref bool iniRegistered)
	{
		RegistryKey registryKey = null;
		RegistryKey registryKey2 = null;
		RegistryKey registryKey3 = null;
		RegistryPermission registryPermission = new RegistryPermission(PermissionState.Unrestricted);
		registryPermission.Assert();
		try
		{
			registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services", writable: true);
			registryKey2 = registryKey.OpenSubKey(categoryName + "\\Performance", writable: true);
			if (registryKey2 == null)
			{
				registryKey2 = registryKey.CreateSubKey(categoryName + "\\Performance");
			}
			registryKey2.SetValue("Open", "OpenPerformanceData");
			registryKey2.SetValue("Collect", "CollectPerformanceData");
			registryKey2.SetValue("Close", "ClosePerformanceData");
			registryKey2.SetValue("Library", "netfxperf.dll");
			registryKey2.SetValue("IsMultiInstance", (int)categoryType, RegistryValueKind.DWord);
			registryKey2.SetValue("CategoryOptions", 3, RegistryValueKind.DWord);
			string[] array = new string[creationData.Count];
			string[] array2 = new string[creationData.Count];
			for (int i = 0; i < creationData.Count; i++)
			{
				array[i] = creationData[i].CounterName;
				array2[i] = ((int)creationData[i].CounterType).ToString(CultureInfo.InvariantCulture);
			}
			registryKey3 = registryKey.OpenSubKey(categoryName + "\\Linkage", writable: true);
			if (registryKey3 == null)
			{
				registryKey3 = registryKey.CreateSubKey(categoryName + "\\Linkage");
			}
			registryKey3.SetValue("Export", new string[1] { categoryName });
			registryKey2.SetValue("Counter Types", array2);
			registryKey2.SetValue("Counter Names", array);
			object value = registryKey2.GetValue("First Counter");
			if (value != null)
			{
				iniRegistered = true;
			}
			else
			{
				iniRegistered = false;
			}
		}
		finally
		{
			registryKey2?.Close();
			registryKey3?.Close();
			registryKey?.Close();
			CodeAccessPermission.RevertAssert();
		}
	}

	private static void CreateSymbolFile(CounterCreationDataCollection creationData)
	{
		FileIOPermission fileIOPermission = new FileIOPermission(PermissionState.Unrestricted);
		fileIOPermission.Assert();
		try
		{
			StreamWriter streamWriter = new StreamWriter(SymbolFilePath);
			try
			{
				streamWriter.Write("#define");
				streamWriter.Write(" ");
				streamWriter.Write("OBJECT_");
				streamWriter.WriteLine("1 0;");
				for (int i = 1; i <= creationData.Count; i++)
				{
					streamWriter.Write("#define");
					streamWriter.Write(" ");
					streamWriter.Write("DEVICE_COUNTER_");
					streamWriter.Write(i.ToString(CultureInfo.InvariantCulture));
					streamWriter.Write(" ");
					streamWriter.Write((i * 2).ToString(CultureInfo.InvariantCulture));
					streamWriter.WriteLine(";");
				}
				streamWriter.WriteLine("");
			}
			finally
			{
				streamWriter.Close();
			}
		}
		finally
		{
			CodeAccessPermission.RevertAssert();
		}
	}

	private static void DeleteRegistryEntry(string categoryName)
	{
		RegistryKey registryKey = null;
		RegistryPermission registryPermission = new RegistryPermission(PermissionState.Unrestricted);
		registryPermission.Assert();
		try
		{
			registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services", writable: true);
			bool flag = false;
			using (RegistryKey registryKey2 = registryKey.OpenSubKey(categoryName, writable: true))
			{
				if (registryKey2 != null)
				{
					if (registryKey2.GetValueNames().Length == 0)
					{
						flag = true;
					}
					else
					{
						registryKey2.DeleteSubKeyTree("Linkage");
						registryKey2.DeleteSubKeyTree("Performance");
					}
				}
			}
			if (flag)
			{
				registryKey.DeleteSubKeyTree(categoryName);
			}
		}
		finally
		{
			registryKey?.Close();
			CodeAccessPermission.RevertAssert();
		}
	}

	private static void DeleteTemporaryFiles()
	{
		try
		{
			File.Delete(IniFilePath);
		}
		catch
		{
		}
		try
		{
			File.Delete(SymbolFilePath);
		}
		catch
		{
		}
	}

	internal bool FindCustomCategory(string category, out PerformanceCounterCategoryType categoryType)
	{
		RegistryKey registryKey = null;
		RegistryKey registryKey2 = null;
		categoryType = PerformanceCounterCategoryType.Unknown;
		if (customCategoryTable == null)
		{
			Interlocked.CompareExchange(ref customCategoryTable, new Hashtable(StringComparer.OrdinalIgnoreCase), null);
		}
		if (customCategoryTable.ContainsKey(category))
		{
			categoryType = (PerformanceCounterCategoryType)customCategoryTable[category];
			return true;
		}
		PermissionSet permissionSet = new PermissionSet(PermissionState.None);
		permissionSet.AddPermission(new RegistryPermission(PermissionState.Unrestricted));
		permissionSet.AddPermission(new SecurityPermission(SecurityPermissionFlag.UnmanagedCode));
		permissionSet.Assert();
		try
		{
			string name = "SYSTEM\\CurrentControlSet\\Services\\" + category + "\\Performance";
			if (machineName == "." || string.Compare(machineName, ComputerName, StringComparison.OrdinalIgnoreCase) == 0)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(name);
			}
			else
			{
				registryKey2 = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, "\\\\" + machineName);
				if (registryKey2 != null)
				{
					try
					{
						registryKey = registryKey2.OpenSubKey(name);
					}
					catch (SecurityException)
					{
						categoryType = PerformanceCounterCategoryType.Unknown;
						customCategoryTable[category] = categoryType;
						return false;
					}
				}
			}
			if (registryKey != null)
			{
				object value = registryKey.GetValue("Library", null, RegistryValueOptions.DoNotExpandEnvironmentNames);
				if (value != null && value is string && (string.Compare((string)value, "netfxperf.dll", StringComparison.OrdinalIgnoreCase) == 0 || ((string)value).EndsWith("\\netfxperf.dll", StringComparison.OrdinalIgnoreCase)))
				{
					object value2 = registryKey.GetValue("IsMultiInstance");
					if (value2 != null)
					{
						categoryType = (PerformanceCounterCategoryType)value2;
						if (categoryType < PerformanceCounterCategoryType.Unknown || categoryType > PerformanceCounterCategoryType.MultiInstance)
						{
							categoryType = PerformanceCounterCategoryType.Unknown;
						}
					}
					else
					{
						categoryType = PerformanceCounterCategoryType.Unknown;
					}
					object value3 = registryKey.GetValue("First Counter");
					if (value3 != null)
					{
						int num = (int)value3;
						customCategoryTable[category] = categoryType;
						return true;
					}
				}
			}
		}
		finally
		{
			registryKey?.Close();
			registryKey2?.Close();
			PermissionSet.RevertAssert();
		}
		return false;
	}

	internal static string[] GetCategories(string machineName)
	{
		PerformanceCounterLib performanceCounterLib;
		for (CultureInfo cultureInfo = CultureInfo.CurrentCulture; cultureInfo != CultureInfo.InvariantCulture; cultureInfo = cultureInfo.Parent)
		{
			performanceCounterLib = GetPerformanceCounterLib(machineName, cultureInfo);
			string[] categories = performanceCounterLib.GetCategories();
			if (categories.Length != 0)
			{
				return categories;
			}
		}
		performanceCounterLib = GetPerformanceCounterLib(machineName, new CultureInfo(9));
		return performanceCounterLib.GetCategories();
	}

	internal string[] GetCategories()
	{
		ICollection keys = CategoryTable.Keys;
		string[] array = new string[keys.Count];
		keys.CopyTo(array, 0);
		return array;
	}

	internal static string GetCategoryHelp(string machine, string category)
	{
		PerformanceCounterLib performanceCounterLib;
		string categoryHelp;
		if (CultureInfo.CurrentCulture.Parent.LCID != 9)
		{
			for (CultureInfo cultureInfo = CultureInfo.CurrentCulture; cultureInfo != CultureInfo.InvariantCulture; cultureInfo = cultureInfo.Parent)
			{
				performanceCounterLib = GetPerformanceCounterLib(machine, cultureInfo);
				categoryHelp = performanceCounterLib.GetCategoryHelp(category);
				if (categoryHelp != null)
				{
					return categoryHelp;
				}
			}
		}
		performanceCounterLib = GetPerformanceCounterLib(machine, new CultureInfo(9));
		categoryHelp = performanceCounterLib.GetCategoryHelp(category);
		if (categoryHelp == null)
		{
			throw new InvalidOperationException(SR.GetString("MissingCategory"));
		}
		return categoryHelp;
	}

	private string GetCategoryHelp(string category)
	{
		CategoryEntry categoryEntry = (CategoryEntry)CategoryTable[category];
		if (categoryEntry == null)
		{
			return null;
		}
		return (string)HelpTable[categoryEntry.HelpIndex];
	}

	internal static CategorySample GetCategorySample(string machine, string category)
	{
		PerformanceCounterLib performanceCounterLib = GetPerformanceCounterLib(machine, new CultureInfo(9));
		CategorySample categorySample = performanceCounterLib.GetCategorySample(category);
		if (categorySample == null && CultureInfo.CurrentCulture.Parent.LCID != 9)
		{
			for (CultureInfo cultureInfo = CultureInfo.CurrentCulture; cultureInfo != CultureInfo.InvariantCulture; cultureInfo = cultureInfo.Parent)
			{
				performanceCounterLib = GetPerformanceCounterLib(machine, cultureInfo);
				categorySample = performanceCounterLib.GetCategorySample(category);
				if (categorySample != null)
				{
					return categorySample;
				}
			}
		}
		if (categorySample == null)
		{
			throw new InvalidOperationException(SR.GetString("MissingCategory"));
		}
		return categorySample;
	}

	private CategorySample GetCategorySample(string category)
	{
		CategoryEntry categoryEntry = (CategoryEntry)CategoryTable[category];
		if (categoryEntry == null)
		{
			return null;
		}
		CategorySample categorySample = null;
		byte[] performanceData = GetPerformanceData(categoryEntry.NameIndex.ToString(CultureInfo.InvariantCulture));
		if (performanceData == null)
		{
			throw new InvalidOperationException(SR.GetString("CantReadCategory", category));
		}
		return new CategorySample(performanceData, categoryEntry, this);
	}

	internal static string[] GetCounters(string machine, string category)
	{
		PerformanceCounterLib performanceCounterLib = GetPerformanceCounterLib(machine, new CultureInfo(9));
		bool categoryExists = false;
		string[] counters = performanceCounterLib.GetCounters(category, ref categoryExists);
		if (!categoryExists && CultureInfo.CurrentCulture.Parent.LCID != 9)
		{
			for (CultureInfo cultureInfo = CultureInfo.CurrentCulture; cultureInfo != CultureInfo.InvariantCulture; cultureInfo = cultureInfo.Parent)
			{
				performanceCounterLib = GetPerformanceCounterLib(machine, cultureInfo);
				counters = performanceCounterLib.GetCounters(category, ref categoryExists);
				if (categoryExists)
				{
					return counters;
				}
			}
		}
		if (!categoryExists)
		{
			throw new InvalidOperationException(SR.GetString("MissingCategory"));
		}
		return counters;
	}

	private string[] GetCounters(string category, ref bool categoryExists)
	{
		categoryExists = false;
		CategoryEntry categoryEntry = (CategoryEntry)CategoryTable[category];
		if (categoryEntry == null)
		{
			return null;
		}
		categoryExists = true;
		int num = 0;
		string[] array = new string[categoryEntry.CounterIndexes.Length];
		for (int i = 0; i < array.Length; i++)
		{
			int num2 = categoryEntry.CounterIndexes[i];
			string text = (string)NameTable[num2];
			if (text != null && text != string.Empty)
			{
				array[num] = text;
				num++;
			}
		}
		if (num < array.Length)
		{
			string[] array2 = new string[num];
			Array.Copy(array, array2, num);
			array = array2;
		}
		return array;
	}

	internal static string GetCounterHelp(string machine, string category, string counter)
	{
		bool categoryExists = false;
		PerformanceCounterLib performanceCounterLib;
		string counterHelp;
		if (CultureInfo.CurrentCulture.Parent.LCID != 9)
		{
			for (CultureInfo cultureInfo = CultureInfo.CurrentCulture; cultureInfo != CultureInfo.InvariantCulture; cultureInfo = cultureInfo.Parent)
			{
				performanceCounterLib = GetPerformanceCounterLib(machine, cultureInfo);
				counterHelp = performanceCounterLib.GetCounterHelp(category, counter, ref categoryExists);
				if (categoryExists)
				{
					return counterHelp;
				}
			}
		}
		performanceCounterLib = GetPerformanceCounterLib(machine, new CultureInfo(9));
		counterHelp = performanceCounterLib.GetCounterHelp(category, counter, ref categoryExists);
		if (!categoryExists)
		{
			throw new InvalidOperationException(SR.GetString("MissingCategoryDetail", category));
		}
		return counterHelp;
	}

	private string GetCounterHelp(string category, string counter, ref bool categoryExists)
	{
		categoryExists = false;
		CategoryEntry categoryEntry = (CategoryEntry)CategoryTable[category];
		if (categoryEntry == null)
		{
			return null;
		}
		categoryExists = true;
		int num = -1;
		for (int i = 0; i < categoryEntry.CounterIndexes.Length; i++)
		{
			int num2 = categoryEntry.CounterIndexes[i];
			string text = (string)NameTable[num2];
			if (text == null)
			{
				text = string.Empty;
			}
			if (string.Compare(text, counter, StringComparison.OrdinalIgnoreCase) == 0)
			{
				num = categoryEntry.HelpIndexes[i];
				break;
			}
		}
		if (num == -1)
		{
			throw new InvalidOperationException(SR.GetString("MissingCounter", counter));
		}
		string text2 = (string)HelpTable[num];
		if (text2 == null)
		{
			return string.Empty;
		}
		return text2;
	}

	internal string GetCounterName(int index)
	{
		if (NameTable.ContainsKey(index))
		{
			return (string)NameTable[index];
		}
		return "";
	}

	private static string[] GetLanguageIds()
	{
		RegistryKey registryKey = null;
		string[] result = new string[0];
		new RegistryPermission(PermissionState.Unrestricted).Assert();
		try
		{
			registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Perflib");
			if (registryKey != null)
			{
				result = registryKey.GetSubKeyNames();
			}
		}
		finally
		{
			registryKey?.Close();
			CodeAccessPermission.RevertAssert();
		}
		return result;
	}

	internal static PerformanceCounterLib GetPerformanceCounterLib(string machineName, CultureInfo culture)
	{
		SharedUtils.CheckEnvironment();
		string text = culture.LCID.ToString("X3", CultureInfo.InvariantCulture);
		machineName = ((machineName.CompareTo(".") != 0) ? machineName.ToLower(CultureInfo.InvariantCulture) : ComputerName.ToLower(CultureInfo.InvariantCulture));
		if (libraryTable == null)
		{
			lock (InternalSyncObject)
			{
				if (libraryTable == null)
				{
					libraryTable = new Hashtable();
				}
			}
		}
		string key = machineName + ":" + text;
		if (libraryTable.Contains(key))
		{
			return (PerformanceCounterLib)libraryTable[key];
		}
		PerformanceCounterLib performanceCounterLib = new PerformanceCounterLib(machineName, text);
		libraryTable[key] = performanceCounterLib;
		return performanceCounterLib;
	}

	internal byte[] GetPerformanceData(string item)
	{
		if (performanceMonitor == null)
		{
			lock (InternalSyncObject)
			{
				if (performanceMonitor == null)
				{
					performanceMonitor = new PerformanceMonitor(machineName);
				}
			}
		}
		return performanceMonitor.GetData(item);
	}

	private Hashtable GetStringTable(bool isHelp)
	{
		PermissionSet permissionSet = new PermissionSet(PermissionState.None);
		permissionSet.AddPermission(new RegistryPermission(PermissionState.Unrestricted));
		permissionSet.AddPermission(new SecurityPermission(SecurityPermissionFlag.UnmanagedCode));
		permissionSet.Assert();
		RegistryKey registryKey = ((string.Compare(machineName, ComputerName, StringComparison.OrdinalIgnoreCase) != 0) ? RegistryKey.OpenRemoteBaseKey(RegistryHive.PerformanceData, machineName) : Registry.PerformanceData);
		Hashtable hashtable;
		try
		{
			string[] array = null;
			int num = 14;
			int num2 = 0;
			while (num > 0)
			{
				try
				{
					array = (isHelp ? ((string[])registryKey.GetValue("Explain " + perfLcid)) : ((string[])registryKey.GetValue("Counter " + perfLcid)));
					if (array == null || array.Length == 0)
					{
						num--;
						if (num2 == 0)
						{
							num2 = 10;
							continue;
						}
						Thread.Sleep(num2);
						num2 *= 2;
						continue;
					}
				}
				catch (IOException)
				{
					array = null;
				}
				catch (InvalidCastException)
				{
					array = null;
				}
				break;
			}
			if (array == null)
			{
				hashtable = new Hashtable();
			}
			else
			{
				hashtable = new Hashtable(array.Length / 2);
				for (int i = 0; i < array.Length / 2; i++)
				{
					string text = array[i * 2 + 1];
					if (text == null)
					{
						text = string.Empty;
					}
					if (!int.TryParse(array[i * 2], NumberStyles.Integer, CultureInfo.InvariantCulture, out var result))
					{
						if (isHelp)
						{
							throw new InvalidOperationException(SR.GetString("CategoryHelpCorrupt", array[i * 2]));
						}
						throw new InvalidOperationException(SR.GetString("CounterNameCorrupt", array[i * 2]));
					}
					hashtable[result] = text;
				}
			}
		}
		finally
		{
			registryKey.Close();
		}
		return hashtable;
	}

	internal static bool IsCustomCategory(string machine, string category)
	{
		PerformanceCounterLib performanceCounterLib = GetPerformanceCounterLib(machine, new CultureInfo(9));
		if (performanceCounterLib.IsCustomCategory(category))
		{
			return true;
		}
		if (CultureInfo.CurrentCulture.Parent.LCID != 9)
		{
			for (CultureInfo cultureInfo = CultureInfo.CurrentCulture; cultureInfo != CultureInfo.InvariantCulture; cultureInfo = cultureInfo.Parent)
			{
				performanceCounterLib = GetPerformanceCounterLib(machine, cultureInfo);
				if (performanceCounterLib.IsCustomCategory(category))
				{
					return true;
				}
			}
		}
		return false;
	}

	internal static bool IsBaseCounter(int type)
	{
		if (type != 1073939458 && type != 1107494144 && type != 1073939459 && type != 1073939712)
		{
			return type == 1073939457;
		}
		return true;
	}

	private bool IsCustomCategory(string category)
	{
		PerformanceCounterCategoryType categoryType;
		return FindCustomCategory(category, out categoryType);
	}

	internal static PerformanceCounterCategoryType GetCategoryType(string machine, string category)
	{
		PerformanceCounterCategoryType categoryType = PerformanceCounterCategoryType.Unknown;
		PerformanceCounterLib performanceCounterLib = GetPerformanceCounterLib(machine, new CultureInfo(9));
		if (!performanceCounterLib.FindCustomCategory(category, out categoryType) && CultureInfo.CurrentCulture.Parent.LCID != 9)
		{
			for (CultureInfo cultureInfo = CultureInfo.CurrentCulture; cultureInfo != CultureInfo.InvariantCulture; cultureInfo = cultureInfo.Parent)
			{
				performanceCounterLib = GetPerformanceCounterLib(machine, cultureInfo);
				if (performanceCounterLib.FindCustomCategory(category, out categoryType))
				{
					return categoryType;
				}
			}
		}
		return categoryType;
	}

	internal static void RegisterCategory(string categoryName, PerformanceCounterCategoryType categoryType, string categoryHelp, CounterCreationDataCollection creationData)
	{
		try
		{
			bool iniRegistered = false;
			CreateRegistryEntry(categoryName, categoryType, creationData, ref iniRegistered);
			if (!iniRegistered)
			{
				string[] languageIds = GetLanguageIds();
				CreateIniFile(categoryName, categoryHelp, creationData, languageIds);
				CreateSymbolFile(creationData);
				RegisterFiles(IniFilePath, unregister: false);
			}
			CloseAllTables();
			CloseAllLibraries();
		}
		finally
		{
			DeleteTemporaryFiles();
		}
	}

	private static void RegisterFiles(string arg0, bool unregister)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.ErrorDialog = false;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.WorkingDirectory = Environment.SystemDirectory;
		if (unregister)
		{
			processStartInfo.FileName = Environment.SystemDirectory + "\\unlodctr.exe";
		}
		else
		{
			processStartInfo.FileName = Environment.SystemDirectory + "\\lodctr.exe";
		}
		int num = 0;
		new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Assert();
		try
		{
			processStartInfo.Arguments = "\"" + arg0 + "\"";
			Process process = Process.Start(processStartInfo);
			process.WaitForExit();
			num = process.ExitCode;
		}
		finally
		{
			CodeAccessPermission.RevertAssert();
		}
		if (num == 5)
		{
			throw new UnauthorizedAccessException(SR.GetString("CantChangeCategoryRegistration", arg0));
		}
		if (unregister && num == 2)
		{
			num = 0;
		}
		if (num != 0)
		{
			throw SharedUtils.CreateSafeWin32Exception(num);
		}
	}

	internal static void UnregisterCategory(string categoryName)
	{
		RegisterFiles(categoryName, unregister: true);
		DeleteRegistryEntry(categoryName);
		CloseAllTables();
		CloseAllLibraries();
	}
}
