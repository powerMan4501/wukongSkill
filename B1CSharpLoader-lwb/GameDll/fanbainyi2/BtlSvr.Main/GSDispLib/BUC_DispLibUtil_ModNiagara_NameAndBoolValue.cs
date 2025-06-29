using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModNiagara_NameAndBoolValue")]
public struct BUC_DispLibUtil_ModNiagara_NameAndBoolValue
{
	[BlueprintReadWrite]
	[DisplayName("Bool参数名")]
	[Tooltip("DBC相关的重要参数不能通过这种形式修改，程序会直接阻止这类参数设置，如 GS_EfxStop")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModNiagara_NameAndBoolValue:ParamName")]
	public FName ParamName;

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("参数值-主要阶段")]
	[EditAnywhere]
	[Tooltip("从参数事件开始执行到收尾阶段第一帧为止将设置此值；是否每帧设置依据【每帧设置】")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModNiagara_NameAndBoolValue:Value")]
	public bool Value;

	[Tooltip("此参数事件处于收尾阶段时将每帧设置此值")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("参数值-收尾阶段")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModNiagara_NameAndBoolValue:EndDispStageValue")]
	public bool EndDispStageValue;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("参数值-等待事件RealEnd阶段")]
	[Tooltip("此参数事件的收尾阶段结束之后，直到其所属的父级事件RealEnd之前，将每帧设置此值")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModNiagara_NameAndBoolValue:AfterParamEventRealEndValue")]
	public bool AfterParamEventRealEndValue;

	[BlueprintReadWrite]
	[EditAnywhere]
	[Tooltip("主要阶段的持续时长，主要阶段结束后会进入收尾阶段；\n<=0 程序通知何时进入收尾阶段；\n>0 事件持续时间超过【总时间】后进入收尾阶段")]
	[DisplayName("时长")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModNiagara_NameAndBoolValue:Duration")]
	public float Duration;

	[UProperty]
	[DisplayName("收尾阶段时长")]
	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "<=0 表示跳过收尾阶段，在主要阶段结束后直接将参数设置为【参数值-等待事件RealEnd阶段】")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModNiagara_NameAndBoolValue:EndStageDuration")]
	public float EndStageDuration;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("每帧设置")]
	[UMeta(MD.ToolTip, "事件执行的第一帧设置一次参数值还是主要阶段内每帧都设置；如果事件正处于【收尾阶段】或【等待事件RealEnd阶段】，则忽略此项，参数一定会每帧都设置")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModNiagara_NameAndBoolValue:SetEveryFrame")]
	public bool SetEveryFrame;

	private static int BUC_DispLibUtil_ModNiagara_NameAndBoolValue_StructSize;

	private static int BUC_DispLibUtil_ModNiagara_NameAndBoolValue_IsValid;

	private static bool ParamName_IsValid;

	private static int ParamName_Offset;

	private static bool Value_IsValid;

	private static int Value_Offset;

	private static FFieldAddress Value_PropertyAddress;

	private static bool EndDispStageValue_IsValid;

	private static int EndDispStageValue_Offset;

	private static FFieldAddress EndDispStageValue_PropertyAddress;

	private static bool AfterParamEventRealEndValue_IsValid;

	private static int AfterParamEventRealEndValue_Offset;

	private static FFieldAddress AfterParamEventRealEndValue_PropertyAddress;

	private static bool Duration_IsValid;

	private static int Duration_Offset;

	private static bool EndStageDuration_IsValid;

	private static int EndStageDuration_Offset;

	private static bool SetEveryFrame_IsValid;

	private static int SetEveryFrame_Offset;

	private static FFieldAddress SetEveryFrame_PropertyAddress;

	public bool IsValid()
	{
		if (ParamName == default(FName) || ParamName.PlainName == "GS_EfxStop" || ParamName.PlainName == "User.GS_EfxStop")
		{
			return false;
		}
		return true;
	}

	public bool NeedVelocity()
	{
		return false;
	}

	public BUC_DispLibUtil_ModNiagara_NameAndBoolValue Copy()
	{
		return this;
	}

	public static BUC_DispLibUtil_ModNiagara_NameAndBoolValue FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibUtil_ModNiagara_NameAndBoolValue(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibUtil_ModNiagara_NameAndBoolValue value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibUtil_ModNiagara_NameAndBoolValue FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibUtil_ModNiagara_NameAndBoolValue(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_ModNiagara_NameAndBoolValue_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibUtil_ModNiagara_NameAndBoolValue value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_ModNiagara_NameAndBoolValue_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_ModNiagara_NameAndBoolValue_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_ModNiagara_NameAndBoolValue");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParamName_Offset), ParamName);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Value_Offset), 0, Value_PropertyAddress.Address, Value);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EndDispStageValue_Offset), 0, EndDispStageValue_PropertyAddress.Address, EndDispStageValue);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AfterParamEventRealEndValue_Offset), 0, AfterParamEventRealEndValue_PropertyAddress.Address, AfterParamEventRealEndValue);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Duration_Offset), Duration);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, EndStageDuration_Offset), EndStageDuration);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SetEveryFrame_Offset), 0, SetEveryFrame_PropertyAddress.Address, SetEveryFrame);
	}

	public BUC_DispLibUtil_ModNiagara_NameAndBoolValue(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_ModNiagara_NameAndBoolValue_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_ModNiagara_NameAndBoolValue");
			ParamName = default(FName);
			Value = false;
			EndDispStageValue = false;
			AfterParamEventRealEndValue = false;
			Duration = 0f;
			EndStageDuration = 0f;
			SetEveryFrame = false;
		}
		else
		{
			ParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ParamName_Offset));
			Value = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Value_Offset), 0, Value_PropertyAddress.Address);
			EndDispStageValue = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EndDispStageValue_Offset), 0, EndDispStageValue_PropertyAddress.Address);
			AfterParamEventRealEndValue = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AfterParamEventRealEndValue_Offset), 0, AfterParamEventRealEndValue_PropertyAddress.Address);
			Duration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Duration_Offset));
			EndStageDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, EndStageDuration_Offset));
			SetEveryFrame = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SetEveryFrame_Offset), 0, SetEveryFrame_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibUtil_ModNiagara_NameAndBoolValue");
		BUC_DispLibUtil_ModNiagara_NameAndBoolValue_StructSize = NativeReflection.GetStructSize(intPtr);
		ParamName_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParamName");
		ParamName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParamName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref Value_PropertyAddress, intPtr, "Value");
		Value_Offset = NativeReflection.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Value", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EndDispStageValue_PropertyAddress, intPtr, "EndDispStageValue");
		EndDispStageValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndDispStageValue");
		EndDispStageValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndDispStageValue", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref AfterParamEventRealEndValue_PropertyAddress, intPtr, "AfterParamEventRealEndValue");
		AfterParamEventRealEndValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "AfterParamEventRealEndValue");
		AfterParamEventRealEndValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AfterParamEventRealEndValue", Classes.FBoolProperty);
		Duration_Offset = NativeReflection.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Duration", Classes.FFloatProperty);
		EndStageDuration_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndStageDuration");
		EndStageDuration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndStageDuration", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref SetEveryFrame_PropertyAddress, intPtr, "SetEveryFrame");
		SetEveryFrame_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetEveryFrame");
		SetEveryFrame_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetEveryFrame", Classes.FBoolProperty);
		BUC_DispLibUtil_ModNiagara_NameAndBoolValue_IsValid = ((intPtr != IntPtr.Zero && ParamName_IsValid && Value_IsValid && EndDispStageValue_IsValid && AfterParamEventRealEndValue_IsValid && Duration_IsValid && EndStageDuration_IsValid && SetEveryFrame_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibUtil_ModNiagara_NameAndBoolValue", (byte)BUC_DispLibUtil_ModNiagara_NameAndBoolValue_IsValid != 0);
	}

	static BUC_DispLibUtil_ModNiagara_NameAndBoolValue()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibUtil_ModNiagara_NameAndBoolValue)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibUtil_ModNiagara_NameAndBoolValue));
	}
}
