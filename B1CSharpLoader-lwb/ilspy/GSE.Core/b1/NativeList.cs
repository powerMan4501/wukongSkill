using System;
using System.Diagnostics;

namespace b1;

[DebuggerDisplay("Length = {Length}")]
[DebuggerTypeProxy(typeof(NativeListDebugView<>))]
public struct NativeList<T> : IDisposable where T : unmanaged
{
	internal unsafe NativeListData* m_ListData;

	public unsafe IntPtr Address => new IntPtr(m_ListData);

	public unsafe T this[int index]
	{
		get
		{
			return ((T*)m_ListData->buffer)[index];
		}
		set
		{
			((T*)m_ListData->buffer)[index] = value;
		}
	}

	public unsafe int Length => m_ListData->length;

	public unsafe int Capacity
	{
		get
		{
			return m_ListData->capacity;
		}
		set
		{
			if (m_ListData->capacity != value)
			{
				void* ptr = UnsafeUtility.Malloc(value * sizeof(T), UnsafeUtility.AlignOf<T>());
				UnsafeUtility.MemCpy(ptr, m_ListData->buffer, m_ListData->length * sizeof(T));
				UnsafeUtility.Free(m_ListData->buffer);
				m_ListData->buffer = ptr;
				m_ListData->capacity = value;
			}
		}
	}

	public unsafe bool IsCreated => m_ListData != null;

	public NativeList(int capacity)
		: this(capacity, 2)
	{
	}

	private unsafe NativeList(int capacity, int stackDepth)
	{
		capacity = Math.Max(1, capacity);
		int cb = sizeof(T) * capacity;
		m_ListData = (NativeListData*)UnsafeUtility.Malloc(sizeof(NativeListData), UnsafeUtility.AlignOf<T>());
		m_ListData->buffer = UnsafeUtility.Malloc(cb, UnsafeUtility.AlignOf<T>());
		m_ListData->length = 0;
		m_ListData->capacity = capacity;
	}

	public unsafe void Add(T element)
	{
		if (m_ListData->length >= m_ListData->capacity)
		{
			Capacity = m_ListData->length + m_ListData->capacity * 2;
		}
		this[m_ListData->length++] = element;
	}

	public unsafe void AddRange(void* elements, int count)
	{
		if (m_ListData->length + count > m_ListData->capacity)
		{
			Capacity = m_ListData->length + count * 2;
		}
		int num = sizeof(T);
		UnsafeUtility.MemCpy((byte*)m_ListData->buffer + m_ListData->length * num, elements, num * count);
		m_ListData->length += count;
	}

	public unsafe void RemoveAtSwapBack(int index)
	{
		int num = m_ListData->length - 1;
		this[index] = this[num];
		m_ListData->length = num;
	}

	public unsafe bool RemoveKeepOrder(T element)
	{
		for (int i = 0; i < m_ListData->length; i++)
		{
			if (this[i].Equals(element))
			{
				int num = sizeof(T);
				long num2 = num * (m_ListData->length - i - 1);
				if (num2 > 0)
				{
					Buffer.MemoryCopy((byte*)m_ListData->buffer + (i + 1) * num, (byte*)m_ListData->buffer + i * num, num2, num2);
				}
				m_ListData->length = m_ListData->length - 1;
				return true;
			}
		}
		return false;
	}

	public unsafe void Dispose()
	{
		if (m_ListData != null)
		{
			UnsafeUtility.Free(m_ListData->buffer);
			UnsafeUtility.Free(m_ListData);
			m_ListData = null;
		}
	}

	public void Clear()
	{
		ResizeUninitialized(0);
	}

	public T[] ToArray()
	{
		T[] array = new T[Length];
		for (int i = 0; i < Length; i++)
		{
			array[i] = this[i];
		}
		return array;
	}

	public void CopyFrom(T[] array)
	{
		Clear();
		if (array != null)
		{
			foreach (T element in array)
			{
				Add(element);
			}
		}
	}

	public unsafe void ResizeUninitialized(int length)
	{
		Capacity = Math.Max(length, Capacity);
		m_ListData->length = length;
	}
}
