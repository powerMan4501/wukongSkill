using System.Collections.Generic;
using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_CliffFallComp : UActorCompBaseCS
{
	private b1.BUC_CliffFallData CliffFallData;

	private IBUC_PropMgrData PropMgrData;

	private ECollisionChannel AirWallChannel = ECollisionChannel.ECC_GameTraceChannel16;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_SimpleStateData SimpleStateData;

	private const float MaxAngel = 67.5f;

	public override void OnAttach()
	{
		CliffFallData = RequireWritableData<b1.BUC_CliffFallData>();
		PropMgrData = RequireReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		base.BUSEventCollection.Evt_OnBeatBackStartCheck += new Del_OnBeatBackStartCheck(OnBeatBackStartCheck);
		base.BUSEventCollection.Evt_AfterUnitRebirth += new Del_UnitRebirth(OnPlayerRebirth);
		base.BUSEventCollection.Evt_FallIntoDeadZone += new Del_Void(PlayerFallIntoDeadZone);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (CliffFallData.bFlag_PendingDead)
		{
			if (!CliffFallData.ActuallyThroughCliffAirWall)
			{
				OnActuallyThroughAirWallCheck();
			}
			if (CliffFallData.PendingDeadCostDmgDelayTimer > 0f)
			{
				CliffFallData.PendingDeadCostDmgDelayTimer -= DeltaTime;
				if (CliffFallData.PendingDeadCostDmgDelayTimer <= 0f)
				{
					if (CliffFallData.ActuallyThroughCliffAirWall)
					{
						Wrapper_SkillDamage(CliffFallData.PendingDeadAttacker);
						DettachCam();
					}
					else
					{
						CancelPendingDead();
					}
				}
			}
		}
		if (CliffFallData.NeedDettachCam != -1)
		{
			if (CliffFallData.NeedDettachCam < 2)
			{
				CliffFallData.NeedDettachCam++;
			}
			else
			{
				base.BUSEventCollection?.Evt_DetachCameraFromPlayer.Invoke();
				CliffFallData.NeedDettachCam = -1;
			}
		}
		if (CliffFallData.EnableCollisionToAirWall)
		{
			return;
		}
		if (!UnitStateData.HasState(EBGUUnitState.Dead) && !UnitStateData.HasState(EBGUUnitState.LifeSavingHair_FakeDead) && !SimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing) && !UnitStateData.HasState(EBGUUnitState.Beatback))
		{
			CloseCollisionToAirWall_End();
		}
		else if (!CliffFallData.bTransToRagdoll)
		{
			FVector startTrace = BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerAsCharacterCS);
			FVector endTrace = BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerAsCharacterCS) - OwnerAsCharacterCS.GetActorUpVector() * 20000.0;
			if (UBGUSelectUtil.LineTraceForObjects(OwnerAsCharacterCS, startTrace, endTrace, CliffFallData.DeadZoneObjectType, bDebug: false, out var HitResult) > 0 && HitResult.HitActor as BGUDeadZone != null)
			{
				base.BUSEventCollection?.Evt_SetPhysAnimSetting.Invoke(EPhysAnimType.Death);
				CliffFallData.bTransToRagdoll = true;
			}
		}
	}

	private void OnActuallyThroughAirWallCheck()
	{
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
		if (UBGUSelectUtil.LineTraceForObjects(Owner, CliffFallData.OwnerLastPos, fVector, CliffFallData.AirWallObjectType, bDebug: false, out var HitResult) > 0 && HitResult.HitActor.ActorHasTag(B1GlobalFNames.CliffAirWall))
		{
			CliffFallData.ActuallyThroughCliffAirWall = true;
		}
		CliffFallData.OwnerLastPos = fVector;
	}

	private void OnBeatBackStartCheck(AActor Attacker, FVector HitDir, float TraceLength)
	{
		if (CheckEnableByAngel(HitDir, TraceLength))
		{
			CloseCollisionToAirWall_Begin();
			PendingDead(Attacker);
		}
	}

	private void CloseCollisionToAirWall_Begin()
	{
		if (base.BUSEventCollection != null)
		{
			Dictionary<ECollisionChannel, ECollisionResponseType> value = new Dictionary<ECollisionChannel, ECollisionResponseType> { 
			{
				AirWallChannel,
				ECollisionResponseType.ECR_Ignore
			} };
			if (CliffFallData.CapsuleCollisionResponseHandleID == 0)
			{
				base.BUSEventCollection.Evt_SetCollisionResponseProperty.Invoke(EPropType.Capsule_CollisionResponseToChannels, value);
				CliffFallData.CapsuleCollisionResponseHandleID = PropMgrData.GetLastHandleID();
			}
			else
			{
				base.BUSEventCollection.Evt_SetCollisionResponseProperty.Invoke(EPropType.Capsule_CollisionResponseToChannels, value, CliffFallData.CapsuleCollisionResponseHandleID);
			}
			if (CliffFallData.MeshCollisionResponseHandleID == 0)
			{
				base.BUSEventCollection.Evt_SetCollisionResponseProperty.Invoke(EPropType.Mesh_CollisionResponseToChannels, value);
				CliffFallData.MeshCollisionResponseHandleID = PropMgrData.GetLastHandleID();
			}
			else
			{
				base.BUSEventCollection.Evt_SetCollisionResponseProperty.Invoke(EPropType.Mesh_CollisionResponseToChannels, value, CliffFallData.MeshCollisionResponseHandleID);
			}
			CliffFallData.EnableCollisionToAirWall = false;
		}
	}

	private void CloseCollisionToAirWall_End()
	{
		if (base.BUSEventCollection != null)
		{
			base.BUSEventCollection.Evt_ResetProperty.Invoke(CliffFallData.CapsuleCollisionResponseHandleID);
			CliffFallData.CapsuleCollisionResponseHandleID = 0u;
			base.BUSEventCollection.Evt_ResetProperty.Invoke(CliffFallData.MeshCollisionResponseHandleID);
			CliffFallData.MeshCollisionResponseHandleID = 0u;
			CliffFallData.EnableCollisionToAirWall = true;
		}
	}

	private bool CheckEnableByAngel(FVector MoveDir, float TraceLength = 500f, FVector TraceStartOffset = default(FVector))
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS.IsNullOrDestroyed())
		{
			return false;
		}
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS) + TraceStartOffset;
		FVector endTrace = fVector + MoveDir.GetSafeNormal2D() * TraceLength;
		if (UBGUSelectUtil.LineTraceForObjects(bGUCharacterCS, fVector, endTrace, CliffFallData.AirWallObjectType, bDebug: false, out var HitResult) > 0 && HitResult.HitActor.ActorHasTag(B1GlobalFNames.CliffAirWall))
		{
			if (Owner is BGUPlayerCharacterCS && !HitResult.HitActor.ActorHasTag(B1GlobalFNames.PlayerCanThrough))
			{
				return false;
			}
			if (MathLib.Abs(UBUS_UtilComm.CalcDegreeFromVectorsProjectInXYPlane(MoveDir.GetSafeNormal2D(), HitResult.HitImpactNormal)) >= 112.5f)
			{
				return true;
			}
		}
		return false;
	}

	private void PlayerFallIntoDeadZone()
	{
		DettachCam();
		base.BUSEventCollection.Evt_BuffAdd.Invoke(CliffFallData.IgnoreAllInputBuff, Owner, Owner, -1f, EBuffSourceType.CliffFall);
	}

	private void DettachCam()
	{
		if (!CliffFallData.bCamIsDettach)
		{
			base.BUSEventCollection.Evt_EnableCustomCamPitch.Invoke(P1: true, -90f);
			CliffFallData.NeedDettachCam = 0;
			CliffFallData.bCamIsDettach = true;
		}
	}

	private void PendingDead(AActor Attacker)
	{
		CliffFallData.PendingDeadAttacker = Attacker;
		int valueInGameThread = GSGameplayCVar.CVar_CliffDelayDead.GetValueInGameThread();
		CliffFallData.PendingDeadCostDmgDelayTimer = (float)valueInGameThread / 1000f;
		CliffFallData.bFlag_PendingDead = true;
		CliffFallData.OwnerLastPos = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
		base.BUSEventCollection.Evt_OnLanded += new Del_Void(OnLanded);
		CliffFallData.bFlag_DelaySimulate_BindOnLand = true;
	}

	private void CancelPendingDead()
	{
		if (CliffFallData.bFlag_DelaySimulate_BindOnLand)
		{
			base.BUSEventCollection.Evt_OnLanded -= new Del_Void(OnLanded);
		}
		CliffFallData.ResetPendingDead();
	}

	private void Wrapper_SkillDamage(AActor Attacker)
	{
		float hPMaxINV10000Damage_Abs = 9999999f;
		base.BUSEventCollection?.Evt_TriggerNormalDamageEffect.Invoke(Attacker, new FSkillDamageConfig
		{
			DamageCalcType = EDamageCalcType.HPMaxRatioAbs,
			HPMaxINV10000Damage_Abs = hPMaxINV10000Damage_Abs,
			DamageImmueLevel = 2,
			DmgReason = EDamageReason.DeadZone
		}, default(FEffectInstReq), new FBattleAttrSnapShot(null));
		CliffFallData.PendingDeadCostDmgDelayTimer = -1f;
		base.BUSEventCollection.Evt_BuffAdd.Invoke(CliffFallData.IgnoreAllInputBuff, Owner, Owner, -1f, EBuffSourceType.CliffFall);
	}

	private void OnLanded()
	{
		if (CliffFallData.bFlag_PendingDead)
		{
			if (!CliffFallData.ActuallyThroughCliffAirWall)
			{
				CancelPendingDead();
				return;
			}
			Wrapper_SkillDamage(CliffFallData.PendingDeadAttacker);
			base.BUSEventCollection?.Evt_SetPhysAnimSetting.Invoke(EPhysAnimType.Death);
			base.BUSEventCollection.Evt_OnLanded -= new Del_Void(OnLanded);
			CliffFallData.bFlag_DelaySimulate_BindOnLand = false;
		}
	}

	private void OnPlayerRebirth(ERebirthType RebirthType = ERebirthType.RebirthPoint)
	{
		if (!Owner.IsNullOrDestroyed())
		{
			if (CliffFallData.bFlag_DelaySimulate_BindOnLand)
			{
				base.BUSEventCollection.Evt_OnLanded -= new Del_Void(OnLanded);
				CliffFallData.bFlag_DelaySimulate_BindOnLand = false;
			}
			if (CliffFallData.bCamIsDettach)
			{
				base.BUSEventCollection.Evt_EnableCustomCamPitch.Invoke(P1: false, 0f);
				base.BUSEventCollection.Evt_ReAttachCameraToPlayer.Invoke();
				CliffFallData.bCamIsDettach = false;
			}
			base.BUSEventCollection.Evt_BuffRemoveImmediately.Invoke(CliffFallData.IgnoreAllInputBuff, EBuffEffectTriggerType.Remove);
			CliffFallData.ResetPendingDead();
		}
	}
}
