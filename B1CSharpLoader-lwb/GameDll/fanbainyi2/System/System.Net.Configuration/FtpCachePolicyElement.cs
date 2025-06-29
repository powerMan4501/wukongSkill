using System.Configuration;
using System.Net.Cache;
using System.Xml;

namespace System.Net.Configuration;

public sealed class FtpCachePolicyElement : ConfigurationElement
{
	private bool wasReadFromConfig;

	private ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

	private readonly ConfigurationProperty policyLevel = new ConfigurationProperty("policyLevel", typeof(RequestCacheLevel), RequestCacheLevel.Default, ConfigurationPropertyOptions.None);

	protected override ConfigurationPropertyCollection Properties => properties;

	[ConfigurationProperty("policyLevel", DefaultValue = RequestCacheLevel.Default)]
	public RequestCacheLevel PolicyLevel
	{
		get
		{
			return (RequestCacheLevel)base[policyLevel];
		}
		set
		{
			base[policyLevel] = value;
		}
	}

	internal bool WasReadFromConfig => wasReadFromConfig;

	public FtpCachePolicyElement()
	{
		properties.Add(policyLevel);
	}

	protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
	{
		wasReadFromConfig = true;
		base.DeserializeElement(reader, serializeCollectionKey);
	}

	protected override void Reset(ConfigurationElement parentElement)
	{
		if (parentElement != null)
		{
			FtpCachePolicyElement ftpCachePolicyElement = (FtpCachePolicyElement)parentElement;
			wasReadFromConfig = ftpCachePolicyElement.wasReadFromConfig;
		}
		base.Reset(parentElement);
	}
}
