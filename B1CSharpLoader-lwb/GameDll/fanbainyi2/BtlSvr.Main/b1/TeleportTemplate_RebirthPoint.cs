using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class TeleportTemplate_RebirthPoint : TeleportTemplateRebirthPointBase
{
	private TeleportParam_RebirthPoint TeleportParam => (TeleportParam_RebirthPoint)(object)UserData;

	public override FTransform ChoosePlayerTeleportTransform()
	{
		if (UBGWFunctionLibraryCS.GetRebirthPointTransform(GameInst, TeleportParam.RebirthPointId, out var Transform, out var RebirthPointActor))
		{
			CurrentRBP = RebirthPointActor;
			ACharacter aCharacter = base.PlayerPawn as ACharacter;
			float num = (aCharacter.IsNullOrDestroyed() ? 0f : aCharacter.CapsuleComponent.GetScaledCapsuleHalfHeight());
			FVector location = Transform.GetLocation() + new FVector(0.0, 0.0, num);
			Transform.SetLocation(location);
			return Transform;
		}
		GSEUtil.Ensure(GameInst.GetObject<BGW_GameArchiveMgr>().CurrentArchiveId <= 0, $"TeleportTemplate_RebirthPoint RebirthPointId:{TeleportParam.RebirthPointId} Not Found!!!");
		return base.ChoosePlayerTeleportTransform();
	}

	public override void OnBegin()
	{
		base.OnBegin();
	}

	public override void LoadingFadeAwayBegin()
	{
		base.LoadingFadeAwayBegin();
		if (base.PlayerPawn.IsPlayerControlled())
		{
			IBPC_PlayerTagData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerTagData, BPC_PlayerTagData>(base.PlayerPawn.PlayerState);
			BGU_DataUtil.GetReadOnlyData<IBPC_TransData, BPC_TransData>(base.PlayerPawn.PlayerState);
			if (BGW_TeleportFuncUtil.CheckAndTransByRebirthPoint(TeleportParam.RebirthPointId, base.PlayerController, out var TargetResId))
			{
				BPS_EventCollectionCS.Get(base.PlayerPawn.PlayerState)?.Evt_TriggerPlayerTransBegin.Invoke(EPlayerTransBeginType.RebirthPoint, new PlayerTransParam
				{
					TargetResId = TargetResId,
					NeedBlend = true
				});
				BUS_EventCollectionCS.Get(CurrentRBP)?.Evt_RBP_RebirthTeleportFinish.Invoke();
				return;
			}
			if (readOnlyData != null && readOnlyData.HasTag(EBGPPlayerTag.Transforming))
			{
				if (TeleportParam.FromSettingUI)
				{
					BPS_EventCollectionCS.Get(base.PlayerPawn.PlayerState)?.Evt_TriggerPlayerTransEnd.Invoke(EPlayerTransEndType.SettingransBack, default(PlayerTransParam));
					BPS_EventCollectionCS.Get(base.PlayerPawn.PlayerState)?.Evt_SetCurrentRebirthPoint.Invoke(TeleportParam.RebirthPointId);
					return;
				}
				FUStPlayerTransUnitConfDesc fUStPlayerTransUnitConfDesc = BGW_GameDB.GetFUStPlayerTransUnitConfDesc((base.PlayerPawn as BGUCharacterCS).GetResID());
				if (fUStPlayerTransUnitConfDesc != null && fUStPlayerTransUnitConfDesc.DeadDontTransback == 0)
				{
					BPS_EventCollectionCS.Get(base.PlayerPawn.PlayerState)?.Evt_TriggerPlayerTransEnd.Invoke(EPlayerTransEndType.RebirthTransBack, default(PlayerTransParam));
				}
			}
		}
		BUS_EventCollectionCS.Get(base.PlayerPawn)?.Evt_RebirthTeleportFinish.Invoke(TeleportParam.RebirthType);
		BUS_EventCollectionCS.Get(CurrentRBP)?.Evt_RBP_RebirthTeleportFinish.Invoke();
		BUS_EventCollectionCS.Get(base.PlayerPawn)?.Evt_TriggerTeleportResetPlayer.Invoke();
	}

	public override void LoadingFadeInFinish()
	{
		base.LoadingFadeInFinish();
		if (base.PlayerPawn.IsPlayerControlled())
		{
			IBPC_PlayerTagData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerTagData, BPC_PlayerTagData>(base.PlayerPawn.PlayerState);
			if (readOnlyData != null && readOnlyData.HasTag(EBGPPlayerTag.Transforming))
			{
				BUS_EventCollectionCS.Get(base.PlayerPawn)?.Evt_RebirthTeleportFinish.Invoke(TeleportParam.RebirthType);
			}
		}
	}

	public override void OnEnd()
	{
		base.OnEnd();
		BGW_GameArchiveMgr.Get(GameInst).MarkSaveArchive(EArchiveSaveSource.TeleportFinish);
	}

	public override int GetTargetLevelId()
	{
		return BGW_GameDB.GetRebirthPointDesc(TeleportParam.RebirthPointId)?.MapID ?? (-1);
	}

	public override int GetRebirthPointId()
	{
		return TeleportParam.RebirthPointId;
	}

	public override bool TickPreTeleportAction(float Delta)
	{
		return true;
	}

	public override bool LevelTravelUseDefaultPlayerStart()
	{
		return false;
	}
}
