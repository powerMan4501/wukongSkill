using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FVector")]
public struct BUC_DispLibUtil_ModifyNiagaraParams_FVector
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("模式")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FVector:Mode")]
	public DispLibDBCAdvProcessModifyNiagaraParamUtilMode Mode;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("每帧设置")]
	[UMeta(MD.ToolTip, "单值模式时，是在事件执行的第一帧设置一次还是事件持续时间内每帧都设置")]
	[UMeta(MDProp.EditCondition, "Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::Standard || Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::RandomOnSpawn")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FVector:SetEveryFrame")]
	public bool SetEveryFrame;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[UMeta(MDProp.EditCondition, "Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::SpecAtt || Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::SpecAttUCurve")]
	[DisplayName("特殊属性类型")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FVector:SpecAttType")]
	public DispLibDBCSpecialAttritubeTpye SpecAttType;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("值")]
	[UMeta(MDProp.EditCondition, "Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::Standard || Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::SpecAtt || Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::SpecAttUCurve")]
	[UMeta(MD.ToolTip, "【特殊属性类型】为速度时，此参数的 X分量 表示计算速度时的平滑插值速率")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FVector:Value")]
	public FVector Value;

	[UMeta(MDProp.EditCondition, "Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::RandomOnSpawn || Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::Random")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("随机范围Min")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FVector:RangeMin")]
	public FVector RangeMin;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("随机范围Max")]
	[UMeta(MDProp.EditCondition, "Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::RandomOnSpawn || Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::Random")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FVector:RangeMax")]
	public FVector RangeMax;

	[UMeta(MDProp.EditCondition, "Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::TimedUCurve")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("循环")]
	[UMeta(MD.ToolTip, "true 在主要阶段内按【周期时长】循环采样曲线；\nfalse 在主要阶段内按【周期时长】采样一遍曲线，之后一直维持曲线最终值直到进入收尾阶段")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FVector:Loop")]
	public bool Loop;

	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::TimedUCurve")]
	[DisplayName("周期时长")]
	[EditAnywhere]
	[UProperty]
	[UMeta(MD.ToolTip, "<=0 按真实时间流速采样一遍曲线\n>0 真实时间按此参数归一化后再采样曲线")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FVector:Period")]
	public float Period;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("总时间")]
	[UMeta(MD.ToolTip, "主要阶段的持续时长，主要阶段结束后会进入收尾阶段；\n<=0 程序通知何时进入收尾阶段；\n>0 事件持续时间超过【总时间】后进入收尾阶段")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FVector:Duration")]
	public float Duration;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("收尾时间")]
	[UMeta(MD.ToolTip, "TODO: ModNiagara事件没有真的参数控制权的概念，也没有参数自动还原机制，因为用的地方很少，真需要再写此参数事件进入收尾阶段后，收尾阶段持续多长时间。注意，何时进入收尾阶段取决于此参数事件的【总时间】，如果【总时间】小于等于0，此参数事件的收尾阶段会和事件整体的结束表现阶段同时开始\n<0 收尾阶段一直持续，直到整个父级事件RealEnd，收尾阶段参数一直维持主要阶段的最终值；\n=0 分两种情况：如果【总时间】小于等于0，收尾阶段一直持续，直到整个父级事件RealEnd，收尾阶段的第一帧直接设置参数为【收尾至】并一直维持；如果【总时间】大于0，相当于没有收尾阶段，【收尾至】是无效参数，会立即释放参数控制权\n>0 收尾阶段将持续此参数配置的时间，收尾阶段参数值将从主要阶段的最终值逐渐插值至【收尾至】，但注意，如果收尾阶段还没结束整个事件就结束了，画面表现极可能是：参数还没插值到【收尾至】参数值就被瞬间还原为原始值；\n不论何种情况，收尾阶段结束后都会释放参数控制权，如果没有其他事件在操作此参数，参数将自动重置为原始值，原始值一般是角色出生时该参数的值；")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FVector:EndStageDuration")]
	public float EndStageDuration;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "EndStageDuration >= 0")]
	[DisplayName("收尾至")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FVector:EndValue")]
	public FVector EndValue;

	[UMeta(MDProp.EditCondition, "Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::TimedUCurve || Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::SpecAttUCurve")]
	[UMeta(MD.ToolTip, "注意，曲线上所有点的Y值都会缩放，这可能导致初始值变化")]
	[DisplayName("Y轴缩放")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FVector:Scale")]
	public float Scale;

	[DisplayName("曲线")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.EditCondition, "Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::TimedUCurve || Mode == DispLibDBCAdvProcessModifyNiagaraParamUtilMode::SpecAttUCurve")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FVector:Curve")]
	public UCurveVector Curve;

	private static int BUC_DispLibUtil_ModifyNiagaraParams_FVector_StructSize;

	private static int BUC_DispLibUtil_ModifyNiagaraParams_FVector_IsValid;

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
			if (Value == default(FVector))
			{
				return true;
			}
			break;
		case DispLibDBCAdvProcessModifyNiagaraParamUtilMode.RandomOnSpawn:
		case DispLibDBCAdvProcessModifyNiagaraParamUtilMode.Random:
			if (RangeMin == FVector.ZeroVector && RangeMax == FVector.ZeroVector)
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

	public BUC_DispLibUtil_ModifyNiagaraParams_FVector Copy()
	{
		return this;
	}

	public static BUC_DispLibUtil_ModifyNiagaraParams_FVector FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibUtil_ModifyNiagaraParams_FVector(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibUtil_ModifyNiagaraParams_FVector value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibUtil_ModifyNiagaraParams_FVector FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibUtil_ModifyNiagaraParams_FVector(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_ModifyNiagaraParams_FVector_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibUtil_ModifyNiagaraParams_FVector value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_ModifyNiagaraParams_FVector_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_ModifyNiagaraParams_FVector_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FVector");
			return;
		}
		EnumMarshaler<DispLibDBCAdvProcessModifyNiagaraParamUtilMode>.ToNative(IntPtr.Add(nativeStruct, Mode_Offset), 0, Mode_PropertyAddress.Address, Mode);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SetEveryFrame_Offset), 0, SetEveryFrame_PropertyAddress.Address, SetEveryFrame);
		EnumMarshaler<DispLibDBCSpecialAttritubeTpye>.ToNative(IntPtr.Add(nativeStruct, SpecAttType_Offset), 0, SpecAttType_PropertyAddress.Address, SpecAttType);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, RangeMin_Offset), RangeMin);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, RangeMax_Offset), RangeMax);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Loop_Offset), 0, Loop_PropertyAddress.Address, Loop);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Period_Offset), Period);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Duration_Offset), Duration);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, EndStageDuration_Offset), EndStageDuration);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, EndValue_Offset), EndValue);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Scale_Offset), Scale);
		UObjectMarshaler<UCurveVector>.ToNative(IntPtr.Add(nativeStruct, Curve_Offset), Curve);
	}

	public BUC_DispLibUtil_ModifyNiagaraParams_FVector(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_ModifyNiagaraParams_FVector_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FVector");
			Mode = DispLibDBCAdvProcessModifyNiagaraParamUtilMode.Standard;
			SetEveryFrame = false;
			SpecAttType = DispLibDBCSpecialAttritubeTpye.Velocity;
			Value = default(FVector);
			RangeMin = default(FVector);
			RangeMax = default(FVector);
			Loop = false;
			Period = 0f;
			Duration = 0f;
			EndStageDuration = 0f;
			EndValue = default(FVector);
			Scale = 0f;
			Curve = null;
		}
		else
		{
			Mode = EnumMarshaler<DispLibDBCAdvProcessModifyNiagaraParamUtilMode>.FromNative(IntPtr.Add(nativeStruct, Mode_Offset), 0, Mode_PropertyAddress.Address);
			SetEveryFrame = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SetEveryFrame_Offset), 0, SetEveryFrame_PropertyAddress.Address);
			SpecAttType = EnumMarshaler<DispLibDBCSpecialAttritubeTpye>.FromNative(IntPtr.Add(nativeStruct, SpecAttType_Offset), 0, SpecAttType_PropertyAddress.Address);
			Value = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
			RangeMin = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, RangeMin_Offset));
			RangeMax = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, RangeMax_Offset));
			Loop = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Loop_Offset), 0, Loop_PropertyAddress.Address);
			Period = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Period_Offset));
			Duration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Duration_Offset));
			EndStageDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, EndStageDuration_Offset));
			EndValue = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, EndValue_Offset));
			Scale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Scale_Offset));
			Curve = UObjectMarshaler<UCurveVector>.FromNative(IntPtr.Add(nativeStruct, Curve_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FVector");
		BUC_DispLibUtil_ModifyNiagaraParams_FVector_StructSize = NativeReflection.GetStructSize(intPtr);
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
		BUC_DispLibUtil_ModifyNiagaraParams_FVector_IsValid = ((intPtr != IntPtr.Zero && Mode_IsValid && SetEveryFrame_IsValid && SpecAttType_IsValid && Value_IsValid && RangeMin_IsValid && RangeMax_IsValid && Loop_IsValid && Period_IsValid && Duration_IsValid && EndStageDuration_IsValid && EndValue_IsValid && Scale_IsValid && Curve_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibUtil_ModifyNiagaraParams_FVector", (byte)BUC_DispLibUtil_ModifyNiagaraParams_FVector_IsValid != 0);
	}

	static BUC_DispLibUtil_ModifyNiagaraParams_FVector()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibUtil_ModifyNiagaraParams_FVector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibUtil_ModifyNiagaraParams_FVector));
	}
}
