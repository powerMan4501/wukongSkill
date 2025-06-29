using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
internal class BUS_UnitHitVEffectComp : UActorCompBaseCS
{
	private BUC_UnitHitVEffectData UnitHitVEffectData;

	private IBUC_PropMgrData PropMgrData;

	public override void OnAttach()
	{
		UnitHitVEffectData = RequireWritableData<BUC_UnitHitVEffectData>();
		PropMgrData = RequireReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>();
		base.BUSEventCollection.Evt_TriggerFreezeFrame += new Del_TriggerFreezeFrame(OnTriggerFreezeFrame);
		base.BUSEventCollection.Evt_SetSlowIKConfig += new Del_SetSlowIKConfig(OnSetSlowIKConfig);
		base.BUSEventCollection.Evt_DisableSlowIK += new Del_Void(DisableSlowIK);
		base.BUSEventCollection.Evt_TriggerSlowIK += new Del_TriggerSlowIK(TriggerSlowIK);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		AActor owner = GetOwner();
		if (owner == null)
		{
			return;
		}
		ACharacter aCharacter = owner as ACharacter;
		if (!(aCharacter == null))
		{
			UWorld world = aCharacter.World;
			if (!(world == null))
			{
				float timeSeconds = world.GetTimeSeconds();
				UpdateForBeAttackedFreezeFrame(aCharacter, DeltaTime);
				UpdateForUnFreezeFrame(aCharacter, timeSeconds);
			}
		}
	}

	private void UpdateForBeAttackedFreezeFrame(ACharacter OwnerChr, float DeltaTime)
	{
		if (!UnitHitVEffectData.IsTriggerFreezeFrameEnable)
		{
			return;
		}
		if (UnitHitVEffectData.BeAttackedDelayTriggerFreezeFrameTimer > 0f)
		{
			if (IsPlayingMontage(OwnerChr))
			{
				float freezeFrameTimeCache = UnitHitVEffectData.FreezeFrameTimeCache;
				float freezeFrameGapCache = UnitHitVEffectData.FreezeFrameGapCache;
				UnitHitVEffectData.BeAttackedDelayTriggerFreezeFrameTimer = 0f;
				UnitHitVEffectData.FreezeFrameTimeCache = 0f;
				UnitHitVEffectData.FreezeFrameGapCache = 0f;
				EnableFreezeFrame(freezeFrameTimeCache, freezeFrameGapCache, bPlayedMontage: true);
			}
		}
		else
		{
			UnitHitVEffectData.IsTriggerFreezeFrameEnable = false;
		}
		UnitHitVEffectData.BeAttackedDelayTriggerFreezeFrameTimer -= DeltaTime;
	}

	private void UpdateForUnFreezeFrame(ACharacter OwnerChr, float CurrentTimeInSeconds)
	{
		if (UnitHitVEffectData.UnFreezeFrameTimeMark(CurrentTimeInSeconds))
		{
			base.BUSEventCollection?.Evt_PauseUpdate.Invoke(P1: false);
			UnitHitVEffectData.IsTriggerFreezeFrameEnable = false;
			BGUFuncLibAnim.BGUSetCharacterMontagePlaying(OwnerChr, IsPlaying: true);
			base.BUSEventCollection?.Evt_ResetProperty.Invoke(UnitHitVEffectData.PauseAnimsHandleID);
			UnitHitVEffectData.PauseAnimsHandleID = 0u;
			UBUS_UtilComm.ParticleSystemComponentTrailSetTimeRate(OwnerChr, 1f);
			UpdateForFreezeFrameGap(CurrentTimeInSeconds);
		}
	}

	private void UpdateForFreezeFrameGap(float CurrentTimeInSeconds)
	{
		if (!UnitHitVEffectData.CheckIsInFreezeFrameGap(CurrentTimeInSeconds))
		{
			UnitHitVEffectData.ResetFreezeFrameStartTimeMark();
			UnitHitVEffectData.ResetFreezeFrameGap();
		}
	}

	private void OnTriggerFreezeFrame(float TotalFreezeTime, float FreezeGap, bool EnableCache = false, bool bPlayedMontage = true)
	{
		AActor owner = GetOwner();
		if (owner == null)
		{
			return;
		}
		ACharacter aCharacter = owner as ACharacter;
		if (!(aCharacter == null))
		{
			if (bPlayedMontage && !IsPlayingMontage(aCharacter) && EnableCache)
			{
				UnitHitVEffectData.IsTriggerFreezeFrameEnable = true;
				UnitHitVEffectData.BeAttackedDelayTriggerFreezeFrameTimer = 0.1f;
				UnitHitVEffectData.FreezeFrameTimeCache = TotalFreezeTime;
				UnitHitVEffectData.FreezeFrameGapCache = FreezeGap;
			}
			else
			{
				EnableFreezeFrame(TotalFreezeTime, FreezeGap, bPlayedMontage);
			}
		}
	}

	private void EnableFreezeFrame(float TotalFreezeTime, float FreezeGap, bool bPlayedMontage)
	{
		AActor owner = GetOwner();
		if (owner == null)
		{
			return;
		}
		ACharacter aCharacter = owner as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		base.BUSEventCollection?.Evt_PauseUpdate.Invoke(P1: true);
		UnitHitVEffectData.UpdateFreezeFrameGap(FreezeGap);
		float timeSeconds = aCharacter.World.GetTimeSeconds();
		if (UnitHitVEffectData.CheckIsInFreezeFrameGap(timeSeconds))
		{
			return;
		}
		UnitHitVEffectData.IsTriggerFreezeFrameEnable = true;
		UnitHitVEffectData.MarkFreezeFrame(TotalFreezeTime, timeSeconds);
		BGUFuncLibAnim.BGUSetCharacterMontagePlaying(aCharacter, IsPlaying: false);
		if (!bPlayedMontage)
		{
			if (UnitHitVEffectData.PauseAnimsHandleID == 0)
			{
				base.BUSEventCollection?.Evt_SetBoolProperty.Invoke(EPropType.Mesh_PauseAnims, Value: true);
				UnitHitVEffectData.PauseAnimsHandleID = PropMgrData.GetLastHandleID();
			}
			else
			{
				base.BUSEventCollection?.Evt_SetBoolProperty.Invoke(EPropType.Mesh_PauseAnims, Value: true, UnitHitVEffectData.PauseAnimsHandleID);
			}
		}
		UBUS_UtilComm.ParticleSystemComponentTrailSetTimeRate(aCharacter, 0f);
		aCharacter.CharacterMovement.Velocity = FVector.ZeroVector;
	}

	private bool IsPlayingMontage(ACharacter OwnerChr)
	{
		USkeletalMeshComponent mesh = OwnerChr.Mesh;
		if (mesh == null)
		{
			return false;
		}
		UAnimInstance animInstance = mesh.GetAnimInstance();
		if (animInstance == null)
		{
			return false;
		}
		if (animInstance.GetCurrentActiveMontage() == null)
		{
			return false;
		}
		return true;
	}

	public void OnSetSlowIKConfig(ESlowIKType SlowIKType, float SlowTime, float SlowTime_Crit, float ProtectGap)
	{
		UnitHitVEffectData.SlowIKType = SlowIKType;
		UnitHitVEffectData.SlowTime = SlowTime;
		UnitHitVEffectData.SlowTime_Crit = SlowTime_Crit;
		UnitHitVEffectData.SlowIK_ProtectGap = ProtectGap;
	}

	public void DisableSlowIK()
	{
		UnitHitVEffectData.SlowIKType = ESlowIKType.None;
		UnitHitVEffectData.SlowTime = -1f;
		UnitHitVEffectData.SlowTime_Crit = -1f;
		UnitHitVEffectData.SlowIK_ProtectGap = 0f;
	}

	public void TriggerSlowIK(ESlowIKType SlowIKType, float SlowTime)
	{
		float timeSeconds = Owner.World.GetTimeSeconds();
		if (!UnitHitVEffectData.CheckIsInFreezeFrameGap(timeSeconds))
		{
			UnitHitVEffectData.MarkSlowIKProtectGap(UnitHitVEffectData.SlowIK_ProtectGap, timeSeconds);
			base.BUSEventCollection.Evt_HandleSlowIK.Invoke(Enable: true, SlowIKType, SlowTime);
		}
	}
}
