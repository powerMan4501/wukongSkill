using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BGS_TaskCollectiontManagerSystem : GameStateSystemBase
{
	private BGC_TaskCollectionMgrData BGCTaskCollectionMgrData;

	public override void OnAttach()
	{
		BGCTaskCollectionMgrData = RequireWritableData<BGC_TaskCollectionMgrData>();
		base.BGSEventCollection.Evt_BGS_RegisterTaskCollectiont += new Del_RegisterTaskCollectiont(OnRegTaskCollectiontActor);
		base.BGSEventCollection.Evt_BGS_UnRegisterTaskCollectiont += new Del_Void_String(OnUnRegTaskCollectiontActor);
	}

	private void OnRegTaskCollectiontActor(string Guid, AActor Actor)
	{
		if (!BGCTaskCollectionMgrData.TaskCollectionDict.ContainsKey(Guid))
		{
			BGCTaskCollectionMgrData.TaskCollectionDict.Add(Guid, Actor);
		}
	}

	private void OnUnRegTaskCollectiontActor(string Guid)
	{
		if (BGCTaskCollectionMgrData.TaskCollectionDict.ContainsKey(Guid))
		{
			BGCTaskCollectionMgrData.TaskCollectionDict.Remove(Guid);
		}
	}
}
