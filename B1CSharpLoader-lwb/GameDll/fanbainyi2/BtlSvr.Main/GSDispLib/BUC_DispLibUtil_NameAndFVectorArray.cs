using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndFVectorArray")]
public struct BUC_DispLibUtil_NameAndFVectorArray
{
	[DisplayName("参数名")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndFVectorArray:ParamName")]
	public FName ParamName;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("FVector Array")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndFVectorArray:FVectorArray")]
	public List<FVector> FVectorArray;

	[UMeta(MDProp.EditCondition, "Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::Standard || Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::RandomOnSpawn")]
	[UMeta(MD.ToolTip, "单值模式时，是在事件执行的第一帧设置一次还是事件持续时间内每帧都设置；如果每帧都设置会将参数设置到此事件持续时间内新创建的且符合筛选条件的特效")]
	[BlueprintReadWrite]
	[DisplayName("每帧设置")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndFVectorArray:SetEveryFrame")]
	public bool SetEveryFrame;

	private static int BUC_DispLibUtil_NameAndFVectorArray_StructSize;

	private static int BUC_DispLibUtil_NameAndFVectorArray_IsValid;

	private static bool ParamName_IsValid;

	private static int ParamName_Offset;

	private static bool FVectorArray_IsValid;

	private static int FVectorArray_Offset;

	private static FFieldAddress FVectorArray_PropertyAddress;

	private static bool SetEveryFrame_IsValid;

	private static int SetEveryFrame_Offset;

	private static FFieldAddress SetEveryFrame_PropertyAddress;

	public bool IsValid()
	{
		if (ParamName == default(FName))
		{
			return false;
		}
		if (FVectorArray == null || FVectorArray.Count == 0)
		{
			return false;
		}
		return true;
	}

	public bool NeedVelocity()
	{
		return false;
	}

	public BUC_DispLibUtil_NameAndFVectorArray Copy()
	{
		BUC_DispLibUtil_NameAndFVectorArray result = this;
		if (FVectorArray != null)
		{
			result.FVectorArray = new List<FVector>(FVectorArray);
		}
		return result;
	}

	public static BUC_DispLibUtil_NameAndFVectorArray FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibUtil_NameAndFVectorArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibUtil_NameAndFVectorArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibUtil_NameAndFVectorArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibUtil_NameAndFVectorArray(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_NameAndFVectorArray_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibUtil_NameAndFVectorArray value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_NameAndFVectorArray_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_NameAndFVectorArray_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_NameAndFVectorArray");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParamName_Offset), ParamName);
		new TArrayCopyMarshaler<FVector>(1, FVectorArray_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(nativeStruct, FVectorArray_Offset), FVectorArray);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SetEveryFrame_Offset), 0, SetEveryFrame_PropertyAddress.Address, SetEveryFrame);
	}

	public BUC_DispLibUtil_NameAndFVectorArray(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_NameAndFVectorArray_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_NameAndFVectorArray");
			ParamName = default(FName);
			FVectorArray = null;
			SetEveryFrame = false;
		}
		else
		{
			ParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ParamName_Offset));
			FVectorArray = new TArrayCopyMarshaler<FVector>(1, FVectorArray_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(nativeStruct, FVectorArray_Offset));
			SetEveryFrame = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SetEveryFrame_Offset), 0, SetEveryFrame_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibUtil_NameAndFVectorArray");
		BUC_DispLibUtil_NameAndFVectorArray_StructSize = NativeReflection.GetStructSize(intPtr);
		ParamName_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParamName");
		ParamName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParamName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref FVectorArray_PropertyAddress, intPtr, "FVectorArray");
		FVectorArray_Offset = NativeReflection.GetPropertyOffset(intPtr, "FVectorArray");
		FVectorArray_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FVectorArray", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SetEveryFrame_PropertyAddress, intPtr, "SetEveryFrame");
		SetEveryFrame_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetEveryFrame");
		SetEveryFrame_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetEveryFrame", Classes.FBoolProperty);
		BUC_DispLibUtil_NameAndFVectorArray_IsValid = ((intPtr != IntPtr.Zero && ParamName_IsValid && FVectorArray_IsValid && SetEveryFrame_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibUtil_NameAndFVectorArray", (byte)BUC_DispLibUtil_NameAndFVectorArray_IsValid != 0);
	}

	static BUC_DispLibUtil_NameAndFVectorArray()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibUtil_NameAndFVectorArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibUtil_NameAndFVectorArray));
	}
}
