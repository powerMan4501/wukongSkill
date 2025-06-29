using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace b1;

public struct NativeArray<T> : IDisposable, IEnumerable<T>, IEnumerable, IEquatable<NativeArray<T>> where T : struct
{
	public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private NativeArray<T> m_Array;

		private int m_Index;

		public T Current => m_Array[m_Index];

		object IEnumerator.Current => Current;

		public Enumerator(ref NativeArray<T> array)
		{
			m_Array = array;
			m_Index = -1;
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			m_Index++;
			return m_Index < m_Array.Length;
		}

		public void Reset()
		{
			m_Index = -1;
		}
	}

	internal unsafe void* m_Buffer;

	internal int m_Length;

	internal int m_MinIndex;

	internal int m_MaxIndex;

	public int Length => m_Length;

	public unsafe T this[int index]
	{
		get
		{
			CheckElementReadAccess(index);
			return UnsafeUtility.ReadArrayElement<T>(m_Buffer, index);
		}
		set
		{
			UnsafeUtility.WriteArrayElement(m_Buffer, index, value);
		}
	}

	public unsafe bool IsCreated => m_Buffer != null;

	public NativeArray(int length)
	{
		Allocate(length, out this);
	}

	public NativeArray(T[] array)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		Allocate(array.Length, out this);
		Copy(array, this);
	}

	public NativeArray(int length, NativeArray<T> array)
	{
		Allocate(array.Length, out this);
		Copy(array, this);
	}

	private unsafe static void Allocate(int length, out NativeArray<T> array)
	{
		int num = UnsafeUtility.SizeOf<T>() * length;
		if (length < 0)
		{
			throw new ArgumentOutOfRangeException("length", "Length must be >= 0");
		}
		IsBlittableAndThrow();
		if (num > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException("length", $"Length * sizeof(T) cannot exceed {int.MaxValue} bytes");
		}
		array.m_Buffer = UnsafeUtility.Malloc(num, UnsafeUtility.AlignOf<T>());
		array.m_Length = length;
		array.m_MinIndex = 0;
		array.m_MaxIndex = length - 1;
	}

	internal static void IsBlittableAndThrow()
	{
		if (!UnsafeUtility.IsBlittable<T>())
		{
			throw new InvalidOperationException($"{typeof(T)} used in NativeArray<{typeof(T)}> must be blittable.");
		}
	}

	private void CheckElementReadAccess(int index)
	{
		if (index < m_MinIndex || index > m_MaxIndex)
		{
			FailOutOfRangeError(index);
		}
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CheckElementWriteAccess(int index)
	{
		if (index < m_MinIndex || index > m_MaxIndex)
		{
			FailOutOfRangeError(index);
		}
	}

	public unsafe void Dispose()
	{
		UnsafeUtility.Free(m_Buffer);
		m_Buffer = null;
		m_Length = 0;
	}

	public void CopyFrom(T[] array)
	{
		Copy(array, this);
	}

	public void CopyFrom(NativeArray<T> array)
	{
		Copy(array, this);
	}

	public void CopyTo(T[] array)
	{
		Copy(this, array);
	}

	public void CopyTo(NativeArray<T> array)
	{
		Copy(this, array);
	}

	public T[] ToArray()
	{
		T[] array = new T[Length];
		Copy(this, array, Length);
		return array;
	}

	private void FailOutOfRangeError(int index)
	{
		if (index >= Length || (m_MinIndex == 0 && m_MaxIndex == Length - 1))
		{
			throw new IndexOutOfRangeException($"Index {index} is out of range of '{Length}' Length.");
		}
		throw new IndexOutOfRangeException($"Index {index} is out of restricted IJobParallelFor range [{m_MinIndex}...{m_MaxIndex}] in ReadWriteBuffer." + "ReadWriteBuffers are restricted to only read & write the element at the job index. You can use double buffering strategies to avoid race conditions due to reading & writing in parallel to the same elements from a job.");
	}

	public IEnumerator<T> GetEnumerator()
	{
		return new Enumerator(ref this);
	}

	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return new Enumerator(ref this);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public unsafe bool Equals(NativeArray<T> other)
	{
		if (m_Buffer == other.m_Buffer)
		{
			return m_Length == other.m_Length;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (obj is NativeArray<T>)
		{
			return Equals((NativeArray<T>)obj);
		}
		return false;
	}

	public unsafe override int GetHashCode()
	{
		return ((int)m_Buffer * 397) ^ m_Length;
	}

	public static bool operator ==(NativeArray<T> left, NativeArray<T> right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(NativeArray<T> left, NativeArray<T> right)
	{
		return !left.Equals(right);
	}

	public static void Copy(NativeArray<T> src, NativeArray<T> dst)
	{
		if (src.Length != dst.Length)
		{
			throw new ArgumentException("source and destination length must be the same");
		}
		Copy(src, 0, dst, 0, src.Length);
	}

	public static void Copy(T[] src, NativeArray<T> dst)
	{
		if (src.Length != dst.Length)
		{
			throw new ArgumentException("source and destination length must be the same");
		}
		Copy(src, 0, dst, 0, src.Length);
	}

	public static void Copy(NativeArray<T> src, T[] dst)
	{
		if (src.Length != dst.Length)
		{
			throw new ArgumentException("source and destination length must be the same");
		}
		Copy(src, 0, dst, 0, src.Length);
	}

	public static void Copy(NativeArray<T> src, NativeArray<T> dst, int length)
	{
		Copy(src, 0, dst, 0, length);
	}

	public static void Copy(T[] src, NativeArray<T> dst, int length)
	{
		Copy(src, 0, dst, 0, length);
	}

	public static void Copy(NativeArray<T> src, T[] dst, int length)
	{
		Copy(src, 0, dst, 0, length);
	}

	public unsafe static void Copy(NativeArray<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length)
	{
		if (length < 0)
		{
			throw new ArgumentOutOfRangeException("length", "length must be equal or greater than zero.");
		}
		if (srcIndex < 0 || srcIndex > src.Length || (srcIndex == src.Length && src.Length > 0))
		{
			throw new ArgumentOutOfRangeException("srcIndex", "srcIndex is outside the range of valid indexes for the source NativeArray.");
		}
		if (dstIndex < 0 || dstIndex > dst.Length || (dstIndex == dst.Length && dst.Length > 0))
		{
			throw new ArgumentOutOfRangeException("dstIndex", "dstIndex is outside the range of valid indexes for the destination NativeArray.");
		}
		if (srcIndex + length > src.Length)
		{
			throw new ArgumentException("length is greater than the number of elements from srcIndex to the end of the source NativeArray.", "length");
		}
		if (dstIndex + length > dst.Length)
		{
			throw new ArgumentException("length is greater than the number of elements from dstIndex to the end of the destination NativeArray.", "length");
		}
		UnsafeUtility.MemCpy((byte*)dst.m_Buffer + dstIndex * UnsafeUtility.SizeOf<T>(), (byte*)src.m_Buffer + srcIndex * UnsafeUtility.SizeOf<T>(), length * UnsafeUtility.SizeOf<T>());
	}

	public unsafe static void Copy(T[] src, int srcIndex, NativeArray<T> dst, int dstIndex, int length)
	{
		if (src == null)
		{
			throw new ArgumentNullException("src");
		}
		if (length < 0)
		{
			throw new ArgumentOutOfRangeException("length", "length must be equal or greater than zero.");
		}
		if (srcIndex < 0 || srcIndex > src.Length || (srcIndex == src.Length && src.Length != 0))
		{
			throw new ArgumentOutOfRangeException("srcIndex", "srcIndex is outside the range of valid indexes for the source array.");
		}
		if (dstIndex < 0 || dstIndex > dst.Length || (dstIndex == dst.Length && dst.Length > 0))
		{
			throw new ArgumentOutOfRangeException("dstIndex", "dstIndex is outside the range of valid indexes for the destination NativeArray.");
		}
		if (srcIndex + length > src.Length)
		{
			throw new ArgumentException("length is greater than the number of elements from srcIndex to the end of the source array.", "length");
		}
		if (dstIndex + length > dst.Length)
		{
			throw new ArgumentException("length is greater than the number of elements from dstIndex to the end of the destination NativeArray.", "length");
		}
		GCHandle gCHandle = GCHandle.Alloc(src, GCHandleType.Pinned);
		IntPtr intPtr = gCHandle.AddrOfPinnedObject();
		UnsafeUtility.MemCpy((byte*)dst.m_Buffer + dstIndex * UnsafeUtility.SizeOf<T>(), (byte*)(void*)intPtr + srcIndex * UnsafeUtility.SizeOf<T>(), length * UnsafeUtility.SizeOf<T>());
		gCHandle.Free();
	}

	public unsafe static void Copy(NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length)
	{
		if (dst == null)
		{
			throw new ArgumentNullException("dst");
		}
		if (length < 0)
		{
			throw new ArgumentOutOfRangeException("length", "length must be equal or greater than zero.");
		}
		if (srcIndex < 0 || srcIndex > src.Length || (srcIndex == src.Length && src.Length > 0))
		{
			throw new ArgumentOutOfRangeException("srcIndex", "srcIndex is outside the range of valid indexes for the source NativeArray.");
		}
		if (dstIndex < 0 || dstIndex > dst.Length || (dstIndex == dst.Length && dst.Length != 0))
		{
			throw new ArgumentOutOfRangeException("dstIndex", "dstIndex is outside the range of valid indexes for the destination array.");
		}
		if (srcIndex + length > src.Length)
		{
			throw new ArgumentException("length is greater than the number of elements from srcIndex to the end of the source NativeArray.", "length");
		}
		if (dstIndex + length > dst.Length)
		{
			throw new ArgumentException("length is greater than the number of elements from dstIndex to the end of the destination array.", "length");
		}
		GCHandle gCHandle = GCHandle.Alloc(dst, GCHandleType.Pinned);
		UnsafeUtility.MemCpy((byte*)(void*)gCHandle.AddrOfPinnedObject() + dstIndex * UnsafeUtility.SizeOf<T>(), (byte*)src.m_Buffer + srcIndex * UnsafeUtility.SizeOf<T>(), length * UnsafeUtility.SizeOf<T>());
		gCHandle.Free();
	}
}
