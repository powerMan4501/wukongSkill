using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_PCurve_NameAndScalar")]
public struct BUC_DispLibUtil_PCurve_NameAndScalar
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("Scalar参数名")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_PCurve_NameAndScalar:ParamName")]
	public FName ParamName;

	[UProperty]
	[EditAnywhere]
	[DisplayName("值")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_PCurve_NameAndScalar:Value")]
	public float Value;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("时间阶段")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_PCurve_NameAndScalar:TimeStage")]
	public FVector TimeStage;

	public float ValueOnBreak;

	private static int BUC_DispLibUtil_PCurve_NameAndScalar_StructSize;

	private static int BUC_DispLibUtil_PCurve_NameAndScalar_IsValid;

	private static bool ParamName_IsValid;

	private static int ParamName_Offset;

	private static bool Value_IsValid;

	private static int Value_Offset;

	private static bool TimeStage_IsValid;

	private static int TimeStage_Offset;

	public BUC_DispLibUtil_PCurve_NameAndScalar Copy()
	{
		return this;
	}

	public static BUC_DispLibUtil_PCurve_NameAndScalar FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibUtil_PCurve_NameAndScalar(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibUtil_PCurve_NameAndScalar value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibUtil_PCurve_NameAndScalar FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibUtil_PCurve_NameAndScalar(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_PCurve_NameAndScalar_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibUtil_PCurve_NameAndScalar value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_PCurve_NameAndScalar_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_PCurve_NameAndScalar_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_PCurve_NameAndScalar");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParamName_Offset), ParamName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, TimeStage_Offset), TimeStage);
	}

	public BUC_DispLibUtil_PCurve_NameAndScalar(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_PCurve_NameAndScalar_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_PCurve_NameAndScalar");
			ParamName = default(FName);
			Value = 0f;
			TimeStage = default(FVector);
		}
		else
		{
			ParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ParamName_Offset));
			Value = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
			TimeStage = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, TimeStage_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibUtil_PCurve_NameAndScalar");
		BUC_DispLibUtil_PCurve_NameAndScalar_StructSize = NativeReflection.GetStructSize(intPtr);
		ParamName_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParamName");
		ParamName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParamName", Classes.FNameProperty);
		Value_Offset = NativeReflection.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Value", Classes.FFloatProperty);
		TimeStage_Offset = NativeReflection.GetPropertyOffset(intPtr, "TimeStage");
		TimeStage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TimeStage", Classes.FStructProperty);
		BUC_DispLibUtil_PCurve_NameAndScalar_IsValid = ((intPtr != IntPtr.Zero && ParamName_IsValid && Value_IsValid && TimeStage_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibUtil_PCurve_NameAndScalar", (byte)BUC_DispLibUtil_PCurve_NameAndScalar_IsValid != 0);
	}

	static BUC_DispLibUtil_PCurve_NameAndScalar()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibUtil_PCurve_NameAndScalar)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibUtil_PCurve_NameAndScalar));
	}
}
