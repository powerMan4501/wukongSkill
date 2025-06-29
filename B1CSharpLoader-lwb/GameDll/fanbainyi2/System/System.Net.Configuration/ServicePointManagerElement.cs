using System.Configuration;
using System.Net.Security;

namespace System.Net.Configuration;

public sealed class ServicePointManagerElement : ConfigurationElement
{
	private ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

	private readonly ConfigurationProperty checkCertificateName = new ConfigurationProperty("checkCertificateName", typeof(bool), true, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty checkCertificateRevocationList = new ConfigurationProperty("checkCertificateRevocationList", typeof(bool), false, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty dnsRefreshTimeout = new ConfigurationProperty("dnsRefreshTimeout", typeof(int), 120000, null, new TimeoutValidator(zeroValid: true), ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty enableDnsRoundRobin = new ConfigurationProperty("enableDnsRoundRobin", typeof(bool), false, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty encryptionPolicy = new ConfigurationProperty("encryptionPolicy", typeof(EncryptionPolicy), EncryptionPolicy.RequireEncryption, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty expect100Continue = new ConfigurationProperty("expect100Continue", typeof(bool), true, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty useNagleAlgorithm = new ConfigurationProperty("useNagleAlgorithm", typeof(bool), true, ConfigurationPropertyOptions.None);

	[ConfigurationProperty("checkCertificateName", DefaultValue = true)]
	public bool CheckCertificateName
	{
		get
		{
			return (bool)base[checkCertificateName];
		}
		set
		{
			base[checkCertificateName] = value;
		}
	}

	[ConfigurationProperty("checkCertificateRevocationList", DefaultValue = false)]
	public bool CheckCertificateRevocationList
	{
		get
		{
			return (bool)base[checkCertificateRevocationList];
		}
		set
		{
			base[checkCertificateRevocationList] = value;
		}
	}

	[ConfigurationProperty("dnsRefreshTimeout", DefaultValue = 120000)]
	public int DnsRefreshTimeout
	{
		get
		{
			return (int)base[dnsRefreshTimeout];
		}
		set
		{
			base[dnsRefreshTimeout] = value;
		}
	}

	[ConfigurationProperty("enableDnsRoundRobin", DefaultValue = false)]
	public bool EnableDnsRoundRobin
	{
		get
		{
			return (bool)base[enableDnsRoundRobin];
		}
		set
		{
			base[enableDnsRoundRobin] = value;
		}
	}

	[ConfigurationProperty("encryptionPolicy", DefaultValue = EncryptionPolicy.RequireEncryption)]
	public EncryptionPolicy EncryptionPolicy
	{
		get
		{
			return (EncryptionPolicy)base[encryptionPolicy];
		}
		set
		{
			base[encryptionPolicy] = value;
		}
	}

	[ConfigurationProperty("expect100Continue", DefaultValue = true)]
	public bool Expect100Continue
	{
		get
		{
			return (bool)base[expect100Continue];
		}
		set
		{
			base[expect100Continue] = value;
		}
	}

	[ConfigurationProperty("useNagleAlgorithm", DefaultValue = true)]
	public bool UseNagleAlgorithm
	{
		get
		{
			return (bool)base[useNagleAlgorithm];
		}
		set
		{
			base[useNagleAlgorithm] = value;
		}
	}

	protected override ConfigurationPropertyCollection Properties => properties;

	public ServicePointManagerElement()
	{
		properties.Add(checkCertificateName);
		properties.Add(checkCertificateRevocationList);
		properties.Add(dnsRefreshTimeout);
		properties.Add(enableDnsRoundRobin);
		properties.Add(encryptionPolicy);
		properties.Add(expect100Continue);
		properties.Add(useNagleAlgorithm);
	}

	protected override void PostDeserialize()
	{
		if (base.EvaluationContext.IsMachineLevel)
		{
			return;
		}
		PropertyInformation[] array = new PropertyInformation[2]
		{
			base.ElementInformation.Properties["checkCertificateName"],
			base.ElementInformation.Properties["checkCertificateRevocationList"]
		};
		PropertyInformation[] array2 = array;
		foreach (PropertyInformation propertyInformation in array2)
		{
			if (propertyInformation.ValueOrigin == PropertyValueOrigin.SetHere)
			{
				try
				{
					ExceptionHelper.UnmanagedPermission.Demand();
				}
				catch (Exception inner)
				{
					throw new ConfigurationErrorsException(SR.GetString("net_config_property_permission", propertyInformation.Name), inner);
				}
			}
		}
	}
}
