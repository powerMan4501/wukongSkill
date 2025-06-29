using System.Collections;
using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeNamespaceImportCollection : IList, ICollection, IEnumerable
{
	private ArrayList data = new ArrayList();

	private Hashtable keys = new Hashtable(StringComparer.OrdinalIgnoreCase);

	public CodeNamespaceImport this[int index]
	{
		get
		{
			return (CodeNamespaceImport)data[index];
		}
		set
		{
			data[index] = value;
			SyncKeys();
		}
	}

	public int Count => data.Count;

	bool IList.IsReadOnly => false;

	bool IList.IsFixedSize => false;

	object IList.this[int index]
	{
		get
		{
			return this[index];
		}
		set
		{
			this[index] = (CodeNamespaceImport)value;
			SyncKeys();
		}
	}

	int ICollection.Count => Count;

	bool ICollection.IsSynchronized => false;

	object ICollection.SyncRoot => null;

	public void Add(CodeNamespaceImport value)
	{
		if (!keys.ContainsKey(value.Namespace))
		{
			keys[value.Namespace] = value;
			data.Add(value);
		}
	}

	public void AddRange(CodeNamespaceImport[] value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		foreach (CodeNamespaceImport value2 in value)
		{
			Add(value2);
		}
	}

	public void Clear()
	{
		data.Clear();
		keys.Clear();
	}

	private void SyncKeys()
	{
		keys = new Hashtable(StringComparer.OrdinalIgnoreCase);
		IEnumerator enumerator = GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				CodeNamespaceImport codeNamespaceImport = (CodeNamespaceImport)enumerator.Current;
				keys[codeNamespaceImport.Namespace] = codeNamespaceImport;
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}
	}

	public IEnumerator GetEnumerator()
	{
		return data.GetEnumerator();
	}

	void ICollection.CopyTo(Array array, int index)
	{
		data.CopyTo(array, index);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	int IList.Add(object value)
	{
		return data.Add((CodeNamespaceImport)value);
	}

	void IList.Clear()
	{
		Clear();
	}

	bool IList.Contains(object value)
	{
		return data.Contains(value);
	}

	int IList.IndexOf(object value)
	{
		return data.IndexOf((CodeNamespaceImport)value);
	}

	void IList.Insert(int index, object value)
	{
		data.Insert(index, (CodeNamespaceImport)value);
		SyncKeys();
	}

	void IList.Remove(object value)
	{
		data.Remove((CodeNamespaceImport)value);
		SyncKeys();
	}

	void IList.RemoveAt(int index)
	{
		data.RemoveAt(index);
		SyncKeys();
	}
}
