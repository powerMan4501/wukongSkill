using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_RandomPlayer", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_RandomPlayer
{
	private static bool Entries_IsValid;

	private static FFieldAddress Entries_PropertyAddress;

	private static int Entries_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_RandomPlayer:Entries")]
	public List<FRandomPlayerSequenceEntry> Entries;

	private static bool ShuffleMode_IsValid;

	private static FFieldAddress ShuffleMode_PropertyAddress;

	private static int ShuffleMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_RandomPlayer:bShuffleMode")]
	public bool ShuffleMode;

	private static bool FAnimNode_RandomPlayer_IsValid;

	private static int FAnimNode_RandomPlayer_StructSize;

	public FAnimNode_RandomPlayer Copy()
	{
		FAnimNode_RandomPlayer result = this;
		if (Entries != null)
		{
			result.Entries = new List<FRandomPlayerSequenceEntry>(Entries);
		}
		return result;
	}

	public static FAnimNode_RandomPlayer FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_RandomPlayer(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_RandomPlayer value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_RandomPlayer FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_RandomPlayer(nativeBuffer + arrayIndex * FAnimNode_RandomPlayer_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_RandomPlayer value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_RandomPlayer_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_RandomPlayer_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_RandomPlayer");
			return;
		}
		new TArrayCopyMarshaler<FRandomPlayerSequenceEntry>(1, Entries_PropertyAddress, CachedMarshalingDelegates<FRandomPlayerSequenceEntry, FRandomPlayerSequenceEntry>.FromNative, CachedMarshalingDelegates<FRandomPlayerSequenceEntry, FRandomPlayerSequenceEntry>.ToNative).ToNative(IntPtr.Add(nativeStruct, Entries_Offset), Entries);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ShuffleMode_Offset), 0, ShuffleMode_PropertyAddress.Address, ShuffleMode);
	}

	public FAnimNode_RandomPlayer(IntPtr nativeStruct)
	{
		if (!FAnimNode_RandomPlayer_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_RandomPlayer");
			Entries = null;
			ShuffleMode = false;
		}
		else
		{
			Entries = new TArrayCopyMarshaler<FRandomPlayerSequenceEntry>(1, Entries_PropertyAddress, CachedMarshalingDelegates<FRandomPlayerSequenceEntry, FRandomPlayerSequenceEntry>.FromNative, CachedMarshalingDelegates<FRandomPlayerSequenceEntry, FRandomPlayerSequenceEntry>.ToNative).FromNative(IntPtr.Add(nativeStruct, Entries_Offset));
			ShuffleMode = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ShuffleMode_Offset), 0, ShuffleMode_PropertyAddress.Address);
		}
	}

	static FAnimNode_RandomPlayer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_RandomPlayer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_RandomPlayer));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_RandomPlayer");
		FAnimNode_RandomPlayer_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Entries_PropertyAddress, intPtr, "Entries");
		Entries_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Entries");
		Entries_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Entries", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ShuffleMode_PropertyAddress, intPtr, "bShuffleMode");
		ShuffleMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShuffleMode");
		ShuffleMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShuffleMode", Classes.FBoolProperty);
		FAnimNode_RandomPlayer_IsValid = intPtr != IntPtr.Zero && Entries_IsValid && ShuffleMode_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_RandomPlayer", FAnimNode_RandomPlayer_IsValid);
	}
}
