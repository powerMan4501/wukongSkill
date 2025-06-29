using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam")]
public struct BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam
{
	[DisplayName("参数名")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam:ParamName")]
	public FName ParamName;

	[DisplayName("数值")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam:ProcessValue")]
	public BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor ProcessValue;

	private static int BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam_StructSize;

	private static int BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam_IsValid;

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

	public BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam Copy()
	{
		return this;
	}

	public static BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParamName_Offset), ParamName);
		BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor.ToNative(IntPtr.Add(nativeStruct, ProcessValue_Offset), ProcessValue);
	}

	public BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam");
			ParamName = default(FName);
			ProcessValue = default(BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor);
		}
		else
		{
			ParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ParamName_Offset));
			ProcessValue = BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor.FromNative(IntPtr.Add(nativeStruct, ProcessValue_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam");
		BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam_StructSize = NativeReflection.GetStructSize(intPtr);
		ParamName_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParamName");
		ParamName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParamName", Classes.FNameProperty);
		ProcessValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProcessValue");
		ProcessValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProcessValue", Classes.FStructProperty);
		BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam_IsValid = ((intPtr != IntPtr.Zero && ParamName_IsValid && ProcessValue_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam", (byte)BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam_IsValid != 0);
	}

	static BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibUtil_ModifyNiagaraParams_FLinearColorParam));
	}
}
