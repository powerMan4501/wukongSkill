using System;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.GameplayCameras;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake")]
public struct BUC_DispLibDBC_PlayCustomCameraShake
{
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("延迟时间")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake:Delay")]
	public float Delay;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("持续时间")]
	[UMeta(MD.ToolTip, "无视各条曲线的持续时间，到达此持续时间后震屏一定立即进入结束表现阶段")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake:TotalTime")]
	public float TotalTime;

	[UProperty]
	[EditAnywhere]
	[DisplayName("结束表现时间")]
	[UMeta(MD.ToolTip, "0 = 立即结束震屏； >0 到达持续时间后会通知各曲线进入收尾阶段，再经过结束表现时间后震屏彻底结束")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake:DelayTimeAfterStop")]
	public float DelayTimeAfterStop;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("忽略保护时间")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake:ForceApply")]
	public bool ForceApply;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("相机旋转")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake:CtrlRO")]
	public bool CtrlRO;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("旋转扰动")]
	[UMeta(MDProp.EditCondition, "CtrlRO")]
	[Category("RO")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake:RO_Noise")]
	public EOscillatorWaveform RO_Noise;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("RO_Pitch_Amplitude")]
	[UMeta(MDProp.EditCondition, "CtrlRO")]
	[Category("RO")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake:RO_Pitch_Amplitude")]
	public BUC_DispLibUtil_DBCPCurveScalar RO_Pitch_Amplitude;

	[Category("RO")]
	[UMeta(MDProp.EditCondition, "CtrlRO")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("RO_Yaw_Amplitude")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake:RO_Yaw_Amplitude")]
	public BUC_DispLibUtil_DBCPCurveScalar RO_Yaw_Amplitude;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("RO_Roll_Amplitude")]
	[UMeta(MDProp.EditCondition, "CtrlRO")]
	[Category("RO")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake:RO_Roll_Amplitude")]
	public BUC_DispLibUtil_DBCPCurveScalar RO_Roll_Amplitude;

	[Category("RO")]
	[UMeta(MDProp.EditCondition, "CtrlRO")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("RO_Pitch_Frequency")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake:RO_Pitch_Frequency")]
	public BUC_DispLibUtil_DBCPCurveScalar RO_Pitch_Frequency;

	[UMeta(MDProp.EditCondition, "CtrlRO")]
	[Category("RO")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("RO_Yaw_Frequency")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake:RO_Yaw_Frequency")]
	public BUC_DispLibUtil_DBCPCurveScalar RO_Yaw_Frequency;

	[Category("RO")]
	[UMeta(MDProp.EditCondition, "CtrlRO")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("RO_Roll_Frequency")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake:RO_Roll_Frequency")]
	public BUC_DispLibUtil_DBCPCurveScalar RO_Roll_Frequency;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("相机位移")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake:CtrlLO")]
	public bool CtrlLO;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("位移扰动")]
	[UMeta(MDProp.EditCondition, "CtrlLO")]
	[Category("LO")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake:LO_Noise")]
	public EOscillatorWaveform LO_Noise;

	[Category("LO")]
	[DisplayName("LO_X_Amplitude")]
	[UProperty]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "CtrlLO")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake:LO_X_Amplitude")]
	public BUC_DispLibUtil_DBCPCurveScalar LO_X_Amplitude;

	[UMeta(MDProp.EditCondition, "CtrlLO")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("LO_Y_Amplitude")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake:LO_Y_Amplitude")]
	public BUC_DispLibUtil_DBCPCurveScalar LO_Y_Amplitude;

	[UProperty]
	[EditAnywhere]
	[DisplayName("LO_Z_Amplitude")]
	[UMeta(MDProp.EditCondition, "CtrlLO")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake:LO_Z_Amplitude")]
	public BUC_DispLibUtil_DBCPCurveScalar LO_Z_Amplitude;

	[UMeta(MDProp.EditCondition, "CtrlLO")]
	[DisplayName("LO_X_Frequency")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake:LO_X_Frequency")]
	public BUC_DispLibUtil_DBCPCurveScalar LO_X_Frequency;

	[DisplayName("LO_Y_Frequency")]
	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "CtrlLO")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake:LO_Y_Frequency")]
	public BUC_DispLibUtil_DBCPCurveScalar LO_Y_Frequency;

	[DisplayName("LO_Z_Frequency")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.EditCondition, "CtrlLO")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake:LO_Z_Frequency")]
	public BUC_DispLibUtil_DBCPCurveScalar LO_Z_Frequency;

	[EditAnywhere]
	[DisplayName("相机FOV")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake:CtrlFOV")]
	public bool CtrlFOV;

	[UMeta(MDProp.EditCondition, "CtrlFOV")]
	[DisplayName("FOV扰动")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake:FOV_Noise")]
	public EOscillatorWaveform FOV_Noise;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("FOV_Amplitude")]
	[UMeta(MDProp.EditCondition, "CtrlFOV")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake:FOV_Amplitude")]
	public BUC_DispLibUtil_DBCPCurveScalar FOV_Amplitude;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("FOV_Frequency")]
	[UMeta(MDProp.EditCondition, "CtrlFOV")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake:FOV_Frequency")]
	public BUC_DispLibUtil_DBCPCurveScalar FOV_Frequency;

	[DisplayName("启用距离衰减")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake:UseDistanceDamping")]
	public bool UseDistanceDamping;

	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "UseDistanceDamping")]
	[DisplayName("跟随插槽更新中心位置")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake:AttachedTarget")]
	public bool AttachedTarget;

	[UMeta(MDProp.EditCondition, "UseDistanceDamping")]
	[DisplayName("目标插槽")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake:AttachedTargetSocketName")]
	public FName AttachedTargetSocketName;

	[UProperty]
	[DisplayName("衰减曲线(0-1)")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "UseDistanceDamping")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake:CamShakeScaleByDistCurve")]
	public UCurveFloat CamShakeScaleByDistCurve;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("最大距离")]
	[UMeta(MDProp.EditCondition, "UseDistanceDamping")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake:MaxDistance")]
	public float MaxDistance;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("暂停优先级")]
	[UMeta(MD.ToolTip, "当触发暂停时会给定一个优先级，如果此参数大于优先级则不会被暂停")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake:PausePriority")]
	public int PausePriority;

	private static int BUC_DispLibDBC_PlayCustomCameraShake_StructSize;

	private static int BUC_DispLibDBC_PlayCustomCameraShake_IsValid;

	private static bool Delay_IsValid;

	private static int Delay_Offset;

	private static bool TotalTime_IsValid;

	private static int TotalTime_Offset;

	private static bool DelayTimeAfterStop_IsValid;

	private static int DelayTimeAfterStop_Offset;

	private static bool ForceApply_IsValid;

	private static int ForceApply_Offset;

	private static FFieldAddress ForceApply_PropertyAddress;

	private static bool CtrlRO_IsValid;

	private static int CtrlRO_Offset;

	private static FFieldAddress CtrlRO_PropertyAddress;

	private static bool RO_Noise_IsValid;

	private static int RO_Noise_Offset;

	private static FFieldAddress RO_Noise_PropertyAddress;

	private static bool RO_Pitch_Amplitude_IsValid;

	private static int RO_Pitch_Amplitude_Offset;

	private static bool RO_Yaw_Amplitude_IsValid;

	private static int RO_Yaw_Amplitude_Offset;

	private static bool RO_Roll_Amplitude_IsValid;

	private static int RO_Roll_Amplitude_Offset;

	private static bool RO_Pitch_Frequency_IsValid;

	private static int RO_Pitch_Frequency_Offset;

	private static bool RO_Yaw_Frequency_IsValid;

	private static int RO_Yaw_Frequency_Offset;

	private static bool RO_Roll_Frequency_IsValid;

	private static int RO_Roll_Frequency_Offset;

	private static bool CtrlLO_IsValid;

	private static int CtrlLO_Offset;

	private static FFieldAddress CtrlLO_PropertyAddress;

	private static bool LO_Noise_IsValid;

	private static int LO_Noise_Offset;

	private static FFieldAddress LO_Noise_PropertyAddress;

	private static bool LO_X_Amplitude_IsValid;

	private static int LO_X_Amplitude_Offset;

	private static bool LO_Y_Amplitude_IsValid;

	private static int LO_Y_Amplitude_Offset;

	private static bool LO_Z_Amplitude_IsValid;

	private static int LO_Z_Amplitude_Offset;

	private static bool LO_X_Frequency_IsValid;

	private static int LO_X_Frequency_Offset;

	private static bool LO_Y_Frequency_IsValid;

	private static int LO_Y_Frequency_Offset;

	private static bool LO_Z_Frequency_IsValid;

	private static int LO_Z_Frequency_Offset;

	private static bool CtrlFOV_IsValid;

	private static int CtrlFOV_Offset;

	private static FFieldAddress CtrlFOV_PropertyAddress;

	private static bool FOV_Noise_IsValid;

	private static int FOV_Noise_Offset;

	private static FFieldAddress FOV_Noise_PropertyAddress;

	private static bool FOV_Amplitude_IsValid;

	private static int FOV_Amplitude_Offset;

	private static bool FOV_Frequency_IsValid;

	private static int FOV_Frequency_Offset;

	private static bool UseDistanceDamping_IsValid;

	private static int UseDistanceDamping_Offset;

	private static FFieldAddress UseDistanceDamping_PropertyAddress;

	private static bool AttachedTarget_IsValid;

	private static int AttachedTarget_Offset;

	private static FFieldAddress AttachedTarget_PropertyAddress;

	private static bool AttachedTargetSocketName_IsValid;

	private static int AttachedTargetSocketName_Offset;

	private static bool CamShakeScaleByDistCurve_IsValid;

	private static int CamShakeScaleByDistCurve_Offset;

	private static bool MaxDistance_IsValid;

	private static int MaxDistance_Offset;

	private static bool PausePriority_IsValid;

	private static int PausePriority_Offset;

	public BUC_DispLibDBC_PlayCustomCameraShake Copy()
	{
		return this;
	}

	public static BUC_DispLibDBC_PlayCustomCameraShake FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibDBC_PlayCustomCameraShake(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibDBC_PlayCustomCameraShake value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibDBC_PlayCustomCameraShake FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibDBC_PlayCustomCameraShake(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_PlayCustomCameraShake_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibDBC_PlayCustomCameraShake value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_PlayCustomCameraShake_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_PlayCustomCameraShake_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Delay_Offset), Delay);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TotalTime_Offset), TotalTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DelayTimeAfterStop_Offset), DelayTimeAfterStop);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ForceApply_Offset), 0, ForceApply_PropertyAddress.Address, ForceApply);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CtrlRO_Offset), 0, CtrlRO_PropertyAddress.Address, CtrlRO);
		EnumMarshaler<EOscillatorWaveform>.ToNative(IntPtr.Add(nativeStruct, RO_Noise_Offset), 0, RO_Noise_PropertyAddress.Address, RO_Noise);
		BUC_DispLibUtil_DBCPCurveScalar.ToNative(IntPtr.Add(nativeStruct, RO_Pitch_Amplitude_Offset), RO_Pitch_Amplitude);
		BUC_DispLibUtil_DBCPCurveScalar.ToNative(IntPtr.Add(nativeStruct, RO_Yaw_Amplitude_Offset), RO_Yaw_Amplitude);
		BUC_DispLibUtil_DBCPCurveScalar.ToNative(IntPtr.Add(nativeStruct, RO_Roll_Amplitude_Offset), RO_Roll_Amplitude);
		BUC_DispLibUtil_DBCPCurveScalar.ToNative(IntPtr.Add(nativeStruct, RO_Pitch_Frequency_Offset), RO_Pitch_Frequency);
		BUC_DispLibUtil_DBCPCurveScalar.ToNative(IntPtr.Add(nativeStruct, RO_Yaw_Frequency_Offset), RO_Yaw_Frequency);
		BUC_DispLibUtil_DBCPCurveScalar.ToNative(IntPtr.Add(nativeStruct, RO_Roll_Frequency_Offset), RO_Roll_Frequency);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CtrlLO_Offset), 0, CtrlLO_PropertyAddress.Address, CtrlLO);
		EnumMarshaler<EOscillatorWaveform>.ToNative(IntPtr.Add(nativeStruct, LO_Noise_Offset), 0, LO_Noise_PropertyAddress.Address, LO_Noise);
		BUC_DispLibUtil_DBCPCurveScalar.ToNative(IntPtr.Add(nativeStruct, LO_X_Amplitude_Offset), LO_X_Amplitude);
		BUC_DispLibUtil_DBCPCurveScalar.ToNative(IntPtr.Add(nativeStruct, LO_Y_Amplitude_Offset), LO_Y_Amplitude);
		BUC_DispLibUtil_DBCPCurveScalar.ToNative(IntPtr.Add(nativeStruct, LO_Z_Amplitude_Offset), LO_Z_Amplitude);
		BUC_DispLibUtil_DBCPCurveScalar.ToNative(IntPtr.Add(nativeStruct, LO_X_Frequency_Offset), LO_X_Frequency);
		BUC_DispLibUtil_DBCPCurveScalar.ToNative(IntPtr.Add(nativeStruct, LO_Y_Frequency_Offset), LO_Y_Frequency);
		BUC_DispLibUtil_DBCPCurveScalar.ToNative(IntPtr.Add(nativeStruct, LO_Z_Frequency_Offset), LO_Z_Frequency);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CtrlFOV_Offset), 0, CtrlFOV_PropertyAddress.Address, CtrlFOV);
		EnumMarshaler<EOscillatorWaveform>.ToNative(IntPtr.Add(nativeStruct, FOV_Noise_Offset), 0, FOV_Noise_PropertyAddress.Address, FOV_Noise);
		BUC_DispLibUtil_DBCPCurveScalar.ToNative(IntPtr.Add(nativeStruct, FOV_Amplitude_Offset), FOV_Amplitude);
		BUC_DispLibUtil_DBCPCurveScalar.ToNative(IntPtr.Add(nativeStruct, FOV_Frequency_Offset), FOV_Frequency);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseDistanceDamping_Offset), 0, UseDistanceDamping_PropertyAddress.Address, UseDistanceDamping);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AttachedTarget_Offset), 0, AttachedTarget_PropertyAddress.Address, AttachedTarget);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AttachedTargetSocketName_Offset), AttachedTargetSocketName);
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(nativeStruct, CamShakeScaleByDistCurve_Offset), CamShakeScaleByDistCurve);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxDistance_Offset), MaxDistance);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PausePriority_Offset), PausePriority);
	}

	public BUC_DispLibDBC_PlayCustomCameraShake(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_PlayCustomCameraShake_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake");
			Delay = 0f;
			TotalTime = 0f;
			DelayTimeAfterStop = 0f;
			ForceApply = false;
			CtrlRO = false;
			RO_Noise = EOscillatorWaveform.SineWave;
			RO_Pitch_Amplitude = default(BUC_DispLibUtil_DBCPCurveScalar);
			RO_Yaw_Amplitude = default(BUC_DispLibUtil_DBCPCurveScalar);
			RO_Roll_Amplitude = default(BUC_DispLibUtil_DBCPCurveScalar);
			RO_Pitch_Frequency = default(BUC_DispLibUtil_DBCPCurveScalar);
			RO_Yaw_Frequency = default(BUC_DispLibUtil_DBCPCurveScalar);
			RO_Roll_Frequency = default(BUC_DispLibUtil_DBCPCurveScalar);
			CtrlLO = false;
			LO_Noise = EOscillatorWaveform.SineWave;
			LO_X_Amplitude = default(BUC_DispLibUtil_DBCPCurveScalar);
			LO_Y_Amplitude = default(BUC_DispLibUtil_DBCPCurveScalar);
			LO_Z_Amplitude = default(BUC_DispLibUtil_DBCPCurveScalar);
			LO_X_Frequency = default(BUC_DispLibUtil_DBCPCurveScalar);
			LO_Y_Frequency = default(BUC_DispLibUtil_DBCPCurveScalar);
			LO_Z_Frequency = default(BUC_DispLibUtil_DBCPCurveScalar);
			CtrlFOV = false;
			FOV_Noise = EOscillatorWaveform.SineWave;
			FOV_Amplitude = default(BUC_DispLibUtil_DBCPCurveScalar);
			FOV_Frequency = default(BUC_DispLibUtil_DBCPCurveScalar);
			UseDistanceDamping = false;
			AttachedTarget = false;
			AttachedTargetSocketName = default(FName);
			CamShakeScaleByDistCurve = null;
			MaxDistance = 0f;
			PausePriority = 0;
		}
		else
		{
			Delay = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Delay_Offset));
			TotalTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TotalTime_Offset));
			DelayTimeAfterStop = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DelayTimeAfterStop_Offset));
			ForceApply = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ForceApply_Offset), 0, ForceApply_PropertyAddress.Address);
			CtrlRO = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CtrlRO_Offset), 0, CtrlRO_PropertyAddress.Address);
			RO_Noise = EnumMarshaler<EOscillatorWaveform>.FromNative(IntPtr.Add(nativeStruct, RO_Noise_Offset), 0, RO_Noise_PropertyAddress.Address);
			RO_Pitch_Amplitude = BUC_DispLibUtil_DBCPCurveScalar.FromNative(IntPtr.Add(nativeStruct, RO_Pitch_Amplitude_Offset));
			RO_Yaw_Amplitude = BUC_DispLibUtil_DBCPCurveScalar.FromNative(IntPtr.Add(nativeStruct, RO_Yaw_Amplitude_Offset));
			RO_Roll_Amplitude = BUC_DispLibUtil_DBCPCurveScalar.FromNative(IntPtr.Add(nativeStruct, RO_Roll_Amplitude_Offset));
			RO_Pitch_Frequency = BUC_DispLibUtil_DBCPCurveScalar.FromNative(IntPtr.Add(nativeStruct, RO_Pitch_Frequency_Offset));
			RO_Yaw_Frequency = BUC_DispLibUtil_DBCPCurveScalar.FromNative(IntPtr.Add(nativeStruct, RO_Yaw_Frequency_Offset));
			RO_Roll_Frequency = BUC_DispLibUtil_DBCPCurveScalar.FromNative(IntPtr.Add(nativeStruct, RO_Roll_Frequency_Offset));
			CtrlLO = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CtrlLO_Offset), 0, CtrlLO_PropertyAddress.Address);
			LO_Noise = EnumMarshaler<EOscillatorWaveform>.FromNative(IntPtr.Add(nativeStruct, LO_Noise_Offset), 0, LO_Noise_PropertyAddress.Address);
			LO_X_Amplitude = BUC_DispLibUtil_DBCPCurveScalar.FromNative(IntPtr.Add(nativeStruct, LO_X_Amplitude_Offset));
			LO_Y_Amplitude = BUC_DispLibUtil_DBCPCurveScalar.FromNative(IntPtr.Add(nativeStruct, LO_Y_Amplitude_Offset));
			LO_Z_Amplitude = BUC_DispLibUtil_DBCPCurveScalar.FromNative(IntPtr.Add(nativeStruct, LO_Z_Amplitude_Offset));
			LO_X_Frequency = BUC_DispLibUtil_DBCPCurveScalar.FromNative(IntPtr.Add(nativeStruct, LO_X_Frequency_Offset));
			LO_Y_Frequency = BUC_DispLibUtil_DBCPCurveScalar.FromNative(IntPtr.Add(nativeStruct, LO_Y_Frequency_Offset));
			LO_Z_Frequency = BUC_DispLibUtil_DBCPCurveScalar.FromNative(IntPtr.Add(nativeStruct, LO_Z_Frequency_Offset));
			CtrlFOV = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CtrlFOV_Offset), 0, CtrlFOV_PropertyAddress.Address);
			FOV_Noise = EnumMarshaler<EOscillatorWaveform>.FromNative(IntPtr.Add(nativeStruct, FOV_Noise_Offset), 0, FOV_Noise_PropertyAddress.Address);
			FOV_Amplitude = BUC_DispLibUtil_DBCPCurveScalar.FromNative(IntPtr.Add(nativeStruct, FOV_Amplitude_Offset));
			FOV_Frequency = BUC_DispLibUtil_DBCPCurveScalar.FromNative(IntPtr.Add(nativeStruct, FOV_Frequency_Offset));
			UseDistanceDamping = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseDistanceDamping_Offset), 0, UseDistanceDamping_PropertyAddress.Address);
			AttachedTarget = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AttachedTarget_Offset), 0, AttachedTarget_PropertyAddress.Address);
			AttachedTargetSocketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AttachedTargetSocketName_Offset));
			CamShakeScaleByDistCurve = UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(nativeStruct, CamShakeScaleByDistCurve_Offset));
			MaxDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxDistance_Offset));
			PausePriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PausePriority_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake");
		BUC_DispLibDBC_PlayCustomCameraShake_StructSize = NativeReflection.GetStructSize(intPtr);
		Delay_Offset = NativeReflection.GetPropertyOffset(intPtr, "Delay");
		Delay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Delay", Classes.FFloatProperty);
		TotalTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "TotalTime");
		TotalTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TotalTime", Classes.FFloatProperty);
		DelayTimeAfterStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "DelayTimeAfterStop");
		DelayTimeAfterStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DelayTimeAfterStop", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref ForceApply_PropertyAddress, intPtr, "ForceApply");
		ForceApply_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForceApply");
		ForceApply_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForceApply", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref CtrlRO_PropertyAddress, intPtr, "CtrlRO");
		CtrlRO_Offset = NativeReflection.GetPropertyOffset(intPtr, "CtrlRO");
		CtrlRO_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CtrlRO", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref RO_Noise_PropertyAddress, intPtr, "RO_Noise");
		RO_Noise_Offset = NativeReflection.GetPropertyOffset(intPtr, "RO_Noise");
		RO_Noise_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RO_Noise", Classes.FEnumProperty);
		RO_Pitch_Amplitude_Offset = NativeReflection.GetPropertyOffset(intPtr, "RO_Pitch_Amplitude");
		RO_Pitch_Amplitude_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RO_Pitch_Amplitude", Classes.FStructProperty);
		RO_Yaw_Amplitude_Offset = NativeReflection.GetPropertyOffset(intPtr, "RO_Yaw_Amplitude");
		RO_Yaw_Amplitude_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RO_Yaw_Amplitude", Classes.FStructProperty);
		RO_Roll_Amplitude_Offset = NativeReflection.GetPropertyOffset(intPtr, "RO_Roll_Amplitude");
		RO_Roll_Amplitude_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RO_Roll_Amplitude", Classes.FStructProperty);
		RO_Pitch_Frequency_Offset = NativeReflection.GetPropertyOffset(intPtr, "RO_Pitch_Frequency");
		RO_Pitch_Frequency_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RO_Pitch_Frequency", Classes.FStructProperty);
		RO_Yaw_Frequency_Offset = NativeReflection.GetPropertyOffset(intPtr, "RO_Yaw_Frequency");
		RO_Yaw_Frequency_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RO_Yaw_Frequency", Classes.FStructProperty);
		RO_Roll_Frequency_Offset = NativeReflection.GetPropertyOffset(intPtr, "RO_Roll_Frequency");
		RO_Roll_Frequency_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RO_Roll_Frequency", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref CtrlLO_PropertyAddress, intPtr, "CtrlLO");
		CtrlLO_Offset = NativeReflection.GetPropertyOffset(intPtr, "CtrlLO");
		CtrlLO_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CtrlLO", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref LO_Noise_PropertyAddress, intPtr, "LO_Noise");
		LO_Noise_Offset = NativeReflection.GetPropertyOffset(intPtr, "LO_Noise");
		LO_Noise_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LO_Noise", Classes.FEnumProperty);
		LO_X_Amplitude_Offset = NativeReflection.GetPropertyOffset(intPtr, "LO_X_Amplitude");
		LO_X_Amplitude_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LO_X_Amplitude", Classes.FStructProperty);
		LO_Y_Amplitude_Offset = NativeReflection.GetPropertyOffset(intPtr, "LO_Y_Amplitude");
		LO_Y_Amplitude_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LO_Y_Amplitude", Classes.FStructProperty);
		LO_Z_Amplitude_Offset = NativeReflection.GetPropertyOffset(intPtr, "LO_Z_Amplitude");
		LO_Z_Amplitude_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LO_Z_Amplitude", Classes.FStructProperty);
		LO_X_Frequency_Offset = NativeReflection.GetPropertyOffset(intPtr, "LO_X_Frequency");
		LO_X_Frequency_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LO_X_Frequency", Classes.FStructProperty);
		LO_Y_Frequency_Offset = NativeReflection.GetPropertyOffset(intPtr, "LO_Y_Frequency");
		LO_Y_Frequency_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LO_Y_Frequency", Classes.FStructProperty);
		LO_Z_Frequency_Offset = NativeReflection.GetPropertyOffset(intPtr, "LO_Z_Frequency");
		LO_Z_Frequency_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LO_Z_Frequency", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref CtrlFOV_PropertyAddress, intPtr, "CtrlFOV");
		CtrlFOV_Offset = NativeReflection.GetPropertyOffset(intPtr, "CtrlFOV");
		CtrlFOV_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CtrlFOV", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref FOV_Noise_PropertyAddress, intPtr, "FOV_Noise");
		FOV_Noise_Offset = NativeReflection.GetPropertyOffset(intPtr, "FOV_Noise");
		FOV_Noise_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FOV_Noise", Classes.FEnumProperty);
		FOV_Amplitude_Offset = NativeReflection.GetPropertyOffset(intPtr, "FOV_Amplitude");
		FOV_Amplitude_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FOV_Amplitude", Classes.FStructProperty);
		FOV_Frequency_Offset = NativeReflection.GetPropertyOffset(intPtr, "FOV_Frequency");
		FOV_Frequency_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FOV_Frequency", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UseDistanceDamping_PropertyAddress, intPtr, "UseDistanceDamping");
		UseDistanceDamping_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseDistanceDamping");
		UseDistanceDamping_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseDistanceDamping", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref AttachedTarget_PropertyAddress, intPtr, "AttachedTarget");
		AttachedTarget_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachedTarget");
		AttachedTarget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachedTarget", Classes.FBoolProperty);
		AttachedTargetSocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachedTargetSocketName");
		AttachedTargetSocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachedTargetSocketName", Classes.FNameProperty);
		CamShakeScaleByDistCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "CamShakeScaleByDistCurve");
		CamShakeScaleByDistCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CamShakeScaleByDistCurve", Classes.FObjectProperty);
		MaxDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxDistance");
		MaxDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxDistance", Classes.FFloatProperty);
		PausePriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "PausePriority");
		PausePriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PausePriority", Classes.FIntProperty);
		BUC_DispLibDBC_PlayCustomCameraShake_IsValid = ((intPtr != IntPtr.Zero && Delay_IsValid && TotalTime_IsValid && DelayTimeAfterStop_IsValid && ForceApply_IsValid && CtrlRO_IsValid && RO_Noise_IsValid && RO_Pitch_Amplitude_IsValid && RO_Yaw_Amplitude_IsValid && RO_Roll_Amplitude_IsValid && RO_Pitch_Frequency_IsValid && RO_Yaw_Frequency_IsValid && RO_Roll_Frequency_IsValid && CtrlLO_IsValid && LO_Noise_IsValid && LO_X_Amplitude_IsValid && LO_Y_Amplitude_IsValid && LO_Z_Amplitude_IsValid && LO_X_Frequency_IsValid && LO_Y_Frequency_IsValid && LO_Z_Frequency_IsValid && CtrlFOV_IsValid && FOV_Noise_IsValid && FOV_Amplitude_IsValid && FOV_Frequency_IsValid && UseDistanceDamping_IsValid && AttachedTarget_IsValid && AttachedTargetSocketName_IsValid && CamShakeScaleByDistCurve_IsValid && MaxDistance_IsValid && PausePriority_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibDBC_PlayCustomCameraShake", (byte)BUC_DispLibDBC_PlayCustomCameraShake_IsValid != 0);
	}

	static BUC_DispLibDBC_PlayCustomCameraShake()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibDBC_PlayCustomCameraShake)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibDBC_PlayCustomCameraShake));
	}
}
