using System;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BPS_CameraSystem : PlayerControllerSystemBase
{
	private BPC_PlayerCameraData CameraData { get; set; }

	public override void OnAttach()
	{
		CameraData = RequireWritablePlayerStateData<BPC_PlayerCameraData>();
		BPS_GSEventCollection bPSEventCollection = GetBPSEventCollection();
		bPSEventCollection.Evt_EnterSkillCameraConversionParam += new Del_Void_Int(EnterSkillCameraParamConversion);
		bPSEventCollection.Evt_ExitSkillCameraConversionParam += new Del_Void_Int(ExitSkillCameraParamConversion);
		bPSEventCollection.Evt_SetResIDCameraConversionParam += new Del_Void_Int(SetCameraParamConversionResID);
		bPSEventCollection.Evt_OnSwitchCameraGroupVolumeTo += new Del_Void_IntFloatFloat(SwitchCameraGroupVolumeTo);
		bPSEventCollection.Evt_EnterSkillCam += new Del_Void_ActorInt(EnterSkillCamera);
		bPSEventCollection.Evt_ExitSkillCam += new Del_Void_Actor(ExitSkillCamera);
		bPSEventCollection.Evt_EnterCameraGroup += new Del_Void_Int(OnEnterCameraGroup);
		bPSEventCollection.Evt_ExitCameraGroup += new Del_Void_Int(OnExitCameraGroup);
		bPSEventCollection.Evt_OnEnterSkillCameraGroup += new Del_Void_IntInt(OnEnterSkillCameraGroup);
		bPSEventCollection.Evt_OnExitSkillCameraGroup += new Del_Void_IntInt(OnExitSkillCameraGroup);
		bPSEventCollection.Evt_BPS_OnControlledPawnChange += new Del_Param_APawn(OnControlledPawnChange);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_TriggerResetAllActors = (BGW_EventCollection.Del_TriggerResetAllActors)Delegate.Combine(bGWEventCollection.Evt_TriggerResetAllActors, new BGW_EventCollection.Del_TriggerResetAllActors(OnTriggerResetAllActors));
		base.BUSEventCollection = BUS_EventCollectionCS.Get(GetControlledPlayerCharacter());
	}

	private void SwitchCameraGroupVolumeTo(int TargetCameraGroupId, float Alpha, float BlendTime)
	{
		CameraData.CameraGroupIdFromVolume = TargetCameraGroupId;
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_TriggerResetAllActors = (BGW_EventCollection.Del_TriggerResetAllActors)Delegate.Remove(bGWEventCollection.Evt_TriggerResetAllActors, new BGW_EventCollection.Del_TriggerResetAllActors(OnTriggerResetAllActors));
	}

	private void OnControlledPawnChange(APawn TargetPawn)
	{
		base.BUSEventCollection = BUS_EventCollectionCS.Get(TargetPawn);
	}

	public override void PreBeginPlay()
	{
		CameraData.RemainUnitTransBlendTime = 0f;
	}

	private void SetCameraParamConversionResID(int ResID)
	{
		if (CameraData.CurrentParams == null)
		{
			CameraData.CurrentParams = new FCameraConversionParams();
			CameraData.CurrentParams.InitByID(ResID);
		}
		BeginBlend2Target(ResID);
	}

	private void EnterSkillCameraParamConversion(int ConversionID)
	{
		if (ConversionID > 100)
		{
			if (CameraData.SkillTargetParams == null)
			{
				CameraData.SkillTargetParams = CameraData.SkillTargetParamsPrototype;
			}
			BeginBlend2Target(ConversionID);
		}
	}

	private void ExitSkillCameraParamConversion(int ConversionID)
	{
		if (CameraData.SkillTargetParams != null && CameraData.SkillTargetParams.ParamID == ConversionID)
		{
			if (CameraData.SkillTargetParams != null)
			{
				CameraData.SkillTargetParams = null;
			}
			CameraData.PreviousParams.CopyFromOther(CameraData.CurrentParams);
			SetBlendTime(CameraData.ResIDTargetParams);
		}
	}

	private void BeginBlend2Target(int TargetParamID)
	{
		CameraData.PreviousParams.CopyFromOther(CameraData.CurrentParams);
		if (TargetParamID < 100)
		{
			CameraData.ResIDTargetParams.InitByID(TargetParamID);
			if (CameraData.SkillTargetParams == null)
			{
				SetBlendTime(CameraData.ResIDTargetParams);
			}
		}
		else
		{
			CameraData.SkillTargetParams.InitByID(TargetParamID);
			SetBlendTime(CameraData.SkillTargetParams);
		}
	}

	private void SetBlendTime(FCameraConversionParams Target)
	{
		if (Target.BlendTime > 1E-08f)
		{
			CameraData.RemainUnitTransBlendTime = Target.BlendTime;
			return;
		}
		CameraData.RemainUnitTransBlendTime = 0f;
		CameraData.CurrentParams.CopyFromOther(Target);
	}

	public override int GetTickGroupMask()
	{
		return 1;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (CameraData.RemainUnitTransBlendTime > 0f)
		{
			FCameraConversionParams fCameraConversionParams = CameraData.SkillTargetParams ?? CameraData.ResIDTargetParams;
			CameraData.RemainUnitTransBlendTime -= DeltaTime;
			float alpha = 1f - FMath.Clamp(CameraData.RemainUnitTransBlendTime / fCameraConversionParams.BlendTime, 0f, 1f);
			CameraData.CurrentParams.LerpValue(CameraData.PreviousParams, fCameraConversionParams, alpha);
		}
	}

	private void EnterSkillCamera(AActor InSkillCaster, int SkillCamID)
	{
		CameraData.SkillCameraDictionary[InSkillCaster] = SkillCamID;
		base.BUSEventCollection.Evt_EnterSkillCam.Invoke(InSkillCaster);
	}

	private void ExitSkillCamera(AActor InSkillCaster)
	{
		CameraData.SkillCameraDictionary.Remove(InSkillCaster);
		base.BUSEventCollection.Evt_ExitSkillCam.Invoke(InSkillCaster);
	}

	private void OnEnterCameraGroup(int CameraGroupId)
	{
		CameraData.CameraGroupIdOverride = CameraGroupId;
	}

	private void OnExitCameraGroup(int CameraGroupId)
	{
		if (CameraGroupId <= 0 || CameraData.CameraGroupIdOverride == CameraGroupId)
		{
			CameraData.CameraGroupIdOverride = -1;
		}
	}

	private void OnEnterSkillCameraGroup(int SkillCameraGroupId, int NotifyID)
	{
		CameraData.SkillCameraGroupIdOverride = SkillCameraGroupId;
		CameraData.SkillCameraGroupIdOverrideByNotifyID = NotifyID;
	}

	private void OnExitSkillCameraGroup(int SkillCameraGroupId, int NotifyID)
	{
		if (SkillCameraGroupId <= 0 || (CameraData.SkillCameraGroupIdOverride == SkillCameraGroupId && CameraData.SkillCameraGroupIdOverrideByNotifyID == NotifyID))
		{
			CameraData.SkillCameraGroupIdOverrideByNotifyID = -1;
			CameraData.SkillCameraGroupIdOverride = -1;
		}
	}

	private void OnTriggerResetAllActors(EResetActorReason ResetReason)
	{
		if (ResetReason == EResetActorReason.Rebirth || ResetReason == EResetActorReason.InteractRebirthPoint)
		{
			OnExitSkillCameraGroup(-1, -1);
		}
	}
}
