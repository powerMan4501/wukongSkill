using System.Collections;
using System.Collections.Specialized;
using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, Synchronization = true)]
public class PropertyDescriptorCollection : ICollection, IEnumerable, IList, IDictionary
{
	private class PropertyDescriptorEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private PropertyDescriptorCollection owner;

		private int index = -1;

		public object Current => Entry;

		public DictionaryEntry Entry
		{
			get
			{
				PropertyDescriptor propertyDescriptor = owner[index];
				return new DictionaryEntry(propertyDescriptor.Name, propertyDescriptor);
			}
		}

		public object Key => owner[index].Name;

		public object Value => owner[index].Name;

		public PropertyDescriptorEnumerator(PropertyDescriptorCollection owner)
		{
			this.owner = owner;
		}

		public bool MoveNext()
		{
			if (index < owner.Count - 1)
			{
				index++;
				return true;
			}
			return false;
		}

		public void Reset()
		{
			index = -1;
		}
	}

	public static readonly PropertyDescriptorCollection Empty = new PropertyDescriptorCollection(null, readOnly: true);

	private IDictionary cachedFoundProperties;

	private bool cachedIgnoreCase;

	private PropertyDescriptor[] properties;

	private int propCount;

	private string[] namedSort;

	private IComparer comparer;

	private bool propsOwned = true;

	private bool needSort;

	private bool readOnly;

	public int Count => propCount;

	public virtual PropertyDescriptor this[int index]
	{
		get
		{
			if (index >= propCount)
			{
				throw new IndexOutOfRangeException();
			}
			EnsurePropsOwned();
			return properties[index];
		}
	}

	public virtual PropertyDescriptor this[string name] => Find(name, ignoreCase: false);

	int ICollection.Count => Count;

	bool ICollection.IsSynchronized => false;

	object ICollection.SyncRoot => null;

	bool IDictionary.IsFixedSize => readOnly;

	bool IDictionary.IsReadOnly => readOnly;

	object IDictionary.this[object key]
	{
		get
		{
			if (key is string)
			{
				return this[(string)key];
			}
			return null;
		}
		set
		{
			if (readOnly)
			{
				throw new NotSupportedException();
			}
			if (value != null && !(value is PropertyDescriptor))
			{
				throw new ArgumentException("value");
			}
			int num = -1;
			if (key is int)
			{
				num = (int)key;
				if (num < 0 || num >= propCount)
				{
					throw new IndexOutOfRangeException();
				}
			}
			else
			{
				if (!(key is string))
				{
					throw new ArgumentException("key");
				}
				for (int i = 0; i < propCount; i++)
				{
					if (properties[i].Name.Equals((string)key))
					{
						num = i;
						break;
					}
				}
			}
			if (num == -1)
			{
				Add((PropertyDescriptor)value);
				return;
			}
			EnsurePropsOwned();
			properties[num] = (PropertyDescriptor)value;
			if (cachedFoundProperties != null && key is string)
			{
				cachedFoundProperties[key] = value;
			}
		}
	}

	ICollection IDictionary.Keys
	{
		get
		{
			string[] array = new string[propCount];
			for (int i = 0; i < propCount; i++)
			{
				array[i] = properties[i].Name;
			}
			return array;
		}
	}

	ICollection IDictionary.Values
	{
		get
		{
			if (properties.Length != propCount)
			{
				PropertyDescriptor[] array = new PropertyDescriptor[propCount];
				Array.Copy(properties, 0, array, 0, propCount);
				return array;
			}
			return (ICollection)properties.Clone();
		}
	}

	bool IList.IsReadOnly => readOnly;

	bool IList.IsFixedSize => readOnly;

	object IList.this[int index]
	{
		get
		{
			return this[index];
		}
		set
		{
			if (readOnly)
			{
				throw new NotSupportedException();
			}
			if (index >= propCount)
			{
				throw new IndexOutOfRangeException();
			}
			if (value != null && !(value is PropertyDescriptor))
			{
				throw new ArgumentException("value");
			}
			EnsurePropsOwned();
			properties[index] = (PropertyDescriptor)value;
		}
	}

	public PropertyDescriptorCollection(PropertyDescriptor[] properties)
	{
		this.properties = properties;
		if (properties == null)
		{
			this.properties = new PropertyDescriptor[0];
			propCount = 0;
		}
		else
		{
			propCount = properties.Length;
		}
		propsOwned = true;
	}

	public PropertyDescriptorCollection(PropertyDescriptor[] properties, bool readOnly)
		: this(properties)
	{
		this.readOnly = readOnly;
	}

	private PropertyDescriptorCollection(PropertyDescriptor[] properties, int propCount, string[] namedSort, IComparer comparer)
	{
		propsOwned = false;
		if (namedSort != null)
		{
			this.namedSort = (string[])namedSort.Clone();
		}
		this.comparer = comparer;
		this.properties = properties;
		this.propCount = propCount;
		needSort = true;
	}

	public int Add(PropertyDescriptor value)
	{
		if (readOnly)
		{
			throw new NotSupportedException();
		}
		EnsureSize(propCount + 1);
		properties[propCount++] = value;
		return propCount - 1;
	}

	public void Clear()
	{
		if (readOnly)
		{
			throw new NotSupportedException();
		}
		propCount = 0;
		cachedFoundProperties = null;
	}

	public bool Contains(PropertyDescriptor value)
	{
		return IndexOf(value) >= 0;
	}

	public void CopyTo(Array array, int index)
	{
		EnsurePropsOwned();
		Array.Copy(properties, 0, array, index, Count);
	}

	private void EnsurePropsOwned()
	{
		if (!propsOwned)
		{
			propsOwned = true;
			if (properties != null)
			{
				PropertyDescriptor[] destinationArray = new PropertyDescriptor[Count];
				Array.Copy(properties, 0, destinationArray, 0, Count);
				properties = destinationArray;
			}
		}
		if (needSort)
		{
			needSort = false;
			InternalSort(namedSort);
		}
	}

	private void EnsureSize(int sizeNeeded)
	{
		if (sizeNeeded > properties.Length)
		{
			if (properties == null || properties.Length == 0)
			{
				propCount = 0;
				properties = new PropertyDescriptor[sizeNeeded];
				return;
			}
			EnsurePropsOwned();
			int num = Math.Max(sizeNeeded, properties.Length * 2);
			PropertyDescriptor[] destinationArray = new PropertyDescriptor[num];
			Array.Copy(properties, 0, destinationArray, 0, propCount);
			properties = destinationArray;
		}
	}

	public virtual PropertyDescriptor Find(string name, bool ignoreCase)
	{
		lock (this)
		{
			PropertyDescriptor result = null;
			if (cachedFoundProperties == null || cachedIgnoreCase != ignoreCase)
			{
				cachedIgnoreCase = ignoreCase;
				cachedFoundProperties = new HybridDictionary(ignoreCase);
			}
			object obj = cachedFoundProperties[name];
			if (obj != null)
			{
				return (PropertyDescriptor)obj;
			}
			for (int i = 0; i < propCount; i++)
			{
				if (ignoreCase)
				{
					if (string.Equals(properties[i].Name, name, StringComparison.OrdinalIgnoreCase))
					{
						cachedFoundProperties[name] = properties[i];
						result = properties[i];
						break;
					}
				}
				else if (properties[i].Name.Equals(name))
				{
					cachedFoundProperties[name] = properties[i];
					result = properties[i];
					break;
				}
			}
			return result;
		}
	}

	public int IndexOf(PropertyDescriptor value)
	{
		return Array.IndexOf(properties, value, 0, propCount);
	}

	public void Insert(int index, PropertyDescriptor value)
	{
		if (readOnly)
		{
			throw new NotSupportedException();
		}
		EnsureSize(propCount + 1);
		if (index < propCount)
		{
			Array.Copy(properties, index, properties, index + 1, propCount - index);
		}
		properties[index] = value;
		propCount++;
	}

	public void Remove(PropertyDescriptor value)
	{
		if (readOnly)
		{
			throw new NotSupportedException();
		}
		int num = IndexOf(value);
		if (num != -1)
		{
			RemoveAt(num);
		}
	}

	public void RemoveAt(int index)
	{
		if (readOnly)
		{
			throw new NotSupportedException();
		}
		if (index < propCount - 1)
		{
			Array.Copy(properties, index + 1, properties, index, propCount - index - 1);
		}
		properties[propCount - 1] = null;
		propCount--;
	}

	public virtual PropertyDescriptorCollection Sort()
	{
		return new PropertyDescriptorCollection(properties, propCount, namedSort, comparer);
	}

	public virtual PropertyDescriptorCollection Sort(string[] names)
	{
		return new PropertyDescriptorCollection(properties, propCount, names, comparer);
	}

	public virtual PropertyDescriptorCollection Sort(string[] names, IComparer comparer)
	{
		return new PropertyDescriptorCollection(properties, propCount, names, comparer);
	}

	public virtual PropertyDescriptorCollection Sort(IComparer comparer)
	{
		return new PropertyDescriptorCollection(properties, propCount, namedSort, comparer);
	}

	protected void InternalSort(string[] names)
	{
		if (properties == null || properties.Length == 0)
		{
			return;
		}
		InternalSort(comparer);
		if (names == null || names.Length == 0)
		{
			return;
		}
		ArrayList arrayList = new ArrayList(properties);
		int num = 0;
		int num2 = properties.Length;
		for (int i = 0; i < names.Length; i++)
		{
			for (int j = 0; j < num2; j++)
			{
				PropertyDescriptor propertyDescriptor = (PropertyDescriptor)arrayList[j];
				if (propertyDescriptor != null && propertyDescriptor.Name.Equals(names[i]))
				{
					properties[num++] = propertyDescriptor;
					arrayList[j] = null;
					break;
				}
			}
		}
		for (int k = 0; k < num2; k++)
		{
			if (arrayList[k] != null)
			{
				properties[num++] = (PropertyDescriptor)arrayList[k];
			}
		}
	}

	protected void InternalSort(IComparer sorter)
	{
		if (sorter == null)
		{
			TypeDescriptor.SortDescriptorArray(this);
		}
		else
		{
			Array.Sort(properties, sorter);
		}
	}

	public virtual IEnumerator GetEnumerator()
	{
		EnsurePropsOwned();
		if (properties.Length != propCount)
		{
			PropertyDescriptor[] array = new PropertyDescriptor[propCount];
			Array.Copy(properties, 0, array, 0, propCount);
			return array.GetEnumerator();
		}
		return properties.GetEnumerator();
	}

	void IDictionary.Add(object key, object value)
	{
		if (!(value is PropertyDescriptor value2))
		{
			throw new ArgumentException("value");
		}
		Add(value2);
	}

	void IDictionary.Clear()
	{
		Clear();
	}

	bool IDictionary.Contains(object key)
	{
		if (key is string)
		{
			return this[(string)key] != null;
		}
		return false;
	}

	IDictionaryEnumerator IDictionary.GetEnumerator()
	{
		return new PropertyDescriptorEnumerator(this);
	}

	void IDictionary.Remove(object key)
	{
		if (key is string)
		{
			PropertyDescriptor propertyDescriptor = this[(string)key];
			if (propertyDescriptor != null)
			{
				((IList)this).Remove((object)propertyDescriptor);
			}
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	int IList.Add(object value)
	{
		return Add((PropertyDescriptor)value);
	}

	void IList.Clear()
	{
		Clear();
	}

	bool IList.Contains(object value)
	{
		return Contains((PropertyDescriptor)value);
	}

	int IList.IndexOf(object value)
	{
		return IndexOf((PropertyDescriptor)value);
	}

	void IList.Insert(int index, object value)
	{
		Insert(index, (PropertyDescriptor)value);
	}

	void IList.Remove(object value)
	{
		Remove((PropertyDescriptor)value);
	}

	void IList.RemoveAt(int index)
	{
		RemoveAt(index);
	}
}
