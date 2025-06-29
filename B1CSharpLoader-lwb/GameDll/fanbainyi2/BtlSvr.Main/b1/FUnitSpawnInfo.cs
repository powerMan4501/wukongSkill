using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FUnitSpawnInfo
{
	private TStrongObjectPtr<UAnimMontage> SpawnMontagePtr = new TStrongObjectPtr<UAnimMontage>();

	public UAnimMontage SpawnMontage
	{
		get
		{
			return SpawnMontagePtr.Get();
		}
		set
		{
			SpawnMontagePtr.Set(value);
		}
	}

	public bool bFacePlayer { get; set; }

	public bool bCatchPlayer { get; set; }

	public bool bSyncMasterTarget { get; set; }

	public List<FName> ActorTags { get; set; } = new List<FName>();

	public List<int> BirthBuff { get; set; } = new List<int>();

	public string SpawnMasterGuid { get; set; }
}
