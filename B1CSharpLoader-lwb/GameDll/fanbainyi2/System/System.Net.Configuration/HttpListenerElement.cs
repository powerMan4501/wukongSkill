using System.Configuration;

namespace System.Net.Configuration;

public sealed class HttpListenerElement : ConfigurationElement
{
	internal const bool UnescapeRequestUrlDefaultValue = true;

	private static ConfigurationPropertyCollection properties;

	private static readonly ConfigurationProperty unescapeRequestUrl;

	private static readonly ConfigurationProperty timeouts;

	[ConfigurationProperty("unescapeRequestUrl", DefaultValue = true, IsRequired = false)]
	public bool UnescapeRequestUrl => (bool)base[unescapeRequestUrl];

	[ConfigurationProperty("timeouts")]
	public HttpListenerTimeoutsElement Timeouts => (HttpListenerTimeoutsElement)base[timeouts];

	protected override ConfigurationPropertyCollection Properties => properties;

	static HttpListenerElement()
	{
		unescapeRequestUrl = new ConfigurationProperty("unescapeRequestUrl", typeof(bool), true, ConfigurationPropertyOptions.None);
		timeouts = new ConfigurationProperty("timeouts", typeof(HttpListenerTimeoutsElement), null, ConfigurationPropertyOptions.None);
		properties = new ConfigurationPropertyCollection();
		properties.Add(unescapeRequestUrl);
		properties.Add(timeouts);
	}
}
