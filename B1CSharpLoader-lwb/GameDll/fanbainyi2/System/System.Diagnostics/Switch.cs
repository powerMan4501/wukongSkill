using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Globalization;
using System.Xml.Serialization;

namespace System.Diagnostics;

public abstract class Switch
{
	private SwitchElementsCollection switchSettings;

	private readonly string description;

	private readonly string displayName;

	private int switchSetting;

	private volatile bool initialized;

	private bool initializing;

	private volatile string switchValueString = string.Empty;

	private StringDictionary attributes;

	private string defaultValue;

	private static List<WeakReference> switches = new List<WeakReference>();

	private static int s_LastCollectionCount;

	[XmlIgnore]
	public StringDictionary Attributes
	{
		get
		{
			Initialize();
			if (attributes == null)
			{
				attributes = new StringDictionary();
			}
			return attributes;
		}
	}

	public string DisplayName => displayName;

	public string Description
	{
		get
		{
			if (description != null)
			{
				return description;
			}
			return string.Empty;
		}
	}

	protected int SwitchSetting
	{
		get
		{
			if (!initialized && InitializeWithStatus())
			{
				OnSwitchSettingChanged();
			}
			return switchSetting;
		}
		set
		{
			bool flag = false;
			lock (TraceInternal.critSec)
			{
				initialized = true;
				if (switchSetting != value)
				{
					switchSetting = value;
					flag = true;
				}
			}
			if (flag)
			{
				OnSwitchSettingChanged();
			}
		}
	}

	protected string Value
	{
		get
		{
			Initialize();
			return switchValueString;
		}
		set
		{
			Initialize();
			switchValueString = value;
			try
			{
				OnValueChanged();
			}
			catch (ArgumentException inner)
			{
				throw new ConfigurationErrorsException(SR.GetString("BadConfigSwitchValue", DisplayName), inner);
			}
			catch (FormatException inner2)
			{
				throw new ConfigurationErrorsException(SR.GetString("BadConfigSwitchValue", DisplayName), inner2);
			}
			catch (OverflowException inner3)
			{
				throw new ConfigurationErrorsException(SR.GetString("BadConfigSwitchValue", DisplayName), inner3);
			}
		}
	}

	protected Switch(string displayName, string description)
		: this(displayName, description, "0")
	{
	}

	protected Switch(string displayName, string description, string defaultSwitchValue)
	{
		if (displayName == null)
		{
			displayName = string.Empty;
		}
		this.displayName = displayName;
		this.description = description;
		lock (switches)
		{
			_pruneCachedSwitches();
			switches.Add(new WeakReference(this));
		}
		defaultValue = defaultSwitchValue;
	}

	private static void _pruneCachedSwitches()
	{
		lock (switches)
		{
			if (s_LastCollectionCount == GC.CollectionCount(2))
			{
				return;
			}
			List<WeakReference> list = new List<WeakReference>(switches.Count);
			for (int i = 0; i < switches.Count; i++)
			{
				Switch obj = (Switch)switches[i].Target;
				if (obj != null)
				{
					list.Add(switches[i]);
				}
			}
			if (list.Count < switches.Count)
			{
				switches.Clear();
				switches.AddRange(list);
				switches.TrimExcess();
			}
			s_LastCollectionCount = GC.CollectionCount(2);
		}
	}

	private void Initialize()
	{
		InitializeWithStatus();
	}

	private bool InitializeWithStatus()
	{
		if (!initialized)
		{
			lock (TraceInternal.critSec)
			{
				if (initialized || initializing)
				{
					return false;
				}
				initializing = true;
				if (switchSettings == null && !InitializeConfigSettings())
				{
					initialized = true;
					initializing = false;
					return false;
				}
				if (switchSettings != null)
				{
					SwitchElement switchElement = switchSettings[displayName];
					if (switchElement != null)
					{
						string value = switchElement.Value;
						if (value != null)
						{
							Value = value;
						}
						else
						{
							Value = defaultValue;
						}
						try
						{
							TraceUtils.VerifyAttributes(switchElement.Attributes, GetSupportedAttributes(), this);
						}
						catch (ConfigurationException)
						{
							initialized = false;
							initializing = false;
							throw;
						}
						attributes = new StringDictionary();
						attributes.ReplaceHashtable(switchElement.Attributes);
					}
					else
					{
						switchValueString = defaultValue;
						OnValueChanged();
					}
				}
				else
				{
					switchValueString = defaultValue;
					OnValueChanged();
				}
				initialized = true;
				initializing = false;
			}
		}
		return true;
	}

	private bool InitializeConfigSettings()
	{
		if (switchSettings != null)
		{
			return true;
		}
		if (!DiagnosticsConfiguration.CanInitialize())
		{
			return false;
		}
		switchSettings = DiagnosticsConfiguration.SwitchSettings;
		return true;
	}

	protected internal virtual string[] GetSupportedAttributes()
	{
		return null;
	}

	protected virtual void OnSwitchSettingChanged()
	{
	}

	protected virtual void OnValueChanged()
	{
		SwitchSetting = int.Parse(Value, CultureInfo.InvariantCulture);
	}

	internal static void RefreshAll()
	{
		lock (switches)
		{
			_pruneCachedSwitches();
			for (int i = 0; i < switches.Count; i++)
			{
				((Switch)switches[i].Target)?.Refresh();
			}
		}
	}

	internal void Refresh()
	{
		lock (TraceInternal.critSec)
		{
			initialized = false;
			switchSettings = null;
			Initialize();
		}
	}
}
