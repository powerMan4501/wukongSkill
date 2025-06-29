using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessFLinearColor")]
public struct BUC_DispLibUtil_DBCAdvProcessFLinearColor
{
	[EditAnywhere]
	[UProperty]
	[DisplayName("模式")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessFLinearColor:Mode")]
	public DispLibDBCAdvProcessFLinearColorMode Mode;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("值")]
	[UMeta(MDProp.EditCondition, "Mode != DispLibDBCAdvProcessFLinearColorMode::UCurve")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessFLinearColor:Value")]
	public FLinearColor Value;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Alpha随机范围")]
	[UMeta(MD.ToolTip, "【曲线模式】或【单值模式】如果需要计算速度，此参数X值表示计算速度时的平滑插值速率，用于平滑速度抖动")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessFLinearColor:Range")]
	public FVector2D Range;

	[UMeta(MDProp.EditCondition, "Mode == DispLibDBCAdvProcessScalarMode::UCurve")]
	[DisplayName("循环")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MD.ToolTip, "true 在主要阶段内按【周期时长】循环采样曲线；\nfalse 在主要阶段内按【周期时长】采样一遍曲线，之后一直维持曲线最终值直到进入收尾阶段")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessFLinearColor:Loop")]
	public bool Loop;

	[UMeta(MDProp.EditCondition, "Mode == DispLibDBCAdvProcessFLinearColorMode::UCurve")]
	[UMeta(MD.ToolTip, "<=0 按真实时间流速采样一遍曲线\n>0 真实时间按此参数归一化后再采样曲线\n另外可配置以下特殊含义参数：\n-1000 以速度大小采样曲线")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("周期时长")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessFLinearColor:Period")]
	public float Period;

	[UMeta(MD.ToolTip, "主要阶段的持续时长，主要阶段结束后会进入收尾阶段；\n<=0 程序通知何时进入收尾阶段；\n>0 超过总时间后进入收尾阶段")]
	[DisplayName("总时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessFLinearColor:Duration")]
	public float Duration;

	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "此参数事件进入收尾阶段后，收尾阶段持续多长时间。注意，何时进入收尾阶段取决于此参数事件的【总时间】，如果【总时间】小于等于0，此参数事件的收尾阶段会和事件整体的结束表现阶段同时开始\n<0 收尾阶段一直持续，直到【释放参数控制权时机】，收尾阶段参数一直维持主要阶段的最终值；\n=0 分两种情况：如果【总时间】小于等于0，收尾阶段的第一帧直接设置参数为【收尾至】并一直维持，直到【释放参数控制权时机】\n>0 收尾阶段参数值将从主要阶段的最终值在【收尾时间】内逐渐插值至【收尾至】，但注意，如果【收尾时间】还没跑完就到了【释放参数控制权时机】，画面表现可能是：参数还没插值到【收尾至】参数值就被瞬间还原为原始值；")]
	[DisplayName("收尾时间")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessFLinearColor:EndStageDuration")]
	public float EndStageDuration;

	[UMeta(MDProp.EditCondition, "EndStageDuration >= 0")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("收尾至")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessFLinearColor:EndValue")]
	public FLinearColor EndValue;

	[UMeta(MD.ToolTip, "在什么时机释放参数控制权，释放参数控制权后，如果没有其他事件在操作此参数，参数将自动重置为原始值，原始值一般是角色出生时该参数的值；")]
	[DisplayName("释放参数控制权时机")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessFLinearColor:ReleaseParameterControlMode")]
	public DispLibDBCAdvProcessReleaseParameterControlMode ReleaseParameterControlMode;

	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "Mode == DispLibDBCAdvProcessScalarMode::UCurve")]
	[UProperty]
	[EditAnywhere]
	[UMeta(MD.ToolTip, "注意，曲线上所有点的Y值都会缩放，这可能导致初始值变化")]
	[DisplayName("Y轴缩放")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessFLinearColor:Scale")]
	public float Scale;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("曲线")]
	[UMeta(MDProp.EditCondition, "Mode == DispLibDBCAdvProcessScalarMode::UCurve")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessFLinearColor:Curve")]
	public UCurveLinearColor Curve;

	private static int BUC_DispLibUtil_DBCAdvProcessFLinearColor_StructSize;

	private static int BUC_DispLibUtil_DBCAdvProcessFLinearColor_IsValid;

	private static bool Mode_IsValid;

	private static int Mode_Offset;

	private static FFieldAddress Mode_PropertyAddress;

	private static bool Value_IsValid;

	private static int Value_Offset;

	private static bool Range_IsValid;

	private static int Range_Offset;

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

	private static bool ReleaseParameterControlMode_IsValid;

	private static int ReleaseParameterControlMode_Offset;

	private static FFieldAddress ReleaseParameterControlMode_PropertyAddress;

	private static bool Scale_IsValid;

	private static int Scale_Offset;

	private static bool Curve_IsValid;

	private static int Curve_Offset;

	public bool IsZeroData()
	{
		switch (Mode)
		{
		case DispLibDBCAdvProcessFLinearColorMode.Standard:
			if (Value == default(FLinearColor))
			{
				return true;
			}
			break;
		case DispLibDBCAdvProcessFLinearColorMode.UCurve:
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
		if (Mode == DispLibDBCAdvProcessFLinearColorMode.UCurve)
		{
			return Period == -1000f;
		}
		return false;
	}

	public BUC_DispLibUtil_DBCAdvProcessFLinearColor SetCustomData(DispLibDBCAdvProcessFLinearColorMode _Mode, FLinearColor _Value, FVector2D _Range, bool _Loop, float _Period, float _Duration, float _EndStageDuration, FLinearColor _EndValue, DispLibDBCAdvProcessReleaseParameterControlMode _ReleaseParameterControlMode, float _Scale, UCurveLinearColor _Curve)
	{
		Mode = _Mode;
		Value = _Value;
		Range = _Range;
		Loop = _Loop;
		Period = _Period;
		Duration = _Duration;
		EndStageDuration = _EndStageDuration;
		EndValue = _EndValue;
		ReleaseParameterControlMode = _ReleaseParameterControlMode;
		Scale = _Scale;
		Curve = _Curve;
		return this;
	}

	public BUC_DispLibUtil_DBCAdvProcessFLinearColor SetCustomData(FLinearColor _Value, float _Duration)
	{
		Mode = DispLibDBCAdvProcessFLinearColorMode.Standard;
		Value = _Value;
		Range = FVector2D.ZeroVector;
		Loop = false;
		Period = 0f;
		Duration = _Duration;
		EndStageDuration = 0f;
		EndValue = FLinearColor.White;
		ReleaseParameterControlMode = DispLibDBCAdvProcessReleaseParameterControlMode.OnEventRealEnd;
		Scale = 1f;
		Curve = null;
		return this;
	}

	public BUC_DispLibUtil_DBCAdvProcessFLinearColor GetDefault()
	{
		return default(BUC_DispLibUtil_DBCAdvProcessFLinearColor).SetCustomData(FLinearColor.White, 0f);
	}

	public BUC_DispLibUtil_DBCAdvProcessFLinearColor Copy()
	{
		return this;
	}

	public static BUC_DispLibUtil_DBCAdvProcessFLinearColor FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibUtil_DBCAdvProcessFLinearColor(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibUtil_DBCAdvProcessFLinearColor value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibUtil_DBCAdvProcessFLinearColor FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibUtil_DBCAdvProcessFLinearColor(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_DBCAdvProcessFLinearColor_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibUtil_DBCAdvProcessFLinearColor value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_DBCAdvProcessFLinearColor_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_DBCAdvProcessFLinearColor_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessFLinearColor");
			return;
		}
		EnumMarshaler<DispLibDBCAdvProcessFLinearColorMode>.ToNative(IntPtr.Add(nativeStruct, Mode_Offset), 0, Mode_PropertyAddress.Address, Mode);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, Range_Offset), Range);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Loop_Offset), 0, Loop_PropertyAddress.Address, Loop);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Period_Offset), Period);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Duration_Offset), Duration);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, EndStageDuration_Offset), EndStageDuration);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, EndValue_Offset), EndValue);
		EnumMarshaler<DispLibDBCAdvProcessReleaseParameterControlMode>.ToNative(IntPtr.Add(nativeStruct, ReleaseParameterControlMode_Offset), 0, ReleaseParameterControlMode_PropertyAddress.Address, ReleaseParameterControlMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Scale_Offset), Scale);
		UObjectMarshaler<UCurveLinearColor>.ToNative(IntPtr.Add(nativeStruct, Curve_Offset), Curve);
	}

	public BUC_DispLibUtil_DBCAdvProcessFLinearColor(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_DBCAdvProcessFLinearColor_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessFLinearColor");
			Mode = DispLibDBCAdvProcessFLinearColorMode.Standard;
			Value = default(FLinearColor);
			Range = default(FVector2D);
			Loop = false;
			Period = 0f;
			Duration = 0f;
			EndStageDuration = 0f;
			EndValue = default(FLinearColor);
			ReleaseParameterControlMode = DispLibDBCAdvProcessReleaseParameterControlMode.OnEventRealEnd;
			Scale = 0f;
			Curve = null;
		}
		else
		{
			Mode = EnumMarshaler<DispLibDBCAdvProcessFLinearColorMode>.FromNative(IntPtr.Add(nativeStruct, Mode_Offset), 0, Mode_PropertyAddress.Address);
			Value = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
			Range = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, Range_Offset));
			Loop = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Loop_Offset), 0, Loop_PropertyAddress.Address);
			Period = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Period_Offset));
			Duration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Duration_Offset));
			EndStageDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, EndStageDuration_Offset));
			EndValue = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, EndValue_Offset));
			ReleaseParameterControlMode = EnumMarshaler<DispLibDBCAdvProcessReleaseParameterControlMode>.FromNative(IntPtr.Add(nativeStruct, ReleaseParameterControlMode_Offset), 0, ReleaseParameterControlMode_PropertyAddress.Address);
			Scale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Scale_Offset));
			Curve = UObjectMarshaler<UCurveLinearColor>.FromNative(IntPtr.Add(nativeStruct, Curve_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessFLinearColor");
		BUC_DispLibUtil_DBCAdvProcessFLinearColor_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref Mode_PropertyAddress, intPtr, "Mode");
		Mode_Offset = NativeReflection.GetPropertyOffset(intPtr, "Mode");
		Mode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Mode", Classes.FEnumProperty);
		Value_Offset = NativeReflection.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Value", Classes.FStructProperty);
		Range_Offset = NativeReflection.GetPropertyOffset(intPtr, "Range");
		Range_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Range", Classes.FStructProperty);
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
		NativeReflection.GetPropertyRef(ref ReleaseParameterControlMode_PropertyAddress, intPtr, "ReleaseParameterControlMode");
		ReleaseParameterControlMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "ReleaseParameterControlMode");
		ReleaseParameterControlMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ReleaseParameterControlMode", Classes.FEnumProperty);
		Scale_Offset = NativeReflection.GetPropertyOffset(intPtr, "Scale");
		Scale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Scale", Classes.FFloatProperty);
		Curve_Offset = NativeReflection.GetPropertyOffset(intPtr, "Curve");
		Curve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Curve", Classes.FObjectProperty);
		BUC_DispLibUtil_DBCAdvProcessFLinearColor_IsValid = ((intPtr != IntPtr.Zero && Mode_IsValid && Value_IsValid && Range_IsValid && Loop_IsValid && Period_IsValid && Duration_IsValid && EndStageDuration_IsValid && EndValue_IsValid && ReleaseParameterControlMode_IsValid && Scale_IsValid && Curve_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibUtil_DBCAdvProcessFLinearColor", (byte)BUC_DispLibUtil_DBCAdvProcessFLinearColor_IsValid != 0);
	}

	static BUC_DispLibUtil_DBCAdvProcessFLinearColor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibUtil_DBCAdvProcessFLinearColor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibUtil_DBCAdvProcessFLinearColor));
	}
}
