using System;
using b1.Plugins.AsyncLoadingScreen;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class TeleportTemplateBase
{
	protected ValueType UserData;

	protected BGWGameInstanceCS GameInst;

	private int ArchiveLockerID;

	private bool IsNeedLockArchive;

	public int GrassTickInterval_CvarHandle = -1;

	public ulong PlayerRoleId { get; protected set; }

	public APawn PlayerPawn
	{
		get
		{
			if (PlayerController.IsNullOrDestroyed())
			{
				return null;
			}
			return PlayerController.GetControlledPawn();
		}
	}

	public APlayerController PlayerController => UBGWFunctionLibraryCS.GetPlayerControllerByRoleId(GameInst, PlayerRoleId);

	public virtual bool CanUseSeamlessLevelTravel()
	{
		return false;
	}

	public void Init(ValueType UserData, APlayerController PlayerController)
	{
		this.UserData = UserData;
		PlayerRoleId = BGU_DataUtil.GetReadOnlyData<IBPC_RoleBaseData, BPC_RoleBaseData>(PlayerController.PlayerState).RoleId;
		GameInst = BGWGameInstanceCS.Get(PlayerController);
		IsNeedLockArchive = GetIsNeedLockArchive();
	}

	public virtual void OnBegin()
	{
		if (IsNeedLockArchive)
		{
			ArchiveLockerID = BGW_GameArchiveMgr.Get(GameInst).LockSaveArchive(EArchiveDelaySaveSource.Teleporting, GetType().Name ?? "");
		}
		ReSetPlayerState(ReSetActor: false);
		BGW_EventCollection.Get(GameInst).Evt_SetProcessGraphPaused(P1: true);
	}

	protected virtual void ReSetPlayerState(bool ReSetActor)
	{
		BGU_DataUtil.GetReadOnlyData<BPC_TransData>(PlayerPawn.PlayerState)?.SetCurActorResId(0);
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(PlayerPawn);
		if (bUS_GSEventCollection != null)
		{
			if (ReSetActor)
			{
				bUS_GSEventCollection.Evt_TriggerPlayerRest.Invoke();
			}
			else
			{
				bUS_GSEventCollection.Evt_TriggerTeleportResetPlayer.Invoke();
			}
		}
	}

	public virtual EGSLoadingScreenType GetLoadingScreenType()
	{
		return EGSLoadingScreenType.Full;
	}

	public virtual bool TickPreTeleportAction(float Delta)
	{
		return true;
	}

	public virtual void OnEnd()
	{
		if (IsNeedLockArchive && ArchiveLockerID != 0)
		{
			BGW_GameArchiveMgr.Get(GameInst).ReleaseSaveLock(ArchiveLockerID);
		}
	}

	public virtual void OnLevelTravelBegin()
	{
	}

	public virtual void OnLevelTravelEnd()
	{
	}

	public virtual FTransform ChoosePlayerTeleportTransform()
	{
		if (!PlayerPawn.IsNullOrDestroyed())
		{
			return PlayerPawn.GetActorTransform();
		}
		return UGameplayStatics.GetAllActorsOfClass<APlayerStart>(GameInst)[0].GetActorTransform();
	}

	public virtual bool LevelTravelUseDefaultPlayerStart()
	{
		return true;
	}

	public virtual int GetTargetLevelId()
	{
		return -1;
	}

	public virtual void LoadingFadeInFinish()
	{
	}

	public virtual void LoadingFadeAwayPreBegin()
	{
		ReSetPlayerState(ReSetActor: true);
		BGW_EventCollection.Get(GameInst).Evt_SetProcessGraphPaused(P1: false);
	}

	public virtual void LoadingFadeAwayBegin()
	{
		BUS_EventCollectionCS.Get(PlayerPawn)?.Evt_ResetCameraSpringArmRot.Invoke();
	}

	private bool GetIsNeedLockArchive()
	{
		int curLevelId = BGUFuncLibMap.GetCurLevelId(PlayerController);
		int targetLevelId = GetTargetLevelId();
		if (UGSE_EngineFuncLib.IsListenServer(PlayerController.World))
		{
			return false;
		}
		if (BGUFuncLibMap.IsPartyLevel(curLevelId, PlayerController) || BGUFuncLibMap.IsPartyLevel(targetLevelId, PlayerController))
		{
			return false;
		}
		return true;
	}
}
