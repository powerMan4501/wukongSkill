using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace UnrealEngine.Runtime;

[Serializable]
[DebuggerTypeProxy(typeof(TArrayDebugView<>))]
[DebuggerDisplay("Count = {Count}")]
public class TArrayUnsafe<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IDisposable
{
	public class Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private int index;

		private T current;

		private TArrayUnsafe<T> array;

		public T Current => current;

		object IEnumerator.Current => current;

		public Enumerator(TArrayUnsafe<T> array)
		{
			index = 0;
			this.array = array;
			current = default(T);
		}

		public void Dispose()
		{
		}

		public unsafe bool MoveNext()
		{
			if (array.nativeArray == null)
			{
				return false;
			}
			if (index < array.nativeArray->ArrayNum)
			{
				current = array[index];
				index++;
				return true;
			}
			return false;
		}

		public void Reset()
		{
			index = 0;
			current = default(T);
		}
	}

	private IntPtr address;

	private unsafe FScriptArray* nativeArray;

	private bool isUObject;

	private bool isString;

	private int numBytesPerElement;

	protected bool isRef;

	public unsafe IntPtr Address => (IntPtr)nativeArray;

	public unsafe FScriptArray ScriptArray => *nativeArray;

	public unsafe bool IsValid => nativeArray != null;

	public unsafe T this[int index]
	{
		get
		{
			if (!nativeArray->IsValidIndex(index))
			{
				throw new IndexOutOfRangeException();
			}
			IntPtr ptr = IntPtr.Add(nativeArray->Data, numBytesPerElement * index);
			if (isUObject)
			{
				return (T)(object)GCHelper.Find<UObject>(Marshal.ReadIntPtr(ptr));
			}
			if (isString)
			{
				return (T)(object)FStringMarshaler.FromPtr(ptr);
			}
			return (T)Marshal.PtrToStructure(ptr, typeof(T));
		}
		set
		{
			if (!nativeArray->IsValidIndex(index))
			{
				throw new IndexOutOfRangeException();
			}
			IntPtr intPtr = IntPtr.Add(nativeArray->Data, numBytesPerElement * index);
			if (isUObject)
			{
				if (value == null)
				{
					Marshal.WriteIntPtr(intPtr, IntPtr.Zero);
					return;
				}
				UObject uObject = (UObject)(object)value;
				Marshal.WriteIntPtr(intPtr, uObject.Address);
			}
			else if (isString)
			{
				FScriptArray* ptr = (FScriptArray*)(void*)intPtr;
				ptr->Destroy();
				string value2 = ((value == null) ? null : ((string)(object)value));
				if (!string.IsNullOrEmpty(value2))
				{
					FStringMarshaler.ToArray(intPtr, value2);
				}
			}
			else
			{
				Marshal.StructureToPtr(value, intPtr, fDeleteOld: false);
			}
		}
	}

	public unsafe int Count => nativeArray->Count;

	public bool IsReadOnly => false;

	public unsafe TArrayUnsafe(IntPtr native)
	{
		nativeArray = (FScriptArray*)(void*)native;
		ValidateType();
	}

	public unsafe TArrayUnsafe()
	{
		address = Marshal.AllocHGlobal(FScriptArray.StructSize);
		nativeArray = (FScriptArray*)(void*)address;
		nativeArray->Data = IntPtr.Zero;
		nativeArray->ArrayNum = 0;
		nativeArray->ArrayMax = 0;
		ValidateType();
	}

	public TArrayUnsafe(FScriptArray array)
		: this()
	{
		CopyFrom(array);
	}

	public unsafe void Dispose()
	{
		if (!isRef)
		{
			if (nativeArray != null)
			{
				Clear();
				nativeArray->Destroy();
				nativeArray = null;
			}
			if (address != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(address);
				address = IntPtr.Zero;
			}
		}
	}

	private void ValidateType()
	{
		if (typeof(T).IsSameOrSubclassOf(typeof(UObject)))
		{
			isUObject = true;
			numBytesPerElement = IntPtr.Size;
			return;
		}
		if (typeof(T) == typeof(string))
		{
			isString = true;
			numBytesPerElement = FScriptArray.StructSize;
			return;
		}
		if (typeof(T).IsValueType)
		{
			numBytesPerElement = Marshal.SizeOf(typeof(T));
			return;
		}
		throw new InvalidOperationException("TArray can only work with UnrealObject types and value types.");
	}

	public unsafe void CopyFrom(FScriptArray array)
	{
		Clear();
		nativeArray->AddZeroed(numBytesPerElement, array.Count);
		for (int i = 0; i < array.Count; i++)
		{
			IntPtr intPtr = IntPtr.Add(nativeArray->Data, numBytesPerElement * i);
			if (isUObject)
			{
				Add((T)(object)GCHelper.Find<UObject>(intPtr));
			}
			else if (isString)
			{
				Add((T)(object)FStringMarshaler.FromPtr(intPtr));
			}
			else
			{
				Add((T)Marshal.PtrToStructure(intPtr, typeof(T)));
			}
		}
	}

	public int IndexOf(T item)
	{
		int count = Count;
		for (int i = 0; i < count; i++)
		{
			if (this[i].Equals(item))
			{
				return i;
			}
		}
		return -1;
	}

	public unsafe void Insert(int index, T item)
	{
		nativeArray->InsertZeroed(index, numBytesPerElement);
		this[index] = item;
	}

	public unsafe void RemoveAt(int index)
	{
		if (isString)
		{
			this[index] = (T)(object)null;
		}
		nativeArray->RemoveAt(index, numBytesPerElement);
	}

	public unsafe void Add(T item)
	{
		int index = nativeArray->AddZeroed(numBytesPerElement);
		this[index] = item;
	}

	public unsafe void AddRange(T[] items)
	{
		if (items != null)
		{
			int num = nativeArray->AddZeroed(numBytesPerElement, items.Length);
			for (int i = 0; i < items.Length; i++)
			{
				this[num + i] = items[i];
			}
		}
	}

	public unsafe void AddRange(List<T> items)
	{
		if (items != null)
		{
			int num = nativeArray->AddZeroed(numBytesPerElement, items.Count);
			for (int i = 0; i < items.Count; i++)
			{
				this[num + i] = items[i];
			}
		}
	}

	public unsafe void Clear()
	{
		if (isString)
		{
			for (int i = 0; i < Count; i++)
			{
				this[i] = (T)(object)null;
			}
		}
		else if (typeof(T).IsAssignableFrom(typeof(IDisposable)))
		{
			for (int j = 0; j < Count; j++)
			{
				(this[j] as IDisposable).Dispose();
			}
		}
		nativeArray->Empty(0, numBytesPerElement);
	}

	public bool Contains(T item)
	{
		if (item == null)
		{
			using (Enumerator enumerator = GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current == null)
					{
						return true;
					}
				}
			}
			return false;
		}
		EqualityComparer<T> equalityComparer = EqualityComparer<T>.Default;
		using (Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				T current = enumerator.Current;
				if (equalityComparer.Equals(current, item))
				{
					return true;
				}
			}
		}
		return false;
	}

	public void CopyTo(T[] array, int arrayIndex)
	{
		int count = Count;
		for (int i = 0; i < count; i++)
		{
			array[i + arrayIndex] = this[i];
		}
	}

	public bool Remove(T item)
	{
		int num = IndexOf(item);
		if (num != -1)
		{
			RemoveAt(num);
		}
		return num != -1;
	}

	public Enumerator GetEnumerator()
	{
		return new Enumerator(this);
	}

	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return new Enumerator(this);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return new Enumerator(this);
	}
}
