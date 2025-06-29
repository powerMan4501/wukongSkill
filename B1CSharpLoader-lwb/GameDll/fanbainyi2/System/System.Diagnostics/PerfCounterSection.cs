using System.Configuration;

namespace System.Diagnostics;

internal class PerfCounterSection : ConfigurationElement
{
	private static readonly ConfigurationPropertyCollection _properties;

	private static readonly ConfigurationProperty _propFileMappingSize;

	[ConfigurationProperty("filemappingsize", DefaultValue = 524288)]
	public int FileMappingSize => (int)base[_propFileMappingSize];

	protected override ConfigurationPropertyCollection Properties => _properties;

	static PerfCounterSection()
	{
		_propFileMappingSize = new ConfigurationProperty("filemappingsize", typeof(int), 524288, ConfigurationPropertyOptions.None);
		_properties = new ConfigurationPropertyCollection();
		_properties.Add(_propFileMappingSize);
	}
}
