using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1;

public class BGC_FoliageInteractSoundMgrData : IBGC_FoliageInteractSoundMgrData, IPersistentECSData
{
	private TStrongObjectPtr<BGWDataAsset_GlobalFoliageInteractSoundConfig> mGlobalFoliageInteractSoundConfig = new TStrongObjectPtr<BGWDataAsset_GlobalFoliageInteractSoundConfig>();

	public EFoliageInteractSoundPriority CurrentHighestPriority;

	public List<AudioData> PendingSoundsToPlay = new List<AudioData>();

	public BGWDataAsset_GlobalFoliageInteractSoundConfig GlobalFoliageInteractSoundConfig
	{
		get
		{
			return mGlobalFoliageInteractSoundConfig.Get();
		}
		set
		{
			mGlobalFoliageInteractSoundConfig.Set(value);
		}
	}

	public void Reset()
	{
		CurrentHighestPriority = EFoliageInteractSoundPriority.Default;
		PendingSoundsToPlay.Clear();
	}
}
