using System;
using UnrealEngine.Runtime;

namespace b1.ECS;

public struct NativeStream : IDisposable
{
	public struct Writer
	{
		private unsafe byte* mStart;

		private int CurIndex;

		private int Capacity;

		internal unsafe Writer(ref NativeStream stream)
		{
			mStart = stream.mData;
			Capacity = stream.Capacity;
			CurIndex = 0;
		}

		public unsafe void Write<T>(ref T value) where T : unmanaged
		{
			int num = sizeof(T);
			if (Capacity < CurIndex + num)
			{
				throw new Exception("Writing out of bounds");
			}
			T* ptr = (T*)(mStart + CurIndex);
			*ptr = value;
			CurIndex += num;
		}
	}

	public struct Reader
	{
		private unsafe byte* mStart;

		private int CurIndex;

		private int Capacity;

		internal unsafe Reader(ref NativeStream stream)
		{
			mStart = stream.mData;
			Capacity = stream.Capacity;
			CurIndex = 0;
		}

		public unsafe IntPtr ReadPtrBySize(int Size)
		{
			if (Capacity < CurIndex + Size)
			{
				throw new Exception("Reading out of bounds");
			}
			IntPtr result = (IntPtr)(mStart + CurIndex);
			CurIndex += Size;
			return result;
		}

		public unsafe void Read<T>(ref T Buffer) where T : unmanaged
		{
			int num = sizeof(T);
			if (Capacity < CurIndex + num)
			{
				throw new Exception("Reading out of bounds");
			}
			T* ptr = (T*)(mStart + CurIndex);
			Buffer = *ptr;
			CurIndex += num;
		}
	}

	private unsafe byte* mData;

	private int Capacity;

	public unsafe NativeStream(int Capacity)
	{
		this.Capacity = Capacity;
		mData = (byte*)(void*)FMemory.Malloc(Capacity);
	}

	public Reader AsReader()
	{
		return new Reader(ref this);
	}

	public Writer AsWriter()
	{
		return new Writer(ref this);
	}

	public unsafe void Dispose()
	{
		if (mData != null)
		{
			FMemory.Free((IntPtr)mData);
			mData = null;
		}
	}
}
