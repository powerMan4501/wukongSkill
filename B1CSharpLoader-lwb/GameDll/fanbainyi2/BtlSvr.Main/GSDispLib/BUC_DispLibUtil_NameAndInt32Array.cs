using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndInt32Array")]
public struct BUC_DispLibUtil_NameAndInt32Array
{
	[UProperty]
	[DisplayName("参数名")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndInt32Array:ParamName")]
	public FName ParamName;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Int32 Array")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndInt32Array:Int32Array")]
	public List<int> Int32Array;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::Standard || Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::RandomOnSpawn")]
	[DisplayName("每帧设置")]
	[UMeta(MD.ToolTip, "单值模式时，是在事件执行的第一帧设置一次还是事件持续时间内每帧都设置；如果每帧都设置会将参数设置到此事件持续时间内新创建的且符合筛选条件的特效")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndInt32Array:SetEveryFrame")]
	public bool SetEveryFrame;

	private static int BUC_DispLibUtil_NameAndInt32Array_StructSize;

	private static int BUC_DispLibUtil_NameAndInt32Array_IsValid;

	private static bool ParamName_IsValid;

	private static int ParamName_Offset;

	private static bool Int32Array_IsValid;

	private static int Int32Array_Offset;

	private static FFieldAddress Int32Array_PropertyAddress;

	private static bool SetEveryFrame_IsValid;

	private static int SetEveryFrame_Offset;

	private static FFieldAddress SetEveryFrame_PropertyAddress;

	public bool IsValid()
	{
		if (ParamName == default(FName))
		{
			return false;
		}
		if (Int32Array == null || Int32Array.Count == 0)
		{
			return false;
		}
		return true;
	}

	public bool NeedVelocity()
	{
		return false;
	}

	public BUC_DispLibUtil_NameAndInt32Array Copy()
	{
		BUC_DispLibUtil_NameAndInt32Array result = this;
		if (Int32Array != null)
		{
			result.Int32Array = new List<int>(Int32Array);
		}
		return result;
	}

	public static BUC_DispLibUtil_NameAndInt32Array FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibUtil_NameAndInt32Array(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibUtil_NameAndInt32Array value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibUtil_NameAndInt32Array FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibUtil_NameAndInt32Array(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_NameAndInt32Array_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibUtil_NameAndInt32Array value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_NameAndInt32Array_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_NameAndInt32Array_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_NameAndInt32Array");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParamName_Offset), ParamName);
		new TArrayCopyMarshaler<int>(1, Int32Array_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, Int32Array_Offset), Int32Array);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SetEveryFrame_Offset), 0, SetEveryFrame_PropertyAddress.Address, SetEveryFrame);
	}

	public BUC_DispLibUtil_NameAndInt32Array(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_NameAndInt32Array_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_NameAndInt32Array");
			ParamName = default(FName);
			Int32Array = null;
			SetEveryFrame = false;
		}
		else
		{
			ParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ParamName_Offset));
			Int32Array = new TArrayCopyMarshaler<int>(1, Int32Array_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, Int32Array_Offset));
			SetEveryFrame = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SetEveryFrame_Offset), 0, SetEveryFrame_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibUtil_NameAndInt32Array");
		BUC_DispLibUtil_NameAndInt32Array_StructSize = NativeReflection.GetStructSize(intPtr);
		ParamName_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParamName");
		ParamName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParamName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref Int32Array_PropertyAddress, intPtr, "Int32Array");
		Int32Array_Offset = NativeReflection.GetPropertyOffset(intPtr, "Int32Array");
		Int32Array_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Int32Array", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SetEveryFrame_PropertyAddress, intPtr, "SetEveryFrame");
		SetEveryFrame_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetEveryFrame");
		SetEveryFrame_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetEveryFrame", Classes.FBoolProperty);
		BUC_DispLibUtil_NameAndInt32Array_IsValid = ((intPtr != IntPtr.Zero && ParamName_IsValid && Int32Array_IsValid && SetEveryFrame_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibUtil_NameAndInt32Array", (byte)BUC_DispLibUtil_NameAndInt32Array_IsValid != 0);
	}

	static BUC_DispLibUtil_NameAndInt32Array()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibUtil_NameAndInt32Array)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibUtil_NameAndInt32Array));
	}
}
