using System.Configuration;

namespace System.Net.Configuration;

public sealed class WindowsAuthenticationElement : ConfigurationElement
{
	private class CacheSizeValidator : ConfigurationValidatorBase
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

	private ConfigurationPropertyCollection properties;

	private readonly ConfigurationProperty defaultCredentialsHandleCacheSize;

	protected override ConfigurationPropertyCollection Properties => properties;

	[ConfigurationProperty("defaultCredentialsHandleCacheSize", DefaultValue = 0)]
	public int DefaultCredentialsHandleCacheSize
	{
		get
		{
			return (int)base[defaultCredentialsHandleCacheSize];
		}
		set
		{
			base[defaultCredentialsHandleCacheSize] = value;
		}
	}

	public WindowsAuthenticationElement()
	{
		defaultCredentialsHandleCacheSize = new ConfigurationProperty("defaultCredentialsHandleCacheSize", typeof(int), 0, null, new CacheSizeValidator(), ConfigurationPropertyOptions.None);
		properties = new ConfigurationPropertyCollection();
		properties.Add(defaultCredentialsHandleCacheSize);
	}
}
