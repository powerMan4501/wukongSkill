using System.IO;
using b1.BGW;
using b1.Plugins.AkAudio;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

public class QuestNodeInstance_PostAkEvent : QuestNodeInstance
{
	private string AkEventPathCache { get; set; }

	[UProperty]
	private UAkAudioEvent AkEvent { get; set; }

	private QuestCustom_PostAkEvent CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_PostAkEvent();
		CustomData.MergeFrom(base.Node.NodeData);
		if (!string.IsNullOrEmpty(CustomData.AkEventPath))
		{
			string akEventPath = CustomData.AkEventPath;
			AkEventPathCache = akEventPath + "." + Path.GetFileNameWithoutExtension(akEventPath);
			UAkAudioEvent uAkAudioEvent = base.PreloadAssetMgr.TryGetCachedResourceObj<UAkAudioEvent>(AkEventPathCache, ELoadResourceType.AsyncLoadAndCache);
			if (uAkAudioEvent != null)
			{
				AkEvent = uAkAudioEvent;
			}
		}
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		if (AkEvent == null)
		{
			AkEvent = base.PreloadAssetMgr.TryGetCachedResourceObj<UAkAudioEvent>(AkEventPathCache, ELoadResourceType.SyncLoadAndCache);
		}
		if (AkEvent != null)
		{
			BGS_EventCollectionCS.Get(base.Owner).Evt_PostMulticastAkEvent.Invoke(AkEvent);
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
		if (AkEvent != null)
		{
			UAkGameplayStatics.PostEvent(AkEvent, UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner).GetControlledPawn(), 0, null);
		}
		TriggerFirstOutput(bFinish: true);
	}
}
