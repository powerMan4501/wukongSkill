using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class TeleportTemplate_RebirthPointTeleportOnly : TeleportTemplateRebirthPointBase
{
	private TeleportParam_RebirthPoint TeleportParam => (TeleportParam_RebirthPoint)(object)UserData;

	public override FTransform ChoosePlayerTeleportTransform()
	{
		BGURebirthPointBase[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGURebirthPointBase>(GameInst);
		foreach (BGURebirthPointBase bGURebirthPointBase in allActorsOfClass)
		{
			if (bGURebirthPointBase.RebirthPointConfigComp.RebirthPointConfig.RebirthPointID == TeleportParam.RebirthPointId)
			{
				CurrentRBP = bGURebirthPointBase;
				ACharacter aCharacter = base.PlayerPawn as ACharacter;
				float num = (aCharacter.IsNullOrDestroyed() ? 0f : aCharacter.CapsuleComponent.GetScaledCapsuleHalfHeight());
				FTransform sceneComponentTransformByName = UGSE_CharacterFuncLib.GetSceneComponentTransformByName(bGURebirthPointBase, BGW_GameDB.GetRebirthPointDesc(TeleportParam.RebirthPointId).SceneComponentName);
				FVector location = sceneComponentTransformByName.GetLocation() + new FVector(0.0, 0.0, num);
				sceneComponentTransformByName.SetLocation(location);
				return sceneComponentTransformByName;
			}
		}
		GSEUtil.Ensure(Condition: false, $"没有找到复活点{TeleportParam.RebirthPointId} 对应Actor, 请联系对应策划处理");
		return base.ChoosePlayerTeleportTransform();
	}

	public override void OnBegin()
	{
		base.OnBegin();
	}

	public override void LoadingFadeAwayBegin()
	{
		base.LoadingFadeAwayBegin();
		if (base.PlayerPawn != null && base.PlayerPawn.IsPlayerControlled() && BGW_TeleportFuncUtil.CheckAndTransByRebirthPoint(TeleportParam.RebirthPointId, base.PlayerController, out var TargetResId))
		{
			BPS_EventCollectionCS.Get(base.PlayerPawn.PlayerState)?.Evt_TriggerPlayerTransBegin.Invoke(EPlayerTransBeginType.RebirthPoint, new PlayerTransParam
			{
				TargetResId = TargetResId,
				NeedBlend = true
			});
			BPS_EventCollectionCS.Get(base.PlayerPawn.PlayerState)?.Evt_SetCurrentRebirthPoint.Invoke(TeleportParam.RebirthPointId);
			BUS_EventCollectionCS.Get(CurrentRBP)?.Evt_RBP_RebirthTeleportFinish.Invoke();
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(base.PlayerPawn);
		if (bUS_GSEventCollection != null)
		{
			FUStPlayerCommDesc playerCommDesc = BGW_GameDB.GetPlayerCommDesc((base.PlayerPawn as BGUCharacterCS).GetResID(), base.PlayerPawn);
			if (playerCommDesc != null)
			{
				bUS_GSEventCollection.Evt_UnitCastSkillTryCMultiCast.Invoke(new FCastSkillInfo(playerCommDesc.TeleportSkillID, ECastSkillSourceType.Teleport));
			}
			BPS_EventCollectionCS.Get(base.PlayerPawn.PlayerState)?.Evt_SetCurrentRebirthPoint.Invoke(TeleportParam.RebirthPointId);
		}
		BUS_EventCollectionCS.Get(CurrentRBP)?.Evt_RBP_RebirthTeleportFinish.Invoke();
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

	public override bool TickPreTeleportAction(float Delta)
	{
		return true;
	}

	public override bool LevelTravelUseDefaultPlayerStart()
	{
		return false;
	}

	public override int GetRebirthPointId()
	{
		return TeleportParam.RebirthPointId;
	}
}
