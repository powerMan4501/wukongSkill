using System.Configuration;

namespace System.Diagnostics;

[ConfigurationCollection(typeof(SourceElement), AddItemName = "source", CollectionType = ConfigurationElementCollectionType.BasicMap)]
internal class SourceElementsCollection : ConfigurationElementCollection
{
	public new SourceElement this[string name] => (SourceElement)BaseGet(name);

	protected override string ElementName => "source";

	public override ConfigurationElementCollectionType CollectionType => ConfigurationElementCollectionType.BasicMap;

	protected override ConfigurationElement CreateNewElement()
	{
		SourceElement sourceElement = new SourceElement();
		sourceElement.Listeners.InitializeDefaultInternal();
		return sourceElement;
	}

	protected override object GetElementKey(ConfigurationElement element)
	{
		return ((SourceElement)element).Name;
	}
}
