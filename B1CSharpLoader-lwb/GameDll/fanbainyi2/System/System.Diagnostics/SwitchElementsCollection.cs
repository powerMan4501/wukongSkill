using System.Configuration;

namespace System.Diagnostics;

[ConfigurationCollection(typeof(SwitchElement))]
internal class SwitchElementsCollection : ConfigurationElementCollection
{
	public new SwitchElement this[string name] => (SwitchElement)BaseGet(name);

	public override ConfigurationElementCollectionType CollectionType => ConfigurationElementCollectionType.AddRemoveClearMap;

	protected override ConfigurationElement CreateNewElement()
	{
		return new SwitchElement();
	}

	protected override object GetElementKey(ConfigurationElement element)
	{
		return ((SwitchElement)element).Name;
	}
}
