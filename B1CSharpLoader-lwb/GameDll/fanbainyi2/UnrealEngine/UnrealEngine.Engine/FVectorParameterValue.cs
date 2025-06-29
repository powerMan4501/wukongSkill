using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.VectorParameterValue", "Engine", UnrealModuleType.Engine)]
public struct FVectorParameterValue
{
	private static bool ParameterInfo_IsValid;

	private static int ParameterInfo_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.VectorParameterValue:ParameterInfo")]
	public FMaterialParameterInfo ParameterInfo;

	private static bool ParameterValue_IsValid;

	private static int ParameterValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.VectorParameterValue:ParameterValue")]
	public FLinearColor ParameterValue;

	private static bool FVectorParameterValue_IsValid;

	private static int FVectorParameterValue_StructSize;

	public FVectorParameterValue Copy()
	{
		return this;
	}

	public static FVectorParameterValue FromNative(IntPtr nativeBuffer)
	{
		return new FVectorParameterValue(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FVectorParameterValue value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FVectorParameterValue FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FVectorParameterValue(nativeBuffer + arrayIndex * FVectorParameterValue_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FVectorParameterValue value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FVectorParameterValue_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FVectorParameterValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.VectorParameterValue");
			return;
		}
		FMaterialParameterInfo.ToNative(IntPtr.Add(nativeStruct, ParameterInfo_Offset), ParameterInfo);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, ParameterValue_Offset), ParameterValue);
	}

	public FVectorParameterValue(IntPtr nativeStruct)
	{
		if (!FVectorParameterValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.VectorParameterValue");
			ParameterInfo = default(FMaterialParameterInfo);
			ParameterValue = default(FLinearColor);
		}
		else
		{
			ParameterInfo = FMaterialParameterInfo.FromNative(IntPtr.Add(nativeStruct, ParameterInfo_Offset));
			ParameterValue = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, ParameterValue_Offset));
		}
	}

	static FVectorParameterValue()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FVectorParameterValue)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FVectorParameterValue));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.VectorParameterValue");
		FVectorParameterValue_StructSize = NativeReflection.GetStructSize(intPtr);
		ParameterInfo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParameterInfo");
		ParameterInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParameterInfo", Classes.FStructProperty);
		ParameterValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParameterValue");
		ParameterValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParameterValue", Classes.FStructProperty);
		FVectorParameterValue_IsValid = intPtr != IntPtr.Zero && ParameterInfo_IsValid && ParameterValue_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.VectorParameterValue", FVectorParameterValue_IsValid);
	}
}
