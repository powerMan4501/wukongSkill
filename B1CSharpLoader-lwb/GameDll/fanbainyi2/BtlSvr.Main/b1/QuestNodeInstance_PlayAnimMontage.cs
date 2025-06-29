using System.IO;
using b1.BGW;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class QuestNodeInstance_PlayAnimMontage : QuestNodeInstance
{
	private string CasterGuid { get; set; }

	private string AnimMontagePathCache { get; set; }

	private TStrongObjectPtr<UAnimMontage> AnimMontage { get; } = new TStrongObjectPtr<UAnimMontage>();

	private QuestCustom_PlayAnimMontage CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_PlayAnimMontage();
		CustomData.MergeFrom(base.Node.NodeData);
		CasterGuid = CustomData.CasterGuid;
		string amPath = CustomData.AmPath;
		if (!string.IsNullOrEmpty(amPath))
		{
			AnimMontagePathCache = amPath + "." + Path.GetFileNameWithoutExtension(amPath);
			UAnimMontage uAnimMontage = BGW_PreloadAssetMgr.Get(base.Owner).TryGetCachedResourceObj<UAnimMontage>(AnimMontagePathCache, ELoadResourceType.AsyncLoadAndCache);
			if (uAnimMontage != null)
			{
				AnimMontage.Set(uAnimMontage);
			}
		}
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		if (!AnimMontage.IsValid())
		{
			AnimMontage.Set(BGW_PreloadAssetMgr.Get(base.Owner).TryGetCachedResourceObj<UAnimMontage>(AnimMontagePathCache, ELoadResourceType.SyncLoadAndCache));
		}
		if (AnimMontage.IsValid())
		{
			AActor aActor = ((!(CasterGuid == B1GlobalFNames.Player_Wukong.PlainName)) ? BGU_DataUtil.GetActorByGuid(base.Owner, CasterGuid) : UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner).GetControlledPawn());
			BGUCharacterCS bGUCharacterCS = aActor as BGUCharacterCS;
			if (!bGUCharacterCS.IsNullOrDestroyed())
			{
				bGUCharacterCS.StopAnimMontage(null);
				BGUFuncLibAnim.BGUActorTryPlayMontage(bGUCharacterCS, AnimMontage.Get(), FName.None);
			}
		}
		TriggerFirstOutput(bFinish: true);
	}

	public override byte[] GetNodeCustomData()
	{
		return new byte[0];
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
	}

	public override void RecoverActiveState()
	{
		TriggerFirstOutput(bFinish: true);
	}
}
