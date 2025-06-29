using System.Linq;
using ArchiveB1;
using b1.BGU.BUActor;
using b1.Plugins.AsyncLoadingScreen;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class TeleportTemplate_Dream : TeleportTemplateBase
{
	private bool _isActiveBlackOutFinish;

	private TeleportParam_Dream TeleportParam => (TeleportParam_Dream)(object)UserData;

	public override bool LevelTravelUseDefaultPlayerStart()
	{
		return false;
	}

	public override EGSLoadingScreenType GetLoadingScreenType()
	{
		return TeleportParam.LoadingScreenType;
	}

	public override int GetTargetLevelId()
	{
		return TeleportParam.LevelId;
	}

	public override FTransform ChoosePlayerTeleportTransform()
	{
		if (TeleportParam.RebirthPointId > 0 && UBGWFunctionLibraryCS.GetRebirthPointTransform(GameInst, TeleportParam.RebirthPointId, out var Transform))
		{
			ACharacter aCharacter = base.PlayerPawn as ACharacter;
			float num = (aCharacter.IsNullOrDestroyed() ? 0f : aCharacter.CapsuleComponent.GetScaledCapsuleHalfHeight());
			FVector location = Transform.GetLocation() + new FVector(0.0, 0.0, num);
			Transform.SetLocation(location);
			return Transform;
		}
		if (TeleportParam.RebirthPointId > 0)
		{
			BGW_LogUtil.LogError($"TeleportTemplate_Dream RebirthPointId:{TeleportParam.RebirthPointId} Cant get rebirthpoint transform. " + $"Please check if rebirth point is on the target level. LevelId:{TeleportParam.LevelId}");
		}
		if (TeleportParam.TeleportPointName == FName.None)
		{
			IBIC_LevelData gameInstanceReadonlyData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_LevelData, BIC_LevelData>(GameInst);
			if (gameInstanceReadonlyData != null && gameInstanceReadonlyData.GetAllLevelArchiveData(out var BaseDataCollection, out var _))
			{
				foreach (LevelArchiveBaseData item in BaseDataCollection)
				{
					if (item?.MapId == TeleportParam.LevelId)
					{
						LevelArchivePlayerData playerData = item.PlayerData;
						if (playerData != null)
						{
							return new FTransform(translation: new FVector(playerData.PlayerPosX, playerData.PlayerPosY, playerData.PlayerPosZ), rotation: new FRotator(playerData.PlayerPosPitch, playerData.PlayerPosYaw, playerData.PlayerPosRoll));
						}
					}
				}
			}
		}
		else
		{
			BGWTeleportNamedPoint[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGWTeleportNamedPoint>(GameInst);
			foreach (BGWTeleportNamedPoint bGWTeleportNamedPoint in allActorsOfClass)
			{
				if (bGWTeleportNamedPoint.GetFName() == TeleportParam.TeleportPointName || bGWTeleportNamedPoint.TeleportID == TeleportParam.TeleportPointName)
				{
					return bGWTeleportNamedPoint.GetActorTransform();
				}
			}
		}
		BGW_LogUtil.LogError($"TeleportTemplate_Dream ChoosePlayerTeleportTransform {TeleportParam.TeleportPointName} Not Found!!!");
		APlayerStart[] allActorsOfClass2 = UGameplayStatics.GetAllActorsOfClass<APlayerStart>(GameInst);
		GSEUtil.Check(allActorsOfClass2.Any(), "进入梦境传送没有配置传送复活点且没有PlayerStart");
		return allActorsOfClass2[0].GetActorTransform();
	}

	public override void OnEnd()
	{
		base.OnEnd();
	}

	public override void OnBegin()
	{
		base.OnBegin();
		if (GetTargetLevelId() == 62)
		{
			base.ReSetPlayerState(ReSetActor: true);
		}
		if (GetLoadingScreenType() == EGSLoadingScreenType.FullWhite)
		{
			_isActiveBlackOutFinish = true;
			return;
		}
		BGW_EventCollection.Get(GameInst).Evt_ActiveBlackOut(IsActive: true, delegate
		{
			_isActiveBlackOutFinish = true;
		}, -1f, default(FColor), IsPauseWorld: false);
	}

	protected override void ReSetPlayerState(bool ReSetActor)
	{
		if (!TeleportParam.DontResetPlayerState)
		{
			base.ReSetPlayerState(ReSetActor: false);
		}
	}

	public override bool TickPreTeleportAction(float Delta)
	{
		return _isActiveBlackOutFinish;
	}

	public override void LoadingFadeInFinish()
	{
		base.LoadingFadeInFinish();
		BGW_EventCollection.Get(GameInst).Evt_ActiveBlackOut(IsActive: false);
	}

	public override void LoadingFadeAwayBegin()
	{
		base.LoadingFadeAwayBegin();
		if (TeleportParam.RebirthPointId > 0)
		{
			if (!(BUS_EventCollectionCS.Get(base.PlayerPawn) != null))
			{
				return;
			}
			if (base.PlayerPawn != null && base.PlayerPawn.IsPlayerControlled() && BGW_TeleportFuncUtil.CheckAndTransByRebirthPoint(TeleportParam.RebirthPointId, base.PlayerController, out var TargetResId))
			{
				BPS_EventCollectionCS.Get(base.PlayerPawn.PlayerState)?.Evt_TriggerPlayerTransBegin.Invoke(EPlayerTransBeginType.RebirthPoint, new PlayerTransParam
				{
					TargetResId = TargetResId,
					NeedBlend = true
				});
			}
			BPS_EventCollectionCS.Get(base.PlayerPawn.PlayerState)?.Evt_SetCurrentRebirthPoint.Invoke(TeleportParam.RebirthPointId);
			{
				foreach (BGURebirthPointBase allActorsOfClass in UGameplayStatics.GetAllActorsOfClassList<BGURebirthPointBase>(base.PlayerPawn))
				{
					BUS_RebirthPointConfigComp componentByClass = allActorsOfClass.GetComponentByClass<BUS_RebirthPointConfigComp>();
					if (componentByClass != null && componentByClass.RebirthPointConfig.RebirthPointID == TeleportParam.RebirthPointId)
					{
						BUS_EventCollectionCS.Get(allActorsOfClass).Evt_SetRebirthPointActiveState.Invoke(P1: true, P2: true);
					}
				}
				return;
			}
		}
		BPC_RebirthPointData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_RebirthPointData>(base.PlayerController);
		if (readOnlyData != null && readOnlyData.CurrentRebirthPointIDMap != null)
		{
			int curLevelId = BGUFuncLibMap.GetCurLevelId(GameInst);
			if (readOnlyData.CurrentRebirthPointIDMap.ContainsKey(curLevelId))
			{
				BPS_EventCollectionCS.Get(base.PlayerPawn.PlayerState)?.Evt_SetCurrentRebirthPoint.Invoke(readOnlyData.CurrentRebirthPointIDMap[curLevelId]);
			}
		}
	}
}
