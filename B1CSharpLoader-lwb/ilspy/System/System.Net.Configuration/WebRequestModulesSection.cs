using System.Configuration;

namespace System.Net.Configuration;

public sealed class WebRequestModulesSection : ConfigurationSection
{
	private ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

	private readonly ConfigurationProperty webRequestModules = new ConfigurationProperty(null, typeof(WebRequestModuleElementCollection), null, ConfigurationPropertyOptions.IsDefaultCollection);

	protected override ConfigurationPropertyCollection Properties => properties;

	[ConfigurationProperty("", IsDefaultCollection = true)]
	public WebRequestModuleElementCollection WebRequestModules => (WebRequestModuleElementCollection)base[webRequestModules];

	public WebRequestModulesSection()
	{
		properties.Add(webRequestModules);
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
			throw new ConfigurationErrorsException(SR.GetString("net_config_section_permission", "webRequestModules"), inner);
		}
	}

	protected override void InitializeDefault()
	{
		WebRequestModules.Add(new WebRequestModuleElement("https:", typeof(HttpRequestCreator)));
		WebRequestModules.Add(new WebRequestModuleElement("http:", typeof(HttpRequestCreator)));
		WebRequestModules.Add(new WebRequestModuleElement("file:", typeof(FileWebRequestCreator)));
		WebRequestModules.Add(new WebRequestModuleElement("ftp:", typeof(FtpWebRequestCreator)));
	}
}
