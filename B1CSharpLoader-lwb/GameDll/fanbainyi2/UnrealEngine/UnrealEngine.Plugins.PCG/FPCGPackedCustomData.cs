using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGPackedCustomData", "PCG", UnrealModuleType.EnginePlugin)]
public struct FPCGPackedCustomData
{
	private static bool NumCustomDataFloats_IsValid;

	private static int NumCustomDataFloats_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGPackedCustomData:NumCustomDataFloats")]
	public int NumCustomDataFloats;

	private static bool CustomData_IsValid;

	private static FFieldAddress CustomData_PropertyAddress;

	private static int CustomData_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/PCG.PCGPackedCustomData:CustomData")]
	public List<float> CustomData;

	private static bool FPCGPackedCustomData_IsValid;

	private static int FPCGPackedCustomData_StructSize;

	public FPCGPackedCustomData Copy()
	{
		FPCGPackedCustomData result = this;
		if (CustomData != null)
		{
			result.CustomData = new List<float>(CustomData);
		}
		return result;
	}

	public static FPCGPackedCustomData FromNative(IntPtr nativeBuffer)
	{
		return new FPCGPackedCustomData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPCGPackedCustomData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPCGPackedCustomData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPCGPackedCustomData(nativeBuffer + arrayIndex * FPCGPackedCustomData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPCGPackedCustomData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPCGPackedCustomData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPCGPackedCustomData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGPackedCustomData");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NumCustomDataFloats_Offset), NumCustomDataFloats);
		new TArrayCopyMarshaler<float>(1, CustomData_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(nativeStruct, CustomData_Offset), CustomData);
	}

	public FPCGPackedCustomData(IntPtr nativeStruct)
	{
		if (!FPCGPackedCustomData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGPackedCustomData");
			NumCustomDataFloats = 0;
			CustomData = null;
		}
		else
		{
			NumCustomDataFloats = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NumCustomDataFloats_Offset));
			CustomData = new TArrayCopyMarshaler<float>(1, CustomData_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(nativeStruct, CustomData_Offset));
		}
	}

	static FPCGPackedCustomData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPCGPackedCustomData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPCGPackedCustomData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PCG.PCGPackedCustomData");
		FPCGPackedCustomData_StructSize = NativeReflection.GetStructSize(intPtr);
		NumCustomDataFloats_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumCustomDataFloats");
		NumCustomDataFloats_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumCustomDataFloats", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CustomData_PropertyAddress, intPtr, "CustomData");
		CustomData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomData");
		CustomData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomData", Classes.FArrayProperty);
		FPCGPackedCustomData_IsValid = intPtr != IntPtr.Zero && NumCustomDataFloats_IsValid && CustomData_IsValid;
		NativeReflection.LogStructIsValid("/Script/PCG.PCGPackedCustomData", FPCGPackedCustomData_IsValid);
	}
}
