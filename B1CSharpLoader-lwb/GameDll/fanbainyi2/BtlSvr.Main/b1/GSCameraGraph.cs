using System;
using UnrealEngine.Runtime;

namespace b1;

[Blueprintable]
[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.GSCameraGraph")]
public class GSCameraGraph : UObject
{
	private static bool IsG4Mode_IsValid;

	private static IntPtr IsG4Mode_FunctionAddress;

	private static int IsG4Mode_ParamsSize;

	private static bool IsG4Mode_ReturnValue_IsValid;

	private static int IsG4Mode_ReturnValue_Offset;

	private static FFieldAddress IsG4Mode_ReturnValue_PropertyAddress;

	private static bool IsLocked_IsValid;

	private static IntPtr IsLocked_FunctionAddress;

	private static int IsLocked_ParamsSize;

	private static bool IsLocked_ReturnValue_IsValid;

	private static int IsLocked_ReturnValue_Offset;

	private static FFieldAddress IsLocked_ReturnValue_PropertyAddress;

	private static bool HasTarget_IsValid;

	private static IntPtr HasTarget_FunctionAddress;

	private static int HasTarget_ParamsSize;

	private static bool HasTarget_ReturnValue_IsValid;

	private static int HasTarget_ReturnValue_Offset;

	private static FFieldAddress HasTarget_ReturnValue_PropertyAddress;

	private static bool TargetResIDEqual_IsValid;

	private static IntPtr TargetResIDEqual_FunctionAddress;

	private static int TargetResIDEqual_ParamsSize;

	private static bool TargetResIDEqual_TargetResID_IsValid;

	private static int TargetResIDEqual_TargetResID_Offset;

	private static bool TargetResIDEqual_ReturnValue_IsValid;

	private static int TargetResIDEqual_ReturnValue_Offset;

	private static FFieldAddress TargetResIDEqual_ReturnValue_PropertyAddress;

	private static bool HasNoCameraInput_IsValid;

	private static IntPtr HasNoCameraInput_FunctionAddress;

	private static int HasNoCameraInput_ParamsSize;

	private static bool HasNoCameraInput_DurationTime_IsValid;

	private static int HasNoCameraInput_DurationTime_Offset;

	private static bool HasNoCameraInput_ReturnValue_IsValid;

	private static int HasNoCameraInput_ReturnValue_Offset;

	private static FFieldAddress HasNoCameraInput_ReturnValue_PropertyAddress;

	private static bool IsUseGuiBeiCamera_IsValid;

	private static IntPtr IsUseGuiBeiCamera_FunctionAddress;

	private static int IsUseGuiBeiCamera_ParamsSize;

	private static bool IsUseGuiBeiCamera_ReturnValue_IsValid;

	private static int IsUseGuiBeiCamera_ReturnValue_Offset;

	private static FFieldAddress IsUseGuiBeiCamera_ReturnValue_PropertyAddress;

	private static bool OnCameraGraphTick_IsValid;

	private static IntPtr OnCameraGraphTick_FunctionAddress;

	private static int OnCameraGraphTick_ParamsSize;

	private IntPtr OnCameraGraphTick_InstanceFunctionAddressInstance;

	private static bool CameraGraphNode_G4_IsValid;

	private static IntPtr CameraGraphNode_G4_FunctionAddress;

	private static int CameraGraphNode_G4_ParamsSize;

	private static bool CameraGraphNode_G4_bEnable_IsValid;

	private static int CameraGraphNode_G4_bEnable_Offset;

	private static FFieldAddress CameraGraphNode_G4_bEnable_PropertyAddress;

	private static bool TargetExtendIDEqual_IsValid;

	private static IntPtr TargetExtendIDEqual_FunctionAddress;

	private static int TargetExtendIDEqual_ParamsSize;

	private static bool TargetExtendIDEqual_ExtendID_IsValid;

	private static int TargetExtendIDEqual_ExtendID_Offset;

	private static bool TargetExtendIDEqual_ReturnValue_IsValid;

	private static int TargetExtendIDEqual_ReturnValue_Offset;

	private static FFieldAddress TargetExtendIDEqual_ReturnValue_PropertyAddress;

	private static bool CameraGraphNode_Dead_IsValid;

	private static IntPtr CameraGraphNode_Dead_FunctionAddress;

	private static int CameraGraphNode_Dead_ParamsSize;

	private static bool CameraGraphNode_Dead_bEnable_IsValid;

	private static int CameraGraphNode_Dead_bEnable_Offset;

	private static FFieldAddress CameraGraphNode_Dead_bEnable_PropertyAddress;

	private static bool CameraGraphNode_Dead_ArmLength_IsValid;

	private static int CameraGraphNode_Dead_ArmLength_Offset;

	private static bool CameraGraphNode_Dead_ArmLengthSpeed_IsValid;

	private static int CameraGraphNode_Dead_ArmLengthSpeed_Offset;

	private static bool CameraGraphNode_Dead_CameraPitch_IsValid;

	private static int CameraGraphNode_Dead_CameraPitch_Offset;

	private static bool CameraGraphNode_Dead_CameraPitchSpeed_IsValid;

	private static int CameraGraphNode_Dead_CameraPitchSpeed_Offset;

	private static bool CameraGraphNode_Lock_IsValid;

	private static IntPtr CameraGraphNode_Lock_FunctionAddress;

	private static int CameraGraphNode_Lock_ParamsSize;

	private static bool CameraGraphNode_Lock_bEnable_IsValid;

	private static int CameraGraphNode_Lock_bEnable_Offset;

	private static FFieldAddress CameraGraphNode_Lock_bEnable_PropertyAddress;

	private static bool CameraGraphNode_Giant_IsValid;

	private static IntPtr CameraGraphNode_Giant_FunctionAddress;

	private static int CameraGraphNode_Giant_ParamsSize;

	private static bool CameraGraphNode_Giant_bEnable_IsValid;

	private static int CameraGraphNode_Giant_bEnable_Offset;

	private static FFieldAddress CameraGraphNode_Giant_bEnable_PropertyAddress;

	private static bool CameraGraphNode_Curve_IsValid;

	private static IntPtr CameraGraphNode_Curve_FunctionAddress;

	private static int CameraGraphNode_Curve_ParamsSize;

	private static bool CameraGraphNode_Curve_bEnable_IsValid;

	private static int CameraGraphNode_Curve_bEnable_Offset;

	private static FFieldAddress CameraGraphNode_Curve_bEnable_PropertyAddress;

	private static bool CameraGraphNode_Player_IsValid;

	private static IntPtr CameraGraphNode_Player_FunctionAddress;

	private static int CameraGraphNode_Player_ParamsSize;

	private static bool CameraGraphNode_Player_bEnable_IsValid;

	private static int CameraGraphNode_Player_bEnable_Offset;

	private static FFieldAddress CameraGraphNode_Player_bEnable_PropertyAddress;

	private static bool CameraGraphNode_AutoTrail_IsValid;

	private static IntPtr CameraGraphNode_AutoTrail_FunctionAddress;

	private static int CameraGraphNode_AutoTrail_ParamsSize;

	private static bool CameraGraphNode_AutoTrail_bEnable_IsValid;

	private static int CameraGraphNode_AutoTrail_bEnable_Offset;

	private static FFieldAddress CameraGraphNode_AutoTrail_bEnable_PropertyAddress;

	private static bool CameraGraphNode_AutoTrail_InCameraRotationRate_IsValid;

	private static int CameraGraphNode_AutoTrail_InCameraRotationRate_Offset;

	private static bool CameraGraphNode_AutoTrail_InCameraRotationAccelerate_IsValid;

	private static int CameraGraphNode_AutoTrail_InCameraRotationAccelerate_Offset;

	private static bool CameraGraphNode_AutoTrail_InCameraRotationVelocityThreshold_IsValid;

	private static int CameraGraphNode_AutoTrail_InCameraRotationVelocityThreshold_Offset;

	private static bool CameraGraphNode_AutoTrail_InFallingAdjustAngleLimit_IsValid;

	private static int CameraGraphNode_AutoTrail_InFallingAdjustAngleLimit_Offset;

	private static bool CameraGraphNode_AutoTrail_InFallingAdjustSpeedPercent_IsValid;

	private static int CameraGraphNode_AutoTrail_InFallingAdjustSpeedPercent_Offset;

	private static bool CameraGraphNode_LockSkill_IsValid;

	private static IntPtr CameraGraphNode_LockSkill_FunctionAddress;

	private static int CameraGraphNode_LockSkill_ParamsSize;

	private static bool CameraGraphNode_LockSkill_bEnable_IsValid;

	private static int CameraGraphNode_LockSkill_bEnable_Offset;

	private static FFieldAddress CameraGraphNode_LockSkill_bEnable_PropertyAddress;

	private static bool CameraGraphNode_FixedParam_IsValid;

	private static IntPtr CameraGraphNode_FixedParam_FunctionAddress;

	private static int CameraGraphNode_FixedParam_ParamsSize;

	private static bool CameraGraphNode_FixedParam_bEnable_IsValid;

	private static int CameraGraphNode_FixedParam_bEnable_Offset;

	private static FFieldAddress CameraGraphNode_FixedParam_bEnable_PropertyAddress;

	private static bool CameraGraphNode_SplineMove_IsValid;

	private static IntPtr CameraGraphNode_SplineMove_FunctionAddress;

	private static int CameraGraphNode_SplineMove_ParamsSize;

	private static bool CameraGraphNode_SplineMove_bEnable_IsValid;

	private static int CameraGraphNode_SplineMove_bEnable_Offset;

	private static FFieldAddress CameraGraphNode_SplineMove_bEnable_PropertyAddress;

	private static bool CameraGraphNode_SplineMove_CameraPitchAdditive_IsValid;

	private static int CameraGraphNode_SplineMove_CameraPitchAdditive_Offset;

	private static bool CameraGraphNode_SplineMove_CameraYawAdditive_IsValid;

	private static int CameraGraphNode_SplineMove_CameraYawAdditive_Offset;

	private static bool CameraGraphNode_GiantSkill_IsValid;

	private static IntPtr CameraGraphNode_GiantSkill_FunctionAddress;

	private static int CameraGraphNode_GiantSkill_ParamsSize;

	private static bool CameraGraphNode_GiantSkill_bEnable_IsValid;

	private static int CameraGraphNode_GiantSkill_bEnable_Offset;

	private static FFieldAddress CameraGraphNode_GiantSkill_bEnable_PropertyAddress;

	private static bool CameraGraphNode_AxisSmooth_IsValid;

	private static IntPtr CameraGraphNode_AxisSmooth_FunctionAddress;

	private static int CameraGraphNode_AxisSmooth_ParamsSize;

	private static bool CameraGraphNode_AxisSmooth_bEnable_IsValid;

	private static int CameraGraphNode_AxisSmooth_bEnable_Offset;

	private static FFieldAddress CameraGraphNode_AxisSmooth_bEnable_PropertyAddress;

	private static bool CameraGraphNode_AxisSmooth_IsXAxisFixed_IsValid;

	private static int CameraGraphNode_AxisSmooth_IsXAxisFixed_Offset;

	private static FFieldAddress CameraGraphNode_AxisSmooth_IsXAxisFixed_PropertyAddress;

	private static bool CameraGraphNode_AxisSmooth_IsYAxisFixed_IsValid;

	private static int CameraGraphNode_AxisSmooth_IsYAxisFixed_Offset;

	private static FFieldAddress CameraGraphNode_AxisSmooth_IsYAxisFixed_PropertyAddress;

	private static bool CameraGraphNode_AxisSmooth_IsZAxisFixed_IsValid;

	private static int CameraGraphNode_AxisSmooth_IsZAxisFixed_Offset;

	private static FFieldAddress CameraGraphNode_AxisSmooth_IsZAxisFixed_PropertyAddress;

	private static bool CameraGraphNode_AxisSmooth_SmoothSpeed_IsValid;

	private static int CameraGraphNode_AxisSmooth_SmoothSpeed_Offset;

	private static bool CameraGraphNode_AxisSmooth_CameraLagSpeed_IsValid;

	private static int CameraGraphNode_AxisSmooth_CameraLagSpeed_Offset;

	private static bool CameraGraphNode_PlayerSkill_IsValid;

	private static IntPtr CameraGraphNode_PlayerSkill_FunctionAddress;

	private static int CameraGraphNode_PlayerSkill_ParamsSize;

	private static bool CameraGraphNode_PlayerSkill_bEnable_IsValid;

	private static int CameraGraphNode_PlayerSkill_bEnable_Offset;

	private static FFieldAddress CameraGraphNode_PlayerSkill_bEnable_PropertyAddress;

	private static bool CameraGraphNode_GuiBeiCamera_IsValid;

	private static IntPtr CameraGraphNode_GuiBeiCamera_FunctionAddress;

	private static int CameraGraphNode_GuiBeiCamera_ParamsSize;

	private static bool CameraGraphNode_GuiBeiCamera_bEnable_IsValid;

	private static int CameraGraphNode_GuiBeiCamera_bEnable_Offset;

	private static FFieldAddress CameraGraphNode_GuiBeiCamera_bEnable_PropertyAddress;

	private static bool CameraGraphNode_ShootSuction_IsValid;

	private static IntPtr CameraGraphNode_ShootSuction_FunctionAddress;

	private static int CameraGraphNode_ShootSuction_ParamsSize;

	private static bool CameraGraphNode_ShootSuction_bEnable_IsValid;

	private static int CameraGraphNode_ShootSuction_bEnable_Offset;

	private static FFieldAddress CameraGraphNode_ShootSuction_bEnable_PropertyAddress;

	private static bool CameraGraphNode_TraceVelocity_IsValid;

	private static IntPtr CameraGraphNode_TraceVelocity_FunctionAddress;

	private static int CameraGraphNode_TraceVelocity_ParamsSize;

	private static bool CameraGraphNode_TraceVelocity_bEnable_IsValid;

	private static int CameraGraphNode_TraceVelocity_bEnable_Offset;

	private static FFieldAddress CameraGraphNode_TraceVelocity_bEnable_PropertyAddress;

	private static bool CameraGraphNode_InverseCamera_IsValid;

	private static IntPtr CameraGraphNode_InverseCamera_FunctionAddress;

	private static int CameraGraphNode_InverseCamera_ParamsSize;

	private static bool CameraGraphNode_InverseCamera_bEnable_IsValid;

	private static int CameraGraphNode_InverseCamera_bEnable_Offset;

	private static FFieldAddress CameraGraphNode_InverseCamera_bEnable_PropertyAddress;

	private static bool CameraGraphNode_CloudMoveLimit_IsValid;

	private static IntPtr CameraGraphNode_CloudMoveLimit_FunctionAddress;

	private static int CameraGraphNode_CloudMoveLimit_ParamsSize;

	private static bool CameraGraphNode_CloudMoveLimit_bEnable_IsValid;

	private static int CameraGraphNode_CloudMoveLimit_bEnable_Offset;

	private static FFieldAddress CameraGraphNode_CloudMoveLimit_bEnable_PropertyAddress;

	private static bool CameraGraphNode_LerpPostProcess_IsValid;

	private static IntPtr CameraGraphNode_LerpPostProcess_FunctionAddress;

	private static int CameraGraphNode_LerpPostProcess_ParamsSize;

	private static bool CameraGraphNode_LerpPostProcess_bEnable_IsValid;

	private static int CameraGraphNode_LerpPostProcess_bEnable_Offset;

	private static FFieldAddress CameraGraphNode_LerpPostProcess_bEnable_PropertyAddress;

	private static bool CameraGraphNode_AutoMoveTrailCamera_IsValid;

	private static IntPtr CameraGraphNode_AutoMoveTrailCamera_FunctionAddress;

	private static int CameraGraphNode_AutoMoveTrailCamera_ParamsSize;

	private static bool CameraGraphNode_AutoMoveTrailCamera_bEnable_IsValid;

	private static int CameraGraphNode_AutoMoveTrailCamera_bEnable_Offset;

	private static FFieldAddress CameraGraphNode_AutoMoveTrailCamera_bEnable_PropertyAddress;

	public float DeltaTime { get; set; }

	public BUC_CameraState CameraState { get; set; }

	public GSCameraControlData CameraControlData { get; set; }

	public GSCameraMonitorData MonitorData { get; set; }

	private FCameraBlend_Default DefaultCamera { get; }

	private FCameraBlend_Player PlayerCamera { get; }

	private FCameraBlend_PlayerSkill PlayerSkillCamera { get; }

	private FCameraBlend_Curve CurveCamera { get; }

	private FCameraBlend_Lock LockCamera { get; }

	private FCameraBlend_LockSkill LockSkillCamera { get; }

	private FCameraBlend_Giant GiantCamera { get; }

	private FCameraBlend_GiantSkill GiantSkillCamera { get; }

	private FCameraBlend_UnlockAutoTrail AutoTrailCamera { get; }

	private FCameraBlend_AxisSmooth AxisSmoothCamera { get; }

	private FCameraBlend_GuiBei GuiBeiCamera { get; }

	private FCameraBlend_LerpPostProcess PostProcessCamera { get; }

	private FCameraBlend_G4 G4Camera { get; }

	private FCameraBlend_ShootSuction ShootSuctionCamera { get; }

	private FCameraBlend_FixedParam FixedParamCamera { get; }

	private FCameraBlend_TraceVelocity TraceVelocityCamera { get; }

	private FCameraBlend_InverseCamera InverseCamera { get; }

	private FCameraBlend_CloudMoveLimit CloudMoveLimitCamera { get; }

	private FCameraBlend_Dead DeadCamera { get; }

	private FCameraBlend_SplineMove SplineMoveCamera { get; }

	private FCameraBlend_AutoMoveTrail AutoMoveTrailCamera { get; }

	public GSCameraGraph()
	{
		DefaultCamera = new FCameraBlend_Default(this);
		PlayerCamera = new FCameraBlend_Player(this);
		PlayerSkillCamera = new FCameraBlend_PlayerSkill(this);
		CurveCamera = new FCameraBlend_Curve(this);
		LockCamera = new FCameraBlend_Lock(this);
		LockSkillCamera = new FCameraBlend_LockSkill(this);
		AutoTrailCamera = new FCameraBlend_UnlockAutoTrail(this);
		AxisSmoothCamera = new FCameraBlend_AxisSmooth(this);
		GuiBeiCamera = new FCameraBlend_GuiBei(this);
		PostProcessCamera = new FCameraBlend_LerpPostProcess(this);
		G4Camera = new FCameraBlend_G4(this);
		ShootSuctionCamera = new FCameraBlend_ShootSuction(this);
		FixedParamCamera = new FCameraBlend_FixedParam(this);
		TraceVelocityCamera = new FCameraBlend_TraceVelocity(this);
		InverseCamera = new FCameraBlend_InverseCamera(this);
		DeadCamera = new FCameraBlend_Dead(this);
		SplineMoveCamera = new FCameraBlend_SplineMove(this);
		GiantCamera = new FCameraBlend_Giant(this);
		GiantSkillCamera = new FCameraBlend_GiantSkill(this);
		CloudMoveLimitCamera = new FCameraBlend_CloudMoveLimit(this);
		AutoMoveTrailCamera = new FCameraBlend_AutoMoveTrail(this);
	}

	public void Tick(float InDeltaTime, BUC_CameraState InCameraState, GSCameraControlData InCameraControlData, GSCameraMonitorData InMonitorData)
	{
		DeltaTime = InDeltaTime;
		CameraState = InCameraState;
		CameraControlData = InCameraControlData;
		MonitorData = InMonitorData;
		DefaultCamera.NotifyBlendCamera();
		OnCameraGraphTick();
	}

	[DisplayName("CameraGraph Start")]
	[BlueprintImplementedEvent]
	[UFunction]
	[USharpPath("/Script/b1-Managed.GSCameraGraph:OnCameraGraphTick")]
	protected unsafe void OnCameraGraphTick()
	{
		CheckDestroyed();
		if (!OnCameraGraphTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.GSCameraGraph:OnCameraGraphTick");
			return;
		}
		if (OnCameraGraphTick_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnCameraGraphTick_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnCameraGraphTick");
		}
		byte* value = stackalloc byte[(int)(uint)OnCameraGraphTick_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnCameraGraphTick_ParamsSize);
		NativeReflection.InvokeFunction(base.Address, OnCameraGraphTick_InstanceFunctionAddressInstance, intPtr, OnCameraGraphTick_ParamsSize);
	}

	[DisplayName("主角镜头")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_Player")]
	public void CameraGraphNode_Player(bool bEnable)
	{
		if (bEnable)
		{
			PlayerCamera.NotifyBlendCamera();
		}
	}

	[BlueprintCallable]
	[DisplayName("主角技能镜头")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_PlayerSkill")]
	public void CameraGraphNode_PlayerSkill(bool bEnable)
	{
		if (bEnable)
		{
			PlayerSkillCamera.NotifyBlendCamera();
		}
	}

	[UFunction]
	[BlueprintCallable]
	[DisplayName("CurveNode")]
	[Tooltip("运动镜头节点")]
	[USharpPath("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_Curve")]
	public void CameraGraphNode_Curve(bool bEnable)
	{
		if (bEnable)
		{
			CurveCamera.NotifyBlendCamera();
		}
	}

	[UFunction]
	[BlueprintCallable]
	[DisplayName("锁定镜头")]
	[USharpPath("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_Lock")]
	public void CameraGraphNode_Lock(bool bEnable)
	{
		if (bEnable)
		{
			LockCamera.NotifyBlendCamera();
		}
	}

	[UFunction]
	[DisplayName("怪物锁定技能镜头")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_LockSkill")]
	public void CameraGraphNode_LockSkill(bool bEnable)
	{
		if (bEnable)
		{
			LockSkillCamera.NotifyBlendCamera();
		}
	}

	[DisplayName("巨猿镜头")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_Giant")]
	public void CameraGraphNode_Giant(bool bEnable)
	{
		if (bEnable)
		{
			GiantCamera.NotifyBlendCamera();
		}
	}

	[DisplayName("巨猿技能镜头镜头")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_GiantSkill")]
	public void CameraGraphNode_GiantSkill(bool bEnable)
	{
		if (bEnable)
		{
			GiantSkillCamera.NotifyBlendCamera();
		}
	}

	[UFunction]
	[BlueprintCallable]
	[DisplayName("自动追尾镜头")]
	[USharpPath("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_AutoTrail")]
	public void CameraGraphNode_AutoTrail(bool bEnable, float InCameraRotationRate = 0.3f, float InCameraRotationAccelerate = 6f, float InCameraRotationVelocityThreshold = 600f, float InFallingAdjustAngleLimit = 15f, float InFallingAdjustSpeedPercent = 1f)
	{
		if (bEnable)
		{
			AutoTrailCamera.CameraRotationRateAccelerate = InCameraRotationAccelerate;
			AutoTrailCamera.CameraRotationMaxVelocity = InCameraRotationRate;
			AutoTrailCamera.CameraRotationVelocityThreshold = InCameraRotationVelocityThreshold;
			AutoTrailCamera.FallingAdjustAngleLimit = InFallingAdjustAngleLimit;
			AutoTrailCamera.FallingAdjustSpeedPercent = InFallingAdjustSpeedPercent;
			AutoTrailCamera.NotifyBlendCamera();
		}
	}

	[DisplayName("反向运动镜头")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_InverseCamera")]
	public void CameraGraphNode_InverseCamera(bool bEnable)
	{
		if (bEnable)
		{
			InverseCamera.NotifyBlendCamera();
		}
	}

	[UFunction]
	[BlueprintCallable]
	[DisplayName("筋斗云限制镜头")]
	[USharpPath("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_CloudMoveLimit")]
	public void CameraGraphNode_CloudMoveLimit(bool bEnable)
	{
		if (bEnable)
		{
			CloudMoveLimitCamera.NotifyBlendCamera();
		}
	}

	[DisplayName("相机特定轴平滑")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_AxisSmooth")]
	public void CameraGraphNode_AxisSmooth(bool bEnable, bool IsXAxisFixed, bool IsYAxisFixed, bool IsZAxisFixed, float SmoothSpeed, float CameraLagSpeed)
	{
		if (bEnable)
		{
			AxisSmoothCamera.IsXAxisFixed = IsXAxisFixed;
			AxisSmoothCamera.IsYAxisFixed = IsYAxisFixed;
			AxisSmoothCamera.IsZAxisFixed = IsZAxisFixed;
			AxisSmoothCamera.SmoothSpeed = SmoothSpeed;
			AxisSmoothCamera.CameraLagSpeed = CameraLagSpeed;
			AxisSmoothCamera.NotifyBlendCamera();
		}
	}

	[Tooltip("龟背相机平滑临时节点")]
	[BlueprintCallable]
	[DisplayName("GuiBeiCameraSmoothTmpNode")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_GuiBeiCamera")]
	public void CameraGraphNode_GuiBeiCamera(bool bEnable)
	{
		if (bEnable)
		{
			GuiBeiCamera.NotifyBlendCamera();
		}
	}

	[Tooltip("龟背相机平滑临时节点")]
	[DisplayName("程序自动移动追尾镜头")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_AutoMoveTrailCamera")]
	public void CameraGraphNode_AutoMoveTrailCamera(bool bEnable)
	{
		if (bEnable)
		{
			AutoMoveTrailCamera.NotifyBlendCamera();
		}
	}

	[UFunction]
	[DisplayName("后处理效果平滑")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_LerpPostProcess")]
	public void CameraGraphNode_LerpPostProcess(bool bEnable)
	{
		if (bEnable)
		{
			PostProcessCamera.NotifyBlendCamera();
		}
	}

	[Tooltip("战神4镜头节点")]
	[UFunction]
	[BlueprintCallable]
	[DisplayName("G4Node")]
	[USharpPath("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_G4")]
	public void CameraGraphNode_G4(bool bEnable)
	{
		if (bEnable)
		{
			G4Camera.NotifyBlendCamera();
		}
	}

	[UFunction]
	[BlueprintCallable]
	[DisplayName("ShootSuctionNode")]
	[Tooltip("射击吸附镜头节点")]
	[USharpPath("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_ShootSuction")]
	public void CameraGraphNode_ShootSuction(bool bEnable)
	{
		if (bEnable)
		{
			ShootSuctionCamera.NotifyBlendCamera();
		}
	}

	[UFunction]
	[BlueprintCallable]
	[DisplayName("固定镜头参数")]
	[Tooltip("在某些条件下可以保持某些镜头参数不变")]
	[USharpPath("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_FixedParam")]
	public void CameraGraphNode_FixedParam(bool bEnable)
	{
		if (bEnable)
		{
			FixedParamCamera.NotifyBlendCamera();
		}
	}

	[UFunction]
	[BlueprintCallable]
	[DisplayName("TraceVelocityNode")]
	[Tooltip("追踪速度方向或速度反方向镜头节点")]
	[USharpPath("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_TraceVelocity")]
	public void CameraGraphNode_TraceVelocity(bool bEnable)
	{
		if (bEnable)
		{
			TraceVelocityCamera.NotifyBlendCamera();
		}
	}

	[Tooltip("主角死亡镜头结点")]
	[UFunction]
	[BlueprintCallable]
	[DisplayName("死亡镜头")]
	[USharpPath("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_Dead")]
	public void CameraGraphNode_Dead(bool bEnable, float ArmLength, float ArmLengthSpeed, float CameraPitch, float CameraPitchSpeed)
	{
		if (bEnable)
		{
			DeadCamera.ArmLength = ArmLength;
			DeadCamera.ArmLengthInterpSpeed = ArmLengthSpeed;
			DeadCamera.CameraPitch = CameraPitch;
			DeadCamera.CameraPitchInterpSpeed = CameraPitchSpeed;
			DeadCamera.NotifyBlendCamera();
		}
	}

	[Tooltip("主角曲线移动镜头结点")]
	[DisplayName("SplineMoveNode")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_SplineMove")]
	public void CameraGraphNode_SplineMove(bool bEnable, float CameraPitchAdditive, float CameraYawAdditive)
	{
		if (bEnable)
		{
			SplineMoveCamera.CameraPitchAdditive = CameraPitchAdditive;
			SplineMoveCamera.CameraYawAdditive = CameraYawAdditive;
			SplineMoveCamera.NotifyBlendCamera();
		}
	}

	[Tooltip("判断是否处于锁定状态")]
	[UFunction]
	[BlueprintPure]
	[USharpPath("/Script/b1-Managed.GSCameraGraph:IsLocked")]
	public bool IsLocked()
	{
		return CameraState.IsLocked;
	}

	[Tooltip("判断是否使用龟背相机")]
	[BlueprintPure]
	[UFunction]
	[USharpPath("/Script/b1-Managed.GSCameraGraph:IsUseGuiBeiCamera")]
	public bool IsUseGuiBeiCamera()
	{
		return CameraState.IsUseGuiBeiCamera;
	}

	[BlueprintPure]
	[UFunction]
	[Tooltip("判断是否在一段时间内没有镜头输入")]
	[USharpPath("/Script/b1-Managed.GSCameraGraph:HasNoCameraInput")]
	public bool HasNoCameraInput(float DurationTime)
	{
		return CameraState.LastCameraInputTimer >= DurationTime;
	}

	[BlueprintPure]
	[Tooltip("判断是否在G4视角下")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.GSCameraGraph:IsG4Mode")]
	public bool IsG4Mode()
	{
		return CameraState.FreeCameraMode == EPlayerFreeCameraType.G4Mode;
	}

	[UFunction]
	[BlueprintPure]
	[Tooltip("是否有目标")]
	[USharpPath("/Script/b1-Managed.GSCameraGraph:HasTarget")]
	public bool HasTarget()
	{
		return CameraState.bHasTarget;
	}

	[Tooltip("判断目标Res")]
	[UFunction]
	[BlueprintPure]
	[USharpPath("/Script/b1-Managed.GSCameraGraph:TargetResIDEqual")]
	public bool TargetResIDEqual(int TargetResID)
	{
		return CameraState.TargetResID == TargetResID;
	}

	[Tooltip("判断目标ExtendID")]
	[BlueprintPure]
	[UFunction]
	[USharpPath("/Script/b1-Managed.GSCameraGraph:TargetExtendIDEqual")]
	public bool TargetExtendIDEqual(int ExtendID)
	{
		return CameraState.TargetExtendID == ExtendID;
	}

	[UFunctionInvoker("/Script/b1-Managed.GSCameraGraph:IsG4Mode")]
	private static void IsG4Mode__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSCameraGraph gSCameraGraph = GCHelper.Find<GSCameraGraph>(obj);
		bool value = gSCameraGraph.IsG4Mode();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsG4Mode_ReturnValue_Offset), 0, IsG4Mode_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSCameraGraph:IsLocked")]
	private static void IsLocked__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSCameraGraph gSCameraGraph = GCHelper.Find<GSCameraGraph>(obj);
		bool value = gSCameraGraph.IsLocked();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsLocked_ReturnValue_Offset), 0, IsLocked_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSCameraGraph:HasTarget")]
	private static void HasTarget__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSCameraGraph gSCameraGraph = GCHelper.Find<GSCameraGraph>(obj);
		bool value = gSCameraGraph.HasTarget();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, HasTarget_ReturnValue_Offset), 0, HasTarget_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSCameraGraph:TargetResIDEqual")]
	private static void TargetResIDEqual__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSCameraGraph gSCameraGraph = GCHelper.Find<GSCameraGraph>(obj);
		int targetResID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, TargetResIDEqual_TargetResID_Offset));
		bool value = gSCameraGraph.TargetResIDEqual(targetResID);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, TargetResIDEqual_ReturnValue_Offset), 0, TargetResIDEqual_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSCameraGraph:HasNoCameraInput")]
	private static void HasNoCameraInput__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSCameraGraph gSCameraGraph = GCHelper.Find<GSCameraGraph>(obj);
		float durationTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, HasNoCameraInput_DurationTime_Offset));
		bool value = gSCameraGraph.HasNoCameraInput(durationTime);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, HasNoCameraInput_ReturnValue_Offset), 0, HasNoCameraInput_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSCameraGraph:IsUseGuiBeiCamera")]
	private static void IsUseGuiBeiCamera__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSCameraGraph gSCameraGraph = GCHelper.Find<GSCameraGraph>(obj);
		bool value = gSCameraGraph.IsUseGuiBeiCamera();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsUseGuiBeiCamera_ReturnValue_Offset), 0, IsUseGuiBeiCamera_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_G4")]
	private static void CameraGraphNode_G4__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSCameraGraph gSCameraGraph = GCHelper.Find<GSCameraGraph>(obj);
		bool bEnable = BoolMarshaler.FromNative(IntPtr.Add(buffer, CameraGraphNode_G4_bEnable_Offset), 0, CameraGraphNode_G4_bEnable_PropertyAddress.Address);
		gSCameraGraph.CameraGraphNode_G4(bEnable);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSCameraGraph:TargetExtendIDEqual")]
	private static void TargetExtendIDEqual__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSCameraGraph gSCameraGraph = GCHelper.Find<GSCameraGraph>(obj);
		int extendID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, TargetExtendIDEqual_ExtendID_Offset));
		bool value = gSCameraGraph.TargetExtendIDEqual(extendID);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, TargetExtendIDEqual_ReturnValue_Offset), 0, TargetExtendIDEqual_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_Dead")]
	private static void CameraGraphNode_Dead__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSCameraGraph gSCameraGraph = GCHelper.Find<GSCameraGraph>(obj);
		bool bEnable = BoolMarshaler.FromNative(IntPtr.Add(buffer, CameraGraphNode_Dead_bEnable_Offset), 0, CameraGraphNode_Dead_bEnable_PropertyAddress.Address);
		float armLength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, CameraGraphNode_Dead_ArmLength_Offset));
		float armLengthSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, CameraGraphNode_Dead_ArmLengthSpeed_Offset));
		float cameraPitch = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, CameraGraphNode_Dead_CameraPitch_Offset));
		float cameraPitchSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, CameraGraphNode_Dead_CameraPitchSpeed_Offset));
		gSCameraGraph.CameraGraphNode_Dead(bEnable, armLength, armLengthSpeed, cameraPitch, cameraPitchSpeed);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_Lock")]
	private static void CameraGraphNode_Lock__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSCameraGraph gSCameraGraph = GCHelper.Find<GSCameraGraph>(obj);
		bool bEnable = BoolMarshaler.FromNative(IntPtr.Add(buffer, CameraGraphNode_Lock_bEnable_Offset), 0, CameraGraphNode_Lock_bEnable_PropertyAddress.Address);
		gSCameraGraph.CameraGraphNode_Lock(bEnable);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_Giant")]
	private static void CameraGraphNode_Giant__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSCameraGraph gSCameraGraph = GCHelper.Find<GSCameraGraph>(obj);
		bool bEnable = BoolMarshaler.FromNative(IntPtr.Add(buffer, CameraGraphNode_Giant_bEnable_Offset), 0, CameraGraphNode_Giant_bEnable_PropertyAddress.Address);
		gSCameraGraph.CameraGraphNode_Giant(bEnable);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_Curve")]
	private static void CameraGraphNode_Curve__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSCameraGraph gSCameraGraph = GCHelper.Find<GSCameraGraph>(obj);
		bool bEnable = BoolMarshaler.FromNative(IntPtr.Add(buffer, CameraGraphNode_Curve_bEnable_Offset), 0, CameraGraphNode_Curve_bEnable_PropertyAddress.Address);
		gSCameraGraph.CameraGraphNode_Curve(bEnable);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_Player")]
	private static void CameraGraphNode_Player__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSCameraGraph gSCameraGraph = GCHelper.Find<GSCameraGraph>(obj);
		bool bEnable = BoolMarshaler.FromNative(IntPtr.Add(buffer, CameraGraphNode_Player_bEnable_Offset), 0, CameraGraphNode_Player_bEnable_PropertyAddress.Address);
		gSCameraGraph.CameraGraphNode_Player(bEnable);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_AutoTrail")]
	private static void CameraGraphNode_AutoTrail__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSCameraGraph gSCameraGraph = GCHelper.Find<GSCameraGraph>(obj);
		bool bEnable = BoolMarshaler.FromNative(IntPtr.Add(buffer, CameraGraphNode_AutoTrail_bEnable_Offset), 0, CameraGraphNode_AutoTrail_bEnable_PropertyAddress.Address);
		float inCameraRotationRate = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, CameraGraphNode_AutoTrail_InCameraRotationRate_Offset));
		float inCameraRotationAccelerate = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, CameraGraphNode_AutoTrail_InCameraRotationAccelerate_Offset));
		float inCameraRotationVelocityThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, CameraGraphNode_AutoTrail_InCameraRotationVelocityThreshold_Offset));
		float inFallingAdjustAngleLimit = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, CameraGraphNode_AutoTrail_InFallingAdjustAngleLimit_Offset));
		float inFallingAdjustSpeedPercent = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, CameraGraphNode_AutoTrail_InFallingAdjustSpeedPercent_Offset));
		gSCameraGraph.CameraGraphNode_AutoTrail(bEnable, inCameraRotationRate, inCameraRotationAccelerate, inCameraRotationVelocityThreshold, inFallingAdjustAngleLimit, inFallingAdjustSpeedPercent);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_LockSkill")]
	private static void CameraGraphNode_LockSkill__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSCameraGraph gSCameraGraph = GCHelper.Find<GSCameraGraph>(obj);
		bool bEnable = BoolMarshaler.FromNative(IntPtr.Add(buffer, CameraGraphNode_LockSkill_bEnable_Offset), 0, CameraGraphNode_LockSkill_bEnable_PropertyAddress.Address);
		gSCameraGraph.CameraGraphNode_LockSkill(bEnable);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_FixedParam")]
	private static void CameraGraphNode_FixedParam__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSCameraGraph gSCameraGraph = GCHelper.Find<GSCameraGraph>(obj);
		bool bEnable = BoolMarshaler.FromNative(IntPtr.Add(buffer, CameraGraphNode_FixedParam_bEnable_Offset), 0, CameraGraphNode_FixedParam_bEnable_PropertyAddress.Address);
		gSCameraGraph.CameraGraphNode_FixedParam(bEnable);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_SplineMove")]
	private static void CameraGraphNode_SplineMove__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSCameraGraph gSCameraGraph = GCHelper.Find<GSCameraGraph>(obj);
		bool bEnable = BoolMarshaler.FromNative(IntPtr.Add(buffer, CameraGraphNode_SplineMove_bEnable_Offset), 0, CameraGraphNode_SplineMove_bEnable_PropertyAddress.Address);
		float cameraPitchAdditive = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, CameraGraphNode_SplineMove_CameraPitchAdditive_Offset));
		float cameraYawAdditive = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, CameraGraphNode_SplineMove_CameraYawAdditive_Offset));
		gSCameraGraph.CameraGraphNode_SplineMove(bEnable, cameraPitchAdditive, cameraYawAdditive);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_GiantSkill")]
	private static void CameraGraphNode_GiantSkill__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSCameraGraph gSCameraGraph = GCHelper.Find<GSCameraGraph>(obj);
		bool bEnable = BoolMarshaler.FromNative(IntPtr.Add(buffer, CameraGraphNode_GiantSkill_bEnable_Offset), 0, CameraGraphNode_GiantSkill_bEnable_PropertyAddress.Address);
		gSCameraGraph.CameraGraphNode_GiantSkill(bEnable);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_AxisSmooth")]
	private static void CameraGraphNode_AxisSmooth__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSCameraGraph gSCameraGraph = GCHelper.Find<GSCameraGraph>(obj);
		bool bEnable = BoolMarshaler.FromNative(IntPtr.Add(buffer, CameraGraphNode_AxisSmooth_bEnable_Offset), 0, CameraGraphNode_AxisSmooth_bEnable_PropertyAddress.Address);
		bool isXAxisFixed = BoolMarshaler.FromNative(IntPtr.Add(buffer, CameraGraphNode_AxisSmooth_IsXAxisFixed_Offset), 0, CameraGraphNode_AxisSmooth_IsXAxisFixed_PropertyAddress.Address);
		bool isYAxisFixed = BoolMarshaler.FromNative(IntPtr.Add(buffer, CameraGraphNode_AxisSmooth_IsYAxisFixed_Offset), 0, CameraGraphNode_AxisSmooth_IsYAxisFixed_PropertyAddress.Address);
		bool isZAxisFixed = BoolMarshaler.FromNative(IntPtr.Add(buffer, CameraGraphNode_AxisSmooth_IsZAxisFixed_Offset), 0, CameraGraphNode_AxisSmooth_IsZAxisFixed_PropertyAddress.Address);
		float smoothSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, CameraGraphNode_AxisSmooth_SmoothSpeed_Offset));
		float cameraLagSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, CameraGraphNode_AxisSmooth_CameraLagSpeed_Offset));
		gSCameraGraph.CameraGraphNode_AxisSmooth(bEnable, isXAxisFixed, isYAxisFixed, isZAxisFixed, smoothSpeed, cameraLagSpeed);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_PlayerSkill")]
	private static void CameraGraphNode_PlayerSkill__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSCameraGraph gSCameraGraph = GCHelper.Find<GSCameraGraph>(obj);
		bool bEnable = BoolMarshaler.FromNative(IntPtr.Add(buffer, CameraGraphNode_PlayerSkill_bEnable_Offset), 0, CameraGraphNode_PlayerSkill_bEnable_PropertyAddress.Address);
		gSCameraGraph.CameraGraphNode_PlayerSkill(bEnable);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_GuiBeiCamera")]
	private static void CameraGraphNode_GuiBeiCamera__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSCameraGraph gSCameraGraph = GCHelper.Find<GSCameraGraph>(obj);
		bool bEnable = BoolMarshaler.FromNative(IntPtr.Add(buffer, CameraGraphNode_GuiBeiCamera_bEnable_Offset), 0, CameraGraphNode_GuiBeiCamera_bEnable_PropertyAddress.Address);
		gSCameraGraph.CameraGraphNode_GuiBeiCamera(bEnable);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_ShootSuction")]
	private static void CameraGraphNode_ShootSuction__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSCameraGraph gSCameraGraph = GCHelper.Find<GSCameraGraph>(obj);
		bool bEnable = BoolMarshaler.FromNative(IntPtr.Add(buffer, CameraGraphNode_ShootSuction_bEnable_Offset), 0, CameraGraphNode_ShootSuction_bEnable_PropertyAddress.Address);
		gSCameraGraph.CameraGraphNode_ShootSuction(bEnable);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_TraceVelocity")]
	private static void CameraGraphNode_TraceVelocity__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSCameraGraph gSCameraGraph = GCHelper.Find<GSCameraGraph>(obj);
		bool bEnable = BoolMarshaler.FromNative(IntPtr.Add(buffer, CameraGraphNode_TraceVelocity_bEnable_Offset), 0, CameraGraphNode_TraceVelocity_bEnable_PropertyAddress.Address);
		gSCameraGraph.CameraGraphNode_TraceVelocity(bEnable);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_InverseCamera")]
	private static void CameraGraphNode_InverseCamera__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSCameraGraph gSCameraGraph = GCHelper.Find<GSCameraGraph>(obj);
		bool bEnable = BoolMarshaler.FromNative(IntPtr.Add(buffer, CameraGraphNode_InverseCamera_bEnable_Offset), 0, CameraGraphNode_InverseCamera_bEnable_PropertyAddress.Address);
		gSCameraGraph.CameraGraphNode_InverseCamera(bEnable);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_CloudMoveLimit")]
	private static void CameraGraphNode_CloudMoveLimit__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSCameraGraph gSCameraGraph = GCHelper.Find<GSCameraGraph>(obj);
		bool bEnable = BoolMarshaler.FromNative(IntPtr.Add(buffer, CameraGraphNode_CloudMoveLimit_bEnable_Offset), 0, CameraGraphNode_CloudMoveLimit_bEnable_PropertyAddress.Address);
		gSCameraGraph.CameraGraphNode_CloudMoveLimit(bEnable);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_LerpPostProcess")]
	private static void CameraGraphNode_LerpPostProcess__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSCameraGraph gSCameraGraph = GCHelper.Find<GSCameraGraph>(obj);
		bool bEnable = BoolMarshaler.FromNative(IntPtr.Add(buffer, CameraGraphNode_LerpPostProcess_bEnable_Offset), 0, CameraGraphNode_LerpPostProcess_bEnable_PropertyAddress.Address);
		gSCameraGraph.CameraGraphNode_LerpPostProcess(bEnable);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_AutoMoveTrailCamera")]
	private static void CameraGraphNode_AutoMoveTrailCamera__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSCameraGraph gSCameraGraph = GCHelper.Find<GSCameraGraph>(obj);
		bool bEnable = BoolMarshaler.FromNative(IntPtr.Add(buffer, CameraGraphNode_AutoMoveTrailCamera_bEnable_Offset), 0, CameraGraphNode_AutoMoveTrailCamera_bEnable_PropertyAddress.Address);
		gSCameraGraph.CameraGraphNode_AutoMoveTrailCamera(bEnable);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.GSCameraGraph");
		IsG4Mode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsG4Mode");
		IsG4Mode_ParamsSize = NativeReflection.GetFunctionParamsSize(IsG4Mode_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsG4Mode_ReturnValue_PropertyAddress, IsG4Mode_FunctionAddress, "ReturnValue");
		IsG4Mode_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsG4Mode_FunctionAddress, "ReturnValue");
		IsG4Mode_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsG4Mode_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsG4Mode_IsValid = IsG4Mode_FunctionAddress != IntPtr.Zero && IsG4Mode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSCameraGraph:IsG4Mode", IsG4Mode_IsValid);
		IsLocked_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsLocked");
		IsLocked_ParamsSize = NativeReflection.GetFunctionParamsSize(IsLocked_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsLocked_ReturnValue_PropertyAddress, IsLocked_FunctionAddress, "ReturnValue");
		IsLocked_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsLocked_FunctionAddress, "ReturnValue");
		IsLocked_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsLocked_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsLocked_IsValid = IsLocked_FunctionAddress != IntPtr.Zero && IsLocked_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSCameraGraph:IsLocked", IsLocked_IsValid);
		HasTarget_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HasTarget");
		HasTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(HasTarget_FunctionAddress);
		NativeReflection.GetPropertyRef(ref HasTarget_ReturnValue_PropertyAddress, HasTarget_FunctionAddress, "ReturnValue");
		HasTarget_ReturnValue_Offset = NativeReflection.GetPropertyOffset(HasTarget_FunctionAddress, "ReturnValue");
		HasTarget_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(HasTarget_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasTarget_IsValid = HasTarget_FunctionAddress != IntPtr.Zero && HasTarget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSCameraGraph:HasTarget", HasTarget_IsValid);
		TargetResIDEqual_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TargetResIDEqual");
		TargetResIDEqual_ParamsSize = NativeReflection.GetFunctionParamsSize(TargetResIDEqual_FunctionAddress);
		TargetResIDEqual_TargetResID_Offset = NativeReflection.GetPropertyOffset(TargetResIDEqual_FunctionAddress, "TargetResID");
		TargetResIDEqual_TargetResID_IsValid = NativeReflection.ValidatePropertyClass(TargetResIDEqual_FunctionAddress, "TargetResID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref TargetResIDEqual_ReturnValue_PropertyAddress, TargetResIDEqual_FunctionAddress, "ReturnValue");
		TargetResIDEqual_ReturnValue_Offset = NativeReflection.GetPropertyOffset(TargetResIDEqual_FunctionAddress, "ReturnValue");
		TargetResIDEqual_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(TargetResIDEqual_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		TargetResIDEqual_IsValid = TargetResIDEqual_FunctionAddress != IntPtr.Zero && TargetResIDEqual_TargetResID_IsValid && TargetResIDEqual_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSCameraGraph:TargetResIDEqual", TargetResIDEqual_IsValid);
		HasNoCameraInput_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HasNoCameraInput");
		HasNoCameraInput_ParamsSize = NativeReflection.GetFunctionParamsSize(HasNoCameraInput_FunctionAddress);
		HasNoCameraInput_DurationTime_Offset = NativeReflection.GetPropertyOffset(HasNoCameraInput_FunctionAddress, "DurationTime");
		HasNoCameraInput_DurationTime_IsValid = NativeReflection.ValidatePropertyClass(HasNoCameraInput_FunctionAddress, "DurationTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref HasNoCameraInput_ReturnValue_PropertyAddress, HasNoCameraInput_FunctionAddress, "ReturnValue");
		HasNoCameraInput_ReturnValue_Offset = NativeReflection.GetPropertyOffset(HasNoCameraInput_FunctionAddress, "ReturnValue");
		HasNoCameraInput_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(HasNoCameraInput_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasNoCameraInput_IsValid = HasNoCameraInput_FunctionAddress != IntPtr.Zero && HasNoCameraInput_DurationTime_IsValid && HasNoCameraInput_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSCameraGraph:HasNoCameraInput", HasNoCameraInput_IsValid);
		IsUseGuiBeiCamera_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsUseGuiBeiCamera");
		IsUseGuiBeiCamera_ParamsSize = NativeReflection.GetFunctionParamsSize(IsUseGuiBeiCamera_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsUseGuiBeiCamera_ReturnValue_PropertyAddress, IsUseGuiBeiCamera_FunctionAddress, "ReturnValue");
		IsUseGuiBeiCamera_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsUseGuiBeiCamera_FunctionAddress, "ReturnValue");
		IsUseGuiBeiCamera_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsUseGuiBeiCamera_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsUseGuiBeiCamera_IsValid = IsUseGuiBeiCamera_FunctionAddress != IntPtr.Zero && IsUseGuiBeiCamera_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSCameraGraph:IsUseGuiBeiCamera", IsUseGuiBeiCamera_IsValid);
		OnCameraGraphTick_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnCameraGraphTick");
		OnCameraGraphTick_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCameraGraphTick_FunctionAddress);
		OnCameraGraphTick_IsValid = OnCameraGraphTick_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSCameraGraph:OnCameraGraphTick", OnCameraGraphTick_IsValid);
		CameraGraphNode_G4_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CameraGraphNode_G4");
		CameraGraphNode_G4_ParamsSize = NativeReflection.GetFunctionParamsSize(CameraGraphNode_G4_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CameraGraphNode_G4_bEnable_PropertyAddress, CameraGraphNode_G4_FunctionAddress, "bEnable");
		CameraGraphNode_G4_bEnable_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_G4_FunctionAddress, "bEnable");
		CameraGraphNode_G4_bEnable_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_G4_FunctionAddress, "bEnable", Classes.FBoolProperty);
		CameraGraphNode_G4_IsValid = CameraGraphNode_G4_FunctionAddress != IntPtr.Zero && CameraGraphNode_G4_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_G4", CameraGraphNode_G4_IsValid);
		TargetExtendIDEqual_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TargetExtendIDEqual");
		TargetExtendIDEqual_ParamsSize = NativeReflection.GetFunctionParamsSize(TargetExtendIDEqual_FunctionAddress);
		TargetExtendIDEqual_ExtendID_Offset = NativeReflection.GetPropertyOffset(TargetExtendIDEqual_FunctionAddress, "ExtendID");
		TargetExtendIDEqual_ExtendID_IsValid = NativeReflection.ValidatePropertyClass(TargetExtendIDEqual_FunctionAddress, "ExtendID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref TargetExtendIDEqual_ReturnValue_PropertyAddress, TargetExtendIDEqual_FunctionAddress, "ReturnValue");
		TargetExtendIDEqual_ReturnValue_Offset = NativeReflection.GetPropertyOffset(TargetExtendIDEqual_FunctionAddress, "ReturnValue");
		TargetExtendIDEqual_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(TargetExtendIDEqual_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		TargetExtendIDEqual_IsValid = TargetExtendIDEqual_FunctionAddress != IntPtr.Zero && TargetExtendIDEqual_ExtendID_IsValid && TargetExtendIDEqual_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSCameraGraph:TargetExtendIDEqual", TargetExtendIDEqual_IsValid);
		CameraGraphNode_Dead_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CameraGraphNode_Dead");
		CameraGraphNode_Dead_ParamsSize = NativeReflection.GetFunctionParamsSize(CameraGraphNode_Dead_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CameraGraphNode_Dead_bEnable_PropertyAddress, CameraGraphNode_Dead_FunctionAddress, "bEnable");
		CameraGraphNode_Dead_bEnable_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_Dead_FunctionAddress, "bEnable");
		CameraGraphNode_Dead_bEnable_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_Dead_FunctionAddress, "bEnable", Classes.FBoolProperty);
		CameraGraphNode_Dead_ArmLength_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_Dead_FunctionAddress, "ArmLength");
		CameraGraphNode_Dead_ArmLength_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_Dead_FunctionAddress, "ArmLength", Classes.FFloatProperty);
		CameraGraphNode_Dead_ArmLengthSpeed_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_Dead_FunctionAddress, "ArmLengthSpeed");
		CameraGraphNode_Dead_ArmLengthSpeed_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_Dead_FunctionAddress, "ArmLengthSpeed", Classes.FFloatProperty);
		CameraGraphNode_Dead_CameraPitch_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_Dead_FunctionAddress, "CameraPitch");
		CameraGraphNode_Dead_CameraPitch_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_Dead_FunctionAddress, "CameraPitch", Classes.FFloatProperty);
		CameraGraphNode_Dead_CameraPitchSpeed_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_Dead_FunctionAddress, "CameraPitchSpeed");
		CameraGraphNode_Dead_CameraPitchSpeed_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_Dead_FunctionAddress, "CameraPitchSpeed", Classes.FFloatProperty);
		CameraGraphNode_Dead_IsValid = CameraGraphNode_Dead_FunctionAddress != IntPtr.Zero && CameraGraphNode_Dead_bEnable_IsValid && CameraGraphNode_Dead_ArmLength_IsValid && CameraGraphNode_Dead_ArmLengthSpeed_IsValid && CameraGraphNode_Dead_CameraPitch_IsValid && CameraGraphNode_Dead_CameraPitchSpeed_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_Dead", CameraGraphNode_Dead_IsValid);
		CameraGraphNode_Lock_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CameraGraphNode_Lock");
		CameraGraphNode_Lock_ParamsSize = NativeReflection.GetFunctionParamsSize(CameraGraphNode_Lock_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CameraGraphNode_Lock_bEnable_PropertyAddress, CameraGraphNode_Lock_FunctionAddress, "bEnable");
		CameraGraphNode_Lock_bEnable_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_Lock_FunctionAddress, "bEnable");
		CameraGraphNode_Lock_bEnable_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_Lock_FunctionAddress, "bEnable", Classes.FBoolProperty);
		CameraGraphNode_Lock_IsValid = CameraGraphNode_Lock_FunctionAddress != IntPtr.Zero && CameraGraphNode_Lock_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_Lock", CameraGraphNode_Lock_IsValid);
		CameraGraphNode_Giant_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CameraGraphNode_Giant");
		CameraGraphNode_Giant_ParamsSize = NativeReflection.GetFunctionParamsSize(CameraGraphNode_Giant_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CameraGraphNode_Giant_bEnable_PropertyAddress, CameraGraphNode_Giant_FunctionAddress, "bEnable");
		CameraGraphNode_Giant_bEnable_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_Giant_FunctionAddress, "bEnable");
		CameraGraphNode_Giant_bEnable_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_Giant_FunctionAddress, "bEnable", Classes.FBoolProperty);
		CameraGraphNode_Giant_IsValid = CameraGraphNode_Giant_FunctionAddress != IntPtr.Zero && CameraGraphNode_Giant_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_Giant", CameraGraphNode_Giant_IsValid);
		CameraGraphNode_Curve_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CameraGraphNode_Curve");
		CameraGraphNode_Curve_ParamsSize = NativeReflection.GetFunctionParamsSize(CameraGraphNode_Curve_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CameraGraphNode_Curve_bEnable_PropertyAddress, CameraGraphNode_Curve_FunctionAddress, "bEnable");
		CameraGraphNode_Curve_bEnable_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_Curve_FunctionAddress, "bEnable");
		CameraGraphNode_Curve_bEnable_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_Curve_FunctionAddress, "bEnable", Classes.FBoolProperty);
		CameraGraphNode_Curve_IsValid = CameraGraphNode_Curve_FunctionAddress != IntPtr.Zero && CameraGraphNode_Curve_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_Curve", CameraGraphNode_Curve_IsValid);
		CameraGraphNode_Player_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CameraGraphNode_Player");
		CameraGraphNode_Player_ParamsSize = NativeReflection.GetFunctionParamsSize(CameraGraphNode_Player_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CameraGraphNode_Player_bEnable_PropertyAddress, CameraGraphNode_Player_FunctionAddress, "bEnable");
		CameraGraphNode_Player_bEnable_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_Player_FunctionAddress, "bEnable");
		CameraGraphNode_Player_bEnable_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_Player_FunctionAddress, "bEnable", Classes.FBoolProperty);
		CameraGraphNode_Player_IsValid = CameraGraphNode_Player_FunctionAddress != IntPtr.Zero && CameraGraphNode_Player_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_Player", CameraGraphNode_Player_IsValid);
		CameraGraphNode_AutoTrail_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CameraGraphNode_AutoTrail");
		CameraGraphNode_AutoTrail_ParamsSize = NativeReflection.GetFunctionParamsSize(CameraGraphNode_AutoTrail_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CameraGraphNode_AutoTrail_bEnable_PropertyAddress, CameraGraphNode_AutoTrail_FunctionAddress, "bEnable");
		CameraGraphNode_AutoTrail_bEnable_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_AutoTrail_FunctionAddress, "bEnable");
		CameraGraphNode_AutoTrail_bEnable_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_AutoTrail_FunctionAddress, "bEnable", Classes.FBoolProperty);
		CameraGraphNode_AutoTrail_InCameraRotationRate_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_AutoTrail_FunctionAddress, "InCameraRotationRate");
		CameraGraphNode_AutoTrail_InCameraRotationRate_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_AutoTrail_FunctionAddress, "InCameraRotationRate", Classes.FFloatProperty);
		CameraGraphNode_AutoTrail_InCameraRotationAccelerate_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_AutoTrail_FunctionAddress, "InCameraRotationAccelerate");
		CameraGraphNode_AutoTrail_InCameraRotationAccelerate_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_AutoTrail_FunctionAddress, "InCameraRotationAccelerate", Classes.FFloatProperty);
		CameraGraphNode_AutoTrail_InCameraRotationVelocityThreshold_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_AutoTrail_FunctionAddress, "InCameraRotationVelocityThreshold");
		CameraGraphNode_AutoTrail_InCameraRotationVelocityThreshold_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_AutoTrail_FunctionAddress, "InCameraRotationVelocityThreshold", Classes.FFloatProperty);
		CameraGraphNode_AutoTrail_InFallingAdjustAngleLimit_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_AutoTrail_FunctionAddress, "InFallingAdjustAngleLimit");
		CameraGraphNode_AutoTrail_InFallingAdjustAngleLimit_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_AutoTrail_FunctionAddress, "InFallingAdjustAngleLimit", Classes.FFloatProperty);
		CameraGraphNode_AutoTrail_InFallingAdjustSpeedPercent_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_AutoTrail_FunctionAddress, "InFallingAdjustSpeedPercent");
		CameraGraphNode_AutoTrail_InFallingAdjustSpeedPercent_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_AutoTrail_FunctionAddress, "InFallingAdjustSpeedPercent", Classes.FFloatProperty);
		CameraGraphNode_AutoTrail_IsValid = CameraGraphNode_AutoTrail_FunctionAddress != IntPtr.Zero && CameraGraphNode_AutoTrail_bEnable_IsValid && CameraGraphNode_AutoTrail_InCameraRotationRate_IsValid && CameraGraphNode_AutoTrail_InCameraRotationAccelerate_IsValid && CameraGraphNode_AutoTrail_InCameraRotationVelocityThreshold_IsValid && CameraGraphNode_AutoTrail_InFallingAdjustAngleLimit_IsValid && CameraGraphNode_AutoTrail_InFallingAdjustSpeedPercent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_AutoTrail", CameraGraphNode_AutoTrail_IsValid);
		CameraGraphNode_LockSkill_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CameraGraphNode_LockSkill");
		CameraGraphNode_LockSkill_ParamsSize = NativeReflection.GetFunctionParamsSize(CameraGraphNode_LockSkill_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CameraGraphNode_LockSkill_bEnable_PropertyAddress, CameraGraphNode_LockSkill_FunctionAddress, "bEnable");
		CameraGraphNode_LockSkill_bEnable_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_LockSkill_FunctionAddress, "bEnable");
		CameraGraphNode_LockSkill_bEnable_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_LockSkill_FunctionAddress, "bEnable", Classes.FBoolProperty);
		CameraGraphNode_LockSkill_IsValid = CameraGraphNode_LockSkill_FunctionAddress != IntPtr.Zero && CameraGraphNode_LockSkill_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_LockSkill", CameraGraphNode_LockSkill_IsValid);
		CameraGraphNode_FixedParam_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CameraGraphNode_FixedParam");
		CameraGraphNode_FixedParam_ParamsSize = NativeReflection.GetFunctionParamsSize(CameraGraphNode_FixedParam_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CameraGraphNode_FixedParam_bEnable_PropertyAddress, CameraGraphNode_FixedParam_FunctionAddress, "bEnable");
		CameraGraphNode_FixedParam_bEnable_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_FixedParam_FunctionAddress, "bEnable");
		CameraGraphNode_FixedParam_bEnable_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_FixedParam_FunctionAddress, "bEnable", Classes.FBoolProperty);
		CameraGraphNode_FixedParam_IsValid = CameraGraphNode_FixedParam_FunctionAddress != IntPtr.Zero && CameraGraphNode_FixedParam_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_FixedParam", CameraGraphNode_FixedParam_IsValid);
		CameraGraphNode_SplineMove_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CameraGraphNode_SplineMove");
		CameraGraphNode_SplineMove_ParamsSize = NativeReflection.GetFunctionParamsSize(CameraGraphNode_SplineMove_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CameraGraphNode_SplineMove_bEnable_PropertyAddress, CameraGraphNode_SplineMove_FunctionAddress, "bEnable");
		CameraGraphNode_SplineMove_bEnable_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_SplineMove_FunctionAddress, "bEnable");
		CameraGraphNode_SplineMove_bEnable_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_SplineMove_FunctionAddress, "bEnable", Classes.FBoolProperty);
		CameraGraphNode_SplineMove_CameraPitchAdditive_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_SplineMove_FunctionAddress, "CameraPitchAdditive");
		CameraGraphNode_SplineMove_CameraPitchAdditive_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_SplineMove_FunctionAddress, "CameraPitchAdditive", Classes.FFloatProperty);
		CameraGraphNode_SplineMove_CameraYawAdditive_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_SplineMove_FunctionAddress, "CameraYawAdditive");
		CameraGraphNode_SplineMove_CameraYawAdditive_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_SplineMove_FunctionAddress, "CameraYawAdditive", Classes.FFloatProperty);
		CameraGraphNode_SplineMove_IsValid = CameraGraphNode_SplineMove_FunctionAddress != IntPtr.Zero && CameraGraphNode_SplineMove_bEnable_IsValid && CameraGraphNode_SplineMove_CameraPitchAdditive_IsValid && CameraGraphNode_SplineMove_CameraYawAdditive_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_SplineMove", CameraGraphNode_SplineMove_IsValid);
		CameraGraphNode_GiantSkill_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CameraGraphNode_GiantSkill");
		CameraGraphNode_GiantSkill_ParamsSize = NativeReflection.GetFunctionParamsSize(CameraGraphNode_GiantSkill_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CameraGraphNode_GiantSkill_bEnable_PropertyAddress, CameraGraphNode_GiantSkill_FunctionAddress, "bEnable");
		CameraGraphNode_GiantSkill_bEnable_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_GiantSkill_FunctionAddress, "bEnable");
		CameraGraphNode_GiantSkill_bEnable_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_GiantSkill_FunctionAddress, "bEnable", Classes.FBoolProperty);
		CameraGraphNode_GiantSkill_IsValid = CameraGraphNode_GiantSkill_FunctionAddress != IntPtr.Zero && CameraGraphNode_GiantSkill_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_GiantSkill", CameraGraphNode_GiantSkill_IsValid);
		CameraGraphNode_AxisSmooth_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CameraGraphNode_AxisSmooth");
		CameraGraphNode_AxisSmooth_ParamsSize = NativeReflection.GetFunctionParamsSize(CameraGraphNode_AxisSmooth_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CameraGraphNode_AxisSmooth_bEnable_PropertyAddress, CameraGraphNode_AxisSmooth_FunctionAddress, "bEnable");
		CameraGraphNode_AxisSmooth_bEnable_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_AxisSmooth_FunctionAddress, "bEnable");
		CameraGraphNode_AxisSmooth_bEnable_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_AxisSmooth_FunctionAddress, "bEnable", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref CameraGraphNode_AxisSmooth_IsXAxisFixed_PropertyAddress, CameraGraphNode_AxisSmooth_FunctionAddress, "IsXAxisFixed");
		CameraGraphNode_AxisSmooth_IsXAxisFixed_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_AxisSmooth_FunctionAddress, "IsXAxisFixed");
		CameraGraphNode_AxisSmooth_IsXAxisFixed_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_AxisSmooth_FunctionAddress, "IsXAxisFixed", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref CameraGraphNode_AxisSmooth_IsYAxisFixed_PropertyAddress, CameraGraphNode_AxisSmooth_FunctionAddress, "IsYAxisFixed");
		CameraGraphNode_AxisSmooth_IsYAxisFixed_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_AxisSmooth_FunctionAddress, "IsYAxisFixed");
		CameraGraphNode_AxisSmooth_IsYAxisFixed_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_AxisSmooth_FunctionAddress, "IsYAxisFixed", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref CameraGraphNode_AxisSmooth_IsZAxisFixed_PropertyAddress, CameraGraphNode_AxisSmooth_FunctionAddress, "IsZAxisFixed");
		CameraGraphNode_AxisSmooth_IsZAxisFixed_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_AxisSmooth_FunctionAddress, "IsZAxisFixed");
		CameraGraphNode_AxisSmooth_IsZAxisFixed_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_AxisSmooth_FunctionAddress, "IsZAxisFixed", Classes.FBoolProperty);
		CameraGraphNode_AxisSmooth_SmoothSpeed_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_AxisSmooth_FunctionAddress, "SmoothSpeed");
		CameraGraphNode_AxisSmooth_SmoothSpeed_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_AxisSmooth_FunctionAddress, "SmoothSpeed", Classes.FFloatProperty);
		CameraGraphNode_AxisSmooth_CameraLagSpeed_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_AxisSmooth_FunctionAddress, "CameraLagSpeed");
		CameraGraphNode_AxisSmooth_CameraLagSpeed_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_AxisSmooth_FunctionAddress, "CameraLagSpeed", Classes.FFloatProperty);
		CameraGraphNode_AxisSmooth_IsValid = CameraGraphNode_AxisSmooth_FunctionAddress != IntPtr.Zero && CameraGraphNode_AxisSmooth_bEnable_IsValid && CameraGraphNode_AxisSmooth_IsXAxisFixed_IsValid && CameraGraphNode_AxisSmooth_IsYAxisFixed_IsValid && CameraGraphNode_AxisSmooth_IsZAxisFixed_IsValid && CameraGraphNode_AxisSmooth_SmoothSpeed_IsValid && CameraGraphNode_AxisSmooth_CameraLagSpeed_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_AxisSmooth", CameraGraphNode_AxisSmooth_IsValid);
		CameraGraphNode_PlayerSkill_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CameraGraphNode_PlayerSkill");
		CameraGraphNode_PlayerSkill_ParamsSize = NativeReflection.GetFunctionParamsSize(CameraGraphNode_PlayerSkill_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CameraGraphNode_PlayerSkill_bEnable_PropertyAddress, CameraGraphNode_PlayerSkill_FunctionAddress, "bEnable");
		CameraGraphNode_PlayerSkill_bEnable_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_PlayerSkill_FunctionAddress, "bEnable");
		CameraGraphNode_PlayerSkill_bEnable_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_PlayerSkill_FunctionAddress, "bEnable", Classes.FBoolProperty);
		CameraGraphNode_PlayerSkill_IsValid = CameraGraphNode_PlayerSkill_FunctionAddress != IntPtr.Zero && CameraGraphNode_PlayerSkill_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_PlayerSkill", CameraGraphNode_PlayerSkill_IsValid);
		CameraGraphNode_GuiBeiCamera_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CameraGraphNode_GuiBeiCamera");
		CameraGraphNode_GuiBeiCamera_ParamsSize = NativeReflection.GetFunctionParamsSize(CameraGraphNode_GuiBeiCamera_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CameraGraphNode_GuiBeiCamera_bEnable_PropertyAddress, CameraGraphNode_GuiBeiCamera_FunctionAddress, "bEnable");
		CameraGraphNode_GuiBeiCamera_bEnable_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_GuiBeiCamera_FunctionAddress, "bEnable");
		CameraGraphNode_GuiBeiCamera_bEnable_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_GuiBeiCamera_FunctionAddress, "bEnable", Classes.FBoolProperty);
		CameraGraphNode_GuiBeiCamera_IsValid = CameraGraphNode_GuiBeiCamera_FunctionAddress != IntPtr.Zero && CameraGraphNode_GuiBeiCamera_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_GuiBeiCamera", CameraGraphNode_GuiBeiCamera_IsValid);
		CameraGraphNode_ShootSuction_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CameraGraphNode_ShootSuction");
		CameraGraphNode_ShootSuction_ParamsSize = NativeReflection.GetFunctionParamsSize(CameraGraphNode_ShootSuction_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CameraGraphNode_ShootSuction_bEnable_PropertyAddress, CameraGraphNode_ShootSuction_FunctionAddress, "bEnable");
		CameraGraphNode_ShootSuction_bEnable_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_ShootSuction_FunctionAddress, "bEnable");
		CameraGraphNode_ShootSuction_bEnable_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_ShootSuction_FunctionAddress, "bEnable", Classes.FBoolProperty);
		CameraGraphNode_ShootSuction_IsValid = CameraGraphNode_ShootSuction_FunctionAddress != IntPtr.Zero && CameraGraphNode_ShootSuction_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_ShootSuction", CameraGraphNode_ShootSuction_IsValid);
		CameraGraphNode_TraceVelocity_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CameraGraphNode_TraceVelocity");
		CameraGraphNode_TraceVelocity_ParamsSize = NativeReflection.GetFunctionParamsSize(CameraGraphNode_TraceVelocity_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CameraGraphNode_TraceVelocity_bEnable_PropertyAddress, CameraGraphNode_TraceVelocity_FunctionAddress, "bEnable");
		CameraGraphNode_TraceVelocity_bEnable_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_TraceVelocity_FunctionAddress, "bEnable");
		CameraGraphNode_TraceVelocity_bEnable_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_TraceVelocity_FunctionAddress, "bEnable", Classes.FBoolProperty);
		CameraGraphNode_TraceVelocity_IsValid = CameraGraphNode_TraceVelocity_FunctionAddress != IntPtr.Zero && CameraGraphNode_TraceVelocity_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_TraceVelocity", CameraGraphNode_TraceVelocity_IsValid);
		CameraGraphNode_InverseCamera_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CameraGraphNode_InverseCamera");
		CameraGraphNode_InverseCamera_ParamsSize = NativeReflection.GetFunctionParamsSize(CameraGraphNode_InverseCamera_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CameraGraphNode_InverseCamera_bEnable_PropertyAddress, CameraGraphNode_InverseCamera_FunctionAddress, "bEnable");
		CameraGraphNode_InverseCamera_bEnable_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_InverseCamera_FunctionAddress, "bEnable");
		CameraGraphNode_InverseCamera_bEnable_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_InverseCamera_FunctionAddress, "bEnable", Classes.FBoolProperty);
		CameraGraphNode_InverseCamera_IsValid = CameraGraphNode_InverseCamera_FunctionAddress != IntPtr.Zero && CameraGraphNode_InverseCamera_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_InverseCamera", CameraGraphNode_InverseCamera_IsValid);
		CameraGraphNode_CloudMoveLimit_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CameraGraphNode_CloudMoveLimit");
		CameraGraphNode_CloudMoveLimit_ParamsSize = NativeReflection.GetFunctionParamsSize(CameraGraphNode_CloudMoveLimit_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CameraGraphNode_CloudMoveLimit_bEnable_PropertyAddress, CameraGraphNode_CloudMoveLimit_FunctionAddress, "bEnable");
		CameraGraphNode_CloudMoveLimit_bEnable_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_CloudMoveLimit_FunctionAddress, "bEnable");
		CameraGraphNode_CloudMoveLimit_bEnable_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_CloudMoveLimit_FunctionAddress, "bEnable", Classes.FBoolProperty);
		CameraGraphNode_CloudMoveLimit_IsValid = CameraGraphNode_CloudMoveLimit_FunctionAddress != IntPtr.Zero && CameraGraphNode_CloudMoveLimit_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_CloudMoveLimit", CameraGraphNode_CloudMoveLimit_IsValid);
		CameraGraphNode_LerpPostProcess_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CameraGraphNode_LerpPostProcess");
		CameraGraphNode_LerpPostProcess_ParamsSize = NativeReflection.GetFunctionParamsSize(CameraGraphNode_LerpPostProcess_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CameraGraphNode_LerpPostProcess_bEnable_PropertyAddress, CameraGraphNode_LerpPostProcess_FunctionAddress, "bEnable");
		CameraGraphNode_LerpPostProcess_bEnable_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_LerpPostProcess_FunctionAddress, "bEnable");
		CameraGraphNode_LerpPostProcess_bEnable_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_LerpPostProcess_FunctionAddress, "bEnable", Classes.FBoolProperty);
		CameraGraphNode_LerpPostProcess_IsValid = CameraGraphNode_LerpPostProcess_FunctionAddress != IntPtr.Zero && CameraGraphNode_LerpPostProcess_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_LerpPostProcess", CameraGraphNode_LerpPostProcess_IsValid);
		CameraGraphNode_AutoMoveTrailCamera_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CameraGraphNode_AutoMoveTrailCamera");
		CameraGraphNode_AutoMoveTrailCamera_ParamsSize = NativeReflection.GetFunctionParamsSize(CameraGraphNode_AutoMoveTrailCamera_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CameraGraphNode_AutoMoveTrailCamera_bEnable_PropertyAddress, CameraGraphNode_AutoMoveTrailCamera_FunctionAddress, "bEnable");
		CameraGraphNode_AutoMoveTrailCamera_bEnable_Offset = NativeReflection.GetPropertyOffset(CameraGraphNode_AutoMoveTrailCamera_FunctionAddress, "bEnable");
		CameraGraphNode_AutoMoveTrailCamera_bEnable_IsValid = NativeReflection.ValidatePropertyClass(CameraGraphNode_AutoMoveTrailCamera_FunctionAddress, "bEnable", Classes.FBoolProperty);
		CameraGraphNode_AutoMoveTrailCamera_IsValid = CameraGraphNode_AutoMoveTrailCamera_FunctionAddress != IntPtr.Zero && CameraGraphNode_AutoMoveTrailCamera_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSCameraGraph:CameraGraphNode_AutoMoveTrailCamera", CameraGraphNode_AutoMoveTrailCamera_IsValid);
	}

	static GSCameraGraph()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSCameraGraph)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSCameraGraph));
	}
}
