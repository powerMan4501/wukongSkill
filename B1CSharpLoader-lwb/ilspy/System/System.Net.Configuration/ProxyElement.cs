using System.ComponentModel;
using System.Configuration;

namespace System.Net.Configuration;

public sealed class ProxyElement : ConfigurationElement
{
	public enum BypassOnLocalValues
	{
		Unspecified = -1,
		False,
		True
	}

	public enum UseSystemDefaultValues
	{
		Unspecified = -1,
		False,
		True
	}

	public enum AutoDetectValues
	{
		Unspecified = -1,
		False,
		True
	}

	private ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

	private readonly ConfigurationProperty autoDetect = new ConfigurationProperty("autoDetect", typeof(AutoDetectValues), AutoDetectValues.Unspecified, new EnumConverter(typeof(AutoDetectValues)), null, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty scriptLocation = new ConfigurationProperty("scriptLocation", typeof(Uri), null, new UriTypeConverter(UriKind.Absolute), null, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty bypassonlocal = new ConfigurationProperty("bypassonlocal", typeof(BypassOnLocalValues), BypassOnLocalValues.Unspecified, new EnumConverter(typeof(BypassOnLocalValues)), null, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty proxyaddress = new ConfigurationProperty("proxyaddress", typeof(Uri), null, new UriTypeConverter(UriKind.Absolute), null, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty usesystemdefault = new ConfigurationProperty("usesystemdefault", typeof(UseSystemDefaultValues), UseSystemDefaultValues.Unspecified, new EnumConverter(typeof(UseSystemDefaultValues)), null, ConfigurationPropertyOptions.None);

	protected override ConfigurationPropertyCollection Properties => properties;

	[ConfigurationProperty("autoDetect", DefaultValue = AutoDetectValues.Unspecified)]
	public AutoDetectValues AutoDetect
	{
		get
		{
			return (AutoDetectValues)base[autoDetect];
		}
		set
		{
			base[autoDetect] = value;
		}
	}

	[ConfigurationProperty("scriptLocation")]
	public Uri ScriptLocation
	{
		get
		{
			return (Uri)base[scriptLocation];
		}
		set
		{
			base[scriptLocation] = value;
		}
	}

	[ConfigurationProperty("bypassonlocal", DefaultValue = BypassOnLocalValues.Unspecified)]
	public BypassOnLocalValues BypassOnLocal
	{
		get
		{
			return (BypassOnLocalValues)base[bypassonlocal];
		}
		set
		{
			base[bypassonlocal] = value;
		}
	}

	[ConfigurationProperty("proxyaddress")]
	public Uri ProxyAddress
	{
		get
		{
			return (Uri)base[proxyaddress];
		}
		set
		{
			base[proxyaddress] = value;
		}
	}

	[ConfigurationProperty("usesystemdefault", DefaultValue = UseSystemDefaultValues.Unspecified)]
	public UseSystemDefaultValues UseSystemDefault
	{
		get
		{
			return (UseSystemDefaultValues)base[usesystemdefault];
		}
		set
		{
			base[usesystemdefault] = value;
		}
	}

	public ProxyElement()
	{
		properties.Add(autoDetect);
		properties.Add(scriptLocation);
		properties.Add(bypassonlocal);
		properties.Add(proxyaddress);
		properties.Add(usesystemdefault);
	}
}
