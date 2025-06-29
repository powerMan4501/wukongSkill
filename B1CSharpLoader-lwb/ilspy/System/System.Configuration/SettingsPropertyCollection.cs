using System.Collections;

namespace System.Configuration;

public class SettingsPropertyCollection : IEnumerable, ICloneable, ICollection
{
	private Hashtable _Hashtable;

	private bool _ReadOnly;

	public SettingsProperty this[string name] => _Hashtable[name] as SettingsProperty;

	public int Count => _Hashtable.Count;

	public bool IsSynchronized => false;

	public object SyncRoot => this;

	public SettingsPropertyCollection()
	{
		_Hashtable = new Hashtable(10, StringComparer.CurrentCultureIgnoreCase);
	}

	public void Add(SettingsProperty property)
	{
		if (_ReadOnly)
		{
			throw new NotSupportedException();
		}
		OnAdd(property);
		_Hashtable.Add(property.Name, property);
		try
		{
			OnAddComplete(property);
		}
		catch
		{
			_Hashtable.Remove(property.Name);
			throw;
		}
	}

	public void Remove(string name)
	{
		if (_ReadOnly)
		{
			throw new NotSupportedException();
		}
		SettingsProperty settingsProperty = (SettingsProperty)_Hashtable[name];
		if (settingsProperty == null)
		{
			return;
		}
		OnRemove(settingsProperty);
		_Hashtable.Remove(name);
		try
		{
			OnRemoveComplete(settingsProperty);
		}
		catch
		{
			_Hashtable.Add(name, settingsProperty);
			throw;
		}
	}

	public IEnumerator GetEnumerator()
	{
		return _Hashtable.Values.GetEnumerator();
	}

	public object Clone()
	{
		return new SettingsPropertyCollection(_Hashtable);
	}

	public void SetReadOnly()
	{
		if (!_ReadOnly)
		{
			_ReadOnly = true;
		}
	}

	public void Clear()
	{
		if (_ReadOnly)
		{
			throw new NotSupportedException();
		}
		OnClear();
		_Hashtable.Clear();
		OnClearComplete();
	}

	protected virtual void OnAdd(SettingsProperty property)
	{
	}

	protected virtual void OnAddComplete(SettingsProperty property)
	{
	}

	protected virtual void OnClear()
	{
	}

	protected virtual void OnClearComplete()
	{
	}

	protected virtual void OnRemove(SettingsProperty property)
	{
	}

	protected virtual void OnRemoveComplete(SettingsProperty property)
	{
	}

	public void CopyTo(Array array, int index)
	{
		_Hashtable.Values.CopyTo(array, index);
	}

	private SettingsPropertyCollection(Hashtable h)
	{
		_Hashtable = (Hashtable)h.Clone();
	}
}
