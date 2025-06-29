using System.Configuration;

namespace System.Diagnostics;

internal class SystemDiagnosticsSection : ConfigurationSection
{
	private static readonly ConfigurationPropertyCollection _properties;

	private static readonly ConfigurationProperty _propAssert;

	private static readonly ConfigurationProperty _propPerfCounters;

	private static readonly ConfigurationProperty _propSources;

	private static readonly ConfigurationProperty _propSharedListeners;

	private static readonly ConfigurationProperty _propSwitches;

	private static readonly ConfigurationProperty _propTrace;

	[ConfigurationProperty("assert")]
	public AssertSection Assert => (AssertSection)base[_propAssert];

	[ConfigurationProperty("performanceCounters")]
	public PerfCounterSection PerfCounters => (PerfCounterSection)base[_propPerfCounters];

	protected override ConfigurationPropertyCollection Properties => _properties;

	[ConfigurationProperty("sources")]
	public SourceElementsCollection Sources => (SourceElementsCollection)base[_propSources];

	[ConfigurationProperty("sharedListeners")]
	public ListenerElementsCollection SharedListeners => (ListenerElementsCollection)base[_propSharedListeners];

	[ConfigurationProperty("switches")]
	public SwitchElementsCollection Switches => (SwitchElementsCollection)base[_propSwitches];

	[ConfigurationProperty("trace")]
	public TraceSection Trace => (TraceSection)base[_propTrace];

	static SystemDiagnosticsSection()
	{
		_propAssert = new ConfigurationProperty("assert", typeof(AssertSection), new AssertSection(), ConfigurationPropertyOptions.None);
		_propPerfCounters = new ConfigurationProperty("performanceCounters", typeof(PerfCounterSection), new PerfCounterSection(), ConfigurationPropertyOptions.None);
		_propSources = new ConfigurationProperty("sources", typeof(SourceElementsCollection), new SourceElementsCollection(), ConfigurationPropertyOptions.None);
		_propSharedListeners = new ConfigurationProperty("sharedListeners", typeof(SharedListenerElementsCollection), new SharedListenerElementsCollection(), ConfigurationPropertyOptions.None);
		_propSwitches = new ConfigurationProperty("switches", typeof(SwitchElementsCollection), new SwitchElementsCollection(), ConfigurationPropertyOptions.None);
		_propTrace = new ConfigurationProperty("trace", typeof(TraceSection), new TraceSection(), ConfigurationPropertyOptions.None);
		_properties = new ConfigurationPropertyCollection();
		_properties.Add(_propAssert);
		_properties.Add(_propPerfCounters);
		_properties.Add(_propSources);
		_properties.Add(_propSharedListeners);
		_properties.Add(_propSwitches);
		_properties.Add(_propTrace);
	}

	protected override void InitializeDefault()
	{
		Trace.Listeners.InitializeDefaultInternal();
	}
}
