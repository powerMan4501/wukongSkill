using System.Configuration;

namespace System.Net.Configuration;

public sealed class HttpListenerTimeoutsElement : ConfigurationElement
{
	private class TimeSpanValidator : ConfigurationValidatorBase
	{
		public override bool CanValidate(Type type)
		{
			return type == typeof(TimeSpan);
		}

		public override void Validate(object value)
		{
			TimeSpan timeSpan = (TimeSpan)value;
			long num = Convert.ToInt64(timeSpan.TotalSeconds);
			if (num < 0 || num > 65535)
			{
				throw new ArgumentOutOfRangeException("value", timeSpan, SR.GetString("ArgumentOutOfRange_Bounds_Lower_Upper", "0:0:0", "18:12:15"));
			}
		}
	}

	private class LongValidator : ConfigurationValidatorBase
	{
		public override bool CanValidate(Type type)
		{
			return type == typeof(long);
		}

		public override void Validate(object value)
		{
			long num = (long)value;
			if (num < 0 || num > uint.MaxValue)
			{
				throw new ArgumentOutOfRangeException("value", num, SR.GetString("ArgumentOutOfRange_Bounds_Lower_Upper", 0, uint.MaxValue));
			}
		}
	}

	private static ConfigurationPropertyCollection properties;

	private static readonly ConfigurationProperty entityBody;

	private static readonly ConfigurationProperty drainEntityBody;

	private static readonly ConfigurationProperty requestQueue;

	private static readonly ConfigurationProperty idleConnection;

	private static readonly ConfigurationProperty headerWait;

	private static readonly ConfigurationProperty minSendBytesPerSecond;

	[ConfigurationProperty("entityBody", DefaultValue = 0, IsRequired = false)]
	public TimeSpan EntityBody => (TimeSpan)base[entityBody];

	[ConfigurationProperty("drainEntityBody", DefaultValue = 0, IsRequired = false)]
	public TimeSpan DrainEntityBody => (TimeSpan)base[drainEntityBody];

	[ConfigurationProperty("requestQueue", DefaultValue = 0, IsRequired = false)]
	public TimeSpan RequestQueue => (TimeSpan)base[requestQueue];

	[ConfigurationProperty("idleConnection", DefaultValue = 0, IsRequired = false)]
	public TimeSpan IdleConnection => (TimeSpan)base[idleConnection];

	[ConfigurationProperty("headerWait", DefaultValue = 0, IsRequired = false)]
	public TimeSpan HeaderWait => (TimeSpan)base[headerWait];

	[ConfigurationProperty("minSendBytesPerSecond", DefaultValue = 0L, IsRequired = false)]
	public long MinSendBytesPerSecond => (long)base[minSendBytesPerSecond];

	protected override ConfigurationPropertyCollection Properties => properties;

	static HttpListenerTimeoutsElement()
	{
		entityBody = CreateTimeSpanProperty("entityBody");
		drainEntityBody = CreateTimeSpanProperty("drainEntityBody");
		requestQueue = CreateTimeSpanProperty("requestQueue");
		idleConnection = CreateTimeSpanProperty("idleConnection");
		headerWait = CreateTimeSpanProperty("headerWait");
		minSendBytesPerSecond = new ConfigurationProperty("minSendBytesPerSecond", typeof(long), 0L, null, new LongValidator(), ConfigurationPropertyOptions.None);
		properties = new ConfigurationPropertyCollection();
		properties.Add(entityBody);
		properties.Add(drainEntityBody);
		properties.Add(requestQueue);
		properties.Add(idleConnection);
		properties.Add(headerWait);
		properties.Add(minSendBytesPerSecond);
	}

	private static ConfigurationProperty CreateTimeSpanProperty(string name)
	{
		return new ConfigurationProperty(name, typeof(TimeSpan), TimeSpan.Zero, null, new TimeSpanValidator(), ConfigurationPropertyOptions.None);
	}

	internal long[] GetTimeouts()
	{
		return new long[6]
		{
			Convert.ToInt64(EntityBody.TotalSeconds),
			Convert.ToInt64(DrainEntityBody.TotalSeconds),
			Convert.ToInt64(RequestQueue.TotalSeconds),
			Convert.ToInt64(IdleConnection.TotalSeconds),
			Convert.ToInt64(HeaderWait.TotalSeconds),
			MinSendBytesPerSecond
		};
	}
}
