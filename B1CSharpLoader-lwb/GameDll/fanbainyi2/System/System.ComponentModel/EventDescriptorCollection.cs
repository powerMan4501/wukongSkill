using System.Collections;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.ComponentModel;

[ComVisible(true)]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true)]
public class EventDescriptorCollection : ICollection, IEnumerable, IList
{
	private EventDescriptor[] events;

	private string[] namedSort;

	private IComparer comparer;

	private bool eventsOwned = true;

	private bool needSort;

	private int eventCount;

	private bool readOnly;

	public static readonly EventDescriptorCollection Empty = new EventDescriptorCollection(null, readOnly: true);

	public int Count => eventCount;

	public virtual EventDescriptor this[int index]
	{
		get
		{
			if (index >= eventCount)
			{
				throw new IndexOutOfRangeException();
			}
			EnsureEventsOwned();
			return events[index];
		}
	}

	public virtual EventDescriptor this[string name] => Find(name, ignoreCase: false);

	int ICollection.Count => Count;

	bool ICollection.IsSynchronized => false;

	object ICollection.SyncRoot => null;

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
			if (index >= eventCount)
			{
				throw new IndexOutOfRangeException();
			}
			EnsureEventsOwned();
			events[index] = (EventDescriptor)value;
		}
	}

	bool IList.IsReadOnly => readOnly;

	bool IList.IsFixedSize => readOnly;

	public EventDescriptorCollection(EventDescriptor[] events)
	{
		this.events = events;
		if (events == null)
		{
			this.events = new EventDescriptor[0];
			eventCount = 0;
		}
		else
		{
			eventCount = this.events.Length;
		}
		eventsOwned = true;
	}

	public EventDescriptorCollection(EventDescriptor[] events, bool readOnly)
		: this(events)
	{
		this.readOnly = readOnly;
	}

	private EventDescriptorCollection(EventDescriptor[] events, int eventCount, string[] namedSort, IComparer comparer)
	{
		eventsOwned = false;
		if (namedSort != null)
		{
			this.namedSort = (string[])namedSort.Clone();
		}
		this.comparer = comparer;
		this.events = events;
		this.eventCount = eventCount;
		needSort = true;
	}

	public int Add(EventDescriptor value)
	{
		if (readOnly)
		{
			throw new NotSupportedException();
		}
		EnsureSize(eventCount + 1);
		events[eventCount++] = value;
		return eventCount - 1;
	}

	public void Clear()
	{
		if (readOnly)
		{
			throw new NotSupportedException();
		}
		eventCount = 0;
	}

	public bool Contains(EventDescriptor value)
	{
		return IndexOf(value) >= 0;
	}

	void ICollection.CopyTo(Array array, int index)
	{
		EnsureEventsOwned();
		Array.Copy(events, 0, array, index, Count);
	}

	private void EnsureEventsOwned()
	{
		if (!eventsOwned)
		{
			eventsOwned = true;
			if (events != null)
			{
				EventDescriptor[] destinationArray = new EventDescriptor[Count];
				Array.Copy(events, 0, destinationArray, 0, Count);
				events = destinationArray;
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
		if (sizeNeeded > events.Length)
		{
			if (events == null || events.Length == 0)
			{
				eventCount = 0;
				events = new EventDescriptor[sizeNeeded];
				return;
			}
			EnsureEventsOwned();
			int num = Math.Max(sizeNeeded, events.Length * 2);
			EventDescriptor[] destinationArray = new EventDescriptor[num];
			Array.Copy(events, 0, destinationArray, 0, eventCount);
			events = destinationArray;
		}
	}

	public virtual EventDescriptor Find(string name, bool ignoreCase)
	{
		EventDescriptor result = null;
		if (ignoreCase)
		{
			for (int i = 0; i < Count; i++)
			{
				if (string.Equals(events[i].Name, name, StringComparison.OrdinalIgnoreCase))
				{
					result = events[i];
					break;
				}
			}
		}
		else
		{
			for (int j = 0; j < Count; j++)
			{
				if (string.Equals(events[j].Name, name, StringComparison.Ordinal))
				{
					result = events[j];
					break;
				}
			}
		}
		return result;
	}

	public int IndexOf(EventDescriptor value)
	{
		return Array.IndexOf(events, value, 0, eventCount);
	}

	public void Insert(int index, EventDescriptor value)
	{
		if (readOnly)
		{
			throw new NotSupportedException();
		}
		EnsureSize(eventCount + 1);
		if (index < eventCount)
		{
			Array.Copy(events, index, events, index + 1, eventCount - index);
		}
		events[index] = value;
		eventCount++;
	}

	public void Remove(EventDescriptor value)
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
		if (index < eventCount - 1)
		{
			Array.Copy(events, index + 1, events, index, eventCount - index - 1);
		}
		events[eventCount - 1] = null;
		eventCount--;
	}

	public IEnumerator GetEnumerator()
	{
		if (events.Length == eventCount)
		{
			return events.GetEnumerator();
		}
		return new ArraySubsetEnumerator(events, eventCount);
	}

	public virtual EventDescriptorCollection Sort()
	{
		return new EventDescriptorCollection(events, eventCount, namedSort, comparer);
	}

	public virtual EventDescriptorCollection Sort(string[] names)
	{
		return new EventDescriptorCollection(events, eventCount, names, comparer);
	}

	public virtual EventDescriptorCollection Sort(string[] names, IComparer comparer)
	{
		return new EventDescriptorCollection(events, eventCount, names, comparer);
	}

	public virtual EventDescriptorCollection Sort(IComparer comparer)
	{
		return new EventDescriptorCollection(events, eventCount, namedSort, comparer);
	}

	protected void InternalSort(string[] names)
	{
		if (events == null || events.Length == 0)
		{
			return;
		}
		InternalSort(comparer);
		if (names == null || names.Length == 0)
		{
			return;
		}
		ArrayList arrayList = new ArrayList(events);
		int num = 0;
		int num2 = events.Length;
		for (int i = 0; i < names.Length; i++)
		{
			for (int j = 0; j < num2; j++)
			{
				EventDescriptor eventDescriptor = (EventDescriptor)arrayList[j];
				if (eventDescriptor != null && eventDescriptor.Name.Equals(names[i]))
				{
					events[num++] = eventDescriptor;
					arrayList[j] = null;
					break;
				}
			}
		}
		for (int k = 0; k < num2; k++)
		{
			if (arrayList[k] != null)
			{
				events[num++] = (EventDescriptor)arrayList[k];
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
			Array.Sort(events, sorter);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	int IList.Add(object value)
	{
		return Add((EventDescriptor)value);
	}

	void IList.Clear()
	{
		Clear();
	}

	bool IList.Contains(object value)
	{
		return Contains((EventDescriptor)value);
	}

	int IList.IndexOf(object value)
	{
		return IndexOf((EventDescriptor)value);
	}

	void IList.Insert(int index, object value)
	{
		Insert(index, (EventDescriptor)value);
	}

	void IList.Remove(object value)
	{
		Remove((EventDescriptor)value);
	}

	void IList.RemoveAt(int index)
	{
		RemoveAt(index);
	}
}
