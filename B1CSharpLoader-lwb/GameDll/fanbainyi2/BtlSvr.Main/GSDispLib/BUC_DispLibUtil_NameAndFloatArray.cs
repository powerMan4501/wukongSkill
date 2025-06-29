using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndFloatArray")]
public struct BUC_DispLibUtil_NameAndFloatArray
{
	[DisplayName("参数名")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndFloatArray:ParamName")]
	public FName ParamName;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Float Array")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndFloatArray:FloatArray")]
	public List<float> FloatArray;

	[DisplayName("每帧设置")]
	[UMeta(MD.ToolTip, "单值模式时，是在事件执行的第一帧设置一次还是事件持续时间内每帧都设置；如果每帧都设置会将参数设置到此事件持续时间内新创建的且符合筛选条件的特效")]
	[UProperty]
	[UMeta(MDProp.EditCondition, "Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::Standard || Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::RandomOnSpawn")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndFloatArray:SetEveryFrame")]
	public bool SetEveryFrame;

	private static int BUC_DispLibUtil_NameAndFloatArray_StructSize;

	private static int BUC_DispLibUtil_NameAndFloatArray_IsValid;

	private static bool ParamName_IsValid;

	private static int ParamName_Offset;

	private static bool FloatArray_IsValid;

	private static int FloatArray_Offset;

	private static FFieldAddress FloatArray_PropertyAddress;

	private static bool SetEveryFrame_IsValid;

	private static int SetEveryFrame_Offset;

	private static FFieldAddress SetEveryFrame_PropertyAddress;

	public bool IsValid()
	{
		if (ParamName == default(FName))
		{
			return false;
		}
		if (FloatArray == null || FloatArray.Count == 0)
		{
			return false;
		}
		return true;
	}

	public bool NeedVelocity()
	{
		return false;
	}

	public BUC_DispLibUtil_NameAndFloatArray Copy()
	{
		BUC_DispLibUtil_NameAndFloatArray result = this;
		if (FloatArray != null)
		{
			result.FloatArray = new List<float>(FloatArray);
		}
		return result;
	}

	public static BUC_DispLibUtil_NameAndFloatArray FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibUtil_NameAndFloatArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibUtil_NameAndFloatArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibUtil_NameAndFloatArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibUtil_NameAndFloatArray(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_NameAndFloatArray_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibUtil_NameAndFloatArray value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_NameAndFloatArray_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_NameAndFloatArray_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_NameAndFloatArray");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParamName_Offset), ParamName);
		new TArrayCopyMarshaler<float>(1, FloatArray_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(nativeStruct, FloatArray_Offset), FloatArray);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SetEveryFrame_Offset), 0, SetEveryFrame_PropertyAddress.Address, SetEveryFrame);
	}

	public BUC_DispLibUtil_NameAndFloatArray(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_NameAndFloatArray_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_NameAndFloatArray");
			ParamName = default(FName);
			FloatArray = null;
			SetEveryFrame = false;
		}
		else
		{
			ParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ParamName_Offset));
			FloatArray = new TArrayCopyMarshaler<float>(1, FloatArray_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(nativeStruct, FloatArray_Offset));
			SetEveryFrame = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SetEveryFrame_Offset), 0, SetEveryFrame_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibUtil_NameAndFloatArray");
		BUC_DispLibUtil_NameAndFloatArray_StructSize = NativeReflection.GetStructSize(intPtr);
		ParamName_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParamName");
		ParamName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParamName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref FloatArray_PropertyAddress, intPtr, "FloatArray");
		FloatArray_Offset = NativeReflection.GetPropertyOffset(intPtr, "FloatArray");
		FloatArray_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FloatArray", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SetEveryFrame_PropertyAddress, intPtr, "SetEveryFrame");
		SetEveryFrame_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetEveryFrame");
		SetEveryFrame_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetEveryFrame", Classes.FBoolProperty);
		BUC_DispLibUtil_NameAndFloatArray_IsValid = ((intPtr != IntPtr.Zero && ParamName_IsValid && FloatArray_IsValid && SetEveryFrame_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibUtil_NameAndFloatArray", (byte)BUC_DispLibUtil_NameAndFloatArray_IsValid != 0);
	}

	static BUC_DispLibUtil_NameAndFloatArray()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibUtil_NameAndFloatArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibUtil_NameAndFloatArray));
	}
}
