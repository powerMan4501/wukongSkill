using System.ComponentModel;

namespace System.Diagnostics;

[Serializable]
[TypeConverter("System.Diagnostics.Design.CounterCreationDataConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
public class CounterCreationData
{
	private PerformanceCounterType counterType = PerformanceCounterType.NumberOfItems32;

	private string counterName = string.Empty;

	private string counterHelp = string.Empty;

	[DefaultValue(PerformanceCounterType.NumberOfItems32)]
	[MonitoringDescription("CounterType")]
	public PerformanceCounterType CounterType
	{
		get
		{
			return counterType;
		}
		set
		{
			if (!Enum.IsDefined(typeof(PerformanceCounterType), value))
			{
				throw new InvalidEnumArgumentException("value", (int)value, typeof(PerformanceCounterType));
			}
			counterType = value;
		}
	}

	[DefaultValue("")]
	[MonitoringDescription("CounterName")]
	[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public string CounterName
	{
		get
		{
			return counterName;
		}
		set
		{
			PerformanceCounterCategory.CheckValidCounter(value);
			counterName = value;
		}
	}

	[DefaultValue("")]
	[MonitoringDescription("CounterHelp")]
	public string CounterHelp
	{
		get
		{
			return counterHelp;
		}
		set
		{
			PerformanceCounterCategory.CheckValidHelp(value);
			counterHelp = value;
		}
	}

	public CounterCreationData()
	{
	}

	public CounterCreationData(string counterName, string counterHelp, PerformanceCounterType counterType)
	{
		CounterType = counterType;
		CounterName = counterName;
		CounterHelp = counterHelp;
	}
}
