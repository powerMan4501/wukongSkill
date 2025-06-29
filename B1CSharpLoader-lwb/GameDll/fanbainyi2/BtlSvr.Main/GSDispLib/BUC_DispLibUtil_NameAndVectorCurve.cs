using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndVectorCurve")]
public struct BUC_DispLibUtil_NameAndVectorCurve
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("FVector参数名")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndVectorCurve:ParamName")]
	public FName ParamName;

	[EditAnywhere]
	[UProperty]
	[DisplayName("曲线")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndVectorCurve:Value")]
	public UCurveVector Value;

	[EditAnywhere]
	[DisplayName("时长")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndVectorCurve:Time")]
	public float Time;

	private static int BUC_DispLibUtil_NameAndVectorCurve_StructSize;

	private static int BUC_DispLibUtil_NameAndVectorCurve_IsValid;

	private static bool ParamName_IsValid;

	private static int ParamName_Offset;

	private static bool Value_IsValid;

	private static int Value_Offset;

	private static bool Time_IsValid;

	private static int Time_Offset;

	public BUC_DispLibUtil_NameAndVectorCurve Copy()
	{
		return this;
	}

	public static BUC_DispLibUtil_NameAndVectorCurve FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibUtil_NameAndVectorCurve(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibUtil_NameAndVectorCurve value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibUtil_NameAndVectorCurve FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibUtil_NameAndVectorCurve(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_NameAndVectorCurve_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibUtil_NameAndVectorCurve value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_NameAndVectorCurve_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_NameAndVectorCurve_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_NameAndVectorCurve");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParamName_Offset), ParamName);
		UObjectMarshaler<UCurveVector>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Time_Offset), Time);
	}

	public BUC_DispLibUtil_NameAndVectorCurve(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_NameAndVectorCurve_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_NameAndVectorCurve");
			ParamName = default(FName);
			Value = null;
			Time = 0f;
		}
		else
		{
			ParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ParamName_Offset));
			Value = UObjectMarshaler<UCurveVector>.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
			Time = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Time_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibUtil_NameAndVectorCurve");
		BUC_DispLibUtil_NameAndVectorCurve_StructSize = NativeReflection.GetStructSize(intPtr);
		ParamName_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParamName");
		ParamName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParamName", Classes.FNameProperty);
		Value_Offset = NativeReflection.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Value", Classes.FObjectProperty);
		Time_Offset = NativeReflection.GetPropertyOffset(intPtr, "Time");
		Time_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Time", Classes.FFloatProperty);
		BUC_DispLibUtil_NameAndVectorCurve_IsValid = ((intPtr != IntPtr.Zero && ParamName_IsValid && Value_IsValid && Time_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibUtil_NameAndVectorCurve", (byte)BUC_DispLibUtil_NameAndVectorCurve_IsValid != 0);
	}

	static BUC_DispLibUtil_NameAndVectorCurve()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibUtil_NameAndVectorCurve)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibUtil_NameAndVectorCurve));
	}
}
