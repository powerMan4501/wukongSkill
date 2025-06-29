using System.Collections;
using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public class ListSortDescriptionCollection : IList, ICollection, IEnumerable
{
	private ArrayList sorts = new ArrayList();

	public ListSortDescription this[int index]
	{
		get
		{
			return (ListSortDescription)sorts[index];
		}
		set
		{
			throw new InvalidOperationException(SR.GetString("CantModifyListSortDescriptionCollection"));
		}
	}

	bool IList.IsFixedSize => true;

	bool IList.IsReadOnly => true;

	object IList.this[int index]
	{
		get
		{
			return this[index];
		}
		set
		{
			throw new InvalidOperationException(SR.GetString("CantModifyListSortDescriptionCollection"));
		}
	}

	public int Count => sorts.Count;

	bool ICollection.IsSynchronized => true;

	object ICollection.SyncRoot => this;

	public ListSortDescriptionCollection()
	{
	}

	public ListSortDescriptionCollection(ListSortDescription[] sorts)
	{
		if (sorts != null)
		{
			for (int i = 0; i < sorts.Length; i++)
			{
				this.sorts.Add(sorts[i]);
			}
		}
	}

	int IList.Add(object value)
	{
		throw new InvalidOperationException(SR.GetString("CantModifyListSortDescriptionCollection"));
	}

	void IList.Clear()
	{
		throw new InvalidOperationException(SR.GetString("CantModifyListSortDescriptionCollection"));
	}

	public bool Contains(object value)
	{
		return ((IList)sorts).Contains(value);
	}

	public int IndexOf(object value)
	{
		return ((IList)sorts).IndexOf(value);
	}

	void IList.Insert(int index, object value)
	{
		throw new InvalidOperationException(SR.GetString("CantModifyListSortDescriptionCollection"));
	}

	void IList.Remove(object value)
	{
		throw new InvalidOperationException(SR.GetString("CantModifyListSortDescriptionCollection"));
	}

	void IList.RemoveAt(int index)
	{
		throw new InvalidOperationException(SR.GetString("CantModifyListSortDescriptionCollection"));
	}

	public void CopyTo(Array array, int index)
	{
		sorts.CopyTo(array, index);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return sorts.GetEnumerator();
	}
}
