using System.Collections.Generic;
using System.Configuration;

namespace System.Security.Authentication.ExtendedProtection.Configuration;

public sealed class ExtendedProtectionPolicyElement : ConfigurationElement
{
	private ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

	private readonly ConfigurationProperty policyEnforcement = new ConfigurationProperty("policyEnforcement", typeof(PolicyEnforcement), DefaultPolicyEnforcement, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty protectionScenario = new ConfigurationProperty("protectionScenario", typeof(ProtectionScenario), ProtectionScenario.TransportSelected, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty customServiceNames = new ConfigurationProperty("customServiceNames", typeof(ServiceNameElementCollection), null, ConfigurationPropertyOptions.None);

	protected override ConfigurationPropertyCollection Properties => properties;

	[ConfigurationProperty("policyEnforcement")]
	public PolicyEnforcement PolicyEnforcement
	{
		get
		{
			return (PolicyEnforcement)base[policyEnforcement];
		}
		set
		{
			base[policyEnforcement] = value;
		}
	}

	[ConfigurationProperty("protectionScenario", DefaultValue = ProtectionScenario.TransportSelected)]
	public ProtectionScenario ProtectionScenario
	{
		get
		{
			return (ProtectionScenario)base[protectionScenario];
		}
		set
		{
			base[protectionScenario] = value;
		}
	}

	[ConfigurationProperty("customServiceNames")]
	public ServiceNameElementCollection CustomServiceNames => (ServiceNameElementCollection)base[customServiceNames];

	private static PolicyEnforcement DefaultPolicyEnforcement => PolicyEnforcement.Never;

	public ExtendedProtectionPolicyElement()
	{
		properties.Add(policyEnforcement);
		properties.Add(protectionScenario);
		properties.Add(customServiceNames);
	}

	public ExtendedProtectionPolicy BuildPolicy()
	{
		if (PolicyEnforcement == PolicyEnforcement.Never)
		{
			return new ExtendedProtectionPolicy(PolicyEnforcement.Never);
		}
		ServiceNameCollection serviceNameCollection = null;
		ServiceNameElementCollection serviceNameElementCollection = CustomServiceNames;
		if (serviceNameElementCollection != null && serviceNameElementCollection.Count > 0)
		{
			List<string> list = new List<string>(serviceNameElementCollection.Count);
			foreach (ServiceNameElement item in serviceNameElementCollection)
			{
				list.Add(item.Name);
			}
			serviceNameCollection = new ServiceNameCollection(list);
		}
		return new ExtendedProtectionPolicy(PolicyEnforcement, ProtectionScenario, serviceNameCollection);
	}
}
