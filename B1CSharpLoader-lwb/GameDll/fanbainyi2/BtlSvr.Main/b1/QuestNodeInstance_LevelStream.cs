using System.Collections.Generic;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class QuestNodeInstance_LevelStream : QuestNodeInstance
{
	private QuestCustom_LevelStream CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_LevelStream();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		Dictionary<string, ABGWLevelStreamingVolume> dictionary = new Dictionary<string, ABGWLevelStreamingVolume>();
		ABGWLevelStreamingVolume[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<ABGWLevelStreamingVolume>(base.Owner);
		foreach (ABGWLevelStreamingVolume aBGWLevelStreamingVolume in allActorsOfClass)
		{
			dictionary.Add(aBGWLevelStreamingVolume.GetName(), aBGWLevelStreamingVolume);
		}
		int num = 0;
		if (CustomData.LoadStreamingVolumes != null)
		{
			foreach (string loadStreamingVolume in CustomData.LoadStreamingVolumes)
			{
				if (string.IsNullOrEmpty(loadStreamingVolume) || !dictionary.ContainsKey(loadStreamingVolume))
				{
					continue;
				}
				ABGWLevelStreamingVolume aBGWLevelStreamingVolume2 = dictionary[loadStreamingVolume];
				aBGWLevelStreamingVolume2.Disabled = true;
				foreach (FName streamingLevelName in aBGWLevelStreamingVolume2.StreamingLevelNames)
				{
					UBGUFunctionLibrary.BGULoadStreamLevel(aBGWLevelStreamingVolume2, streamingLevelName, bMakeVisibleAfterLoad: true, bShouldBlockOnLoad: true, null, B1GlobalFNames.None, num);
					num++;
				}
			}
		}
		if (CustomData.UnloadStreamingVolumes != null)
		{
			foreach (string unloadStreamingVolume in CustomData.UnloadStreamingVolumes)
			{
				if (string.IsNullOrEmpty(unloadStreamingVolume) || !dictionary.ContainsKey(unloadStreamingVolume))
				{
					continue;
				}
				ABGWLevelStreamingVolume aBGWLevelStreamingVolume3 = dictionary[unloadStreamingVolume];
				aBGWLevelStreamingVolume3.Disabled = true;
				foreach (FName streamingLevelName2 in aBGWLevelStreamingVolume3.StreamingLevelNames)
				{
					UBGUFunctionLibrary.BGUUnloadStreamLevel(aBGWLevelStreamingVolume3, streamingLevelName2, bShouldBlockOnUnload: true, null, B1GlobalFNames.None, num);
					num++;
				}
			}
		}
		TriggerFirstOutput(bFinish: true);
	}

	public override byte[] GetNodeCustomData()
	{
		return null;
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
	}

	public override void RecoverActiveState()
	{
		Dictionary<string, ABGWLevelStreamingVolume> dictionary = new Dictionary<string, ABGWLevelStreamingVolume>();
		ABGWLevelStreamingVolume[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<ABGWLevelStreamingVolume>(base.Owner);
		foreach (ABGWLevelStreamingVolume aBGWLevelStreamingVolume in allActorsOfClass)
		{
			dictionary.Add(aBGWLevelStreamingVolume.GetName(), aBGWLevelStreamingVolume);
		}
		int num = 0;
		if (CustomData.LoadStreamingVolumes != null)
		{
			foreach (string loadStreamingVolume in CustomData.LoadStreamingVolumes)
			{
				if (string.IsNullOrEmpty(loadStreamingVolume) || !dictionary.ContainsKey(loadStreamingVolume))
				{
					continue;
				}
				ABGWLevelStreamingVolume aBGWLevelStreamingVolume2 = dictionary[loadStreamingVolume];
				aBGWLevelStreamingVolume2.Disabled = true;
				foreach (FName streamingLevelName in aBGWLevelStreamingVolume2.StreamingLevelNames)
				{
					UBGUFunctionLibrary.BGULoadStreamLevel(aBGWLevelStreamingVolume2, streamingLevelName, bMakeVisibleAfterLoad: true, bShouldBlockOnLoad: true, null, B1GlobalFNames.None, num);
					num++;
				}
			}
		}
		if (CustomData.UnloadStreamingVolumes != null)
		{
			foreach (string unloadStreamingVolume in CustomData.UnloadStreamingVolumes)
			{
				if (string.IsNullOrEmpty(unloadStreamingVolume) || !dictionary.ContainsKey(unloadStreamingVolume))
				{
					continue;
				}
				ABGWLevelStreamingVolume aBGWLevelStreamingVolume3 = dictionary[unloadStreamingVolume];
				aBGWLevelStreamingVolume3.Disabled = true;
				foreach (FName streamingLevelName2 in aBGWLevelStreamingVolume3.StreamingLevelNames)
				{
					UBGUFunctionLibrary.BGUUnloadStreamLevel(aBGWLevelStreamingVolume3, streamingLevelName2, bShouldBlockOnUnload: true, null, B1GlobalFNames.None, num);
					num++;
				}
			}
		}
		TriggerFirstOutput(bFinish: true);
	}
}
