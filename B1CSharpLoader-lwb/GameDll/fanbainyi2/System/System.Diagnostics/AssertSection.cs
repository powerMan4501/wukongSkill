using System.Configuration;

namespace System.Diagnostics;

internal class AssertSection : ConfigurationElement
{
	private static readonly ConfigurationPropertyCollection _properties;

	private static readonly ConfigurationProperty _propAssertUIEnabled;

	private static readonly ConfigurationProperty _propLogFile;

	[ConfigurationProperty("assertuienabled", DefaultValue = true)]
	public bool AssertUIEnabled => (bool)base[_propAssertUIEnabled];

	[ConfigurationProperty("logfilename", DefaultValue = "")]
	public string LogFileName => (string)base[_propLogFile];

	protected override ConfigurationPropertyCollection Properties => _properties;

	static AssertSection()
	{
		_propAssertUIEnabled = new ConfigurationProperty("assertuienabled", typeof(bool), true, ConfigurationPropertyOptions.None);
		_propLogFile = new ConfigurationProperty("logfilename", typeof(string), string.Empty, ConfigurationPropertyOptions.None);
		_properties = new ConfigurationPropertyCollection();
		_properties.Add(_propAssertUIEnabled);
		_properties.Add(_propLogFile);
	}
}
