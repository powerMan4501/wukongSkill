using System.Configuration;

namespace System.Net.Configuration;

public sealed class WebProxyScriptElement : ConfigurationElement
{
	private class RetryIntervalValidator : ConfigurationValidatorBase
	{
		public override bool CanValidate(Type type)
		{
			return type == typeof(int);
		}

		public override void Validate(object value)
		{
			int num = (int)value;
			if (num < 0)
			{
				throw new ArgumentOutOfRangeException("value", num, SR.GetString("ArgumentOutOfRange_Bounds_Lower_Upper", 0, int.MaxValue));
			}
		}
	}

	private ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

	private readonly ConfigurationProperty autoConfigUrlRetryInterval = new ConfigurationProperty("autoConfigUrlRetryInterval", typeof(int), 600, null, new RetryIntervalValidator(), ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty downloadTimeout = new ConfigurationProperty("downloadTimeout", typeof(TimeSpan), TimeSpan.FromMinutes(1.0), null, new TimeSpanValidator(new TimeSpan(0, 0, 0), TimeSpan.MaxValue, rangeIsExclusive: false), ConfigurationPropertyOptions.None);

	[ConfigurationProperty("autoConfigUrlRetryInterval", DefaultValue = 600)]
	public int AutoConfigUrlRetryInterval
	{
		get
		{
			return (int)base[autoConfigUrlRetryInterval];
		}
		set
		{
			base[autoConfigUrlRetryInterval] = value;
		}
	}

	[ConfigurationProperty("downloadTimeout", DefaultValue = "00:01:00")]
	public TimeSpan DownloadTimeout
	{
		get
		{
			return (TimeSpan)base[downloadTimeout];
		}
		set
		{
			base[downloadTimeout] = value;
		}
	}

	protected override ConfigurationPropertyCollection Properties => properties;

	public WebProxyScriptElement()
	{
		properties.Add(autoConfigUrlRetryInterval);
		properties.Add(downloadTimeout);
	}

	protected override void PostDeserialize()
	{
		if (base.EvaluationContext.IsMachineLevel)
		{
			return;
		}
		try
		{
			ExceptionHelper.WebPermissionUnrestricted.Demand();
		}
		catch (Exception inner)
		{
			throw new ConfigurationErrorsException(SR.GetString("net_config_element_permission", "webProxyScript"), inner);
		}
	}
}
