using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Net.Mail;

public sealed class LinkedResourceCollection : Collection<LinkedResource>, IDisposable
{
	private bool disposed;

	internal LinkedResourceCollection()
	{
	}

	public void Dispose()
	{
		if (disposed)
		{
			return;
		}
		using (IEnumerator<LinkedResource> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				LinkedResource current = enumerator.Current;
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

	protected override void SetItem(int index, LinkedResource item)
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

	protected override void InsertItem(int index, LinkedResource item)
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
