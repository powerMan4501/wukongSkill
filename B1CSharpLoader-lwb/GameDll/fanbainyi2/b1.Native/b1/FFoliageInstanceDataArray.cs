using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.FoliageInstanceDataArray", "FuncLibEditor", UnrealModuleType.Game)]
public struct FFoliageInstanceDataArray
{
	private static bool InstanceData_IsValid;

	private static FFieldAddress InstanceData_PropertyAddress;

	private static int InstanceData_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/FuncLibEditor.FoliageInstanceDataArray:InstanceData")]
	public List<FFoliageInstanceData> InstanceData;

	private static bool FFoliageInstanceDataArray_IsValid;

	private static int FFoliageInstanceDataArray_StructSize;

	public FFoliageInstanceDataArray Copy()
	{
		FFoliageInstanceDataArray result = this;
		if (InstanceData != null)
		{
			result.InstanceData = new List<FFoliageInstanceData>(InstanceData);
		}
		return result;
	}

	public static FFoliageInstanceDataArray FromNative(IntPtr nativeBuffer)
	{
		return new FFoliageInstanceDataArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FFoliageInstanceDataArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FFoliageInstanceDataArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FFoliageInstanceDataArray(nativeBuffer + arrayIndex * FFoliageInstanceDataArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FFoliageInstanceDataArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FFoliageInstanceDataArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FFoliageInstanceDataArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.FoliageInstanceDataArray");
		}
		else
		{
			new TArrayCopyMarshaler<FFoliageInstanceData>(1, InstanceData_PropertyAddress, CachedMarshalingDelegates<FFoliageInstanceData, FFoliageInstanceData>.FromNative, CachedMarshalingDelegates<FFoliageInstanceData, FFoliageInstanceData>.ToNative).ToNative(IntPtr.Add(nativeStruct, InstanceData_Offset), InstanceData);
		}
	}

	public FFoliageInstanceDataArray(IntPtr nativeStruct)
	{
		if (!FFoliageInstanceDataArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.FoliageInstanceDataArray");
			InstanceData = null;
		}
		else
		{
			InstanceData = new TArrayCopyMarshaler<FFoliageInstanceData>(1, InstanceData_PropertyAddress, CachedMarshalingDelegates<FFoliageInstanceData, FFoliageInstanceData>.FromNative, CachedMarshalingDelegates<FFoliageInstanceData, FFoliageInstanceData>.ToNative).FromNative(IntPtr.Add(nativeStruct, InstanceData_Offset));
		}
	}

	static FFoliageInstanceDataArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FFoliageInstanceDataArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFoliageInstanceDataArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FuncLibEditor.FoliageInstanceDataArray");
		FFoliageInstanceDataArray_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref InstanceData_PropertyAddress, intPtr, "InstanceData");
		InstanceData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InstanceData");
		InstanceData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InstanceData", Classes.FArrayProperty);
		FFoliageInstanceDataArray_IsValid = intPtr != IntPtr.Zero && InstanceData_IsValid;
		NativeReflection.LogStructIsValid("/Script/FuncLibEditor.FoliageInstanceDataArray", FFoliageInstanceDataArray_IsValid);
	}
}
