using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Net.Mail;

public sealed class AttachmentCollection : Collection<Attachment>, IDisposable
{
	private bool disposed;

	internal AttachmentCollection()
	{
	}

	public void Dispose()
	{
		if (disposed)
		{
			return;
		}
		using (IEnumerator<Attachment> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Attachment current = enumerator.Current;
				current.Dispose();
			}
		}
		Clear();
		disposed = true;
	}

	protected override void RemoveItem(int index)
	{
		if (disposed)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		base.RemoveItem(index);
	}

	protected override void ClearItems()
	{
		if (disposed)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		base.ClearItems();
	}

	protected override void SetItem(int index, Attachment item)
	{
		if (disposed)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		base.SetItem(index, item);
	}

	protected override void InsertItem(int index, Attachment item)
	{
		if (disposed)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		base.InsertItem(index, item);
	}
}
