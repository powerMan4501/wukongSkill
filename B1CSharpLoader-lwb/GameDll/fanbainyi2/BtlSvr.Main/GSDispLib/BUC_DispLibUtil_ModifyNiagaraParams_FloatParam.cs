using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FloatParam")]
public struct BUC_DispLibUtil_ModifyNiagaraParams_FloatParam
{
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("参数名")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FloatParam:ParamName")]
	public FName ParamName;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("数值")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FloatParam:ProcessValue")]
	public BUC_DispLibUtil_ModifyNiagaraParams_Float ProcessValue;

	private static int BUC_DispLibUtil_ModifyNiagaraParams_FloatParam_StructSize;

	private static int BUC_DispLibUtil_ModifyNiagaraParams_FloatParam_IsValid;

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

	public BUC_DispLibUtil_ModifyNiagaraParams_FloatParam Copy()
	{
		return this;
	}

	public static BUC_DispLibUtil_ModifyNiagaraParams_FloatParam FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibUtil_ModifyNiagaraParams_FloatParam(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibUtil_ModifyNiagaraParams_FloatParam value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibUtil_ModifyNiagaraParams_FloatParam FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibUtil_ModifyNiagaraParams_FloatParam(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_ModifyNiagaraParams_FloatParam_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibUtil_ModifyNiagaraParams_FloatParam value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_ModifyNiagaraParams_FloatParam_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_ModifyNiagaraParams_FloatParam_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FloatParam");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParamName_Offset), ParamName);
		BUC_DispLibUtil_ModifyNiagaraParams_Float.ToNative(IntPtr.Add(nativeStruct, ProcessValue_Offset), ProcessValue);
	}

	public BUC_DispLibUtil_ModifyNiagaraParams_FloatParam(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_ModifyNiagaraParams_FloatParam_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FloatParam");
			ParamName = default(FName);
			ProcessValue = default(BUC_DispLibUtil_ModifyNiagaraParams_Float);
		}
		else
		{
			ParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ParamName_Offset));
			ProcessValue = BUC_DispLibUtil_ModifyNiagaraParams_Float.FromNative(IntPtr.Add(nativeStruct, ProcessValue_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FloatParam");
		BUC_DispLibUtil_ModifyNiagaraParams_FloatParam_StructSize = NativeReflection.GetStructSize(intPtr);
		ParamName_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParamName");
		ParamName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParamName", Classes.FNameProperty);
		ProcessValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProcessValue");
		ProcessValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProcessValue", Classes.FStructProperty);
		BUC_DispLibUtil_ModifyNiagaraParams_FloatParam_IsValid = ((intPtr != IntPtr.Zero && ParamName_IsValid && ProcessValue_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FloatParam", (byte)BUC_DispLibUtil_ModifyNiagaraParams_FloatParam_IsValid != 0);
	}

	static BUC_DispLibUtil_ModifyNiagaraParams_FloatParam()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibUtil_ModifyNiagaraParams_FloatParam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibUtil_ModifyNiagaraParams_FloatParam));
	}
}
