using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.MatParamInfo")]
public struct FMatParamInfo
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MatParamInfo:ParameterName")]
	public FName ParameterName;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MatParamInfo:FloatCurve")]
	public UCurveFloat FloatCurve;

	private static int MatParamInfo_StructSize;

	private static int MatParamInfo_IsValid;

	private static bool ParameterName_IsValid;

	private static int ParameterName_Offset;

	private static bool FloatCurve_IsValid;

	private static int FloatCurve_Offset;

	public FMatParamInfo Copy()
	{
		return this;
	}

	public static FMatParamInfo FromNative(IntPtr nativeBuffer)
	{
		return new FMatParamInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMatParamInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMatParamInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMatParamInfo(IntPtr.Add(nativeBuffer, arrayIndex * MatParamInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMatParamInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * MatParamInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (MatParamInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MatParamInfo");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParameterName_Offset), ParameterName);
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(nativeStruct, FloatCurve_Offset), FloatCurve);
	}

	public FMatParamInfo(IntPtr nativeStruct)
	{
		if (MatParamInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MatParamInfo");
			ParameterName = default(FName);
			FloatCurve = null;
		}
		else
		{
			ParameterName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ParameterName_Offset));
			FloatCurve = UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(nativeStruct, FloatCurve_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.MatParamInfo");
		MatParamInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		ParameterName_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParameterName");
		ParameterName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParameterName", Classes.FNameProperty);
		FloatCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "FloatCurve");
		FloatCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FloatCurve", Classes.FObjectProperty);
		MatParamInfo_IsValid = ((intPtr != IntPtr.Zero && ParameterName_IsValid && FloatCurve_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.MatParamInfo", (byte)MatParamInfo_IsValid != 0);
	}

	static FMatParamInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FMatParamInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMatParamInfo));
	}
}
