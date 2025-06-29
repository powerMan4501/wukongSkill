using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public struct FScriptBitArray
{
	private FDefaultBitArrayAllocator AllocatorInstance;

	public int NumBits;

	public int MaxBits;

	public FBitReference this[int index] => Native_FScriptBitArray.Get(ref this, index);

	public bool IsValidIndex(int index)
	{
		return Native_FScriptBitArray.IsValidIndex(ref this, index);
	}

	public void Empty(int slack = 0)
	{
		Native_FScriptBitArray.Empty(ref this, slack);
	}

	public int Add(bool value)
	{
		return Native_FScriptBitArray.Add(ref this, value);
	}

	public void Destroy()
	{
		Native_FScriptBitArray.Destroy(ref this);
	}
}
