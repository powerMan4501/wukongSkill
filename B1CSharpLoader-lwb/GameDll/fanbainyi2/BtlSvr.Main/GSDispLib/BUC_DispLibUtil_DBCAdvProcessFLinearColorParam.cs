using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessFLinearColorParam")]
public struct BUC_DispLibUtil_DBCAdvProcessFLinearColorParam
{
	[DisplayName("参数名")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessFLinearColorParam:ParamName")]
	public FName ParamName;

	[DisplayName("数值")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessFLinearColorParam:ProcessValue")]
	public BUC_DispLibUtil_DBCAdvProcessFLinearColor ProcessValue;

	private static int BUC_DispLibUtil_DBCAdvProcessFLinearColorParam_StructSize;

	private static int BUC_DispLibUtil_DBCAdvProcessFLinearColorParam_IsValid;

	private static bool ParamName_IsValid;

	private static int ParamName_Offset;

	private static bool ProcessValue_IsValid;

	private static int ProcessValue_Offset;

	public bool IsValid()
	{
		if (ParamName == default(FName))
		{
			return false;
		}
		return true;
	}

	public bool NeedVelocity()
	{
		return ProcessValue.NeedVelocity();
	}

	public BUC_DispLibUtil_DBCAdvProcessFLinearColorParam SetCustomData(FName _ParamName, BUC_DispLibUtil_DBCAdvProcessFLinearColor _ProcessValue)
	{
		ParamName = _ParamName;
		ProcessValue = _ProcessValue;
		return this;
	}

	public BUC_DispLibUtil_DBCAdvProcessFLinearColorParam Copy()
	{
		return this;
	}

	public static BUC_DispLibUtil_DBCAdvProcessFLinearColorParam FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibUtil_DBCAdvProcessFLinearColorParam(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibUtil_DBCAdvProcessFLinearColorParam value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibUtil_DBCAdvProcessFLinearColorParam FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibUtil_DBCAdvProcessFLinearColorParam(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_DBCAdvProcessFLinearColorParam_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibUtil_DBCAdvProcessFLinearColorParam value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_DBCAdvProcessFLinearColorParam_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_DBCAdvProcessFLinearColorParam_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessFLinearColorParam");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParamName_Offset), ParamName);
		BUC_DispLibUtil_DBCAdvProcessFLinearColor.ToNative(IntPtr.Add(nativeStruct, ProcessValue_Offset), ProcessValue);
	}

	public BUC_DispLibUtil_DBCAdvProcessFLinearColorParam(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_DBCAdvProcessFLinearColorParam_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessFLinearColorParam");
			ParamName = default(FName);
			ProcessValue = default(BUC_DispLibUtil_DBCAdvProcessFLinearColor);
		}
		else
		{
			ParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ParamName_Offset));
			ProcessValue = BUC_DispLibUtil_DBCAdvProcessFLinearColor.FromNative(IntPtr.Add(nativeStruct, ProcessValue_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessFLinearColorParam");
		BUC_DispLibUtil_DBCAdvProcessFLinearColorParam_StructSize = NativeReflection.GetStructSize(intPtr);
		ParamName_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParamName");
		ParamName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParamName", Classes.FNameProperty);
		ProcessValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProcessValue");
		ProcessValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProcessValue", Classes.FStructProperty);
		BUC_DispLibUtil_DBCAdvProcessFLinearColorParam_IsValid = ((intPtr != IntPtr.Zero && ParamName_IsValid && ProcessValue_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessFLinearColorParam", (byte)BUC_DispLibUtil_DBCAdvProcessFLinearColorParam_IsValid != 0);
	}

	static BUC_DispLibUtil_DBCAdvProcessFLinearColorParam()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibUtil_DBCAdvProcessFLinearColorParam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibUtil_DBCAdvProcessFLinearColorParam));
	}
}
