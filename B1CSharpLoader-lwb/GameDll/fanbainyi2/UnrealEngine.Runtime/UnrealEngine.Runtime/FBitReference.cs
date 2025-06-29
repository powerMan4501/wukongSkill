using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public struct FBitReference
{
	public IntPtr Data;

	public uint Mask;

	public bool Value
	{
		get
		{
			return Native_FBitReference.Get(ref this);
		}
		set
		{
			Native_FBitReference.Set(ref this, value);
		}
	}

	public void AtomicSet(bool value)
	{
		Native_FBitReference.AtomicSet(ref this, value);
	}
}
