using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.RandomAnims")]
public struct FRandomAnims
{
	[Category("Anims")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.RandomAnims:AnimSequences")]
	public List<UAnimSequence> AnimSequences;

	private static int RandomAnims_StructSize;

	private static int RandomAnims_IsValid;

	private static bool AnimSequences_IsValid;

	private static int AnimSequences_Offset;

	private static FFieldAddress AnimSequences_PropertyAddress;

	public FRandomAnims Copy()
	{
		FRandomAnims result = this;
		if (AnimSequences != null)
		{
			result.AnimSequences = new List<UAnimSequence>(AnimSequences);
		}
		return result;
	}

	public static FRandomAnims FromNative(IntPtr nativeBuffer)
	{
		return new FRandomAnims(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRandomAnims value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRandomAnims FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRandomAnims(IntPtr.Add(nativeBuffer, arrayIndex * RandomAnims_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRandomAnims value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * RandomAnims_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (RandomAnims_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.RandomAnims");
		}
		else
		{
			new TArrayCopyMarshaler<UAnimSequence>(1, AnimSequences_PropertyAddress, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.FromNative, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.ToNative).ToNative(IntPtr.Add(nativeStruct, AnimSequences_Offset), AnimSequences);
		}
	}

	public FRandomAnims(IntPtr nativeStruct)
	{
		if (RandomAnims_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.RandomAnims");
			AnimSequences = null;
		}
		else
		{
			AnimSequences = new TArrayCopyMarshaler<UAnimSequence>(1, AnimSequences_PropertyAddress, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.FromNative, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.ToNative).FromNative(IntPtr.Add(nativeStruct, AnimSequences_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.RandomAnims");
		RandomAnims_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref AnimSequences_PropertyAddress, intPtr, "AnimSequences");
		AnimSequences_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimSequences");
		AnimSequences_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimSequences", Classes.FArrayProperty);
		RandomAnims_IsValid = ((intPtr != IntPtr.Zero && AnimSequences_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.RandomAnims", (byte)RandomAnims_IsValid != 0);
	}

	static FRandomAnims()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FRandomAnims)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRandomAnims));
	}
}
