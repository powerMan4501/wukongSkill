using System.Collections;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.WindowsRuntime;

internal sealed class CLRIReferenceArrayImpl<T> : CLRIPropertyValueImpl, IReferenceArray<T>, IPropertyValue, ICustomPropertyProvider, IList, ICollection, IEnumerable
{
	private T[] _value;

	private IList _list;

	public T[] Value => _value;

	Type ICustomPropertyProvider.Type => _value.GetType();

	object IList.this[int index]
	{
		get
		{
			return _list[index];
		}
		set
		{
			_list[index] = value;
		}
	}

	bool IList.IsReadOnly => _list.IsReadOnly;

	bool IList.IsFixedSize => _list.IsFixedSize;

	int ICollection.Count => _list.Count;

	object ICollection.SyncRoot => _list.SyncRoot;

	bool ICollection.IsSynchronized => _list.IsSynchronized;

	public CLRIReferenceArrayImpl(PropertyType type, T[] obj)
		: base(type, obj)
	{
		_value = obj;
		_list = _value;
	}

	public override string ToString()
	{
		if (_value != null)
		{
			return _value.ToString();
		}
		return base.ToString();
	}

	ICustomProperty ICustomPropertyProvider.GetCustomProperty(string name)
	{
		return ICustomPropertyProviderImpl.CreateProperty(_value, name);
	}

	ICustomProperty ICustomPropertyProvider.GetIndexedProperty(string name, Type indexParameterType)
	{
		return ICustomPropertyProviderImpl.CreateIndexedProperty(_value, name, indexParameterType);
	}

	string ICustomPropertyProvider.GetStringRepresentation()
	{
		return _value.ToString();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable)_value).GetEnumerator();
	}

	int IList.Add(object value)
	{
		return _list.Add(value);
	}

	bool IList.Contains(object value)
	{
		return _list.Contains(value);
	}

	void IList.Clear()
	{
		_list.Clear();
	}

	int IList.IndexOf(object value)
	{
		return _list.IndexOf(value);
	}

	void IList.Insert(int index, object value)
	{
		_list.Insert(index, value);
	}

	void IList.Remove(object value)
	{
		_list.Remove(value);
	}

	void IList.RemoveAt(int index)
	{
		_list.RemoveAt(index);
	}

	void ICollection.CopyTo(Array array, int index)
	{
		_list.CopyTo(array, index);
	}

	[FriendAccessAllowed]
	internal static object UnboxHelper(object wrapper)
	{
		IReferenceArray<T> referenceArray = (IReferenceArray<T>)wrapper;
		return referenceArray.Value;
	}
}
