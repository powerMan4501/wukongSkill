using System;

namespace ILRuntime.Runtime.Stack;

public class StackObjectAllocator
{
	private MemoryBlockInfo[] freeBlocks;

	private StackObjectAllocateCallback allocCallback;

	public StackObjectAllocator(StackObjectAllocateCallback cb)
	{
		allocCallback = cb;
		freeBlocks = new MemoryBlockInfo[8];
	}

	public unsafe void Clear()
	{
		for (int i = 0; i < freeBlocks.Length && freeBlocks[i].StartAddress != null; i++)
		{
			freeBlocks[i] = default(MemoryBlockInfo);
		}
	}

	private void ExpandFreeList()
	{
		int num = Math.Min(freeBlocks.Length, 32);
		MemoryBlockInfo[] array = new MemoryBlockInfo[freeBlocks.Length + num];
		freeBlocks.CopyTo(array, 0);
		freeBlocks = array;
	}

	private unsafe void FreeBlock(int idx)
	{
		freeBlocks[idx].RequestAddress = null;
		int num = freeBlocks.Length;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = idx - 1;
		while (num5 >= 0 && freeBlocks[num5].RequestAddress == null)
		{
			idx = num5;
			num5--;
		}
		for (int i = idx + 1; i < num && freeBlocks[i].StartAddress != null && freeBlocks[i].RequestAddress == null; i++)
		{
			num2 += freeBlocks[i].Size;
			num3 += freeBlocks[i].ManagedCount;
			num4++;
		}
		if (num4 > 0)
		{
			freeBlocks[idx].Size += num2;
			freeBlocks[idx].ManagedCount += num3;
			int num6 = idx + num4 + 1;
			if (num6 < freeBlocks.Length)
			{
				Array.Copy(freeBlocks, num6, freeBlocks, idx + 1, num - num6);
			}
			for (int j = num - num4; j < num; j++)
			{
				freeBlocks[j] = default(MemoryBlockInfo);
			}
		}
	}

	public unsafe void FreeBefore(StackObject* ptr)
	{
		int num = -1;
		int num2 = freeBlocks.Length;
		for (int i = 0; i < num2 && freeBlocks[i].StartAddress != null; i++)
		{
			if (freeBlocks[i].StartAddress <= ptr)
			{
				freeBlocks[i] = default(MemoryBlockInfo);
				if (num < 0)
				{
					num = i;
				}
			}
		}
		if (num < 0)
		{
			return;
		}
		int num3 = 0;
		for (int j = num; j < num2; j++)
		{
			if (freeBlocks[j].StartAddress != null && num3 != j)
			{
				freeBlocks[num3++] = freeBlocks[j];
			}
		}
	}

	public unsafe void Free(StackObject* ptr)
	{
		int num = freeBlocks.Length;
		for (int i = 0; i < num && freeBlocks[i].StartAddress != null; i++)
		{
			if (freeBlocks[i].RequestAddress == ptr)
			{
				FreeBlock(i);
				break;
			}
		}
	}

	public unsafe void RegisterAllocation(StackObject* ptr, StackObject* src, int size, int managedIndex, int managedCount)
	{
		int num = -1;
		int num2 = freeBlocks.Length;
		for (int i = 0; i < num2; i++)
		{
			if (freeBlocks[i].StartAddress == null)
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			num = freeBlocks.Length;
			ExpandFreeList();
		}
		allocCallback(size, out var ptr2, out var managedIdx);
		if (ptr2 != src)
		{
			throw new NotSupportedException();
		}
		freeBlocks[num] = new MemoryBlockInfo
		{
			StartAddress = ptr2,
			RequestAddress = ptr,
			Size = size,
			ManagedCount = managedCount,
			ManagedIndex = ((managedIndex != int.MaxValue) ? managedIndex : managedIdx)
		};
	}

	public unsafe bool AllocExisting(StackObject* ptr, int size, int managedSize, out StackObjectAllocation alloc)
	{
		int num = freeBlocks.Length;
		for (int i = 0; i < num && freeBlocks[i].StartAddress != null; i++)
		{
			if ((freeBlocks[i].RequestAddress == ptr || freeBlocks[i].RequestAddress == null) && freeBlocks[i].Size >= size && freeBlocks[i].ManagedCount >= managedSize)
			{
				freeBlocks[i].RequestAddress = ptr;
				alloc = new StackObjectAllocation
				{
					Address = freeBlocks[i].StartAddress,
					ManagedIndex = freeBlocks[i].ManagedIndex
				};
				return true;
			}
		}
		alloc = default(StackObjectAllocation);
		return false;
	}

	public unsafe StackObjectAllocation Alloc(StackObject* ptr, int size, int managedSize)
	{
		int num = -1;
		int num2 = -1;
		int num3 = freeBlocks.Length;
		for (int i = 0; i < num3; i++)
		{
			if (freeBlocks[i].StartAddress == null)
			{
				num2 = i;
				break;
			}
			if (freeBlocks[i].RequestAddress == ptr)
			{
				if (freeBlocks[i].Size >= size && freeBlocks[i].ManagedCount >= managedSize)
				{
					return new StackObjectAllocation
					{
						Address = freeBlocks[i].StartAddress,
						ManagedIndex = freeBlocks[i].ManagedIndex
					};
				}
				FreeBlock(i);
			}
		}
		for (int j = 0; j < num3 && freeBlocks[j].StartAddress != null; j++)
		{
			if (freeBlocks[j].RequestAddress == null && freeBlocks[j].Size >= size && freeBlocks[j].ManagedCount >= managedSize)
			{
				num = j;
				break;
			}
		}
		if (num >= 0)
		{
			freeBlocks[num].RequestAddress = ptr;
			return new StackObjectAllocation
			{
				Address = freeBlocks[num].StartAddress,
				ManagedIndex = freeBlocks[num].ManagedIndex
			};
		}
		if (num2 == -1)
		{
			num2 = freeBlocks.Length;
			ExpandFreeList();
		}
		StackObjectAllocation result = default(StackObjectAllocation);
		allocCallback(size, out result.Address, out result.ManagedIndex);
		freeBlocks[num2] = new MemoryBlockInfo
		{
			StartAddress = result.Address,
			RequestAddress = ptr,
			Size = size,
			ManagedCount = managedSize,
			ManagedIndex = result.ManagedIndex
		};
		return result;
	}
}
