using System.Collections.Generic;

namespace System.Configuration;

internal sealed class UriSectionData
{
	private UriIdnScope? idnScope;

	private bool? iriParsing;

	private Dictionary<string, SchemeSettingInternal> schemeSettings;

	public UriIdnScope? IdnScope
	{
		get
		{
			return idnScope;
		}
		set
		{
			idnScope = value;
		}
	}

	public bool? IriParsing
	{
		get
		{
			return iriParsing;
		}
		set
		{
			iriParsing = value;
		}
	}

	public Dictionary<string, SchemeSettingInternal> SchemeSettings => schemeSettings;

	public UriSectionData()
	{
		schemeSettings = new Dictionary<string, SchemeSettingInternal>();
	}
}
