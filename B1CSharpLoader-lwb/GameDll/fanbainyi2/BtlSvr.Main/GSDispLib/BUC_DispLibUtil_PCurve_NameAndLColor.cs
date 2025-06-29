using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_PCurve_NameAndLColor")]
public struct BUC_DispLibUtil_PCurve_NameAndLColor
{
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("LColor参数名")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_PCurve_NameAndLColor:ParamName")]
	public FName ParamName;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("值")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_PCurve_NameAndLColor:Value")]
	public FLinearColor Value;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("时间阶段")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_PCurve_NameAndLColor:TimeStage")]
	public FVector TimeStage;

	public FLinearColor ValueOnBreak;

	private static int BUC_DispLibUtil_PCurve_NameAndLColor_StructSize;

	private static int BUC_DispLibUtil_PCurve_NameAndLColor_IsValid;

	private static bool ParamName_IsValid;

	private static int ParamName_Offset;

	private static bool Value_IsValid;

	private static int Value_Offset;

	private static bool TimeStage_IsValid;

	private static int TimeStage_Offset;

	public BUC_DispLibUtil_PCurve_NameAndLColor Copy()
	{
		return this;
	}

	public static BUC_DispLibUtil_PCurve_NameAndLColor FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibUtil_PCurve_NameAndLColor(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibUtil_PCurve_NameAndLColor value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibUtil_PCurve_NameAndLColor FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibUtil_PCurve_NameAndLColor(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_PCurve_NameAndLColor_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibUtil_PCurve_NameAndLColor value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_PCurve_NameAndLColor_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_PCurve_NameAndLColor_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_PCurve_NameAndLColor");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParamName_Offset), ParamName);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, TimeStage_Offset), TimeStage);
	}

	public BUC_DispLibUtil_PCurve_NameAndLColor(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_PCurve_NameAndLColor_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_PCurve_NameAndLColor");
			ParamName = default(FName);
			Value = default(FLinearColor);
			TimeStage = default(FVector);
		}
		else
		{
			ParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ParamName_Offset));
			Value = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
			TimeStage = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, TimeStage_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibUtil_PCurve_NameAndLColor");
		BUC_DispLibUtil_PCurve_NameAndLColor_StructSize = NativeReflection.GetStructSize(intPtr);
		ParamName_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParamName");
		ParamName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParamName", Classes.FNameProperty);
		Value_Offset = NativeReflection.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Value", Classes.FStructProperty);
		TimeStage_Offset = NativeReflection.GetPropertyOffset(intPtr, "TimeStage");
		TimeStage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TimeStage", Classes.FStructProperty);
		BUC_DispLibUtil_PCurve_NameAndLColor_IsValid = ((intPtr != IntPtr.Zero && ParamName_IsValid && Value_IsValid && TimeStage_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibUtil_PCurve_NameAndLColor", (byte)BUC_DispLibUtil_PCurve_NameAndLColor_IsValid != 0);
	}

	static BUC_DispLibUtil_PCurve_NameAndLColor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibUtil_PCurve_NameAndLColor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibUtil_PCurve_NameAndLColor));
	}
}
