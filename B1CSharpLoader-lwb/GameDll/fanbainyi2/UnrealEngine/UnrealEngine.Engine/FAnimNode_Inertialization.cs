using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimNode_Inertialization", "Engine", UnrealModuleType.Engine)]
public struct FAnimNode_Inertialization
{
	private static bool Source_IsValid;

	private static int Source_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Engine.AnimNode_Inertialization:Source")]
	public FPoseLink Source;

	private static bool FilteredCurves_IsValid;

	private static FFieldAddress FilteredCurves_PropertyAddress;

	private static int FilteredCurves_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Engine.AnimNode_Inertialization:FilteredCurves")]
	public List<FName> FilteredCurves;

	private static bool FAnimNode_Inertialization_IsValid;

	private static int FAnimNode_Inertialization_StructSize;

	public FAnimNode_Inertialization Copy()
	{
		FAnimNode_Inertialization result = this;
		if (FilteredCurves != null)
		{
			result.FilteredCurves = new List<FName>(FilteredCurves);
		}
		return result;
	}

	public static FAnimNode_Inertialization FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_Inertialization(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_Inertialization value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_Inertialization FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_Inertialization(nativeBuffer + arrayIndex * FAnimNode_Inertialization_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_Inertialization value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_Inertialization_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_Inertialization_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNode_Inertialization");
			return;
		}
		FPoseLink.ToNative(IntPtr.Add(nativeStruct, Source_Offset), Source);
		new TArrayCopyMarshaler<FName>(1, FilteredCurves_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, FilteredCurves_Offset), FilteredCurves);
	}

	public FAnimNode_Inertialization(IntPtr nativeStruct)
	{
		if (!FAnimNode_Inertialization_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNode_Inertialization");
			Source = default(FPoseLink);
			FilteredCurves = null;
		}
		else
		{
			Source = FPoseLink.FromNative(IntPtr.Add(nativeStruct, Source_Offset));
			FilteredCurves = new TArrayCopyMarshaler<FName>(1, FilteredCurves_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, FilteredCurves_Offset));
		}
	}

	static FAnimNode_Inertialization()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_Inertialization)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_Inertialization));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AnimNode_Inertialization");
		FAnimNode_Inertialization_StructSize = NativeReflection.GetStructSize(intPtr);
		Source_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Source");
		Source_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Source", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FilteredCurves_PropertyAddress, intPtr, "FilteredCurves");
		FilteredCurves_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilteredCurves");
		FilteredCurves_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilteredCurves", Classes.FArrayProperty);
		FAnimNode_Inertialization_IsValid = intPtr != IntPtr.Zero && Source_IsValid && FilteredCurves_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimNode_Inertialization", FAnimNode_Inertialization_IsValid);
	}
}
