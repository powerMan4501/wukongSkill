using System.Configuration;

namespace System.Net.Configuration;

[ConfigurationCollection(typeof(ConnectionManagementElement))]
public sealed class ConnectionManagementElementCollection : ConfigurationElementCollection
{
	public ConnectionManagementElement this[int index]
	{
		get
		{
			return (ConnectionManagementElement)BaseGet(index);
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

	public new ConnectionManagementElement this[string name]
	{
		get
		{
			return (ConnectionManagementElement)BaseGet(name);
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

	public void Add(ConnectionManagementElement element)
	{
		BaseAdd(element);
	}

	public void Clear()
	{
		BaseClear();
	}

	protected override ConfigurationElement CreateNewElement()
	{
		return new ConnectionManagementElement();
	}

	protected override object GetElementKey(ConfigurationElement element)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		return ((ConnectionManagementElement)element).Key;
	}

	public int IndexOf(ConnectionManagementElement element)
	{
		return BaseIndexOf(element);
	}

	public void Remove(ConnectionManagementElement element)
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
