using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public sealed class EventHandlerList : IDisposable
{
	private sealed class ListEntry
	{
		internal ListEntry next;

		internal object key;

		internal Delegate handler;

		public ListEntry(object key, Delegate handler, ListEntry next)
		{
			this.next = next;
			this.key = key;
			this.handler = handler;
		}
	}

	private ListEntry head;

	private Component parent;

	public Delegate this[object key]
	{
		get
		{
			ListEntry listEntry = null;
			if (parent == null || parent.CanRaiseEventsInternal)
			{
				listEntry = Find(key);
			}
			return listEntry?.handler;
		}
		set
		{
			ListEntry listEntry = Find(key);
			if (listEntry != null)
			{
				listEntry.handler = value;
			}
			else
			{
				head = new ListEntry(key, value, head);
			}
		}
	}

	public EventHandlerList()
	{
	}

	internal EventHandlerList(Component parent)
	{
		this.parent = parent;
	}

	public void AddHandler(object key, Delegate value)
	{
		ListEntry listEntry = Find(key);
		if (listEntry != null)
		{
			listEntry.handler = Delegate.Combine(listEntry.handler, value);
		}
		else
		{
			head = new ListEntry(key, value, head);
		}
	}

	public void AddHandlers(EventHandlerList listToAddFrom)
	{
		for (ListEntry next = listToAddFrom.head; next != null; next = next.next)
		{
			AddHandler(next.key, next.handler);
		}
	}

	public void Dispose()
	{
		head = null;
	}

	private ListEntry Find(object key)
	{
		ListEntry next = head;
		while (next != null && next.key != key)
		{
			next = next.next;
		}
		return next;
	}

	public void RemoveHandler(object key, Delegate value)
	{
		ListEntry listEntry = Find(key);
		if (listEntry != null)
		{
			listEntry.handler = Delegate.Remove(listEntry.handler, value);
		}
	}
}
