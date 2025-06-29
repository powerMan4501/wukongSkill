namespace System.Configuration;

public sealed class SettingElementCollection : ConfigurationElementCollection
{
	public override ConfigurationElementCollectionType CollectionType => ConfigurationElementCollectionType.BasicMap;

	protected override string ElementName => "setting";

	protected override ConfigurationElement CreateNewElement()
	{
		return new SettingElement();
	}

	protected override object GetElementKey(ConfigurationElement element)
	{
		return ((SettingElement)element).Key;
	}

	public SettingElement Get(string elementKey)
	{
		return (SettingElement)BaseGet(elementKey);
	}

	public void Add(SettingElement element)
	{
		BaseAdd(element);
	}

	public void Remove(SettingElement element)
	{
		BaseRemove(GetElementKey(element));
	}

	public void Clear()
	{
		BaseClear();
	}
}
