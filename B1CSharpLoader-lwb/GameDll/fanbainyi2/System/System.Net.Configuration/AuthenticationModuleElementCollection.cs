using System.Configuration;

namespace System.Net.Configuration;

[ConfigurationCollection(typeof(AuthenticationModuleElement))]
public sealed class AuthenticationModuleElementCollection : ConfigurationElementCollection
{
	public AuthenticationModuleElement this[int index]
	{
		get
		{
			return (AuthenticationModuleElement)BaseGet(index);
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

	public new AuthenticationModuleElement this[string name]
	{
		get
		{
			return (AuthenticationModuleElement)BaseGet(name);
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

	public void Add(AuthenticationModuleElement element)
	{
		BaseAdd(element);
	}

	public void Clear()
	{
		BaseClear();
	}

	protected override ConfigurationElement CreateNewElement()
	{
		return new AuthenticationModuleElement();
	}

	protected override object GetElementKey(ConfigurationElement element)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		return ((AuthenticationModuleElement)element).Key;
	}

	public int IndexOf(AuthenticationModuleElement element)
	{
		return BaseIndexOf(element);
	}

	public void Remove(AuthenticationModuleElement element)
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
