using b1.BGW;
using b1.EventDelDefine;
using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BGS_FoliageInteractSoundMgr : GameStateSystemBase
{
	private BGC_FoliageInteractSoundMgrData FoliageInteractSoundMgrData;

	private readonly string GlobalFoliageInteractSoundConfigPath = "BGWDataAsset_GlobalFoliageInteractSoundConfig'/Game/00Main/BPLibrary/BGW/DA_GlobalFoliageInteractSound.DA_GlobalFoliageInteractSound'";

	public override void OnAttach()
	{
		FoliageInteractSoundMgrData = RequireWritableData<BGC_FoliageInteractSoundMgrData>();
		base.BGSEventCollection.Evt_BGS_SubmitFoliageInteractSound += new Del_BGS_SubmitFoliageInteractSound(OnSubmitFoliageInteractSound);
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		BGW_PreloadAssetMgr.Get(GetOwner()).TryGetCachedResourceObj<BGWDataAsset_GlobalFoliageInteractSoundConfig>(GlobalFoliageInteractSoundConfigPath, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Medium, delegate(int ReqID, UObject Obj)
		{
			if (Obj is BGWDataAsset_GlobalFoliageInteractSoundConfig globalFoliageInteractSoundConfig)
			{
				FoliageInteractSoundMgrData.GlobalFoliageInteractSoundConfig = globalFoliageInteractSoundConfig;
			}
			else
			{
				BGW_LogUtil.LogError("Failed to load GlobalFoliageInteractSoundConfig!");
			}
		});
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (FoliageInteractSoundMgrData.PendingSoundsToPlay.Count <= 0)
		{
			return;
		}
		foreach (AudioData item in FoliageInteractSoundMgrData.PendingSoundsToPlay)
		{
			if (item.Sound != null)
			{
				UAkGameplayStatics.PostEventAtLocation(item.Sound, item.Location, FRotator.ZeroRotator, "", Owner.World);
			}
		}
		FoliageInteractSoundMgrData.Reset();
	}

	private void OnSubmitFoliageInteractSound(EFoliageInteractSoundPriority Priority, string SoundTag, FVector SoundLocation)
	{
		if (!(FoliageInteractSoundMgrData.GlobalFoliageInteractSoundConfig == null) && FoliageInteractSoundMgrData.GlobalFoliageInteractSoundConfig.SoundMap.TryGetValue(SoundTag, out var value))
		{
			if ((int)Priority > (int)FoliageInteractSoundMgrData.CurrentHighestPriority)
			{
				FoliageInteractSoundMgrData.CurrentHighestPriority = Priority;
				FoliageInteractSoundMgrData.PendingSoundsToPlay.Clear();
				FoliageInteractSoundMgrData.PendingSoundsToPlay.Add(new AudioData(value, SoundLocation));
			}
			else if (Priority == FoliageInteractSoundMgrData.CurrentHighestPriority)
			{
				FoliageInteractSoundMgrData.PendingSoundsToPlay.Add(new AudioData(value, SoundLocation));
			}
		}
	}
}
