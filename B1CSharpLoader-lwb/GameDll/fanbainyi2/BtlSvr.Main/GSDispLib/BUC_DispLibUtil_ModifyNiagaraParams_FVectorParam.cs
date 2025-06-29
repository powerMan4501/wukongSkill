using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam")]
public struct BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam
{
	[DisplayName("参数名")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam:ParamName")]
	public FName ParamName;

	[UProperty]
	[EditAnywhere]
	[DisplayName("数值")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam:ProcessValue")]
	public BUC_DispLibUtil_ModifyNiagaraParams_FVector ProcessValue;

	private static int BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam_StructSize;

	private static int BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam_IsValid;

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

	public BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam Copy()
	{
		return this;
	}

	public static BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParamName_Offset), ParamName);
		BUC_DispLibUtil_ModifyNiagaraParams_FVector.ToNative(IntPtr.Add(nativeStruct, ProcessValue_Offset), ProcessValue);
	}

	public BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam");
			ParamName = default(FName);
			ProcessValue = default(BUC_DispLibUtil_ModifyNiagaraParams_FVector);
		}
		else
		{
			ParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ParamName_Offset));
			ProcessValue = BUC_DispLibUtil_ModifyNiagaraParams_FVector.FromNative(IntPtr.Add(nativeStruct, ProcessValue_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam");
		BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam_StructSize = NativeReflection.GetStructSize(intPtr);
		ParamName_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParamName");
		ParamName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParamName", Classes.FNameProperty);
		ProcessValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProcessValue");
		ProcessValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProcessValue", Classes.FStructProperty);
		BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam_IsValid = ((intPtr != IntPtr.Zero && ParamName_IsValid && ProcessValue_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam", (byte)BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam_IsValid != 0);
	}

	static BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibUtil_ModifyNiagaraParams_FVectorParam));
	}
}
