using System.Configuration;

namespace System.Net.Configuration;

public sealed class DefaultProxySection : ConfigurationSection
{
	private ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

	private readonly ConfigurationProperty bypasslist = new ConfigurationProperty("bypasslist", typeof(BypassElementCollection), null, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty module = new ConfigurationProperty("module", typeof(ModuleElement), null, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty proxy = new ConfigurationProperty("proxy", typeof(ProxyElement), null, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty enabled = new ConfigurationProperty("enabled", typeof(bool), true, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty useDefaultCredentials = new ConfigurationProperty("useDefaultCredentials", typeof(bool), false, ConfigurationPropertyOptions.None);

	[ConfigurationProperty("bypasslist")]
	public BypassElementCollection BypassList => (BypassElementCollection)base[bypasslist];

	[ConfigurationProperty("module")]
	public ModuleElement Module => (ModuleElement)base[module];

	protected override ConfigurationPropertyCollection Properties => properties;

	[ConfigurationProperty("proxy")]
	public ProxyElement Proxy => (ProxyElement)base[proxy];

	[ConfigurationProperty("enabled", DefaultValue = true)]
	public bool Enabled
	{
		get
		{
			return (bool)base[enabled];
		}
		set
		{
			base[enabled] = value;
		}
	}

	[ConfigurationProperty("useDefaultCredentials", DefaultValue = false)]
	public bool UseDefaultCredentials
	{
		get
		{
			return (bool)base[useDefaultCredentials];
		}
		set
		{
			base[useDefaultCredentials] = value;
		}
	}

	public DefaultProxySection()
	{
		properties.Add(bypasslist);
		properties.Add(module);
		properties.Add(proxy);
		properties.Add(enabled);
		properties.Add(useDefaultCredentials);
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
			throw new ConfigurationErrorsException(SR.GetString("net_config_section_permission", "defaultProxy"), inner);
		}
	}

	protected override void Reset(ConfigurationElement parentElement)
	{
		DefaultProxySection defaultProxySection = new DefaultProxySection();
		defaultProxySection.InitializeDefault();
		base.Reset(defaultProxySection);
	}
}
