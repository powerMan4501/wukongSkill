using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor")]
public struct BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("模式")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor:Mode")]
	public DispLibDBCAdvProcessModifyNiagaraParamUtilMode Mode;

	[UMeta(MDProp.EditCondition, "Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::Standard || Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::RandomOnSpawn")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("每帧设置")]
	[UMeta(MD.ToolTip, "单值模式时，是在事件执行的第一帧设置一次还是事件持续时间内每帧都设置")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor:SetEveryFrame")]
	public bool SetEveryFrame;

	[UMeta(MDProp.EditCondition, "Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::SpecAtt || Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::SpecAttUCurve")]
	[DisplayName("特殊属性类型")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor:SpecAttType")]
	public DispLibDBCSpecialAttritubeTpye SpecAttType;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::Standard || Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::SpecAtt || Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::SpecAttUCurve")]
	[DisplayName("值")]
	[UMeta(MD.ToolTip, "【特殊属性类型】为速度时，此参数的 X分量 表示计算速度时的平滑插值速率")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor:Value")]
	public FLinearColor Value;

	[UMeta(MDProp.EditCondition, "Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::RandomOnSpawn || Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::Random")]
	[DisplayName("随机范围Min")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor:RangeMin")]
	public FLinearColor RangeMin;

	[UMeta(MDProp.EditCondition, "Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::RandomOnSpawn || Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::Random")]
	[BlueprintReadWrite]
	[DisplayName("随机范围Max")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor:RangeMax")]
	public FLinearColor RangeMax;

	[UMeta(MD.ToolTip, "true 在主要阶段内按【周期时长】循环采样曲线；\nfalse 在主要阶段内按【周期时长】采样一遍曲线，之后一直维持曲线最终值直到进入收尾阶段")]
	[UMeta(MDProp.EditCondition, "Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::TimedUCurve")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("循环")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor:Loop")]
	public bool Loop;

	[UProperty]
	[UMeta(MD.ToolTip, "<=0 按真实时间流速采样一遍曲线\n>0 真实时间按此参数归一化后再采样曲线")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("周期时长")]
	[UMeta(MDProp.EditCondition, "Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::TimedUCurve")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor:Period")]
	public float Period;

	[DisplayName("总时间")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "主要阶段的持续时长，主要阶段结束后会进入收尾阶段；\n<=0 程序通知何时进入收尾阶段；\n>0 事件持续时间超过【总时间】后进入收尾阶段")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor:Duration")]
	public float Duration;

	[UMeta(MD.ToolTip, "TODO: ModNiagara事件没有真的参数控制权的概念，也没有参数自动还原机制，因为用的地方很少，真需要再写此参数事件进入收尾阶段后，收尾阶段持续多长时间。注意，何时进入收尾阶段取决于此参数事件的【总时间】，如果【总时间】小于等于0，此参数事件的收尾阶段会和事件整体的结束表现阶段同时开始\n<0 收尾阶段一直持续，直到整个父级事件RealEnd，收尾阶段参数一直维持主要阶段的最终值；\n=0 分两种情况：如果【总时间】小于等于0，收尾阶段一直持续，直到整个父级事件RealEnd，收尾阶段的第一帧直接设置参数为【收尾至】并一直维持；如果【总时间】大于0，相当于没有收尾阶段，【收尾至】是无效参数，会立即释放参数控制权\n>0 收尾阶段将持续此参数配置的时间，收尾阶段参数值将从主要阶段的最终值逐渐插值至【收尾至】，但注意，如果收尾阶段还没结束整个事件就结束了，画面表现极可能是：参数还没插值到【收尾至】参数值就被瞬间还原为原始值；\n不论何种情况，收尾阶段结束后都会释放参数控制权，如果没有其他事件在操作此参数，参数将自动重置为原始值，原始值一般是角色出生时该参数的值；")]
	[DisplayName("收尾时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor:EndStageDuration")]
	public float EndStageDuration;

	[UMeta(MDProp.EditCondition, "EndStageDuration >= 0")]
	[DisplayName("收尾至")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor:EndValue")]
	public FLinearColor EndValue;

	[UMeta(MDProp.EditCondition, "Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::TimedUCurve || Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::SpecAttUCurve")]
	[DisplayName("Y轴缩放")]
	[UMeta(MD.ToolTip, "注意，曲线上所有点的Y值都会缩放，这可能导致初始值变化")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor:Scale")]
	public float Scale;

	[BlueprintReadWrite]
	[UProperty]
	[UMeta(MDProp.EditCondition, "Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::TimedUCurve || Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::SpecAttUCurve")]
	[EditAnywhere]
	[DisplayName("曲线")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor:Curve")]
	public UCurveLinearColor Curve;

	private static int BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor_StructSize;

	private static int BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor_IsValid;

	private static bool Mode_IsValid;

	private static int Mode_Offset;

	private static FFieldAddress Mode_PropertyAddress;

	private static bool SetEveryFrame_IsValid;

	private static int SetEveryFrame_Offset;

	private static FFieldAddress SetEveryFrame_PropertyAddress;

	private static bool SpecAttType_IsValid;

	private static int SpecAttType_Offset;

	private static FFieldAddress SpecAttType_PropertyAddress;

	private static bool Value_IsValid;

	private static int Value_Offset;

	private static bool RangeMin_IsValid;

	private static int RangeMin_Offset;

	private static bool RangeMax_IsValid;

	private static int RangeMax_Offset;

	private static bool Loop_IsValid;

	private static int Loop_Offset;

	private static FFieldAddress Loop_PropertyAddress;

	private static bool Period_IsValid;

	private static int Period_Offset;

	private static bool Duration_IsValid;

	private static int Duration_Offset;

	private static bool EndStageDuration_IsValid;

	private static int EndStageDuration_Offset;

	private static bool EndValue_IsValid;

	private static int EndValue_Offset;

	private static bool Scale_IsValid;

	private static int Scale_Offset;

	private static bool Curve_IsValid;

	private static int Curve_Offset;

	public bool IsZeroData()
	{
		switch (Mode)
		{
		case DispLibDBCAdvProcessModifyNiagaraParamUtilMode.Standard:
			if (Value == default(FLinearColor))
			{
				return true;
			}
			break;
		case DispLibDBCAdvProcessModifyNiagaraParamUtilMode.RandomOnSpawn:
		case DispLibDBCAdvProcessModifyNiagaraParamUtilMode.Random:
			if (RangeMin == FLinearColor.Black && RangeMax == FLinearColor.Black)
			{
				return true;
			}
			break;
		case DispLibDBCAdvProcessModifyNiagaraParamUtilMode.TimedUCurve:
		case DispLibDBCAdvProcessModifyNiagaraParamUtilMode.SpecAttUCurve:
			if (Curve.IsNullOrDestroyed() || Scale == 0f)
			{
				return true;
			}
			break;
		default:
			return false;
		}
		return false;
	}

	public bool NeedVelocity()
	{
		if (Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.SpecAtt || Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode.SpecAttUCurve)
		{
			return SpecAttType == DispLibDBCSpecialAttritubeTpye.Velocity;
		}
		return false;
	}

	public BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor Copy()
	{
		return this;
	}

	public static BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor");
			return;
		}
		EnumMarshaler<DispLibDBCAdvProcessModifyNiagaraParamUtilMode>.ToNative(IntPtr.Add(nativeStruct, Mode_Offset), 0, Mode_PropertyAddress.Address, Mode);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SetEveryFrame_Offset), 0, SetEveryFrame_PropertyAddress.Address, SetEveryFrame);
		EnumMarshaler<DispLibDBCSpecialAttritubeTpye>.ToNative(IntPtr.Add(nativeStruct, SpecAttType_Offset), 0, SpecAttType_PropertyAddress.Address, SpecAttType);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, RangeMin_Offset), RangeMin);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, RangeMax_Offset), RangeMax);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Loop_Offset), 0, Loop_PropertyAddress.Address, Loop);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Period_Offset), Period);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Duration_Offset), Duration);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, EndStageDuration_Offset), EndStageDuration);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, EndValue_Offset), EndValue);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Scale_Offset), Scale);
		UObjectMarshaler<UCurveLinearColor>.ToNative(IntPtr.Add(nativeStruct, Curve_Offset), Curve);
	}

	public BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor");
			Mode = DispLibDBCAdvProcessModifyNiagaraParamUtilMode.Standard;
			SetEveryFrame = false;
			SpecAttType = DispLibDBCSpecialAttritubeTpye.Velocity;
			Value = default(FLinearColor);
			RangeMin = default(FLinearColor);
			RangeMax = default(FLinearColor);
			Loop = false;
			Period = 0f;
			Duration = 0f;
			EndStageDuration = 0f;
			EndValue = default(FLinearColor);
			Scale = 0f;
			Curve = null;
		}
		else
		{
			Mode = EnumMarshaler<DispLibDBCAdvProcessModifyNiagaraParamUtilMode>.FromNative(IntPtr.Add(nativeStruct, Mode_Offset), 0, Mode_PropertyAddress.Address);
			SetEveryFrame = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SetEveryFrame_Offset), 0, SetEveryFrame_PropertyAddress.Address);
			SpecAttType = EnumMarshaler<DispLibDBCSpecialAttritubeTpye>.FromNative(IntPtr.Add(nativeStruct, SpecAttType_Offset), 0, SpecAttType_PropertyAddress.Address);
			Value = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
			RangeMin = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, RangeMin_Offset));
			RangeMax = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, RangeMax_Offset));
			Loop = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Loop_Offset), 0, Loop_PropertyAddress.Address);
			Period = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Period_Offset));
			Duration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Duration_Offset));
			EndStageDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, EndStageDuration_Offset));
			EndValue = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, EndValue_Offset));
			Scale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Scale_Offset));
			Curve = UObjectMarshaler<UCurveLinearColor>.FromNative(IntPtr.Add(nativeStruct, Curve_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor");
		BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref Mode_PropertyAddress, intPtr, "Mode");
		Mode_Offset = NativeReflection.GetPropertyOffset(intPtr, "Mode");
		Mode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Mode", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref SetEveryFrame_PropertyAddress, intPtr, "SetEveryFrame");
		SetEveryFrame_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetEveryFrame");
		SetEveryFrame_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetEveryFrame", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SpecAttType_PropertyAddress, intPtr, "SpecAttType");
		SpecAttType_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpecAttType");
		SpecAttType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpecAttType", Classes.FEnumProperty);
		Value_Offset = NativeReflection.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Value", Classes.FStructProperty);
		RangeMin_Offset = NativeReflection.GetPropertyOffset(intPtr, "RangeMin");
		RangeMin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RangeMin", Classes.FStructProperty);
		RangeMax_Offset = NativeReflection.GetPropertyOffset(intPtr, "RangeMax");
		RangeMax_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RangeMax", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref Loop_PropertyAddress, intPtr, "Loop");
		Loop_Offset = NativeReflection.GetPropertyOffset(intPtr, "Loop");
		Loop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Loop", Classes.FBoolProperty);
		Period_Offset = NativeReflection.GetPropertyOffset(intPtr, "Period");
		Period_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Period", Classes.FFloatProperty);
		Duration_Offset = NativeReflection.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Duration", Classes.FFloatProperty);
		EndStageDuration_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndStageDuration");
		EndStageDuration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndStageDuration", Classes.FFloatProperty);
		EndValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndValue");
		EndValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndValue", Classes.FStructProperty);
		Scale_Offset = NativeReflection.GetPropertyOffset(intPtr, "Scale");
		Scale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Scale", Classes.FFloatProperty);
		Curve_Offset = NativeReflection.GetPropertyOffset(intPtr, "Curve");
		Curve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Curve", Classes.FObjectProperty);
		BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor_IsValid = ((intPtr != IntPtr.Zero && Mode_IsValid && SetEveryFrame_IsValid && SpecAttType_IsValid && Value_IsValid && RangeMin_IsValid && RangeMax_IsValid && Loop_IsValid && Period_IsValid && Duration_IsValid && EndStageDuration_IsValid && EndValue_IsValid && Scale_IsValid && Curve_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor", (byte)BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor_IsValid != 0);
	}

	static BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor));
	}
}
