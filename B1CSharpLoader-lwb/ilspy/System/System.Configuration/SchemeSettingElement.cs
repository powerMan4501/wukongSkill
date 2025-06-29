namespace System.Configuration;

public sealed class SchemeSettingElement : ConfigurationElement
{
	private static readonly ConfigurationPropertyCollection properties;

	private static readonly ConfigurationProperty name;

	private static readonly ConfigurationProperty genericUriParserOptions;

	[ConfigurationProperty("name", DefaultValue = null, IsRequired = true, IsKey = true)]
	public string Name => (string)base[name];

	[ConfigurationProperty("genericUriParserOptions", DefaultValue = ConfigurationPropertyOptions.None, IsRequired = true)]
	public GenericUriParserOptions GenericUriParserOptions => (GenericUriParserOptions)base[genericUriParserOptions];

	protected override ConfigurationPropertyCollection Properties => properties;

	static SchemeSettingElement()
	{
		name = new ConfigurationProperty("name", typeof(string), null, ConfigurationPropertyOptions.IsRequired | ConfigurationPropertyOptions.IsKey);
		genericUriParserOptions = new ConfigurationProperty("genericUriParserOptions", typeof(GenericUriParserOptions), GenericUriParserOptions.Default, ConfigurationPropertyOptions.IsRequired);
		properties = new ConfigurationPropertyCollection();
		properties.Add(name);
		properties.Add(genericUriParserOptions);
	}
}
