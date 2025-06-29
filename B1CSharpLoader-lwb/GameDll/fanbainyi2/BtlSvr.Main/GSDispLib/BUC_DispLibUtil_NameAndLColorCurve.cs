using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndLColorCurve")]
public struct BUC_DispLibUtil_NameAndLColorCurve
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("FColor参数名")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndLColorCurve:ParamName")]
	public FName ParamName;

	[DisplayName("曲线")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndLColorCurve:Value")]
	public UCurveLinearColor Value;

	[BlueprintReadWrite]
	[DisplayName("时长")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndLColorCurve:Time")]
	public float Time;

	private static int BUC_DispLibUtil_NameAndLColorCurve_StructSize;

	private static int BUC_DispLibUtil_NameAndLColorCurve_IsValid;

	private static bool ParamName_IsValid;

	private static int ParamName_Offset;

	private static bool Value_IsValid;

	private static int Value_Offset;

	private static bool Time_IsValid;

	private static int Time_Offset;

	public BUC_DispLibUtil_NameAndLColorCurve Copy()
	{
		return this;
	}

	public static BUC_DispLibUtil_NameAndLColorCurve FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibUtil_NameAndLColorCurve(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibUtil_NameAndLColorCurve value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibUtil_NameAndLColorCurve FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibUtil_NameAndLColorCurve(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_NameAndLColorCurve_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibUtil_NameAndLColorCurve value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_NameAndLColorCurve_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_NameAndLColorCurve_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_NameAndLColorCurve");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParamName_Offset), ParamName);
		UObjectMarshaler<UCurveLinearColor>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Time_Offset), Time);
	}

	public BUC_DispLibUtil_NameAndLColorCurve(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_NameAndLColorCurve_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_NameAndLColorCurve");
			ParamName = default(FName);
			Value = null;
			Time = 0f;
		}
		else
		{
			ParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ParamName_Offset));
			Value = UObjectMarshaler<UCurveLinearColor>.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
			Time = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Time_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibUtil_NameAndLColorCurve");
		BUC_DispLibUtil_NameAndLColorCurve_StructSize = NativeReflection.GetStructSize(intPtr);
		ParamName_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParamName");
		ParamName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParamName", Classes.FNameProperty);
		Value_Offset = NativeReflection.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Value", Classes.FObjectProperty);
		Time_Offset = NativeReflection.GetPropertyOffset(intPtr, "Time");
		Time_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Time", Classes.FFloatProperty);
		BUC_DispLibUtil_NameAndLColorCurve_IsValid = ((intPtr != IntPtr.Zero && ParamName_IsValid && Value_IsValid && Time_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibUtil_NameAndLColorCurve", (byte)BUC_DispLibUtil_NameAndLColorCurve_IsValid != 0);
	}

	static BUC_DispLibUtil_NameAndLColorCurve()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibUtil_NameAndLColorCurve)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibUtil_NameAndLColorCurve));
	}
}
