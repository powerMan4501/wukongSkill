using System;

namespace b1;

internal struct NativeHashMapData
{
	private const int CacheLineSize = 64;

	public const int MaxJobThreadCount = 128;

	public unsafe byte* values;

	public unsafe byte* keys;

	public unsafe byte* next;

	public unsafe byte* buckets;

	public int keyCapacity;

	public int bucketCapacityMask;

	private unsafe fixed byte padding1[60];

	public const int IntsPerCacheLine = 16;

	public unsafe fixed int firstFreeTLS[2048];

	public int allocatedIndexLength;

	private static int CeilPow2(int i)
	{
		i--;
		i |= i >> 1;
		i |= i >> 2;
		i |= i >> 4;
		i |= i >> 8;
		i |= i >> 16;
		return i + 1;
	}

	public static int GetBucketSize(int capacity)
	{
		return capacity * 2;
	}

	public static int GrowCapacity(int capacity)
	{
		if (capacity == 0)
		{
			return 1;
		}
		return capacity * 2;
	}

	public unsafe static void AllocateHashMap<TKey, TValue>(int length, int bucketLength, out NativeHashMapData* outBuf) where TKey : struct where TValue : struct
	{
		NativeHashMapData* ptr = (NativeHashMapData*)UnsafeUtility.Malloc(sizeof(NativeHashMapData), UnsafeUtility.AlignOf<NativeHashMapData>());
		bucketLength = CeilPow2(bucketLength);
		ptr->keyCapacity = length;
		ptr->bucketCapacityMask = bucketLength - 1;
		int keyOffset;
		int nextOffset;
		int bucketOffset;
		int cb = CalculateDataSize<TKey, TValue>(length, bucketLength, out keyOffset, out nextOffset, out bucketOffset);
		ptr->values = (byte*)UnsafeUtility.Malloc(cb, 64);
		ptr->keys = ptr->values + keyOffset;
		ptr->next = ptr->values + nextOffset;
		ptr->buckets = ptr->values + bucketOffset;
		outBuf = ptr;
	}

	public unsafe static void ReallocateHashMap<TKey, TValue>(NativeHashMapData* data, int newCapacity, int newBucketCapacity) where TKey : struct where TValue : struct
	{
		newBucketCapacity = CeilPow2(newBucketCapacity);
		if (data->keyCapacity == newCapacity && data->bucketCapacityMask + 1 == newBucketCapacity)
		{
			return;
		}
		if (data->keyCapacity > newCapacity)
		{
			throw new Exception("Shrinking a hash map is not supported");
		}
		int keyOffset;
		int nextOffset;
		int bucketOffset;
		byte* ptr = (byte*)UnsafeUtility.Malloc(CalculateDataSize<TKey, TValue>(newCapacity, newBucketCapacity, out keyOffset, out nextOffset, out bucketOffset), 64);
		byte* src = ptr + keyOffset;
		byte* ptr2 = ptr + nextOffset;
		byte* ptr3 = ptr + bucketOffset;
		UnsafeUtility.MemCpy(ptr, data->values, data->keyCapacity * UnsafeUtility.SizeOf<TValue>());
		UnsafeUtility.MemCpy(src, data->keys, data->keyCapacity * UnsafeUtility.SizeOf<TKey>());
		UnsafeUtility.MemCpy(ptr2, data->next, data->keyCapacity * 4);
		for (int i = data->keyCapacity; i < newCapacity; i++)
		{
			((int*)ptr2)[i] = -1;
		}
		for (int j = 0; j < newBucketCapacity; j++)
		{
			((int*)ptr3)[j] = -1;
		}
		for (int k = 0; k <= data->bucketCapacityMask; k++)
		{
			int* ptr4 = (int*)data->buckets;
			int* ptr5 = (int*)ptr2;
			while (ptr4[k] >= 0)
			{
				int num = ptr4[k];
				ptr4[k] = ptr5[num];
				int num2 = UnsafeUtility.ReadArrayElement<TKey>(data->keys, num).GetHashCode() & (newBucketCapacity - 1);
				ptr5[num] = ((int*)ptr3)[num2];
				((int*)ptr3)[num2] = num;
			}
		}
		UnsafeUtility.Free(data->values);
		if (data->allocatedIndexLength > data->keyCapacity)
		{
			data->allocatedIndexLength = data->keyCapacity;
		}
		data->values = ptr;
		data->keys = src;
		data->next = ptr2;
		data->buckets = ptr3;
		data->keyCapacity = newCapacity;
		data->bucketCapacityMask = newBucketCapacity - 1;
	}

	public unsafe static void DeallocateHashMap(NativeHashMapData* data)
	{
		UnsafeUtility.Free(data->values);
		data->values = null;
		data->keys = null;
		data->next = null;
		data->buckets = null;
		UnsafeUtility.Free(data);
	}

	private static int CalculateDataSize<TKey, TValue>(int length, int bucketLength, out int keyOffset, out int nextOffset, out int bucketOffset) where TKey : struct where TValue : struct
	{
		int num = UnsafeUtility.SizeOf<TValue>();
		int num2 = UnsafeUtility.SizeOf<TKey>();
		keyOffset = num * length + 64 - 1;
		keyOffset -= keyOffset % 64;
		nextOffset = keyOffset + num2 * length + 64 - 1;
		nextOffset -= nextOffset % 64;
		bucketOffset = nextOffset + UnsafeUtility.SizeOf<int>() * length + 64 - 1;
		bucketOffset -= bucketOffset % 64;
		return bucketOffset + UnsafeUtility.SizeOf<int>() * bucketLength;
	}

	public unsafe static void GetKeyArray<TKey>(NativeHashMapData* data, NativeArray<TKey> result) where TKey : struct
	{
		int* ptr = (int*)data->buckets;
		int* ptr2 = (int*)data->next;
		int num = 0;
		for (int i = 0; i <= data->bucketCapacityMask; i++)
		{
			for (int num2 = ptr[i]; num2 != -1; num2 = ptr2[num2])
			{
				result[num++] = UnsafeUtility.ReadArrayElement<TKey>(data->keys, num2);
			}
		}
		UnsafeUtility.NativeHelperAssert(result.Length == num);
	}

	public unsafe static void GetValueArray<TValue>(NativeHashMapData* data, NativeArray<TValue> result) where TValue : struct
	{
		int* ptr = (int*)data->buckets;
		int* ptr2 = (int*)data->next;
		int num = 0;
		for (int i = 0; i <= data->bucketCapacityMask; i++)
		{
			for (int num2 = ptr[i]; num2 != -1; num2 = ptr2[num2])
			{
				result[num++] = UnsafeUtility.ReadArrayElement<TValue>(data->values, num2);
			}
		}
		UnsafeUtility.NativeHelperAssert(result.Length == num);
	}
}
