using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public struct TStatId
{
	private IntPtr statIdPtr;

	public IntPtr RawPointer => statIdPtr;

	public bool IsValid => !IsNone;

	public unsafe bool IsNone
	{
		get
		{
			if (statIdPtr == IntPtr.Zero)
			{
				return true;
			}
			return ((TStatIdData*)(void*)statIdPtr)->IsNone;
		}
	}

	public unsafe FName Name
	{
		get
		{
			if (statIdPtr == IntPtr.Zero)
			{
				return FName.None;
			}
			return ((TStatIdData*)(void*)statIdPtr)->Name.ToName();
		}
	}

	public string StatDescriptionANSI
	{
		get
		{
			if (Native_TStatId.GetStatDescriptionANSI == null)
			{
				return null;
			}
			if (statIdPtr == IntPtr.Zero)
			{
				return null;
			}
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_TStatId.GetStatDescriptionANSI(ref this, ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public string StatDescriptionWIDE
	{
		get
		{
			if (Native_TStatId.GetStatDescriptionWIDE == null)
			{
				return null;
			}
			if (statIdPtr == IntPtr.Zero)
			{
				return null;
			}
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_TStatId.GetStatDescriptionWIDE(ref this, ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}
}
