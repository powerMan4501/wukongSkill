using System.Runtime.InteropServices;

namespace System.Collections;

[Serializable]
[ComVisible(true)]
public abstract class ReadOnlyCollectionBase : ICollection, IEnumerable
{
	private ArrayList list;

	protected ArrayList InnerList
	{
		get
		{
			if (list == null)
			{
				list = new ArrayList();
			}
			return list;
		}
	}

	public virtual int Count => InnerList.Count;

	bool ICollection.IsSynchronized => InnerList.IsSynchronized;

	object ICollection.SyncRoot => InnerList.SyncRoot;

	void ICollection.CopyTo(Array array, int index)
	{
		InnerList.CopyTo(array, index);
	}

	public virtual IEnumerator GetEnumerator()
	{
		return InnerList.GetEnumerator();
	}
}
