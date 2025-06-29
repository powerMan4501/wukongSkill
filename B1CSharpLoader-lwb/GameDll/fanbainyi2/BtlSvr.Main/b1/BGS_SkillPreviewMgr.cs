using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BGS_SkillPreviewMgr : GameStateSystemBase
{
	private BGC_SkillPreviewMgrData SkillPreviewMgrData { get; set; }

	public override void OnAttach()
	{
		SkillPreviewMgrData = RequireWritableData<BGC_SkillPreviewMgrData>();
		OnInit();
		base.BGSEventCollection.Evt_SendZBBCreationInfo += new Del_BGS_SendZBBCreationInfo(OnZBBDataReceived);
	}

	private void OnInit()
	{
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
	}

	private void OnZBBDataReceived(AActor Actor, float UnitDist, List<ZBBPreviewConfig> ZBBConfigs)
	{
		if (Actor == null || ZBBConfigs == null || ZBBConfigs.Count == 0)
		{
			return;
		}
		if (Actor is BGUZBBCreatorActorBase bGUZBBCreatorActorBase)
		{
			bGUZBBCreatorActorBase.ZBBCreateInfoSend = true;
			bGUZBBCreatorActorBase.SetActorTickEnabled(bEnabled: false);
		}
		FTransform actorTransform = Actor.GetActorTransform();
		float num = FMath.Sqrt(ZBBConfigs.Count);
		int num2 = FMath.TruncToInt(num);
		int num3 = ((num - (float)num2 > 0f) ? (num2 + 1) : num2);
		for (int i = 0; i < num3; i++)
		{
			for (int j = 0; j < num3; j++)
			{
				int num4 = i * num3 + j;
				if (num4 >= ZBBConfigs.Count)
				{
					continue;
				}
				FVector location = actorTransform.GetLocation() + new FVector((float)i * UnitDist, (float)j * UnitDist, 200.0) - new FVector((float)num3 * UnitDist / 2f, (float)num3 * UnitDist / 2f, 0.0);
				AActor aActor = SpawnSkillPreviewGenerator(location, actorTransform.GetRotation().Rotator());
				if (!(aActor == null))
				{
					BGUSkillPreviewSystem componentByClass = aActor.GetComponentByClass<BGUSkillPreviewSystem>();
					if (!(componentByClass == null))
					{
						componentByClass.OnSetPreviewConfig(ZBBConfigs[num4]);
					}
				}
			}
		}
	}

	private AActor SpawnSkillPreviewGenerator(FVector Location, FRotator Rotation)
	{
		UClass uClass = UObject.LoadClass(UClass.GetClass<AActor>(), null, "/Game/00Main/BPLibrary/Debug/SkillPreviewGenerator.SkillPreviewGenerator_C");
		return BGUFunctionLibraryCS.BGUSpawnActor(Owner.World, uClass, Location, Rotation);
	}
}
