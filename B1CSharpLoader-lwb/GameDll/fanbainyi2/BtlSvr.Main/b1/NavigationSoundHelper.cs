using b1.BGW;
using b1.Plugins.AkAudio;
using BtlB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class NavigationSoundHelper
{
	public enum ESoundType
	{
		FXSync,
		Resident
	}

	private readonly ESoundType SoundHelperType;

	private int PlayingRebirthPointID = -1;

	private string CacheStopEventPath = "";

	public NavigationSoundHelper(ESoundType InSoundType)
	{
		SoundHelperType = InSoundType;
	}

	public void PlayNavigationSound(FUStRebirthPointDesc TargetRebirthPointDesc, AActor TargetRebirthPointActor)
	{
		if (TargetRebirthPointDesc == null || TargetRebirthPointActor.IsNullOrDestroyed())
		{
			BGW_LogUtil.LogError($"[NavigationSoundHelper] {SoundHelperType} PlayNavigationSound TargetRebirthPointDesc == null");
		}
		else
		{
			if (PlayingRebirthPointID == TargetRebirthPointDesc.ID || !IsHasLegacyEars(TargetRebirthPointActor))
			{
				return;
			}
			if (PlayingRebirthPointID >= 0)
			{
				StopNavigationSound("PlayNavigationSound PlayingRebirthPointID >= 0", TargetRebirthPointActor);
			}
			string text = "";
			string text2 = "";
			switch (SoundHelperType)
			{
			case ESoundType.FXSync:
				text = TargetRebirthPointDesc.PlayNavAudioEvent;
				text2 = TargetRebirthPointDesc.StopNavAudioEvent;
				break;
			case ESoundType.Resident:
				text = TargetRebirthPointDesc.PlayResidentAudioEvent;
				text2 = TargetRebirthPointDesc.StopResidentAudioEvent;
				break;
			}
			if (string.IsNullOrWhiteSpace(text) && string.IsNullOrWhiteSpace(text2))
			{
				PlayingRebirthPointID = TargetRebirthPointDesc.ID;
				CacheStopEventPath = text2;
			}
			else
			{
				if (TargetRebirthPointActor.IsNullOrDestroyed())
				{
					return;
				}
				FVector location = BGUFuncLibActorTransformCS.BGUGetActorLocation(TargetRebirthPointActor);
				FRotator orientation = BGUFuncLibActorTransformCS.BGUGetActorRotation(TargetRebirthPointActor);
				UAkAudioEvent uAkAudioEvent = BGW_PreloadAssetMgr.Get(TargetRebirthPointActor).TryGetCachedResourceObj<UAkAudioEvent>(text, ELoadResourceType.SyncLoadAndCache, EAssetPriority.Low);
				if (uAkAudioEvent != null)
				{
					if (UAkGameplayStatics.PostEventAtLocation(uAkAudioEvent, location, orientation, null, TargetRebirthPointActor) > 0)
					{
						PlayingRebirthPointID = TargetRebirthPointDesc.ID;
						CacheStopEventPath = text2;
					}
				}
				else
				{
					BGW_LogUtil.LogError($"[NavigationSoundHelper] {SoundHelperType} PlayNavigationSound LoadedAudioEvent == null StartEventPath:{text}");
				}
			}
		}
	}

	public void StopNavigationSound(string StopReason, UObject WorldContext)
	{
		if (PlayingRebirthPointID < 0 || WorldContext.IsNullOrDestroyed())
		{
			return;
		}
		string cacheStopEventPath = CacheStopEventPath;
		if (string.IsNullOrWhiteSpace(cacheStopEventPath))
		{
			PlayingRebirthPointID = -1;
			CacheStopEventPath = "";
			return;
		}
		UAkAudioEvent uAkAudioEvent = BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<UAkAudioEvent>(cacheStopEventPath, ELoadResourceType.SyncLoadAndCache, EAssetPriority.Low);
		if (uAkAudioEvent != null)
		{
			if (UAkGameplayStatics.PostEventAtLocation(uAkAudioEvent, FVector.ZeroVector, FRotator.ZeroRotator, null, WorldContext) > 0)
			{
				PlayingRebirthPointID = -1;
				CacheStopEventPath = "";
			}
		}
		else
		{
			BGW_LogUtil.LogError($"[NavigationSoundHelper] {SoundHelperType} StopNavigationSound LoadedAudioEvent == null StopEventPath:{cacheStopEventPath}");
		}
	}

	private bool IsHasLegacyEars(UObject WorldContext)
	{
		BGP_PlayerControllerCS bGP_PlayerControllerCS = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext) as BGP_PlayerControllerCS;
		if (!bGP_PlayerControllerCS.IsNullOrDestroyed())
		{
			BPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(bGP_PlayerControllerCS);
			int commLogicCfgValue = GameDBRuntime.GetCommLogicCfgValue(CommCfgType.DashenEarsLegacyId);
			if (commLogicCfgValue > 0)
			{
				return RoleDataHelper.HasItem(readOnlyData, commLogicCfgValue);
			}
		}
		return false;
	}
}
