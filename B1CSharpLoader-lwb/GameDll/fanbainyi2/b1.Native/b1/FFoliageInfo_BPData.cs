using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.FoliageInfo_BPData", "FuncLibEditor", UnrealModuleType.Game)]
public struct FFoliageInfo_BPData
{
	private static bool Transforms_IsValid;

	private static FFieldAddress Transforms_PropertyAddress;

	private static int Transforms_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/FuncLibEditor.FoliageInfo_BPData:Transforms")]
	public List<FTransform> Transforms;

	private static bool FFoliageInfo_BPData_IsValid;

	private static int FFoliageInfo_BPData_StructSize;

	public FFoliageInfo_BPData Copy()
	{
		FFoliageInfo_BPData result = this;
		if (Transforms != null)
		{
			result.Transforms = new List<FTransform>(Transforms);
		}
		return result;
	}

	public static FFoliageInfo_BPData FromNative(IntPtr nativeBuffer)
	{
		return new FFoliageInfo_BPData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FFoliageInfo_BPData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FFoliageInfo_BPData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FFoliageInfo_BPData(nativeBuffer + arrayIndex * FFoliageInfo_BPData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FFoliageInfo_BPData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FFoliageInfo_BPData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FFoliageInfo_BPData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.FoliageInfo_BPData");
		}
		else
		{
			new TArrayCopyMarshaler<FTransform>(1, Transforms_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).ToNative(IntPtr.Add(nativeStruct, Transforms_Offset), Transforms);
		}
	}

	public FFoliageInfo_BPData(IntPtr nativeStruct)
	{
		if (!FFoliageInfo_BPData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.FoliageInfo_BPData");
			Transforms = null;
		}
		else
		{
			Transforms = new TArrayCopyMarshaler<FTransform>(1, Transforms_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).FromNative(IntPtr.Add(nativeStruct, Transforms_Offset));
		}
	}

	static FFoliageInfo_BPData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FFoliageInfo_BPData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFoliageInfo_BPData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FuncLibEditor.FoliageInfo_BPData");
		FFoliageInfo_BPData_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Transforms_PropertyAddress, intPtr, "Transforms");
		Transforms_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Transforms");
		Transforms_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Transforms", Classes.FArrayProperty);
		FFoliageInfo_BPData_IsValid = intPtr != IntPtr.Zero && Transforms_IsValid;
		NativeReflection.LogStructIsValid("/Script/FuncLibEditor.FoliageInfo_BPData", FFoliageInfo_BPData_IsValid);
	}
}
