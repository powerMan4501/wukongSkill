using System.Configuration;

namespace System.Diagnostics;

internal class TraceSection : ConfigurationElement
{
	private static readonly ConfigurationPropertyCollection _properties;

	private static readonly ConfigurationProperty _propListeners;

	private static readonly ConfigurationProperty _propAutoFlush;

	private static readonly ConfigurationProperty _propIndentSize;

	private static readonly ConfigurationProperty _propUseGlobalLock;

	[ConfigurationProperty("autoflush", DefaultValue = false)]
	public bool AutoFlush => (bool)base[_propAutoFlush];

	[ConfigurationProperty("indentsize", DefaultValue = 4)]
	public int IndentSize => (int)base[_propIndentSize];

	[ConfigurationProperty("listeners")]
	public ListenerElementsCollection Listeners => (ListenerElementsCollection)base[_propListeners];

	[ConfigurationProperty("useGlobalLock", DefaultValue = true)]
	public bool UseGlobalLock => (bool)base[_propUseGlobalLock];

	protected override ConfigurationPropertyCollection Properties => _properties;

	static TraceSection()
	{
		_propListeners = new ConfigurationProperty("listeners", typeof(ListenerElementsCollection), new ListenerElementsCollection(), ConfigurationPropertyOptions.None);
		_propAutoFlush = new ConfigurationProperty("autoflush", typeof(bool), false, ConfigurationPropertyOptions.None);
		_propIndentSize = new ConfigurationProperty("indentsize", typeof(int), 4, ConfigurationPropertyOptions.None);
		_propUseGlobalLock = new ConfigurationProperty("useGlobalLock", typeof(bool), true, ConfigurationPropertyOptions.None);
		_properties = new ConfigurationPropertyCollection();
		_properties.Add(_propListeners);
		_properties.Add(_propAutoFlush);
		_properties.Add(_propIndentSize);
		_properties.Add(_propUseGlobalLock);
	}
}
