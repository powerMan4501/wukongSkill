using System.Configuration;

namespace System.Net.Configuration;

[ConfigurationCollection(typeof(BypassElement))]
public sealed class BypassElementCollection : ConfigurationElementCollection
{
	public BypassElement this[int index]
	{
		get
		{
			return (BypassElement)BaseGet(index);
		}
		set
		{
			if (BaseGet(index) != null)
			{
				BaseRemoveAt(index);
			}
			BaseAdd(index, value);
		}
	}

	public new BypassElement this[string name]
	{
		get
		{
			return (BypassElement)BaseGet(name);
		}
		set
		{
			if (BaseGet(name) != null)
			{
				BaseRemove(name);
			}
			BaseAdd(value);
		}
	}

	protected override bool ThrowOnDuplicate => false;

	public void Add(BypassElement element)
	{
		BaseAdd(element);
	}

	public void Clear()
	{
		BaseClear();
	}

	protected override ConfigurationElement CreateNewElement()
	{
		return new BypassElement();
	}

	protected override object GetElementKey(ConfigurationElement element)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		return ((BypassElement)element).Key;
	}

	public int IndexOf(BypassElement element)
	{
		return BaseIndexOf(element);
	}

	public void Remove(BypassElement element)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		BaseRemove(element.Key);
	}

	public void Remove(string name)
	{
		BaseRemove(name);
	}

	public void RemoveAt(int index)
	{
		BaseRemoveAt(index);
	}
}
