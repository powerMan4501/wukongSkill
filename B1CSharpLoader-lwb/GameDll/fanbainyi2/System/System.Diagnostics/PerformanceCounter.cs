using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Permissions;
using System.Threading;

namespace System.Diagnostics;

[InstallerType("System.Diagnostics.PerformanceCounterInstaller,System.Configuration.Install, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[SRDescription("PerformanceCounterDesc")]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, SharedState = true)]
public sealed class PerformanceCounter : Component, ISupportInitialize
{
	private string machineName;

	private string categoryName;

	private string counterName;

	private string instanceName;

	private PerformanceCounterInstanceLifetime instanceLifetime;

	private bool isReadOnly;

	private bool initialized;

	private string helpMsg;

	private int counterType = -1;

	private CounterSample oldSample = CounterSample.Empty;

	private SharedPerformanceCounter sharedCounter;

	[Obsolete("This field has been deprecated and is not used.  Use machine.config or an application configuration file to set the size of the PerformanceCounter file mapping.")]
	public static int DefaultFileMappingSize = 524288;

	private object m_InstanceLockObject;

	private object InstanceLockObject
	{
		get
		{
			if (m_InstanceLockObject == null)
			{
				object value = new object();
				Interlocked.CompareExchange(ref m_InstanceLockObject, value, null);
			}
			return m_InstanceLockObject;
		}
	}

	[ReadOnly(true)]
	[DefaultValue("")]
	[TypeConverter("System.Diagnostics.Design.CategoryValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[SRDescription("PCCategoryName")]
	[SettingsBindable(true)]
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
			if (categoryName == null || string.Compare(categoryName, value, StringComparison.OrdinalIgnoreCase) != 0)
			{
				categoryName = value;
				Close();
			}
		}
	}

	[ReadOnly(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("PC_CounterHelp")]
	public string CounterHelp
	{
		get
		{
			string category = categoryName;
			string machine = machineName;
			PerformanceCounterPermission performanceCounterPermission = new PerformanceCounterPermission(PerformanceCounterPermissionAccess.Browse, machine, category);
			performanceCounterPermission.Demand();
			Initialize();
			if (helpMsg == null)
			{
				helpMsg = PerformanceCounterLib.GetCounterHelp(machine, category, counterName);
			}
			return helpMsg;
		}
	}

	[ReadOnly(true)]
	[DefaultValue("")]
	[TypeConverter("System.Diagnostics.Design.CounterNameConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[SRDescription("PCCounterName")]
	[SettingsBindable(true)]
	public string CounterName
	{
		get
		{
			return counterName;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (counterName == null || string.Compare(counterName, value, StringComparison.OrdinalIgnoreCase) != 0)
			{
				counterName = value;
				Close();
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("PC_CounterType")]
	public PerformanceCounterType CounterType
	{
		get
		{
			if (counterType == -1)
			{
				string category = categoryName;
				string machine = machineName;
				PerformanceCounterPermission performanceCounterPermission = new PerformanceCounterPermission(PerformanceCounterPermissionAccess.Browse, machine, category);
				performanceCounterPermission.Demand();
				Initialize();
				CategorySample categorySample = PerformanceCounterLib.GetCategorySample(machine, category);
				CounterDefinitionSample counterDefinitionSample = categorySample.GetCounterDefinitionSample(counterName);
				counterType = counterDefinitionSample.CounterType;
			}
			return (PerformanceCounterType)counterType;
		}
	}

	[DefaultValue(PerformanceCounterInstanceLifetime.Global)]
	[SRDescription("PCInstanceLifetime")]
	public PerformanceCounterInstanceLifetime InstanceLifetime
	{
		get
		{
			return instanceLifetime;
		}
		set
		{
			if (value > PerformanceCounterInstanceLifetime.Process || value < PerformanceCounterInstanceLifetime.Global)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			if (initialized)
			{
				throw new InvalidOperationException(SR.GetString("CantSetLifetimeAfterInitialized"));
			}
			instanceLifetime = value;
		}
	}

	[ReadOnly(true)]
	[DefaultValue("")]
	[TypeConverter("System.Diagnostics.Design.InstanceNameConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[SRDescription("PCInstanceName")]
	[SettingsBindable(true)]
	public string InstanceName
	{
		get
		{
			return instanceName;
		}
		set
		{
			if ((value != null || instanceName != null) && ((value == null && instanceName != null) || (value != null && instanceName == null) || string.Compare(instanceName, value, StringComparison.OrdinalIgnoreCase) != 0))
			{
				instanceName = value;
				Close();
			}
		}
	}

	[Browsable(false)]
	[DefaultValue(true)]
	[MonitoringDescription("PC_ReadOnly")]
	public bool ReadOnly
	{
		get
		{
			return isReadOnly;
		}
		set
		{
			if (value != isReadOnly)
			{
				if (!value)
				{
					VerifyWriteableCounterAllowed();
				}
				isReadOnly = value;
				Close();
			}
		}
	}

	[Browsable(false)]
	[DefaultValue(".")]
	[SRDescription("PCMachineName")]
	[SettingsBindable(true)]
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
				throw new ArgumentException(SR.GetString("InvalidParameter", "machineName", value));
			}
			if (machineName != value)
			{
				machineName = value;
				Close();
			}
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("PC_RawValue")]
	public long RawValue
	{
		get
		{
			if (ReadOnly)
			{
				return NextSample().RawValue;
			}
			Initialize();
			return sharedCounter.Value;
		}
		set
		{
			if (ReadOnly)
			{
				ThrowReadOnly();
			}
			Initialize();
			sharedCounter.Value = value;
		}
	}

	public PerformanceCounter()
	{
		machineName = ".";
		categoryName = string.Empty;
		counterName = string.Empty;
		instanceName = string.Empty;
		isReadOnly = true;
		GC.SuppressFinalize(this);
	}

	public PerformanceCounter(string categoryName, string counterName, string instanceName, string machineName)
	{
		MachineName = machineName;
		CategoryName = categoryName;
		CounterName = counterName;
		InstanceName = instanceName;
		isReadOnly = true;
		Initialize();
		GC.SuppressFinalize(this);
	}

	internal PerformanceCounter(string categoryName, string counterName, string instanceName, string machineName, bool skipInit)
	{
		MachineName = machineName;
		CategoryName = categoryName;
		CounterName = counterName;
		InstanceName = instanceName;
		isReadOnly = true;
		initialized = true;
		GC.SuppressFinalize(this);
	}

	public PerformanceCounter(string categoryName, string counterName, string instanceName)
		: this(categoryName, counterName, instanceName, readOnly: true)
	{
	}

	public PerformanceCounter(string categoryName, string counterName, string instanceName, bool readOnly)
	{
		if (!readOnly)
		{
			VerifyWriteableCounterAllowed();
		}
		MachineName = ".";
		CategoryName = categoryName;
		CounterName = counterName;
		InstanceName = instanceName;
		isReadOnly = readOnly;
		Initialize();
		GC.SuppressFinalize(this);
	}

	public PerformanceCounter(string categoryName, string counterName)
		: this(categoryName, counterName, readOnly: true)
	{
	}

	public PerformanceCounter(string categoryName, string counterName, bool readOnly)
		: this(categoryName, counterName, "", readOnly)
	{
	}

	public void BeginInit()
	{
		Close();
	}

	public void Close()
	{
		helpMsg = null;
		oldSample = CounterSample.Empty;
		sharedCounter = null;
		initialized = false;
		counterType = -1;
	}

	public static void CloseSharedResources()
	{
		PerformanceCounterPermission performanceCounterPermission = new PerformanceCounterPermission(PerformanceCounterPermissionAccess.Browse, ".", "*");
		performanceCounterPermission.Demand();
		PerformanceCounterLib.CloseAllLibraries();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			Close();
		}
		base.Dispose(disposing);
	}

	public long Decrement()
	{
		if (ReadOnly)
		{
			ThrowReadOnly();
		}
		Initialize();
		return sharedCounter.Decrement();
	}

	public void EndInit()
	{
		Initialize();
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public long IncrementBy(long value)
	{
		if (isReadOnly)
		{
			ThrowReadOnly();
		}
		Initialize();
		return sharedCounter.IncrementBy(value);
	}

	public long Increment()
	{
		if (isReadOnly)
		{
			ThrowReadOnly();
		}
		Initialize();
		return sharedCounter.Increment();
	}

	private void ThrowReadOnly()
	{
		throw new InvalidOperationException(SR.GetString("ReadOnlyCounter"));
	}

	private static void VerifyWriteableCounterAllowed()
	{
		if (EnvironmentHelpers.IsAppContainerProcess)
		{
			throw new NotSupportedException(SR.GetString("PCNotSupportedUnderAppContainer"));
		}
	}

	private void Initialize()
	{
		if (!initialized && !base.DesignMode)
		{
			InitializeImpl();
		}
	}

	private void InitializeImpl()
	{
		bool lockTaken = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			Monitor.Enter(InstanceLockObject, ref lockTaken);
			if (initialized)
			{
				return;
			}
			string text = categoryName;
			string text2 = machineName;
			if (text == string.Empty)
			{
				throw new InvalidOperationException(SR.GetString("CategoryNameMissing"));
			}
			if (counterName == string.Empty)
			{
				throw new InvalidOperationException(SR.GetString("CounterNameMissing"));
			}
			if (ReadOnly)
			{
				PerformanceCounterPermission performanceCounterPermission = new PerformanceCounterPermission(PerformanceCounterPermissionAccess.Browse, text2, text);
				performanceCounterPermission.Demand();
				if (!PerformanceCounterLib.CounterExists(text2, text, counterName))
				{
					throw new InvalidOperationException(SR.GetString("CounterExists", text, counterName));
				}
				switch (PerformanceCounterLib.GetCategoryType(text2, text))
				{
				case PerformanceCounterCategoryType.MultiInstance:
					if (string.IsNullOrEmpty(instanceName))
					{
						throw new InvalidOperationException(SR.GetString("MultiInstanceOnly", text));
					}
					break;
				case PerformanceCounterCategoryType.SingleInstance:
					if (!string.IsNullOrEmpty(instanceName))
					{
						throw new InvalidOperationException(SR.GetString("SingleInstanceOnly", text));
					}
					break;
				}
				if (instanceLifetime != PerformanceCounterInstanceLifetime.Global)
				{
					throw new InvalidOperationException(SR.GetString("InstanceLifetimeProcessonReadOnly"));
				}
				initialized = true;
				return;
			}
			PerformanceCounterPermission performanceCounterPermission2 = new PerformanceCounterPermission(PerformanceCounterPermissionAccess.Write, text2, text);
			performanceCounterPermission2.Demand();
			if (text2 != "." && string.Compare(text2, PerformanceCounterLib.ComputerName, StringComparison.OrdinalIgnoreCase) != 0)
			{
				throw new InvalidOperationException(SR.GetString("RemoteWriting"));
			}
			SharedUtils.CheckNtEnvironment();
			if (!PerformanceCounterLib.IsCustomCategory(text2, text))
			{
				throw new InvalidOperationException(SR.GetString("NotCustomCounter"));
			}
			switch (PerformanceCounterLib.GetCategoryType(text2, text))
			{
			case PerformanceCounterCategoryType.MultiInstance:
				if (string.IsNullOrEmpty(instanceName))
				{
					throw new InvalidOperationException(SR.GetString("MultiInstanceOnly", text));
				}
				break;
			case PerformanceCounterCategoryType.SingleInstance:
				if (!string.IsNullOrEmpty(instanceName))
				{
					throw new InvalidOperationException(SR.GetString("SingleInstanceOnly", text));
				}
				break;
			}
			if (string.IsNullOrEmpty(instanceName) && InstanceLifetime == PerformanceCounterInstanceLifetime.Process)
			{
				throw new InvalidOperationException(SR.GetString("InstanceLifetimeProcessforSingleInstance"));
			}
			sharedCounter = new SharedPerformanceCounter(text.ToLower(CultureInfo.InvariantCulture), counterName.ToLower(CultureInfo.InvariantCulture), instanceName.ToLower(CultureInfo.InvariantCulture), instanceLifetime);
			initialized = true;
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(InstanceLockObject);
			}
		}
	}

	public CounterSample NextSample()
	{
		string category = categoryName;
		string machine = machineName;
		PerformanceCounterPermission performanceCounterPermission = new PerformanceCounterPermission(PerformanceCounterPermissionAccess.Browse, machine, category);
		performanceCounterPermission.Demand();
		Initialize();
		CategorySample categorySample = PerformanceCounterLib.GetCategorySample(machine, category);
		CounterDefinitionSample counterDefinitionSample = categorySample.GetCounterDefinitionSample(counterName);
		counterType = counterDefinitionSample.CounterType;
		if (!categorySample.IsMultiInstance)
		{
			if (instanceName != null && instanceName.Length != 0)
			{
				throw new InvalidOperationException(SR.GetString("InstanceNameProhibited", instanceName));
			}
			return counterDefinitionSample.GetSingleValue();
		}
		if (instanceName == null || instanceName.Length == 0)
		{
			throw new InvalidOperationException(SR.GetString("InstanceNameRequired"));
		}
		return counterDefinitionSample.GetInstanceValue(instanceName);
	}

	public float NextValue()
	{
		CounterSample nextCounterSample = NextSample();
		float num = 0f;
		num = CounterSample.Calculate(oldSample, nextCounterSample);
		oldSample = nextCounterSample;
		return num;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public void RemoveInstance()
	{
		if (isReadOnly)
		{
			throw new InvalidOperationException(SR.GetString("ReadOnlyRemoveInstance"));
		}
		Initialize();
		sharedCounter.RemoveInstance(instanceName.ToLower(CultureInfo.InvariantCulture), instanceLifetime);
	}
}
