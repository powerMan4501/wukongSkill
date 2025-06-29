using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.ScalarParameterValue", "Engine", UnrealModuleType.Engine)]
public struct FScalarParameterValue
{
	private static bool ParameterInfo_IsValid;

	private static int ParameterInfo_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.ScalarParameterValue:ParameterInfo")]
	public FMaterialParameterInfo ParameterInfo;

	private static bool ParameterValue_IsValid;

	private static int ParameterValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ScalarParameterValue:ParameterValue")]
	public float ParameterValue;

	private static bool FScalarParameterValue_IsValid;

	private static int FScalarParameterValue_StructSize;

	public FScalarParameterValue Copy()
	{
		return this;
	}

	public static FScalarParameterValue FromNative(IntPtr nativeBuffer)
	{
		return new FScalarParameterValue(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FScalarParameterValue value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FScalarParameterValue FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FScalarParameterValue(nativeBuffer + arrayIndex * FScalarParameterValue_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FScalarParameterValue value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FScalarParameterValue_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FScalarParameterValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ScalarParameterValue");
			return;
		}
		FMaterialParameterInfo.ToNative(IntPtr.Add(nativeStruct, ParameterInfo_Offset), ParameterInfo);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ParameterValue_Offset), ParameterValue);
	}

	public FScalarParameterValue(IntPtr nativeStruct)
	{
		if (!FScalarParameterValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ScalarParameterValue");
			ParameterInfo = default(FMaterialParameterInfo);
			ParameterValue = 0f;
		}
		else
		{
			ParameterInfo = FMaterialParameterInfo.FromNative(IntPtr.Add(nativeStruct, ParameterInfo_Offset));
			ParameterValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ParameterValue_Offset));
		}
	}

	static FScalarParameterValue()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FScalarParameterValue)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FScalarParameterValue));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.ScalarParameterValue");
		FScalarParameterValue_StructSize = NativeReflection.GetStructSize(intPtr);
		ParameterInfo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParameterInfo");
		ParameterInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParameterInfo", Classes.FStructProperty);
		ParameterValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParameterValue");
		ParameterValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParameterValue", Classes.FFloatProperty);
		FScalarParameterValue_IsValid = intPtr != IntPtr.Zero && ParameterInfo_IsValid && ParameterValue_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.ScalarParameterValue", FScalarParameterValue_IsValid);
	}
}
