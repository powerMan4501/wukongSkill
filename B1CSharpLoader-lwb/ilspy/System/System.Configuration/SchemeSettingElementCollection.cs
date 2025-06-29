namespace System.Configuration;

[ConfigurationCollection(typeof(SchemeSettingElement), CollectionType = ConfigurationElementCollectionType.AddRemoveClearMap, AddItemName = "add", ClearItemsName = "clear", RemoveItemName = "remove")]
public sealed class SchemeSettingElementCollection : ConfigurationElementCollection
{
	internal const string AddItemName = "add";

	internal const string ClearItemsName = "clear";

	internal const string RemoveItemName = "remove";

	public override ConfigurationElementCollectionType CollectionType => ConfigurationElementCollectionType.AddRemoveClearMap;

	public SchemeSettingElement this[int index] => (SchemeSettingElement)BaseGet(index);

	public new SchemeSettingElement this[string name] => (SchemeSettingElement)BaseGet(name);

	public SchemeSettingElementCollection()
	{
		base.AddElementName = "add";
		base.ClearElementName = "clear";
		base.RemoveElementName = "remove";
	}

	public int IndexOf(SchemeSettingElement element)
	{
		return BaseIndexOf(element);
	}

	protected override ConfigurationElement CreateNewElement()
	{
		return new SchemeSettingElement();
	}

	protected override object GetElementKey(ConfigurationElement element)
	{
		return ((SchemeSettingElement)element).Name;
	}
}
