using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.ObservationModeConfig")]
public struct FObservationModeConfig
{
	[UProperty]
	[EditAnywhere]
	[DisplayName("操作类型")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.ObservationModeConfig:ObserveOpType")]
	public EModelOperateType ObserveOpType;

	[UProperty]
	[EditAnywhere]
	[Category("旋转|水平旋转")]
	[BlueprintReadWrite]
	[DisplayName("水平旋转范围")]
	[Tooltip("填‘-1.0’代表不限范围")]
	[USharpPath("/Script/b1-Managed.ObservationModeConfig:RotationRangeYaw")]
	public float RotationRangeYaw;

	[UProperty]
	[Category("旋转|水平旋转")]
	[DisplayName("水平旋转加速度倍率 键鼠")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ObservationModeConfig:YawRotationAccMultipleFactorMouse")]
	public float YawRotationAccMultipleFactorMouse;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("水平旋转加速度倍率 手柄")]
	[Category("旋转|水平旋转")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ObservationModeConfig:YawRotationAccMultipleFactorGamepad")]
	public float YawRotationAccMultipleFactorGamepad;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("水平旋转最大加速度")]
	[Category("旋转|水平旋转")]
	[USharpPath("/Script/b1-Managed.ObservationModeConfig:YawRotationMaxAcc")]
	public float YawRotationMaxAcc;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("水平旋转停止加速度")]
	[Category("旋转|水平旋转")]
	[USharpPath("/Script/b1-Managed.ObservationModeConfig:YawRotationStopAcc")]
	public float YawRotationStopAcc;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("水平旋转最大速度")]
	[Category("旋转|水平旋转")]
	[USharpPath("/Script/b1-Managed.ObservationModeConfig:YawRotationMaxSpeed")]
	public float YawRotationMaxSpeed;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("竖直旋转范围")]
	[Tooltip("填‘-1.0’代表不限范围")]
	[Category("旋转|竖直旋转")]
	[USharpPath("/Script/b1-Managed.ObservationModeConfig:RotationRangePitch")]
	public float RotationRangePitch;

	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("竖直旋转加速度倍率 键鼠")]
	[Category("旋转|竖直旋转")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ObservationModeConfig:PitchRotationAccMultipleFactorMouse")]
	public float PitchRotationAccMultipleFactorMouse;

	[Category("旋转|竖直旋转")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("竖直旋转加速度倍率 手柄")]
	[USharpPath("/Script/b1-Managed.ObservationModeConfig:PitchRotationAccMultipleFactorGamepad")]
	public float PitchRotationAccMultipleFactorGamepad;

	[UProperty]
	[DisplayName("竖直旋转最大加速度")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("旋转|竖直旋转")]
	[USharpPath("/Script/b1-Managed.ObservationModeConfig:PitchRotationMaxAcc")]
	public float PitchRotationMaxAcc;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("竖直旋转停止加速度")]
	[Category("旋转|竖直旋转")]
	[USharpPath("/Script/b1-Managed.ObservationModeConfig:PitchRotationStopAcc")]
	public float PitchRotationStopAcc;

	[Category("旋转|竖直旋转")]
	[DisplayName("竖直旋转最大速度")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ObservationModeConfig:PitchRotationMaxSpeed")]
	public float PitchRotationMaxSpeed;

	[UMeta(MDProp.ClampMin, "1.0")]
	[Category("缩放")]
	[DisplayName("最大缩放范围")]
	[BlueprintReadWrite]
	[UProperty]
	[Tooltip("必须大于1")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ObservationModeConfig:ZoomUpRange")]
	public float ZoomUpRange;

	[DisplayName("最小缩放范围")]
	[BlueprintReadWrite]
	[UMeta(MDProp.ClampMax, "1.0")]
	[Tooltip("必须小于1")]
	[UProperty]
	[Category("缩放")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ObservationModeConfig:ZoomDownRange")]
	public float ZoomDownRange;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("缩放速度 键鼠")]
	[Tooltip("必须大于1，越大越快")]
	[Category("缩放")]
	[UMeta(MDProp.ClampMin, "1.0")]
	[USharpPath("/Script/b1-Managed.ObservationModeConfig:ZoomSpeedMouse")]
	public float ZoomSpeedMouse;

	[Tooltip("必须大于1，越大越快")]
	[UProperty]
	[EditAnywhere]
	[Category("缩放")]
	[BlueprintReadWrite]
	[DisplayName("缩放速度 手柄")]
	[UMeta(MDProp.ClampMin, "1.0")]
	[USharpPath("/Script/b1-Managed.ObservationModeConfig:ZoomSpeedGamepad")]
	public float ZoomSpeedGamepad;

	[Tooltip("不填即为默认 DragArea")]
	[DisplayName("拖拽区域名称")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.ObservationModeConfig:DragAreaName")]
	public string DragAreaName;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("观察模式拖拽区域名称")]
	[Tooltip("不填即为默认 DragArea")]
	[USharpPath("/Script/b1-Managed.ObservationModeConfig:ObsDragAreaName")]
	public string ObsDragAreaName;

	[BlueprintReadWrite]
	[DisplayName("停止判定时间")]
	[UMeta(MDProp.ClampMin, "0.0")]
	[Tooltip("决定鼠标悬停多久开始减速。如果填0即为只要不松开鼠标左键就不进入减速阶段")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ObservationModeConfig:StopJudgmentTime")]
	public float StopJudgmentTime;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("右摇杆水平输入阈值")]
	[UMeta(MDProp.ClampMin, "0.0")]
	[Tooltip("决定右摇杆水平输入的阈值，防止手柄使用右摇杆上下查看文本时触发旋转")]
	[USharpPath("/Script/b1-Managed.ObservationModeConfig:LeftStickXInputThreshold")]
	public float LeftStickXInputThreshold;

	private static int ObservationModeConfig_StructSize;

	private static int ObservationModeConfig_IsValid;

	private static bool ObserveOpType_IsValid;

	private static int ObserveOpType_Offset;

	private static FFieldAddress ObserveOpType_PropertyAddress;

	private static bool RotationRangeYaw_IsValid;

	private static int RotationRangeYaw_Offset;

	private static bool YawRotationAccMultipleFactorMouse_IsValid;

	private static int YawRotationAccMultipleFactorMouse_Offset;

	private static bool YawRotationAccMultipleFactorGamepad_IsValid;

	private static int YawRotationAccMultipleFactorGamepad_Offset;

	private static bool YawRotationMaxAcc_IsValid;

	private static int YawRotationMaxAcc_Offset;

	private static bool YawRotationStopAcc_IsValid;

	private static int YawRotationStopAcc_Offset;

	private static bool YawRotationMaxSpeed_IsValid;

	private static int YawRotationMaxSpeed_Offset;

	private static bool RotationRangePitch_IsValid;

	private static int RotationRangePitch_Offset;

	private static bool PitchRotationAccMultipleFactorMouse_IsValid;

	private static int PitchRotationAccMultipleFactorMouse_Offset;

	private static bool PitchRotationAccMultipleFactorGamepad_IsValid;

	private static int PitchRotationAccMultipleFactorGamepad_Offset;

	private static bool PitchRotationMaxAcc_IsValid;

	private static int PitchRotationMaxAcc_Offset;

	private static bool PitchRotationStopAcc_IsValid;

	private static int PitchRotationStopAcc_Offset;

	private static bool PitchRotationMaxSpeed_IsValid;

	private static int PitchRotationMaxSpeed_Offset;

	private static bool ZoomUpRange_IsValid;

	private static int ZoomUpRange_Offset;

	private static bool ZoomDownRange_IsValid;

	private static int ZoomDownRange_Offset;

	private static bool ZoomSpeedMouse_IsValid;

	private static int ZoomSpeedMouse_Offset;

	private static bool ZoomSpeedGamepad_IsValid;

	private static int ZoomSpeedGamepad_Offset;

	private static bool DragAreaName_IsValid;

	private static int DragAreaName_Offset;

	private static bool ObsDragAreaName_IsValid;

	private static int ObsDragAreaName_Offset;

	private static bool StopJudgmentTime_IsValid;

	private static int StopJudgmentTime_Offset;

	private static bool LeftStickXInputThreshold_IsValid;

	private static int LeftStickXInputThreshold_Offset;

	public FObservationModeConfig Copy()
	{
		return this;
	}

	public static FObservationModeConfig FromNative(IntPtr nativeBuffer)
	{
		return new FObservationModeConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FObservationModeConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FObservationModeConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FObservationModeConfig(IntPtr.Add(nativeBuffer, arrayIndex * ObservationModeConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FObservationModeConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ObservationModeConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ObservationModeConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ObservationModeConfig");
			return;
		}
		EnumMarshaler<EModelOperateType>.ToNative(IntPtr.Add(nativeStruct, ObserveOpType_Offset), 0, ObserveOpType_PropertyAddress.Address, ObserveOpType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RotationRangeYaw_Offset), RotationRangeYaw);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, YawRotationAccMultipleFactorMouse_Offset), YawRotationAccMultipleFactorMouse);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, YawRotationAccMultipleFactorGamepad_Offset), YawRotationAccMultipleFactorGamepad);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, YawRotationMaxAcc_Offset), YawRotationMaxAcc);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, YawRotationStopAcc_Offset), YawRotationStopAcc);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, YawRotationMaxSpeed_Offset), YawRotationMaxSpeed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RotationRangePitch_Offset), RotationRangePitch);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PitchRotationAccMultipleFactorMouse_Offset), PitchRotationAccMultipleFactorMouse);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PitchRotationAccMultipleFactorGamepad_Offset), PitchRotationAccMultipleFactorGamepad);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PitchRotationMaxAcc_Offset), PitchRotationMaxAcc);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PitchRotationStopAcc_Offset), PitchRotationStopAcc);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PitchRotationMaxSpeed_Offset), PitchRotationMaxSpeed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ZoomUpRange_Offset), ZoomUpRange);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ZoomDownRange_Offset), ZoomDownRange);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ZoomSpeedMouse_Offset), ZoomSpeedMouse);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ZoomSpeedGamepad_Offset), ZoomSpeedGamepad);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, DragAreaName_Offset), DragAreaName);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ObsDragAreaName_Offset), ObsDragAreaName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, StopJudgmentTime_Offset), StopJudgmentTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LeftStickXInputThreshold_Offset), LeftStickXInputThreshold);
	}

	public FObservationModeConfig(IntPtr nativeStruct)
	{
		if (ObservationModeConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ObservationModeConfig");
			ObserveOpType = EModelOperateType.UnableOperate;
			RotationRangeYaw = 0f;
			YawRotationAccMultipleFactorMouse = 0f;
			YawRotationAccMultipleFactorGamepad = 0f;
			YawRotationMaxAcc = 0f;
			YawRotationStopAcc = 0f;
			YawRotationMaxSpeed = 0f;
			RotationRangePitch = 0f;
			PitchRotationAccMultipleFactorMouse = 0f;
			PitchRotationAccMultipleFactorGamepad = 0f;
			PitchRotationMaxAcc = 0f;
			PitchRotationStopAcc = 0f;
			PitchRotationMaxSpeed = 0f;
			ZoomUpRange = 0f;
			ZoomDownRange = 0f;
			ZoomSpeedMouse = 0f;
			ZoomSpeedGamepad = 0f;
			DragAreaName = null;
			ObsDragAreaName = null;
			StopJudgmentTime = 0f;
			LeftStickXInputThreshold = 0f;
		}
		else
		{
			ObserveOpType = EnumMarshaler<EModelOperateType>.FromNative(IntPtr.Add(nativeStruct, ObserveOpType_Offset), 0, ObserveOpType_PropertyAddress.Address);
			RotationRangeYaw = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RotationRangeYaw_Offset));
			YawRotationAccMultipleFactorMouse = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, YawRotationAccMultipleFactorMouse_Offset));
			YawRotationAccMultipleFactorGamepad = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, YawRotationAccMultipleFactorGamepad_Offset));
			YawRotationMaxAcc = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, YawRotationMaxAcc_Offset));
			YawRotationStopAcc = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, YawRotationStopAcc_Offset));
			YawRotationMaxSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, YawRotationMaxSpeed_Offset));
			RotationRangePitch = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RotationRangePitch_Offset));
			PitchRotationAccMultipleFactorMouse = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PitchRotationAccMultipleFactorMouse_Offset));
			PitchRotationAccMultipleFactorGamepad = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PitchRotationAccMultipleFactorGamepad_Offset));
			PitchRotationMaxAcc = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PitchRotationMaxAcc_Offset));
			PitchRotationStopAcc = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PitchRotationStopAcc_Offset));
			PitchRotationMaxSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PitchRotationMaxSpeed_Offset));
			ZoomUpRange = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ZoomUpRange_Offset));
			ZoomDownRange = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ZoomDownRange_Offset));
			ZoomSpeedMouse = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ZoomSpeedMouse_Offset));
			ZoomSpeedGamepad = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ZoomSpeedGamepad_Offset));
			DragAreaName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, DragAreaName_Offset));
			ObsDragAreaName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ObsDragAreaName_Offset));
			StopJudgmentTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, StopJudgmentTime_Offset));
			LeftStickXInputThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LeftStickXInputThreshold_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ObservationModeConfig");
		ObservationModeConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref ObserveOpType_PropertyAddress, intPtr, "ObserveOpType");
		ObserveOpType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObserveOpType");
		ObserveOpType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObserveOpType", Classes.FEnumProperty);
		RotationRangeYaw_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotationRangeYaw");
		RotationRangeYaw_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotationRangeYaw", Classes.FFloatProperty);
		YawRotationAccMultipleFactorMouse_Offset = NativeReflection.GetPropertyOffset(intPtr, "YawRotationAccMultipleFactorMouse");
		YawRotationAccMultipleFactorMouse_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "YawRotationAccMultipleFactorMouse", Classes.FFloatProperty);
		YawRotationAccMultipleFactorGamepad_Offset = NativeReflection.GetPropertyOffset(intPtr, "YawRotationAccMultipleFactorGamepad");
		YawRotationAccMultipleFactorGamepad_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "YawRotationAccMultipleFactorGamepad", Classes.FFloatProperty);
		YawRotationMaxAcc_Offset = NativeReflection.GetPropertyOffset(intPtr, "YawRotationMaxAcc");
		YawRotationMaxAcc_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "YawRotationMaxAcc", Classes.FFloatProperty);
		YawRotationStopAcc_Offset = NativeReflection.GetPropertyOffset(intPtr, "YawRotationStopAcc");
		YawRotationStopAcc_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "YawRotationStopAcc", Classes.FFloatProperty);
		YawRotationMaxSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "YawRotationMaxSpeed");
		YawRotationMaxSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "YawRotationMaxSpeed", Classes.FFloatProperty);
		RotationRangePitch_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotationRangePitch");
		RotationRangePitch_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotationRangePitch", Classes.FFloatProperty);
		PitchRotationAccMultipleFactorMouse_Offset = NativeReflection.GetPropertyOffset(intPtr, "PitchRotationAccMultipleFactorMouse");
		PitchRotationAccMultipleFactorMouse_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PitchRotationAccMultipleFactorMouse", Classes.FFloatProperty);
		PitchRotationAccMultipleFactorGamepad_Offset = NativeReflection.GetPropertyOffset(intPtr, "PitchRotationAccMultipleFactorGamepad");
		PitchRotationAccMultipleFactorGamepad_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PitchRotationAccMultipleFactorGamepad", Classes.FFloatProperty);
		PitchRotationMaxAcc_Offset = NativeReflection.GetPropertyOffset(intPtr, "PitchRotationMaxAcc");
		PitchRotationMaxAcc_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PitchRotationMaxAcc", Classes.FFloatProperty);
		PitchRotationStopAcc_Offset = NativeReflection.GetPropertyOffset(intPtr, "PitchRotationStopAcc");
		PitchRotationStopAcc_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PitchRotationStopAcc", Classes.FFloatProperty);
		PitchRotationMaxSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "PitchRotationMaxSpeed");
		PitchRotationMaxSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PitchRotationMaxSpeed", Classes.FFloatProperty);
		ZoomUpRange_Offset = NativeReflection.GetPropertyOffset(intPtr, "ZoomUpRange");
		ZoomUpRange_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ZoomUpRange", Classes.FFloatProperty);
		ZoomDownRange_Offset = NativeReflection.GetPropertyOffset(intPtr, "ZoomDownRange");
		ZoomDownRange_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ZoomDownRange", Classes.FFloatProperty);
		ZoomSpeedMouse_Offset = NativeReflection.GetPropertyOffset(intPtr, "ZoomSpeedMouse");
		ZoomSpeedMouse_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ZoomSpeedMouse", Classes.FFloatProperty);
		ZoomSpeedGamepad_Offset = NativeReflection.GetPropertyOffset(intPtr, "ZoomSpeedGamepad");
		ZoomSpeedGamepad_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ZoomSpeedGamepad", Classes.FFloatProperty);
		DragAreaName_Offset = NativeReflection.GetPropertyOffset(intPtr, "DragAreaName");
		DragAreaName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DragAreaName", Classes.FStrProperty);
		ObsDragAreaName_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObsDragAreaName");
		ObsDragAreaName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObsDragAreaName", Classes.FStrProperty);
		StopJudgmentTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "StopJudgmentTime");
		StopJudgmentTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StopJudgmentTime", Classes.FFloatProperty);
		LeftStickXInputThreshold_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeftStickXInputThreshold");
		LeftStickXInputThreshold_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeftStickXInputThreshold", Classes.FFloatProperty);
		ObservationModeConfig_IsValid = ((intPtr != IntPtr.Zero && ObserveOpType_IsValid && RotationRangeYaw_IsValid && YawRotationAccMultipleFactorMouse_IsValid && YawRotationAccMultipleFactorGamepad_IsValid && YawRotationMaxAcc_IsValid && YawRotationStopAcc_IsValid && YawRotationMaxSpeed_IsValid && RotationRangePitch_IsValid && PitchRotationAccMultipleFactorMouse_IsValid && PitchRotationAccMultipleFactorGamepad_IsValid && PitchRotationMaxAcc_IsValid && PitchRotationStopAcc_IsValid && PitchRotationMaxSpeed_IsValid && ZoomUpRange_IsValid && ZoomDownRange_IsValid && ZoomSpeedMouse_IsValid && ZoomSpeedGamepad_IsValid && DragAreaName_IsValid && ObsDragAreaName_IsValid && StopJudgmentTime_IsValid && LeftStickXInputThreshold_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ObservationModeConfig", (byte)ObservationModeConfig_IsValid != 0);
	}

	static FObservationModeConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FObservationModeConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FObservationModeConfig));
	}
}
