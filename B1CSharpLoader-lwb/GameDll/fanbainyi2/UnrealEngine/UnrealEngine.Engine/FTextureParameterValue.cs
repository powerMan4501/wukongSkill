using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.TextureParameterValue", "Engine", UnrealModuleType.Engine)]
public struct FTextureParameterValue
{
	private static bool ParameterInfo_IsValid;

	private static int ParameterInfo_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.TextureParameterValue:ParameterInfo")]
	public FMaterialParameterInfo ParameterInfo;

	private static bool ParameterValue_IsValid;

	private static int ParameterValue_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.TextureParameterValue:ParameterValue")]
	public UTexture ParameterValue;

	private static bool FTextureParameterValue_IsValid;

	private static int FTextureParameterValue_StructSize;

	public FTextureParameterValue Copy()
	{
		return this;
	}

	public static FTextureParameterValue FromNative(IntPtr nativeBuffer)
	{
		return new FTextureParameterValue(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTextureParameterValue value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTextureParameterValue FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTextureParameterValue(nativeBuffer + arrayIndex * FTextureParameterValue_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTextureParameterValue value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTextureParameterValue_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTextureParameterValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.TextureParameterValue");
			return;
		}
		FMaterialParameterInfo.ToNative(IntPtr.Add(nativeStruct, ParameterInfo_Offset), ParameterInfo);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(nativeStruct, ParameterValue_Offset), ParameterValue);
	}

	public FTextureParameterValue(IntPtr nativeStruct)
	{
		if (!FTextureParameterValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.TextureParameterValue");
			ParameterInfo = default(FMaterialParameterInfo);
			ParameterValue = null;
		}
		else
		{
			ParameterInfo = FMaterialParameterInfo.FromNative(IntPtr.Add(nativeStruct, ParameterInfo_Offset));
			ParameterValue = UObjectMarshaler<UTexture>.FromNative(IntPtr.Add(nativeStruct, ParameterValue_Offset));
		}
	}

	static FTextureParameterValue()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTextureParameterValue)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTextureParameterValue));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.TextureParameterValue");
		FTextureParameterValue_StructSize = NativeReflection.GetStructSize(intPtr);
		ParameterInfo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParameterInfo");
		ParameterInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParameterInfo", Classes.FStructProperty);
		ParameterValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParameterValue");
		ParameterValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParameterValue", Classes.FObjectProperty);
		FTextureParameterValue_IsValid = intPtr != IntPtr.Zero && ParameterInfo_IsValid && ParameterValue_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.TextureParameterValue", FTextureParameterValue_IsValid);
	}
}
