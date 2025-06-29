using System.Configuration;
using System.Net.Cache;
using System.Xml;

namespace System.Net.Configuration;

public sealed class HttpCachePolicyElement : ConfigurationElement
{
	private bool wasReadFromConfig;

	private ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

	private readonly ConfigurationProperty maximumAge = new ConfigurationProperty("maximumAge", typeof(TimeSpan), TimeSpan.MaxValue, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty maximumStale = new ConfigurationProperty("maximumStale", typeof(TimeSpan), TimeSpan.MinValue, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty minimumFresh = new ConfigurationProperty("minimumFresh", typeof(TimeSpan), TimeSpan.MinValue, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty policyLevel = new ConfigurationProperty("policyLevel", typeof(HttpRequestCacheLevel), HttpRequestCacheLevel.Default, ConfigurationPropertyOptions.None);

	protected override ConfigurationPropertyCollection Properties => properties;

	[ConfigurationProperty("maximumAge", DefaultValue = "10675199.02:48:05.4775807")]
	public TimeSpan MaximumAge
	{
		get
		{
			return (TimeSpan)base[maximumAge];
		}
		set
		{
			base[maximumAge] = value;
		}
	}

	[ConfigurationProperty("maximumStale", DefaultValue = "-10675199.02:48:05.4775808")]
	public TimeSpan MaximumStale
	{
		get
		{
			return (TimeSpan)base[maximumStale];
		}
		set
		{
			base[maximumStale] = value;
		}
	}

	[ConfigurationProperty("minimumFresh", DefaultValue = "-10675199.02:48:05.4775808")]
	public TimeSpan MinimumFresh
	{
		get
		{
			return (TimeSpan)base[minimumFresh];
		}
		set
		{
			base[minimumFresh] = value;
		}
	}

	[ConfigurationProperty("policyLevel", IsRequired = true, DefaultValue = HttpRequestCacheLevel.Default)]
	public HttpRequestCacheLevel PolicyLevel
	{
		get
		{
			return (HttpRequestCacheLevel)base[policyLevel];
		}
		set
		{
			base[policyLevel] = value;
		}
	}

	internal bool WasReadFromConfig => wasReadFromConfig;

	public HttpCachePolicyElement()
	{
		properties.Add(maximumAge);
		properties.Add(maximumStale);
		properties.Add(minimumFresh);
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
			HttpCachePolicyElement httpCachePolicyElement = (HttpCachePolicyElement)parentElement;
			wasReadFromConfig = httpCachePolicyElement.wasReadFromConfig;
		}
		base.Reset(parentElement);
	}
}
