using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.WeightedBlendables", "Engine", UnrealModuleType.Engine)]
public struct FWeightedBlendables
{
	private static bool Array_IsValid;

	private static FFieldAddress Array_PropertyAddress;

	private static int Array_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Engine.WeightedBlendables:Array")]
	public List<FWeightedBlendable> Array;

	private static bool FWeightedBlendables_IsValid;

	private static int FWeightedBlendables_StructSize;

	public FWeightedBlendables Copy()
	{
		FWeightedBlendables result = this;
		if (Array != null)
		{
			result.Array = new List<FWeightedBlendable>(Array);
		}
		return result;
	}

	public static FWeightedBlendables FromNative(IntPtr nativeBuffer)
	{
		return new FWeightedBlendables(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FWeightedBlendables value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FWeightedBlendables FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FWeightedBlendables(nativeBuffer + arrayIndex * FWeightedBlendables_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FWeightedBlendables value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FWeightedBlendables_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FWeightedBlendables_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.WeightedBlendables");
		}
		else
		{
			new TArrayCopyMarshaler<FWeightedBlendable>(1, Array_PropertyAddress, CachedMarshalingDelegates<FWeightedBlendable, FWeightedBlendable>.FromNative, CachedMarshalingDelegates<FWeightedBlendable, FWeightedBlendable>.ToNative).ToNative(IntPtr.Add(nativeStruct, Array_Offset), Array);
		}
	}

	public FWeightedBlendables(IntPtr nativeStruct)
	{
		if (!FWeightedBlendables_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.WeightedBlendables");
			Array = null;
		}
		else
		{
			Array = new TArrayCopyMarshaler<FWeightedBlendable>(1, Array_PropertyAddress, CachedMarshalingDelegates<FWeightedBlendable, FWeightedBlendable>.FromNative, CachedMarshalingDelegates<FWeightedBlendable, FWeightedBlendable>.ToNative).FromNative(IntPtr.Add(nativeStruct, Array_Offset));
		}
	}

	static FWeightedBlendables()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FWeightedBlendables)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FWeightedBlendables));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.WeightedBlendables");
		FWeightedBlendables_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Array_PropertyAddress, intPtr, "Array");
		Array_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Array");
		Array_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Array", Classes.FArrayProperty);
		FWeightedBlendables_IsValid = intPtr != IntPtr.Zero && Array_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.WeightedBlendables", FWeightedBlendables_IsValid);
	}
}
