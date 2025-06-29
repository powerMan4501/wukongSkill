using System.Collections;

namespace System.Diagnostics;

public class EventLogEntryCollection : ICollection, IEnumerable
{
	private class EntriesEnumerator : IEnumerator
	{
		private EventLogEntryCollection entries;

		private int num = -1;

		private EventLogEntry cachedEntry;

		public object Current
		{
			get
			{
				if (cachedEntry == null)
				{
					throw new InvalidOperationException(SR.GetString("NoCurrentEntry"));
				}
				return cachedEntry;
			}
		}

		internal EntriesEnumerator(EventLogEntryCollection entries)
		{
			this.entries = entries;
		}

		public bool MoveNext()
		{
			num++;
			cachedEntry = entries.GetEntryAtNoThrow(num);
			return cachedEntry != null;
		}

		public void Reset()
		{
			num = -1;
		}
	}

	private EventLogInternal log;

	public int Count => log.EntryCount;

	public virtual EventLogEntry this[int index] => log.GetEntryAt(index);

	bool ICollection.IsSynchronized => false;

	object ICollection.SyncRoot => this;

	internal EventLogEntryCollection(EventLogInternal log)
	{
		this.log = log;
	}

	public void CopyTo(EventLogEntry[] entries, int index)
	{
		((ICollection)this).CopyTo((Array)entries, index);
	}

	public IEnumerator GetEnumerator()
	{
		return new EntriesEnumerator(this);
	}

	internal EventLogEntry GetEntryAtNoThrow(int index)
	{
		return log.GetEntryAtNoThrow(index);
	}

	void ICollection.CopyTo(Array array, int index)
	{
		EventLogEntry[] allEntries = log.GetAllEntries();
		Array.Copy(allEntries, 0, array, index, allEntries.Length);
	}
}
