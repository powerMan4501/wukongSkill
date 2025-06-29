using System;

namespace b1;

public class WeakReferenceList<T> where T : class
{
	public WeakReference<T>[] Items;

	public int Count;

	public int Capacity
	{
		get
		{
			return Items.Length;
		}
		set
		{
			if (value < Count)
			{
				throw new ArgumentException();
			}
			WeakReference<T>[] array = new WeakReference<T>[value];
			if (Count > 0 && Items != null)
			{
				Array.Copy(Items, 0, array, 0, Items.Length);
			}
			Items = array;
			for (int num = Items.Length - 1; num >= 0; num--)
			{
				if (Items[num] == null)
				{
					Items[num] = new WeakReference<T>(null);
				}
			}
		}
	}

	public WeakReferenceList()
	{
		Capacity = 16384;
	}

	public void Add(T Item)
	{
		Count++;
		EnsureCapacity(Count);
		Items[Count - 1].SetTarget(Item);
	}

	private void EnsureCapacity(int min)
	{
		if (Items.Length < min)
		{
			int num = ((Items.Length == 0) ? 4 : (Items.Length * 2));
			if ((uint)num > 2146435071u)
			{
				num = 2146435071;
			}
			if (num < min)
			{
				num = min;
			}
			Capacity = num;
		}
	}

	public void Clear()
	{
		for (int i = 0; i < Count; i++)
		{
			Items[i].SetTarget(null);
		}
		Count = 0;
	}
}
