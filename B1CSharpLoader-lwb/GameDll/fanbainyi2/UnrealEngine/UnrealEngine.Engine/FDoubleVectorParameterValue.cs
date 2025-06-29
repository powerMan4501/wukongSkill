using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.DoubleVectorParameterValue", "Engine", UnrealModuleType.Engine)]
public struct FDoubleVectorParameterValue
{
	private static bool ParameterInfo_IsValid;

	private static int ParameterInfo_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.DoubleVectorParameterValue:ParameterInfo")]
	public FMaterialParameterInfo ParameterInfo;

	private static bool FDoubleVectorParameterValue_IsValid;

	private static int FDoubleVectorParameterValue_StructSize;

	public FDoubleVectorParameterValue Copy()
	{
		return this;
	}

	public static FDoubleVectorParameterValue FromNative(IntPtr nativeBuffer)
	{
		return new FDoubleVectorParameterValue(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDoubleVectorParameterValue value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDoubleVectorParameterValue FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDoubleVectorParameterValue(nativeBuffer + arrayIndex * FDoubleVectorParameterValue_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDoubleVectorParameterValue value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FDoubleVectorParameterValue_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FDoubleVectorParameterValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.DoubleVectorParameterValue");
		}
		else
		{
			FMaterialParameterInfo.ToNative(IntPtr.Add(nativeStruct, ParameterInfo_Offset), ParameterInfo);
		}
	}

	public FDoubleVectorParameterValue(IntPtr nativeStruct)
	{
		if (!FDoubleVectorParameterValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.DoubleVectorParameterValue");
			ParameterInfo = default(FMaterialParameterInfo);
		}
		else
		{
			ParameterInfo = FMaterialParameterInfo.FromNative(IntPtr.Add(nativeStruct, ParameterInfo_Offset));
		}
	}

	static FDoubleVectorParameterValue()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDoubleVectorParameterValue)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDoubleVectorParameterValue));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.DoubleVectorParameterValue");
		FDoubleVectorParameterValue_StructSize = NativeReflection.GetStructSize(intPtr);
		ParameterInfo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParameterInfo");
		ParameterInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParameterInfo", Classes.FStructProperty);
		FDoubleVectorParameterValue_IsValid = intPtr != IntPtr.Zero && ParameterInfo_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.DoubleVectorParameterValue", FDoubleVectorParameterValue_IsValid);
	}
}
