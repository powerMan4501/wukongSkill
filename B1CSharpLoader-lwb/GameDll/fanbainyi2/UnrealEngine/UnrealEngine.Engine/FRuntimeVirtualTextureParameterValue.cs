using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.RuntimeVirtualTextureParameterValue", "Engine", UnrealModuleType.Engine)]
public struct FRuntimeVirtualTextureParameterValue
{
	private static bool ParameterInfo_IsValid;

	private static int ParameterInfo_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.RuntimeVirtualTextureParameterValue:ParameterInfo")]
	public FMaterialParameterInfo ParameterInfo;

	private static bool ParameterValue_IsValid;

	private static int ParameterValue_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.RuntimeVirtualTextureParameterValue:ParameterValue")]
	public URuntimeVirtualTexture ParameterValue;

	private static bool FRuntimeVirtualTextureParameterValue_IsValid;

	private static int FRuntimeVirtualTextureParameterValue_StructSize;

	public FRuntimeVirtualTextureParameterValue Copy()
	{
		return this;
	}

	public static FRuntimeVirtualTextureParameterValue FromNative(IntPtr nativeBuffer)
	{
		return new FRuntimeVirtualTextureParameterValue(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRuntimeVirtualTextureParameterValue value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRuntimeVirtualTextureParameterValue FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRuntimeVirtualTextureParameterValue(nativeBuffer + arrayIndex * FRuntimeVirtualTextureParameterValue_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRuntimeVirtualTextureParameterValue value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRuntimeVirtualTextureParameterValue_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRuntimeVirtualTextureParameterValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.RuntimeVirtualTextureParameterValue");
			return;
		}
		FMaterialParameterInfo.ToNative(IntPtr.Add(nativeStruct, ParameterInfo_Offset), ParameterInfo);
		UObjectMarshaler<URuntimeVirtualTexture>.ToNative(IntPtr.Add(nativeStruct, ParameterValue_Offset), ParameterValue);
	}

	public FRuntimeVirtualTextureParameterValue(IntPtr nativeStruct)
	{
		if (!FRuntimeVirtualTextureParameterValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.RuntimeVirtualTextureParameterValue");
			ParameterInfo = default(FMaterialParameterInfo);
			ParameterValue = null;
		}
		else
		{
			ParameterInfo = FMaterialParameterInfo.FromNative(IntPtr.Add(nativeStruct, ParameterInfo_Offset));
			ParameterValue = UObjectMarshaler<URuntimeVirtualTexture>.FromNative(IntPtr.Add(nativeStruct, ParameterValue_Offset));
		}
	}

	static FRuntimeVirtualTextureParameterValue()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRuntimeVirtualTextureParameterValue)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRuntimeVirtualTextureParameterValue));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.RuntimeVirtualTextureParameterValue");
		FRuntimeVirtualTextureParameterValue_StructSize = NativeReflection.GetStructSize(intPtr);
		ParameterInfo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParameterInfo");
		ParameterInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParameterInfo", Classes.FStructProperty);
		ParameterValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParameterValue");
		ParameterValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParameterValue", Classes.FObjectProperty);
		FRuntimeVirtualTextureParameterValue_IsValid = intPtr != IntPtr.Zero && ParameterInfo_IsValid && ParameterValue_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.RuntimeVirtualTextureParameterValue", FRuntimeVirtualTextureParameterValue_IsValid);
	}
}
