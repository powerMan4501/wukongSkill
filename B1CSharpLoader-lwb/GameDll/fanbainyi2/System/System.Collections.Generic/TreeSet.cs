using System.Runtime.Serialization;

namespace System.Collections.Generic;

[Serializable]
internal class TreeSet<T> : SortedSet<T>
{
	public TreeSet()
	{
	}

	public TreeSet(IComparer<T> comparer)
		: base(comparer)
	{
	}

	public TreeSet(ICollection<T> collection)
		: base((IEnumerable<T>)collection)
	{
	}

	public TreeSet(ICollection<T> collection, IComparer<T> comparer)
		: base((IEnumerable<T>)collection, comparer)
	{
	}

	public TreeSet(SerializationInfo siInfo, StreamingContext context)
		: base(siInfo, context)
	{
	}

	internal override bool AddIfNotPresent(T item)
	{
		bool flag = base.AddIfNotPresent(item);
		if (!flag)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_AddingDuplicate);
		}
		return flag;
	}
}
