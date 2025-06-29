using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.SparseVolumeTextureParameterValue", "Engine", UnrealModuleType.Engine)]
public struct FSparseVolumeTextureParameterValue
{
	private static bool ParameterInfo_IsValid;

	private static int ParameterInfo_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SparseVolumeTextureParameterValue:ParameterInfo")]
	public FMaterialParameterInfo ParameterInfo;

	private static bool ParameterValue_IsValid;

	private static int ParameterValue_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.SparseVolumeTextureParameterValue:ParameterValue")]
	public USparseVolumeTexture ParameterValue;

	private static bool FSparseVolumeTextureParameterValue_IsValid;

	private static int FSparseVolumeTextureParameterValue_StructSize;

	public FSparseVolumeTextureParameterValue Copy()
	{
		return this;
	}

	public static FSparseVolumeTextureParameterValue FromNative(IntPtr nativeBuffer)
	{
		return new FSparseVolumeTextureParameterValue(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSparseVolumeTextureParameterValue value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSparseVolumeTextureParameterValue FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSparseVolumeTextureParameterValue(nativeBuffer + arrayIndex * FSparseVolumeTextureParameterValue_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSparseVolumeTextureParameterValue value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSparseVolumeTextureParameterValue_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSparseVolumeTextureParameterValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SparseVolumeTextureParameterValue");
			return;
		}
		FMaterialParameterInfo.ToNative(IntPtr.Add(nativeStruct, ParameterInfo_Offset), ParameterInfo);
		UObjectMarshaler<USparseVolumeTexture>.ToNative(IntPtr.Add(nativeStruct, ParameterValue_Offset), ParameterValue);
	}

	public FSparseVolumeTextureParameterValue(IntPtr nativeStruct)
	{
		if (!FSparseVolumeTextureParameterValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SparseVolumeTextureParameterValue");
			ParameterInfo = default(FMaterialParameterInfo);
			ParameterValue = null;
		}
		else
		{
			ParameterInfo = FMaterialParameterInfo.FromNative(IntPtr.Add(nativeStruct, ParameterInfo_Offset));
			ParameterValue = UObjectMarshaler<USparseVolumeTexture>.FromNative(IntPtr.Add(nativeStruct, ParameterValue_Offset));
		}
	}

	static FSparseVolumeTextureParameterValue()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSparseVolumeTextureParameterValue)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSparseVolumeTextureParameterValue));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.SparseVolumeTextureParameterValue");
		FSparseVolumeTextureParameterValue_StructSize = NativeReflection.GetStructSize(intPtr);
		ParameterInfo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParameterInfo");
		ParameterInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParameterInfo", Classes.FStructProperty);
		ParameterValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParameterValue");
		ParameterValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParameterValue", Classes.FObjectProperty);
		FSparseVolumeTextureParameterValue_IsValid = intPtr != IntPtr.Zero && ParameterInfo_IsValid && ParameterValue_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.SparseVolumeTextureParameterValue", FSparseVolumeTextureParameterValue_IsValid);
	}
}
