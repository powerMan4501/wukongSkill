using System.Configuration;

namespace System.Diagnostics;

[ConfigurationCollection(typeof(ListenerElement), AddItemName = "add", CollectionType = ConfigurationElementCollectionType.BasicMap)]
internal class SharedListenerElementsCollection : ListenerElementsCollection
{
	public override ConfigurationElementCollectionType CollectionType => ConfigurationElementCollectionType.BasicMap;

	protected override string ElementName => "add";

	protected override ConfigurationElement CreateNewElement()
	{
		return new ListenerElement(allowReferences: false);
	}
}
