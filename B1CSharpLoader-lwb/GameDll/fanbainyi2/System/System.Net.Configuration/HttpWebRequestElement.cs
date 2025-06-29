using System.Configuration;

namespace System.Net.Configuration;

public sealed class HttpWebRequestElement : ConfigurationElement
{
	private ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

	private readonly ConfigurationProperty maximumResponseHeadersLength = new ConfigurationProperty("maximumResponseHeadersLength", typeof(int), 64, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty maximumErrorResponseLength = new ConfigurationProperty("maximumErrorResponseLength", typeof(int), 64, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty maximumUnauthorizedUploadLength = new ConfigurationProperty("maximumUnauthorizedUploadLength", typeof(int), -1, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty useUnsafeHeaderParsing = new ConfigurationProperty("useUnsafeHeaderParsing", typeof(bool), false, ConfigurationPropertyOptions.None);

	protected override ConfigurationPropertyCollection Properties => properties;

	[ConfigurationProperty("maximumUnauthorizedUploadLength", DefaultValue = -1)]
	public int MaximumUnauthorizedUploadLength
	{
		get
		{
			return (int)base[maximumUnauthorizedUploadLength];
		}
		set
		{
			base[maximumUnauthorizedUploadLength] = value;
		}
	}

	[ConfigurationProperty("maximumErrorResponseLength", DefaultValue = 64)]
	public int MaximumErrorResponseLength
	{
		get
		{
			return (int)base[maximumErrorResponseLength];
		}
		set
		{
			base[maximumErrorResponseLength] = value;
		}
	}

	[ConfigurationProperty("maximumResponseHeadersLength", DefaultValue = 64)]
	public int MaximumResponseHeadersLength
	{
		get
		{
			return (int)base[maximumResponseHeadersLength];
		}
		set
		{
			base[maximumResponseHeadersLength] = value;
		}
	}

	[ConfigurationProperty("useUnsafeHeaderParsing", DefaultValue = false)]
	public bool UseUnsafeHeaderParsing
	{
		get
		{
			return (bool)base[useUnsafeHeaderParsing];
		}
		set
		{
			base[useUnsafeHeaderParsing] = value;
		}
	}

	public HttpWebRequestElement()
	{
		properties.Add(maximumResponseHeadersLength);
		properties.Add(maximumErrorResponseLength);
		properties.Add(maximumUnauthorizedUploadLength);
		properties.Add(useUnsafeHeaderParsing);
	}

	protected override void PostDeserialize()
	{
		if (base.EvaluationContext.IsMachineLevel)
		{
			return;
		}
		PropertyInformation[] array = new PropertyInformation[2]
		{
			base.ElementInformation.Properties["maximumResponseHeadersLength"],
			base.ElementInformation.Properties["maximumErrorResponseLength"]
		};
		PropertyInformation[] array2 = array;
		foreach (PropertyInformation propertyInformation in array2)
		{
			if (propertyInformation.ValueOrigin == PropertyValueOrigin.SetHere)
			{
				try
				{
					ExceptionHelper.WebPermissionUnrestricted.Demand();
				}
				catch (Exception inner)
				{
					throw new ConfigurationErrorsException(SR.GetString("net_config_property_permission", propertyInformation.Name), inner);
				}
			}
		}
	}
}
