using System.Configuration;
using System.Net.Cache;
using System.Xml;

namespace System.Net.Configuration;

public sealed class RequestCachingSection : ConfigurationSection
{
	private ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

	private readonly ConfigurationProperty defaultHttpCachePolicy = new ConfigurationProperty("defaultHttpCachePolicy", typeof(HttpCachePolicyElement), null, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty defaultFtpCachePolicy = new ConfigurationProperty("defaultFtpCachePolicy", typeof(FtpCachePolicyElement), null, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty defaultPolicyLevel = new ConfigurationProperty("defaultPolicyLevel", typeof(RequestCacheLevel), RequestCacheLevel.BypassCache, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty disableAllCaching = new ConfigurationProperty("disableAllCaching", typeof(bool), false, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty isPrivateCache = new ConfigurationProperty("isPrivateCache", typeof(bool), true, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty unspecifiedMaximumAge = new ConfigurationProperty("unspecifiedMaximumAge", typeof(TimeSpan), TimeSpan.FromDays(1.0), ConfigurationPropertyOptions.None);

	[ConfigurationProperty("defaultHttpCachePolicy")]
	public HttpCachePolicyElement DefaultHttpCachePolicy => (HttpCachePolicyElement)base[defaultHttpCachePolicy];

	[ConfigurationProperty("defaultFtpCachePolicy")]
	public FtpCachePolicyElement DefaultFtpCachePolicy => (FtpCachePolicyElement)base[defaultFtpCachePolicy];

	[ConfigurationProperty("defaultPolicyLevel", DefaultValue = RequestCacheLevel.BypassCache)]
	public RequestCacheLevel DefaultPolicyLevel
	{
		get
		{
			return (RequestCacheLevel)base[defaultPolicyLevel];
		}
		set
		{
			base[defaultPolicyLevel] = value;
		}
	}

	[ConfigurationProperty("disableAllCaching", DefaultValue = false)]
	public bool DisableAllCaching
	{
		get
		{
			return (bool)base[disableAllCaching];
		}
		set
		{
			base[disableAllCaching] = value;
		}
	}

	[ConfigurationProperty("isPrivateCache", DefaultValue = true)]
	public bool IsPrivateCache
	{
		get
		{
			return (bool)base[isPrivateCache];
		}
		set
		{
			base[isPrivateCache] = value;
		}
	}

	[ConfigurationProperty("unspecifiedMaximumAge", DefaultValue = "1.00:00:00")]
	public TimeSpan UnspecifiedMaximumAge
	{
		get
		{
			return (TimeSpan)base[unspecifiedMaximumAge];
		}
		set
		{
			base[unspecifiedMaximumAge] = value;
		}
	}

	protected override ConfigurationPropertyCollection Properties => properties;

	public RequestCachingSection()
	{
		properties.Add(disableAllCaching);
		properties.Add(defaultPolicyLevel);
		properties.Add(isPrivateCache);
		properties.Add(defaultHttpCachePolicy);
		properties.Add(defaultFtpCachePolicy);
		properties.Add(unspecifiedMaximumAge);
	}

	protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
	{
		bool flag = DisableAllCaching;
		base.DeserializeElement(reader, serializeCollectionKey);
		if (flag)
		{
			DisableAllCaching = true;
		}
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
			throw new ConfigurationErrorsException(SR.GetString("net_config_section_permission", "requestCaching"), inner);
		}
	}
}
