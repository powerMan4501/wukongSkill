namespace System.Configuration;

public sealed class UriSection : ConfigurationSection
{
	private static readonly ConfigurationPropertyCollection properties;

	private static readonly ConfigurationProperty idn;

	private static readonly ConfigurationProperty iriParsing;

	private static readonly ConfigurationProperty schemeSettings;

	[ConfigurationProperty("idn")]
	public IdnElement Idn => (IdnElement)base[idn];

	[ConfigurationProperty("iriParsing")]
	public IriParsingElement IriParsing => (IriParsingElement)base[iriParsing];

	[ConfigurationProperty("schemeSettings")]
	public SchemeSettingElementCollection SchemeSettings => (SchemeSettingElementCollection)base[schemeSettings];

	protected override ConfigurationPropertyCollection Properties => properties;

	static UriSection()
	{
		properties = new ConfigurationPropertyCollection();
		idn = new ConfigurationProperty("idn", typeof(IdnElement), null, ConfigurationPropertyOptions.None);
		iriParsing = new ConfigurationProperty("iriParsing", typeof(IriParsingElement), null, ConfigurationPropertyOptions.None);
		schemeSettings = new ConfigurationProperty("schemeSettings", typeof(SchemeSettingElementCollection), null, ConfigurationPropertyOptions.None);
		properties.Add(idn);
		properties.Add(iriParsing);
		properties.Add(schemeSettings);
	}
}
