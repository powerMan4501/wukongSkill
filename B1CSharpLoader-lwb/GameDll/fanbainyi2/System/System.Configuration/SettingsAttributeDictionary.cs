using System.Collections;

namespace System.Configuration;

[Serializable]
public class SettingsAttributeDictionary : Hashtable
{
	public SettingsAttributeDictionary()
	{
	}

	public SettingsAttributeDictionary(SettingsAttributeDictionary attributes)
		: base(attributes)
	{
	}
}
